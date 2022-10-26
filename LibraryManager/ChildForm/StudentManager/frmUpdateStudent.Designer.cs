namespace LibraryManager.ChildForm.StudentManager
{
    partial class frmUpdateStudent
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
            this.label5 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.radioMale = new System.Windows.Forms.RadioButton();
            this.radioFemale = new System.Windows.Forms.RadioButton();
            this.dobPicker = new System.Windows.Forms.DateTimePicker();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lbStudentID = new System.Windows.Forms.Label();
            this.infoError = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.infoError)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã số học sinh";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ và tên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(349, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Giới tính";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(349, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ngày sinh";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(133, 60);
            this.txtName.MaxLength = 50;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(170, 23);
            this.txtName.TabIndex = 2;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            this.txtName.Validating += new System.ComponentModel.CancelEventHandler(this.txtName_Validating);
            this.txtName.Validated += new System.EventHandler(this.txtName_Validated);
            // 
            // txtStudentID
            // 
            this.txtStudentID.Location = new System.Drawing.Point(133, 19);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.Size = new System.Drawing.Size(100, 23);
            this.txtStudentID.TabIndex = 1;
            this.txtStudentID.TextChanged += new System.EventHandler(this.txtStudentID_TextChanged);
            this.txtStudentID.Validating += new System.ComponentModel.CancelEventHandler(this.txtStudentID_Validating);
            this.txtStudentID.Validated += new System.EventHandler(this.txtStudentID_Validated);
            // 
            // radioMale
            // 
            this.radioMale.AutoSize = true;
            this.radioMale.Checked = true;
            this.radioMale.Location = new System.Drawing.Point(432, 18);
            this.radioMale.Name = "radioMale";
            this.radioMale.Size = new System.Drawing.Size(51, 19);
            this.radioMale.TabIndex = 3;
            this.radioMale.TabStop = true;
            this.radioMale.Text = "Nam";
            this.radioMale.UseVisualStyleBackColor = true;
            // 
            // radioFemale
            // 
            this.radioFemale.AutoSize = true;
            this.radioFemale.Location = new System.Drawing.Point(491, 18);
            this.radioFemale.Name = "radioFemale";
            this.radioFemale.Size = new System.Drawing.Size(41, 19);
            this.radioFemale.TabIndex = 4;
            this.radioFemale.TabStop = true;
            this.radioFemale.Text = "Nữ";
            this.radioFemale.UseVisualStyleBackColor = true;
            // 
            // dobPicker
            // 
            this.dobPicker.CustomFormat = "dd-MM-yyyy";
            this.dobPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dobPicker.Location = new System.Drawing.Point(432, 57);
            this.dobPicker.Name = "dobPicker";
            this.dobPicker.Size = new System.Drawing.Size(100, 23);
            this.dobPicker.TabIndex = 6;
            this.dobPicker.ValueChanged += new System.EventHandler(this.dobPicker_ValueChanged);
            this.dobPicker.Validating += new System.ComponentModel.CancelEventHandler(this.dobPicker_Validating);
            this.dobPicker.Validated += new System.EventHandler(this.dobPicker_Validated);
            // 
            // btnConfirm
            // 
            this.btnConfirm.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnConfirm.Enabled = false;
            this.btnConfirm.Location = new System.Drawing.Point(92, 121);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(98, 43);
            this.btnConfirm.TabIndex = 7;
            this.btnConfirm.Text = "Thêm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(243, 121);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(98, 43);
            this.btnReset.TabIndex = 8;
            this.btnReset.Text = "Làm mới";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(385, 121);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(98, 43);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Huỷ";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lbStudentID
            // 
            this.lbStudentID.AutoSize = true;
            this.lbStudentID.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbStudentID.Location = new System.Drawing.Point(133, 22);
            this.lbStudentID.Name = "lbStudentID";
            this.lbStudentID.Size = new System.Drawing.Size(39, 15);
            this.lbStudentID.TabIndex = 11;
            this.lbStudentID.Text = "label6";
            this.lbStudentID.Visible = false;
            // 
            // infoError
            // 
            this.infoError.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.infoError.ContainerControl = this;
            // 
            // frmUpdateStudent
            // 
            this.AcceptButton = this.btnConfirm;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(574, 206);
            this.Controls.Add(this.lbStudentID);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.dobPicker);
            this.Controls.Add(this.radioFemale);
            this.Controls.Add(this.radioMale);
            this.Controls.Add(this.txtStudentID);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmUpdateStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý thư viện - Tạo thẻ thư viện";
            this.Load += new System.EventHandler(this.frmUpdateStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.infoError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label5;
        private TextBox txtName;
        private TextBox txtStudentID;
        private RadioButton radioMale;
        private RadioButton radioFemale;
        private DateTimePicker dobPicker;
        private Button btnConfirm;
        private Button btnReset;
        private Button btnCancel;
        private Label lbStudentID;
        private ErrorProvider infoError;
    }
}