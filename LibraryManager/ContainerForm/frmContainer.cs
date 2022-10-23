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
        frmStudentManager? StudentManager;
        frmBookManager? BookManager;
        frmLendingManager? LendingManager;
        frmInfo? InfoManager;
        Librarian librarian;

        public Librarian Librarian { get => librarian; set => librarian = value; }

        private void frmContainer_Load(object sender, EventArgs e)
        {

        }
        private void studentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseAllChildForm();
            StudentManager = new frmStudentManager();
            StudentManager.MdiParent = this;
            StudentManager.Show();
        }

        private void booksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseAllChildForm();
            BookManager = new frmBookManager();
            BookManager.MdiParent = this;
            BookManager.Dock = DockStyle.Fill;
            BookManager.Show();
        }

        private void lendToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseAllChildForm();
            LendingManager = new frmLendingManager();
            LendingManager.MdiParent = this;
            LendingManager.Show();
        }
        private void CloseAllChildForm()
        {
            if (StudentManager != null) StudentManager.Close();
            if (BookManager != null) BookManager.Close();
            if (LendingManager != null) LendingManager.Close();
            if (InfoManager != null) InfoManager.Close();
        }

        private void thayDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseAllChildForm();
            InfoManager = new frmInfo
            {
                Librarian = librarian
            };
            InfoManager.MdiParent = this;
            InfoManager.Dock = DockStyle.Fill;
            InfoManager.Show();
        }
    }
}
