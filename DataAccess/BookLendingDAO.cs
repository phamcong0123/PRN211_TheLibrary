using BusinessObject;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class BookLendingDAO : BaseDAL
    {
        private static BookLendingDAO? instance;
        private static readonly object instanceLock = new object();
        private BookLendingDAO() { }
        public static BookLendingDAO Instance
        {
            get
            {
                lock(instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new BookLendingDAO();
                    }
                    return instance;
                }
            }
        }
        //-------------------------------------------------------------
        private T CheckNull<T>(object obj)
        {
            return (obj == DBNull.Value ? default(T) : (T)obj);
        }

        public IEnumerable<BookLending> GetListBookLending()
        {
            IDataReader dataReader = null;
            string SQLSelect = "SELECT lendID, stu.studentID, stu.name, lib.librarianID, lib.name, lendDate, returnDate, deadline\n" +
                               "FROM tblLending lend\n" +
                               "INNER JOIN tblStudent stu\n" +
                               "ON lend.studentID = stu.studentID\n" +
                               "INNER JOIN tblLibrarian lib\n" +
                               "ON lib.librarianID = lend.librarianID";
            var bookLendings = new List<BookLending>();
            try
            {
                dataReader = dataProvider.GetDataReader(SQLSelect, CommandType.Text, out connection);
                while (dataReader.Read())
                {
                    bookLendings.Add(new BookLending
                    {
                        LendingID = dataReader.GetInt32(0),
                        studentID = dataReader.GetInt32(1),
                        studentName = dataReader.GetString(2),
                        librarianID = dataReader.GetInt32(3),
                        librarianName = dataReader.GetString(4),
                        lendDate = dataReader.GetDateTime(5).Date,
                        returnDate = CheckNull<DateTime?>(dataReader["returnDate"]),
                        deadline = dataReader.GetDateTime(7).Date
                    });
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                if (dataReader != null)
                {
                    dataReader.Close();
                }
                CloseConnection();
            }
            return bookLendings;
        }

        public int GetNextSeed()
        {
            return GetNextSeed("tblLending");
        }

        public void AddBookLending(BookLending book)
        {
            string SQLInsert = "INSERT tblLending VALUES(@studentID, @librarianID, @lendDate, @returnDate, @deadline)";
            var parameters = new List<SqlParameter>();
            try
            {
                parameters.Add(dataProvider.CreateParameter("@studentID", 4, book.studentID, DbType.Int32));
                parameters.Add(dataProvider.CreateParameter("@librarianID", 4, book.librarianID, DbType.Int32));
                parameters.Add(dataProvider.CreateParameter("@lendDate", 8, book.lendDate, DbType.Date));
                parameters.Add(dataProvider.CreateParameter("@returnDate", 8, DBNull.Value, DbType.Date));
                parameters.Add(dataProvider.CreateParameter("@deadline", 8, book.deadline, DbType.Date));
                dataProvider.UpdateDB(SQLInsert, CommandType.Text, parameters.ToArray());
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }

        public void UpdateBookLending(BookLending book)
        {
            string SQLUpdate = "UPDATE tblLending SET returnDate = @returnDate where lendID = @lendID";
            var parameters = new List<SqlParameter>();
            try
            {
                parameters.Add(dataProvider.CreateParameter("@lendID", 4, book.LendingID, DbType.Int32));
                parameters.Add(dataProvider.CreateParameter("@returnDate", 8, DateTime.Now , DbType.Date));
                dataProvider.UpdateDB(SQLUpdate, CommandType.Text, parameters.ToArray());
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }
    }
}
