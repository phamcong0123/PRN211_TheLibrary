using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManager.ChildForm.Lending_Manager
{
    public partial class frmReturnBookLending : Form
    {
        BindingSource source;
        public IBookLendingRepository bookLendingRepository { get; set; }
        IBookLendingDetailRepository bookLendingDetailRepository = new BookLendingDetailRepository();
        IStudentRepository studentRepository = new StudentRepository();

        public frmReturnBookLending()
        {
            InitializeComponent();
        }

        private void frmReturnBookLending_Load(object sender, EventArgs e)
        {
            lbQuaHan.Visible = false;
            lbNotify.Visible = false;
            LoadLendingList();
        }

        public void LoadLendingList()
        {
            var lendings = bookLendingRepository.GetListLending().Where(lend => lend.returnDate == null);
            try
            {
                source = new BindingSource();
                source.DataSource = lendings;

                dgvBookLendingData.Rows.Clear();

                foreach (var item in lendings)
                {
                    dgvBookLendingData.Rows.Add(item.LendingID, item.studentID, item.studentName, item.lendDate, item.deadline);
                }

                dgvBookLendingData.Columns[3].DefaultCellStyle.Format = "dd/MM/yyyy";
                dgvBookLendingData.Columns[4].DefaultCellStyle.Format = "dd/MM/yyyy";

                if (lendings.Count() == 0)
                {
                    lbNotify.Visible = true;
                    btnXacNhan.Enabled = false;
                }
                else
                {
                    lbNotify.Visible = false;
                    btnXacNhan.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Quản lý sách thư viện - Trả sách", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvBookLendingData_SelectionChanged(object sender, EventArgs e)
        {
            var lendingDetails = bookLendingDetailRepository.GetListDetails();
            try
            {
                source = new BindingSource();

                if (dgvBookLendingData.CurrentRow.Cells[0].Value != null)
                {
                    var details = lendingDetails.Where(lend => lend.LendID == Convert.ToInt32(dgvBookLendingData.CurrentRow.Cells[0].Value)).ToList();

                    source.DataSource = details;

                    dgvLendingDetailData.DataSource = null;
                    dgvLendingDetailData.DataSource = details;

                    dgvLendingDetailData.Columns[0].HeaderText = "Mã mượn";
                    dgvLendingDetailData.Columns[1].HeaderText = "Mã sách";
                    dgvLendingDetailData.Columns[2].HeaderText = "Tiêu đề";
                    dgvLendingDetailData.Columns[3].HeaderText = "Số lượng";

                    if (DateTime.Compare(DateTime.Parse(dgvBookLendingData.CurrentRow.Cells[4].Value.ToString()),DateTime.Today) < 0)
                    {
                        lbQuaHan.Visible = true;
                    }
                    else
                    {
                        lbQuaHan.Visible = false;
                    }
                }
                else
                {
                    dgvBookLendingData.DataSource = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Quản lý thư viện - Trả sách", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            var lendings = bookLendingRepository.GetListLending().Where(lend => lend.returnDate == null);
            if (txtTimKiem.Text.Length != 0)
            {
                var searchs = lendings.Where(lend => (lend.LendingID.ToString().Contains(txtTimKiem.Text) || lend.studentID.ToString().Contains(txtTimKiem.Text))).ToList();

                dgvBookLendingData.Rows.Clear();

                if (searchs.Count != 0)
                {
                    foreach (var item in searchs)
                    {
                        dgvBookLendingData.Rows.Add(item.LendingID, item.studentID, item.studentName, item.lendDate, item.deadline);
                    }
                }
                else
                {
                    lbQuaHan.Visible = false;
                    dgvLendingDetailData.DataSource = null;
                }
            }
            else
            {
                dgvBookLendingData.Rows.Clear();

                foreach (var item in lendings)
                {
                    dgvBookLendingData.Rows.Add(item.LendingID, item.studentID, item.studentName, item.lendDate, item.deadline);
                }
            }
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Xác nhận trả sách?", "Quản lý thư viện - Trả sách", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (d == DialogResult.OK)
            {
                int lendID = Convert.ToInt32(dgvBookLendingData.CurrentRow.Cells[0].Value);
                var lendingBook = bookLendingRepository.GetListLending().Where(lend => lend.LendingID == lendID).First();
                if (lendingBook.deadline.CompareTo(DateTime.Today) < 0)
                {
                    var lendingDetail = bookLendingDetailRepository.GetListDetails().Where(lend => lend.LendID == lendID).ToList();
                    var student = studentRepository.GetAllStudents().Where(stu => stu.StudentID == lendingBook.studentID).First();
                    double fee = penaltyFee(lendingBook.deadline, lendingDetail.Count());
                    student.Debt += fee;
                    studentRepository.UpdateStudent(student);
                    MessageBox.Show($"Học sinh mã số #{student.StudentID} đã trả sách không đúng hạn. Tiền phạt là {fee} sẽ được cộng thêm và số dư nợ của học sinh.", "Quản lý thư viện - Trả sách - Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                bookLendingRepository.UpdateLending(lendingBook);
                MessageBox.Show("Trả sách thành công", "Quản lý thư viện - Trả sách", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadLendingList();
            }
        }

        public double penaltyFee(DateTime date, int numOfBook)
        {
            double fee = 0;
            fee = ((DateTime.Today.Subtract(date).TotalDays) * 5000) * numOfBook;
            return fee;
        }

        private void btnThoat_Click(object sender, EventArgs e) => Close();
    }
}
