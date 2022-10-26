namespace LibraryManager.Lending_Manager
{
    partial class frmLendingManager
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnReturnBook = new System.Windows.Forms.Button();
            this.dgvBookLendingData = new System.Windows.Forms.DataGridView();
            this.btnMuon = new System.Windows.Forms.Button();
            this.lbSearch = new System.Windows.Forms.Label();
            this.txtLendID = new System.Windows.Forms.TextBox();
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.lbTitle = new System.Windows.Forms.Label();
            this.gbStudentID = new System.Windows.Forms.GroupBox();
            this.raBChuaTra = new System.Windows.Forms.RadioButton();
            this.rBDaTra = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookLendingData)).BeginInit();
            this.gbStudentID.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnReturnBook
            // 
            this.btnReturnBook.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReturnBook.Location = new System.Drawing.Point(868, 277);
            this.btnReturnBook.Name = "btnReturnBook";
            this.btnReturnBook.Size = new System.Drawing.Size(103, 29);
            this.btnReturnBook.TabIndex = 0;
            this.btnReturnBook.Text = "Trả sách";
            this.btnReturnBook.UseVisualStyleBackColor = true;
            this.btnReturnBook.Click += new System.EventHandler(this.btnReturnBook_Click);
            // 
            // dgvBookLendingData
            // 
            this.dgvBookLendingData.AllowUserToAddRows = false;
            this.dgvBookLendingData.AllowUserToDeleteRows = false;
            this.dgvBookLendingData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBookLendingData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBookLendingData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBookLendingData.Location = new System.Drawing.Point(36, 137);
            this.dgvBookLendingData.Name = "dgvBookLendingData";
            this.dgvBookLendingData.ReadOnly = true;
            this.dgvBookLendingData.RowHeadersWidth = 51;
            this.dgvBookLendingData.RowTemplate.Height = 29;
            this.dgvBookLendingData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBookLendingData.Size = new System.Drawing.Size(793, 373);
            this.dgvBookLendingData.TabIndex = 1;
            // 
            // btnMuon
            // 
            this.btnMuon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMuon.Location = new System.Drawing.Point(30, 84);
            this.btnMuon.Name = "btnMuon";
            this.btnMuon.Size = new System.Drawing.Size(103, 29);
            this.btnMuon.TabIndex = 0;
            this.btnMuon.Text = "Mượn sách";
            this.btnMuon.UseVisualStyleBackColor = true;
            this.btnMuon.Click += new System.EventHandler(this.btnMuon_Click);
            // 
            // lbSearch
            // 
            this.lbSearch.AutoSize = true;
            this.lbSearch.Location = new System.Drawing.Point(45, 95);
            this.lbSearch.Name = "lbSearch";
            this.lbSearch.Size = new System.Drawing.Size(70, 20);
            this.lbSearch.TabIndex = 2;
            this.lbSearch.Text = "Tìm kiếm";
            // 
            // txtLendID
            // 
            this.txtLendID.Location = new System.Drawing.Point(131, 92);
            this.txtLendID.Name = "txtLendID";
            this.txtLendID.PlaceholderText = "Nhập mã mượn...";
            this.txtLendID.Size = new System.Drawing.Size(125, 27);
            this.txtLendID.TabIndex = 3;
            this.txtLendID.TextChanged += new System.EventHandler(this.txtLendID_TextChanged);
            // 
            // txtStudentID
            // 
            this.txtStudentID.Location = new System.Drawing.Point(30, 51);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.PlaceholderText = "Mã học sinh...";
            this.txtStudentID.Size = new System.Drawing.Size(103, 27);
            this.txtStudentID.TabIndex = 3;
            // 
            // lbTitle
            // 
            this.lbTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbTitle.Location = new System.Drawing.Point(313, 28);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(242, 41);
            this.lbTitle.TabIndex = 4;
            this.lbTitle.Text = "Danh sách mượn";
            // 
            // gbStudentID
            // 
            this.gbStudentID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbStudentID.Controls.Add(this.btnMuon);
            this.gbStudentID.Controls.Add(this.txtStudentID);
            this.gbStudentID.Location = new System.Drawing.Point(839, 137);
            this.gbStudentID.Name = "gbStudentID";
            this.gbStudentID.Size = new System.Drawing.Size(143, 119);
            this.gbStudentID.TabIndex = 5;
            this.gbStudentID.TabStop = false;
            this.gbStudentID.Text = "Nhập mã học sinh";
            // 
            // raBChuaTra
            // 
            this.raBChuaTra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.raBChuaTra.AutoSize = true;
            this.raBChuaTra.Location = new System.Drawing.Point(743, 93);
            this.raBChuaTra.Name = "raBChuaTra";
            this.raBChuaTra.Size = new System.Drawing.Size(86, 24);
            this.raBChuaTra.TabIndex = 6;
            this.raBChuaTra.Text = "Chưa trả";
            this.raBChuaTra.UseVisualStyleBackColor = true;
            // 
            // rBDaTra
            // 
            this.rBDaTra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rBDaTra.AutoSize = true;
            this.rBDaTra.Checked = true;
            this.rBDaTra.Location = new System.Drawing.Point(634, 93);
            this.rBDaTra.Name = "rBDaTra";
            this.rBDaTra.Size = new System.Drawing.Size(73, 24);
            this.rBDaTra.TabIndex = 6;
            this.rBDaTra.TabStop = true;
            this.rBDaTra.Text = "Đã Trả";
            this.rBDaTra.UseVisualStyleBackColor = true;
            this.rBDaTra.CheckedChanged += new System.EventHandler(this.rBDaTra_CheckedChanged);
            // 
            // frmLendingManager
            // 
            this.AcceptButton = this.btnMuon;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 577);
            this.ControlBox = false;
            this.Controls.Add(this.rBDaTra);
            this.Controls.Add(this.raBChuaTra);
            this.Controls.Add(this.gbStudentID);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.txtLendID);
            this.Controls.Add(this.lbSearch);
            this.Controls.Add(this.dgvBookLendingData);
            this.Controls.Add(this.btnReturnBook);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLendingManager";
            this.Text = "Trình cho mượn sách";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmLendingManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookLendingData)).EndInit();
            this.gbStudentID.ResumeLayout(false);
            this.gbStudentID.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnReturnBook;
        private DataGridView dgvBookLendingData;
        private Button btnMuon;
        private Label lbSearch;
        private TextBox txtLendID;
        private TextBox txtStudentID;
        private Label lbTitle;
        private GroupBox gbStudentID;
        private RadioButton raBChuaTra;
        private RadioButton rBDaTra;
    }
}