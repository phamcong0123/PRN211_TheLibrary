using BusinessObject;
using DataAccess.Repository;
using LibraryManager.ChildForm.Lending_Manager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManager.Lending_Manager
{
    public partial class frmLendingManager : Form
    {
        IBookLendingRepository bookLendingRepository = new BookLendingRepository();
        IStudentRepository studentRepository = new StudentRepository();
        BindingSource source;
        public Librarian Librarian { get; set; }
        public frmLendingManager()
        {
            InitializeComponent();
        }

        private void frmLendingManager_Load(object sender, EventArgs e)
        {
            LoadLendingList();
        }

        private void btnReturnBook_Click(object sender, EventArgs e)
        {
            frmReturnBookLending frm = new frmReturnBookLending
            {
                Text = "Quản lý thư viện - Trả sách",
                bookLendingRepository = bookLendingRepository
            };
            frm.ShowDialog();
            LoadLendingList();
        }

        private void btnMuon_Click(object sender, EventArgs e)
        {
            frmLendingBook frm = new frmLendingBook
            {
                Text = "Quản lý thư viện - Mượn sách",
                StudentID = txtStudentID.Text,
                Librarian = Librarian,
                bookLendingRepository = bookLendingRepository
            };
            if (txtStudentID.Text.Length != 0)
            {
                if (studentRepository.GetAllStudents().Where(stu => stu.StudentID == Convert.ToInt32(txtStudentID.Text)).FirstOrDefault() != null)
                {
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        LoadLendingList();
                        source.Position = source.Count - 1;
                    }
                }
                else
                {
                    MessageBox.Show("Mã số sinh viên không tồn tại", "Quản lý thư viện - Mượn sách", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Mã số sinh viên không được để trống", "Quản lý thư viện - Mượn sách", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void LoadLendingList()
        {
            var lendings = bookLendingRepository.GetListLending().Where(len => len.returnDate != null).ToList();
            try
            {
                source = new BindingSource();
                source.DataSource = lendings;

                dgvBookLendingData.DataSource = null;
                dgvBookLendingData.DataSource = source;

                for (int i = 5; i < 8; i++)
                {
                    dgvBookLendingData.Columns[i].DefaultCellStyle.Format = "dd/MM/yyyy";
                }

                dgvBookLendingData.Columns[0].HeaderText = "Mã số";
                dgvBookLendingData.Columns[1].HeaderText = "Mã số học sinh";
                dgvBookLendingData.Columns[2].HeaderText = "Tên học sinh";
                dgvBookLendingData.Columns[3].HeaderText = "Mã số thủ thư";
                dgvBookLendingData.Columns[4].HeaderText = "Tên thủ thư";
                dgvBookLendingData.Columns[5].HeaderText = "Ngày mượn";
                dgvBookLendingData.Columns[6].HeaderText = "Ngày trả";
                dgvBookLendingData.Columns[7].HeaderText = "Hạn trả";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Quản lý thư viện - Mượn sách", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void rBDaTra_CheckedChanged(object sender, EventArgs e)
        {
            if (rBDaTra.Checked)
            {
                txtLendID.Clear();
            }
            if (raBChuaTra.Checked)
            {
                txtLendID.Clear();
                var lendings = bookLendingRepository.GetListLending().Where(len => len.returnDate == null).ToList();
                source = new BindingSource();
                source.DataSource = lendings;

                dgvBookLendingData.DataSource = null;
                dgvBookLendingData.DataSource = source;

                for (int i = 5; i < 8; i++)
                {
                    dgvBookLendingData.Columns[i].DefaultCellStyle.Format = "dd/MM/yyyy";
                }

                dgvBookLendingData.Columns[0].HeaderText = "Mã số";
                dgvBookLendingData.Columns[1].HeaderText = "Mã số học sinh";
                dgvBookLendingData.Columns[2].HeaderText = "Tên học sinh";
                dgvBookLendingData.Columns[3].HeaderText = "Mã số thủ thư";
                dgvBookLendingData.Columns[4].HeaderText = "Tên thủ thư";
                dgvBookLendingData.Columns[5].HeaderText = "Ngày mượn";
                dgvBookLendingData.Columns[6].HeaderText = "Ngày trả";
                dgvBookLendingData.Columns[7].HeaderText = "Hạn trả";
            }
            else
            {
                var lendings = bookLendingRepository.GetListLending().Where(len => len.returnDate != null).ToList();
                source = new BindingSource();
                source.DataSource = lendings;

                dgvBookLendingData.DataSource = null;
                dgvBookLendingData.DataSource = source;

                for (int i = 5; i < 8; i++)
                {
                    dgvBookLendingData.Columns[i].DefaultCellStyle.Format = "dd/MM/yyyy";
                }

                dgvBookLendingData.Columns[0].HeaderText = "Mã số";
                dgvBookLendingData.Columns[1].HeaderText = "Mã số học sinh";
                dgvBookLendingData.Columns[2].HeaderText = "Tên học sinh";
                dgvBookLendingData.Columns[3].HeaderText = "Mã số thủ thư";
                dgvBookLendingData.Columns[4].HeaderText = "Tên thủ thư";
                dgvBookLendingData.Columns[5].HeaderText = "Ngày mượn";
                dgvBookLendingData.Columns[6].HeaderText = "Ngày trả";
                dgvBookLendingData.Columns[7].HeaderText = "Hạn trả";
            }
        }

        private void txtLendID_TextChanged(object sender, EventArgs e)
        {
            var lendings = bookLendingRepository.GetListLending();
            source = new BindingSource();
            if (txtLendID.Text.Length != 0)
            {
                raBChuaTra.Checked = false;
                rBDaTra.Checked = false;

                var lendingsSearch = lendings.Where(lend => lend.LendingID.ToString().Contains(txtLendID.Text)).ToList();

                source.DataSource = lendingsSearch;

                dgvBookLendingData.DataSource = null;
                dgvBookLendingData.DataSource = source;

                for (int i = 5; i < 8; i++)
                {
                    dgvBookLendingData.Columns[i].DefaultCellStyle.Format = "dd/MM/yyyy";
                }

                dgvBookLendingData.Columns[0].HeaderText = "Mã số";
                dgvBookLendingData.Columns[1].HeaderText = "Mã số học sinh";
                dgvBookLendingData.Columns[2].HeaderText = "Tên học sinh";
                dgvBookLendingData.Columns[3].HeaderText = "Mã số thủ thư";
                dgvBookLendingData.Columns[4].HeaderText = "Tên thủ thư";
                dgvBookLendingData.Columns[5].HeaderText = "Ngày mượn";
                dgvBookLendingData.Columns[6].HeaderText = "Ngày trả";
                dgvBookLendingData.Columns[7].HeaderText = "Hạn trả";
            }
            else
            {
                rBDaTra.Checked = true;
                rBDaTra.CheckedChanged += rBDaTra_CheckedChanged;
            }
        }
    }
}
