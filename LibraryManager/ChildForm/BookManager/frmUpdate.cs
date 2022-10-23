using BusinessObject;
using DataAccess.Repository;
using LibraryManager.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace LibraryManager.ChildForm.BookManager
{
    public partial class frmUpdate : Form
    {
        public frmUpdate()
        {
            InitializeComponent();
        }
        internal IBookRepository bookRepository;
        internal bool InsertOrUpdate;
        internal Book bookInfo;       
        private void frmUpdate_Load(object sender, EventArgs e)
        {
            LoadComboBoxFilter();        
            if (!InsertOrUpdate)
            {
                this.Text = "Quản lý thư viện - Cập nhật thông tin sách";
                txtBookID.Text = bookInfo.BookID.ToString();
                txtTitle.Text = bookInfo.Title;
                txtPrinter.Text = bookInfo.Printer;
                txtQuantity.Text = bookInfo.Quantity.ToString();
                txtPrice.Text = bookInfo.Price.ToString();
                txtAuthor.Text = bookInfo.Author;
                txtYear.Text = bookInfo.PublishYear;
                cboCategory.SelectedValue = bookInfo.Category.CategoryID;
                btnConfirm.Text = "Cập nhật";
            } else
            {
                txtBookID.Text = bookRepository.GetNewProperBookID().ToString();
            }
        }
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            bookInfo = new Book
            {
                Author = txtAuthor.Text,
                BookID = int.Parse(txtBookID.Text),
                Title = txtTitle.Text,
                Category = (Category)cboCategory.SelectedItem,
                Price = Double.Parse(txtPrice.Text),
                Printer = txtPrinter.Text,
                PublishYear = txtYear.Text,
                Quantity = int.Parse(txtQuantity.Text)
            };
            if (InsertOrUpdate)
            {
                bookRepository.AddBook(bookInfo);
            } else
            {
                bookRepository.UpdateBook(bookInfo);               
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtTitle.Clear();
            txtQuantity.Clear();
            txtPrice.Clear();
            txtPrinter.Clear();
            txtAuthor.Clear();
            txtYear.Clear();
            cboCategory.SelectedIndex = 0;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtTitle_TextChanged(object sender, EventArgs e)
        {
            validateBookInfo();
        }

        private void cboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            validateBookInfo();
        }

        private void txtPrinter_TextChanged(object sender, EventArgs e)
        {
            validateBookInfo();
        }

        private void txtAuthor_TextChanged(object sender, EventArgs e)
        {
            validateBookInfo();
        }

        private void txtYear_TextChanged(object sender, EventArgs e)
        {
            validateBookInfo();
        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            validateBookInfo();
        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {
            validateBookInfo();
        }

        private void txtTitle_Validating(object sender, CancelEventArgs e)
        {
            if (!ValidateHelper.validateVietnameseWithNum(txtTitle.Text))
            {
                e.Cancel = true;
                infoError.SetError(txtTitle, "Tựa đề không thể chứa các ký tự đặc biệt");
            }
        }

        private void txtTitle_Validated(object sender, EventArgs e)
        {
            infoError.SetError(txtTitle, "");
        }

        private void txtPrinter_Validating(object sender, CancelEventArgs e)
        {
            if (!ValidateHelper.validateVietnamese(txtPrinter.Text))
            {
                e.Cancel = true;
                infoError.SetError(txtPrinter, "Tên nhà xuất bản không thể chứa các chữ số và ký tự đặc biệt");
            }
        }

        private void txtPrinter_Validated(object sender, EventArgs e)
        {
            infoError.SetError(txtPrinter, "");
        }

        private void txtAuthor_Validating(object sender, CancelEventArgs e)
        {
            if (!ValidateHelper.validateVietnamese(txtAuthor.Text))
            {
                e.Cancel = true;
                infoError.SetError(txtAuthor, "Tên tác giả không thể chứa các chữ số và ký tự đặc biệt");
            }
        }

        private void txtAuthor_Validated(object sender, EventArgs e)
        {
            infoError.SetError(txtAuthor, "");
        }

        private void txtYear_Validating(object sender, CancelEventArgs e)
        {
            if (!ValidateHelper.validateInteger(txtYear.Text))
            {
                e.Cancel = true;
                infoError.SetError(txtYear, "Năm xuất bản không thể chứa các chữ cái và kí tự đặc biệt");
            }
        }

        private void txtYear_Validated(object sender, EventArgs e)
        {
            infoError.SetError(txtYear, "");
        }

        private void txtQuantity_Validating(object sender, CancelEventArgs e)
        {
            if (!ValidateHelper.validateInteger(txtQuantity.Text))
            {
                e.Cancel = true;
                infoError.SetError(txtQuantity, "Số lượng không thể chứa các chữ cái và ký tự đặc biệt");
            }
        }

        private void txtQuantity_Validated(object sender, EventArgs e)
        {
            infoError.SetError(txtQuantity, "");
        }

        private void txtPrice_Validating(object sender, CancelEventArgs e)
        {
            if (!ValidateHelper.validateDecimal(txtPrice.Text))
            {
                e.Cancel = true;
                infoError.SetError(txtPrice, "Giá tiền không thể chứa các chữ số và ký tự đặc biệt");
            }
        }

        private void txtPrice_Validated(object sender, EventArgs e)
        {
            infoError.SetError(txtPrice, "");
        }
        private void cboCategory_Validating(object sender, CancelEventArgs e)
        {
            if (cboCategory.SelectedIndex == 0)
            {
                e.Cancel = true;
                infoError.SetError(cboCategory, "Phân loại không thể để trống");
            }
        }

        private void cboCategory_Validated(object sender, EventArgs e)
        {
            infoError.SetError(cboCategory, "");
        }
        private void LoadComboBoxFilter()
        {
            cboCategory.Items.Clear();
            ICategoryRepository categoryRepository = new CategoryRepository();
            List<Category> categories = categoryRepository.GetCategories().ToList();
            categories.Insert(0, new Category
            {
                CategoryID = 0,
                CategoryTitle = "-- Chọn 1 phân vùng --"
            });
            cboCategory.DataSource = categories;
            cboCategory.DisplayMember = "categoryTitle";
            cboCategory.ValueMember = "categoryID";
            cboCategory.SelectedIndex = 0;
        }
        private void validateBookInfo()
        {
            bool enabled = true;
            if (!ValidateHelper.validateVietnameseWithNum(txtTitle.Text)) enabled = false;
            if (!ValidateHelper.validateVietnamese(txtPrinter.Text)) enabled = false;
            if (!ValidateHelper.validateVietnamese(txtAuthor.Text)) enabled = false;
            if (!ValidateHelper.validateDecimal(txtPrice.Text)) enabled = false;
            if (!ValidateHelper.validateInteger(txtYear.Text)) enabled = false;
            if (!ValidateHelper.validateInteger(txtQuantity.Text)) enabled = false;
            if (cboCategory.SelectedIndex == 0) enabled = false;
            btnConfirm.Enabled = enabled;
        }      
    }
}
