using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject
{
    public class BookLending
    {
        public int LendingID { get; set; }
        public int studentID { get; set; }
        public string studentName { get; set; }
        public int librarianID { get; set; }
        public string librarianName { get; set; }
        public DateTime lendDate { get; set; }
        public DateTime? returnDate { get; set; }
        public DateTime deadline { get; set; }
    }
}
