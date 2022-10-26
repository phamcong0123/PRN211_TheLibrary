namespace LibraryManager.ChildForm.Lending_Manager
{
    partial class frmReturnBookLending
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
            this.dgvBookLendingData = new System.Windows.Forms.DataGridView();
            this.colLendTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStudentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStudentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLendDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDeadline = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbLendingList = new System.Windows.Forms.Label();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.lbQuaHan = new System.Windows.Forms.Label();
            this.lbNotify = new System.Windows.Forms.Label();
            this.lbDetail = new System.Windows.Forms.Label();
            this.dgvLendingDetailData = new System.Windows.Forms.DataGridView();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.lbTimKiem = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookLendingData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLendingDetailData)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBookLendingData
            // 
            this.dgvBookLendingData.AllowUserToAddRows = false;
            this.dgvBookLendingData.AllowUserToDeleteRows = false;
            this.dgvBookLendingData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBookLendingData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBookLendingData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colLendTitle,
            this.colStudentID,
            this.colStudentName,
            this.colLendDate,
            this.colDeadline});
            this.dgvBookLendingData.Location = new System.Drawing.Point(37, 115);
            this.dgvBookLendingData.Name = "dgvBookLendingData";
            this.dgvBookLendingData.ReadOnly = true;
            this.dgvBookLendingData.RowHeadersVisible = false;
            this.dgvBookLendingData.RowHeadersWidth = 51;
            this.dgvBookLendingData.RowTemplate.Height = 29;
            this.dgvBookLendingData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBookLendingData.Size = new System.Drawing.Size(678, 325);
            this.dgvBookLendingData.TabIndex = 5;
            this.dgvBookLendingData.SelectionChanged += new System.EventHandler(this.dgvBookLendingData_SelectionChanged);
            // 
            // colLendTitle
            // 
            this.colLendTitle.HeaderText = "Mã mượn";
            this.colLendTitle.MinimumWidth = 6;
            this.colLendTitle.Name = "colLendTitle";
            this.colLendTitle.ReadOnly = true;
            // 
            // colStudentID
            // 
            this.colStudentID.HeaderText = "Mã học sinh";
            this.colStudentID.MinimumWidth = 6;
            this.colStudentID.Name = "colStudentID";
            this.colStudentID.ReadOnly = true;
            // 
            // colStudentName
            // 
            this.colStudentName.HeaderText = "Tên học sinh";
            this.colStudentName.MinimumWidth = 6;
            this.colStudentName.Name = "colStudentName";
            this.colStudentName.ReadOnly = true;
            // 
            // colLendDate
            // 
            this.colLendDate.HeaderText = "Ngày mượn";
            this.colLendDate.MinimumWidth = 6;
            this.colLendDate.Name = "colLendDate";
            this.colLendDate.ReadOnly = true;
            // 
            // colDeadline
            // 
            this.colDeadline.HeaderText = "Hạn trả";
            this.colDeadline.MinimumWidth = 6;
            this.colDeadline.Name = "colDeadline";
            this.colDeadline.ReadOnly = true;
            // 
            // lbLendingList
            // 
            this.lbLendingList.AutoSize = true;
            this.lbLendingList.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbLendingList.Location = new System.Drawing.Point(37, 40);
            this.lbLendingList.Name = "lbLendingList";
            this.lbLendingList.Size = new System.Drawing.Size(239, 31);
            this.lbLendingList.TabIndex = 0;
            this.lbLendingList.Text = "Danh sách mượn sách";
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.Location = new System.Drawing.Point(1126, 80);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(94, 29);
            this.btnXacNhan.TabIndex = 6;
            this.btnXacNhan.Text = "Xác nhận";
            this.btnXacNhan.UseVisualStyleBackColor = true;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(1226, 80);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(94, 29);
            this.btnThoat.TabIndex = 6;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // lbQuaHan
            // 
            this.lbQuaHan.AutoSize = true;
            this.lbQuaHan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbQuaHan.ForeColor = System.Drawing.Color.Red;
            this.lbQuaHan.Location = new System.Drawing.Point(591, 81);
            this.lbQuaHan.Name = "lbQuaHan";
            this.lbQuaHan.Size = new System.Drawing.Size(124, 28);
            this.lbQuaHan.TabIndex = 7;
            this.lbQuaHan.Text = "* Đã quá hạn";
            // 
            // lbNotify
            // 
            this.lbNotify.AutoSize = true;
            this.lbNotify.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.lbNotify.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbNotify.Location = new System.Drawing.Point(139, 256);
            this.lbNotify.Name = "lbNotify";
            this.lbNotify.Size = new System.Drawing.Size(509, 41);
            this.lbNotify.TabIndex = 0;
            this.lbNotify.Text = "Không có sách nào đang được mượn";
            // 
            // lbDetail
            // 
            this.lbDetail.AutoSize = true;
            this.lbDetail.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbDetail.Location = new System.Drawing.Point(801, 75);
            this.lbDetail.Name = "lbDetail";
            this.lbDetail.Size = new System.Drawing.Size(91, 31);
            this.lbDetail.TabIndex = 0;
            this.lbDetail.Text = "Chi Tiết";
            // 
            // dgvLendingDetailData
            // 
            this.dgvLendingDetailData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLendingDetailData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLendingDetailData.Location = new System.Drawing.Point(801, 115);
            this.dgvLendingDetailData.Name = "dgvLendingDetailData";
            this.dgvLendingDetailData.ReadOnly = true;
            this.dgvLendingDetailData.RowHeadersVisible = false;
            this.dgvLendingDetailData.RowHeadersWidth = 51;
            this.dgvLendingDetailData.RowTemplate.Height = 29;
            this.dgvLendingDetailData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLendingDetailData.Size = new System.Drawing.Size(519, 325);
            this.dgvLendingDetailData.TabIndex = 8;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(212, 81);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.PlaceholderText = "Nhập Mã mượn hoặc Mã học sinh...";
            this.txtTimKiem.Size = new System.Drawing.Size(258, 27);
            this.txtTimKiem.TabIndex = 9;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // lbTimKiem
            // 
            this.lbTimKiem.AutoSize = true;
            this.lbTimKiem.Location = new System.Drawing.Point(136, 86);
            this.lbTimKiem.Name = "lbTimKiem";
            this.lbTimKiem.Size = new System.Drawing.Size(70, 20);
            this.lbTimKiem.TabIndex = 10;
            this.lbTimKiem.Text = "Tìm kiếm";
            // 
            // frmReturnBookLending
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1345, 472);
            this.Controls.Add(this.lbTimKiem);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.dgvLendingDetailData);
            this.Controls.Add(this.lbNotify);
            this.Controls.Add(this.lbQuaHan);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXacNhan);
            this.Controls.Add(this.dgvBookLendingData);
            this.Controls.Add(this.lbDetail);
            this.Controls.Add(this.lbLendingList);
            this.Name = "frmReturnBookLending";
            this.Text = "frmReturnBookLending";
            this.Load += new System.EventHandler(this.frmReturnBookLending_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookLendingData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLendingDetailData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DataGridView dgvBookLendingData;
        private Label lbLendingList;
        private Button btnXacNhan;
        private Button btnThoat;
        private Label lbQuaHan;
        private Label lbNotify;
        private Label lbDetail;
        private DataGridView dgvLendingDetailData;
        private DataGridViewTextBoxColumn colLendTitle;
        private DataGridViewTextBoxColumn colStudentID;
        private DataGridViewTextBoxColumn colStudentName;
        private DataGridViewTextBoxColumn colLendDate;
        private DataGridViewTextBoxColumn colDeadline;
        private TextBox txtTimKiem;
        private Label lbTimKiem;
    }
}