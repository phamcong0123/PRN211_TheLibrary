namespace LibraryManager.ChildForm.BookManager
{
    partial class frmUpdateBook
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtPrinter = new System.Windows.Forms.TextBox();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.cboCategory = new System.Windows.Forms.ComboBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.infoError = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtBookID = new System.Windows.Forms.Label();
            this.txtYear = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.infoError)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã sách";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tựa đề";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Phân loại";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nhà xuất bản";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(394, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tác giả";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(394, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Năm xuất bản";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(394, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "Số lượng";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(394, 149);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(24, 15);
            this.labelPrice.TabIndex = 7;
            this.labelPrice.Text = "Giá";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(132, 59);
            this.txtTitle.MaxLength = 30;
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(187, 23);
            this.txtTitle.TabIndex = 9;
            this.txtTitle.TextChanged += new System.EventHandler(this.txtTitle_TextChanged);
            this.txtTitle.Validating += new System.ComponentModel.CancelEventHandler(this.txtTitle_Validating);
            this.txtTitle.Validated += new System.EventHandler(this.txtTitle_Validated);
            // 
            // txtPrinter
            // 
            this.txtPrinter.Location = new System.Drawing.Point(132, 146);
            this.txtPrinter.MaxLength = 50;
            this.txtPrinter.Name = "txtPrinter";
            this.txtPrinter.Size = new System.Drawing.Size(187, 23);
            this.txtPrinter.TabIndex = 10;
            this.txtPrinter.TextChanged += new System.EventHandler(this.txtPrinter_TextChanged);
            this.txtPrinter.Validating += new System.ComponentModel.CancelEventHandler(this.txtPrinter_Validating);
            this.txtPrinter.Validated += new System.EventHandler(this.txtPrinter_Validated);
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(509, 16);
            this.txtAuthor.MaxLength = 20;
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(170, 23);
            this.txtAuthor.TabIndex = 11;
            this.txtAuthor.TextChanged += new System.EventHandler(this.txtAuthor_TextChanged);
            this.txtAuthor.Validating += new System.ComponentModel.CancelEventHandler(this.txtAuthor_Validating);
            this.txtAuthor.Validated += new System.EventHandler(this.txtAuthor_Validated);
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(509, 102);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(100, 23);
            this.txtQuantity.TabIndex = 13;
            this.txtQuantity.TextChanged += new System.EventHandler(this.txtQuantity_TextChanged);
            this.txtQuantity.Validating += new System.ComponentModel.CancelEventHandler(this.txtQuantity_Validating);
            this.txtQuantity.Validated += new System.EventHandler(this.txtQuantity_Validated);
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(509, 146);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(119, 23);
            this.txtPrice.TabIndex = 14;
            this.txtPrice.TextChanged += new System.EventHandler(this.txtPrice_TextChanged);
            this.txtPrice.Validating += new System.ComponentModel.CancelEventHandler(this.txtPrice_Validating);
            this.txtPrice.Validated += new System.EventHandler(this.txtPrice_Validated);
            // 
            // cboCategory
            // 
            this.cboCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategory.FormattingEnabled = true;
            this.cboCategory.Location = new System.Drawing.Point(132, 102);
            this.cboCategory.Name = "cboCategory";
            this.cboCategory.Size = new System.Drawing.Size(187, 23);
            this.cboCategory.TabIndex = 15;
            this.cboCategory.SelectedIndexChanged += new System.EventHandler(this.cboCategory_SelectedIndexChanged);
            this.cboCategory.Validating += new System.ComponentModel.CancelEventHandler(this.cboCategory_Validating);
            this.cboCategory.Validated += new System.EventHandler(this.cboCategory_Validated);
            // 
            // btnConfirm
            // 
            this.btnConfirm.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnConfirm.Enabled = false;
            this.btnConfirm.Location = new System.Drawing.Point(104, 226);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(102, 53);
            this.btnConfirm.TabIndex = 16;
            this.btnConfirm.Text = "Thêm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(303, 226);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(102, 53);
            this.btnReset.TabIndex = 17;
            this.btnReset.Text = "Làm mới";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(509, 226);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(102, 53);
            this.btnCancel.TabIndex = 18;
            this.btnCancel.Text = "Huỷ";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(634, 149);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(14, 15);
            this.label8.TabIndex = 19;
            this.label8.Text = "₫";
            // 
            // infoError
            // 
            this.infoError.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.infoError.ContainerControl = this;
            // 
            // txtBookID
            // 
            this.txtBookID.AutoSize = true;
            this.txtBookID.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtBookID.Location = new System.Drawing.Point(132, 19);
            this.txtBookID.Name = "txtBookID";
            this.txtBookID.Size = new System.Drawing.Size(31, 15);
            this.txtBookID.TabIndex = 20;
            this.txtBookID.Text = "xxxx";
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(509, 59);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(100, 23);
            this.txtYear.TabIndex = 12;
            this.txtYear.TextChanged += new System.EventHandler(this.txtYear_TextChanged);
            this.txtYear.Validating += new System.ComponentModel.CancelEventHandler(this.txtYear_Validating);
            this.txtYear.Validated += new System.EventHandler(this.txtYear_Validated);
            // 
            // frmUpdateBook
            // 
            this.AcceptButton = this.btnConfirm;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(726, 310);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.txtBookID);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.cboCategory);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.txtAuthor);
            this.Controls.Add(this.txtPrinter);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmUpdateBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý thư viện - Thêm sách mới";
            this.Load += new System.EventHandler(this.frmUpdate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.infoError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label labelPrice;
        private TextBox txtTitle;
        private TextBox txtPrinter;
        private TextBox txtAuthor;
        private TextBox txtQuantity;
        private TextBox txtPrice;
        private ComboBox cboCategory;
        private Button btnConfirm;
        private Button btnReset;
        private Button btnCancel;
        private Label label8;
        private ErrorProvider infoError;
        private Label txtBookID;
        private TextBox txtYear;
    }
}