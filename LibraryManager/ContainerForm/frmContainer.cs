using BusinessObject;
using LibraryManager.BookManager;
using LibraryManager.ChildForm.Personal_Info;
using LibraryManager.Lending_Manager;
using LibraryManager.StudentManager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManager
{
    public partial class frmContainer : Form
    {
        public frmContainer()
        {
            InitializeComponent();
        }
        frmStudentManager StudentManager = new frmStudentManager();
        frmBookManager BookManager = new frmBookManager();
        frmLendingManager LendingManager = new frmLendingManager();
        frmInfo InfoManager = new frmInfo();
        Librarian librarian;

        public Librarian Librarian { get => librarian; set => librarian = value; }

        private void frmContainer_Load(object sender, EventArgs e)
        {
            txtName.Text = librarian.Name;
        }
        private void studentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HideAllChildForm();
            StudentManager.MdiParent = this;
            StudentManager.Dock = DockStyle.Fill;
            StudentManager.Show();
        }

        private void booksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HideAllChildForm();
            BookManager.MdiParent = this;
            BookManager.Dock = DockStyle.Fill;
            BookManager.Show();
        }

        private void lendToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HideAllChildForm();
            LendingManager.Librarian = librarian;
            LendingManager.MdiParent = this;
            LendingManager.Dock = DockStyle.Fill;
            LendingManager.Show();
        }
        private void HideAllChildForm()
        {
            StudentManager.Hide();
            BookManager.Hide();
            LendingManager.Hide();
            InfoManager.Hide();
        }

        private void thayDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HideAllChildForm();
            InfoManager.Librarian = librarian;
            InfoManager.MdiParent = this;
            InfoManager.Dock = DockStyle.Fill;
            InfoManager.Show();
        }
    }
}
