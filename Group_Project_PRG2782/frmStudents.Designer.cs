namespace Group_Project_PRG2782
{
    partial class frmStudents
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
            this.btnViewCourse = new System.Windows.Forms.Button();
            this.btnViewStudent = new System.Windows.Forms.Button();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.btnUpdateStudent = new System.Windows.Forms.Button();
            this.btnDeleteStudent = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tbxSearch = new System.Windows.Forms.TextBox();
            this.txbxAddress = new System.Windows.Forms.TextBox();
            this.txbxPhone = new System.Windows.Forms.TextBox();
            this.txbxNumber = new System.Windows.Forms.TextBox();
            this.txbxName = new System.Windows.Forms.TextBox();
            this.lblModuleCodes = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblDOB = new System.Windows.Forms.Label();
            this.lblImage = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblStudentNmbr = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.dgvOne = new System.Windows.Forms.DataGridView();
            this.lblSearch = new System.Windows.Forms.Label();
            this.lblHeader = new System.Windows.Forms.Label();
            this.txbxSurname = new System.Windows.Forms.TextBox();
            this.lblSurname = new System.Windows.Forms.Label();
            this.txbxImagePath = new System.Windows.Forms.TextBox();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.tbnBrowse = new System.Windows.Forms.Button();
            this.cbxGender = new System.Windows.Forms.ComboBox();
            this.lbxModules = new System.Windows.Forms.ListBox();
            this.ofdImage = new System.Windows.Forms.OpenFileDialog();
            this.btnAddSubjects = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOne)).BeginInit();
            this.SuspendLayout();
            // 
            // btnViewCourse
            // 
            this.btnViewCourse.Location = new System.Drawing.Point(12, 77);
            this.btnViewCourse.Name = "btnViewCourse";
            this.btnViewCourse.Size = new System.Drawing.Size(75, 41);
            this.btnViewCourse.TabIndex = 0;
            this.btnViewCourse.Text = "View Course Details";
            this.btnViewCourse.UseVisualStyleBackColor = true;
            // 
            // btnViewStudent
            // 
            this.btnViewStudent.Location = new System.Drawing.Point(12, 156);
            this.btnViewStudent.Name = "btnViewStudent";
            this.btnViewStudent.Size = new System.Drawing.Size(75, 41);
            this.btnViewStudent.TabIndex = 1;
            this.btnViewStudent.Text = "View Student";
            this.btnViewStudent.UseVisualStyleBackColor = true;
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Location = new System.Drawing.Point(12, 238);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(75, 41);
            this.btnAddStudent.TabIndex = 2;
            this.btnAddStudent.Text = "Add new Student";
            this.btnAddStudent.UseVisualStyleBackColor = true;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // btnUpdateStudent
            // 
            this.btnUpdateStudent.Location = new System.Drawing.Point(12, 310);
            this.btnUpdateStudent.Name = "btnUpdateStudent";
            this.btnUpdateStudent.Size = new System.Drawing.Size(75, 41);
            this.btnUpdateStudent.TabIndex = 3;
            this.btnUpdateStudent.Text = "Update Student";
            this.btnUpdateStudent.UseVisualStyleBackColor = true;
            // 
            // btnDeleteStudent
            // 
            this.btnDeleteStudent.Location = new System.Drawing.Point(12, 398);
            this.btnDeleteStudent.Name = "btnDeleteStudent";
            this.btnDeleteStudent.Size = new System.Drawing.Size(75, 41);
            this.btnDeleteStudent.TabIndex = 4;
            this.btnDeleteStudent.Text = "Delete Student";
            this.btnDeleteStudent.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(602, 44);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(89, 24);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // tbxSearch
            // 
            this.tbxSearch.Location = new System.Drawing.Point(263, 44);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(293, 20);
            this.tbxSearch.TabIndex = 6;
            // 
            // txbxAddress
            // 
            this.txbxAddress.Location = new System.Drawing.Point(901, 343);
            this.txbxAddress.Margin = new System.Windows.Forms.Padding(2);
            this.txbxAddress.Name = "txbxAddress";
            this.txbxAddress.Size = new System.Drawing.Size(199, 20);
            this.txbxAddress.TabIndex = 32;
            // 
            // txbxPhone
            // 
            this.txbxPhone.Location = new System.Drawing.Point(901, 307);
            this.txbxPhone.Margin = new System.Windows.Forms.Padding(2);
            this.txbxPhone.Name = "txbxPhone";
            this.txbxPhone.Size = new System.Drawing.Size(199, 20);
            this.txbxPhone.TabIndex = 31;
            // 
            // txbxNumber
            // 
            this.txbxNumber.Location = new System.Drawing.Point(901, 73);
            this.txbxNumber.Margin = new System.Windows.Forms.Padding(2);
            this.txbxNumber.Name = "txbxNumber";
            this.txbxNumber.Size = new System.Drawing.Size(199, 20);
            this.txbxNumber.TabIndex = 30;
            // 
            // txbxName
            // 
            this.txbxName.Location = new System.Drawing.Point(901, 103);
            this.txbxName.Margin = new System.Windows.Forms.Padding(2);
            this.txbxName.Name = "txbxName";
            this.txbxName.Size = new System.Drawing.Size(199, 20);
            this.txbxName.TabIndex = 29;
            // 
            // lblModuleCodes
            // 
            this.lblModuleCodes.AutoSize = true;
            this.lblModuleCodes.Location = new System.Drawing.Point(784, 386);
            this.lblModuleCodes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblModuleCodes.Name = "lblModuleCodes";
            this.lblModuleCodes.Size = new System.Drawing.Size(75, 13);
            this.lblModuleCodes.TabIndex = 28;
            this.lblModuleCodes.Text = "Module Codes";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(784, 348);
            this.lblAddress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(45, 13);
            this.lblAddress.TabIndex = 27;
            this.lblAddress.Text = "Address";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(784, 310);
            this.lblPhone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(38, 13);
            this.lblPhone.TabIndex = 26;
            this.lblPhone.Text = "Phone";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(784, 280);
            this.lblGender.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(42, 13);
            this.lblGender.TabIndex = 25;
            this.lblGender.Text = "Gender";
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Location = new System.Drawing.Point(784, 238);
            this.lblDOB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(66, 13);
            this.lblDOB.TabIndex = 24;
            this.lblDOB.Text = "Date of Birth";
            // 
            // lblImage
            // 
            this.lblImage.AutoSize = true;
            this.lblImage.Location = new System.Drawing.Point(784, 170);
            this.lblImage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblImage.Name = "lblImage";
            this.lblImage.Size = new System.Drawing.Size(36, 13);
            this.lblImage.TabIndex = 23;
            this.lblImage.Text = "Image";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(784, 105);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 22;
            this.lblName.Text = "Name";
            // 
            // lblStudentNmbr
            // 
            this.lblStudentNmbr.AutoSize = true;
            this.lblStudentNmbr.Location = new System.Drawing.Point(784, 78);
            this.lblStudentNmbr.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStudentNmbr.Name = "lblStudentNmbr";
            this.lblStudentNmbr.Size = new System.Drawing.Size(84, 13);
            this.lblStudentNmbr.TabIndex = 21;
            this.lblStudentNmbr.Text = "Student Number";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(12, 483);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 41);
            this.btnExit.TabIndex = 35;
            this.btnExit.Text = "Return To Menu";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // dgvOne
            // 
            this.dgvOne.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOne.Location = new System.Drawing.Point(102, 78);
            this.dgvOne.Margin = new System.Windows.Forms.Padding(2);
            this.dgvOne.Name = "dgvOne";
            this.dgvOne.RowHeadersWidth = 51;
            this.dgvOne.RowTemplate.Height = 24;
            this.dgvOne.Size = new System.Drawing.Size(669, 446);
            this.dgvOne.TabIndex = 36;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(161, 47);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(96, 13);
            this.lblSearch.TabIndex = 37;
            this.lblSearch.Text = "Search for Student";
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(8, 9);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(124, 24);
            this.lblHeader.TabIndex = 38;
            this.lblHeader.Text = "Student Form";
            // 
            // txbxSurname
            // 
            this.txbxSurname.Location = new System.Drawing.Point(900, 139);
            this.txbxSurname.Margin = new System.Windows.Forms.Padding(2);
            this.txbxSurname.Name = "txbxSurname";
            this.txbxSurname.Size = new System.Drawing.Size(200, 20);
            this.txbxSurname.TabIndex = 40;
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(784, 139);
            this.lblSurname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(84, 13);
            this.lblSurname.TabIndex = 39;
            this.lblSurname.Text = "Student Number";
            // 
            // txbxImagePath
            // 
            this.txbxImagePath.Location = new System.Drawing.Point(900, 170);
            this.txbxImagePath.Name = "txbxImagePath";
            this.txbxImagePath.Size = new System.Drawing.Size(200, 20);
            this.txbxImagePath.TabIndex = 41;
            // 
            // dtpDOB
            // 
            this.dtpDOB.Location = new System.Drawing.Point(900, 238);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(200, 20);
            this.dtpDOB.TabIndex = 42;
            // 
            // tbnBrowse
            // 
            this.tbnBrowse.Location = new System.Drawing.Point(1009, 197);
            this.tbnBrowse.Name = "tbnBrowse";
            this.tbnBrowse.Size = new System.Drawing.Size(91, 23);
            this.tbnBrowse.TabIndex = 43;
            this.tbnBrowse.Text = "Browse";
            this.tbnBrowse.UseVisualStyleBackColor = true;
            // 
            // cbxGender
            // 
            this.cbxGender.FormattingEnabled = true;
            this.cbxGender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.cbxGender.Location = new System.Drawing.Point(900, 271);
            this.cbxGender.Name = "cbxGender";
            this.cbxGender.Size = new System.Drawing.Size(200, 21);
            this.cbxGender.TabIndex = 44;
            // 
            // lbxModules
            // 
            this.lbxModules.FormattingEnabled = true;
            this.lbxModules.Location = new System.Drawing.Point(900, 386);
            this.lbxModules.Name = "lbxModules";
            this.lbxModules.Size = new System.Drawing.Size(200, 95);
            this.lbxModules.TabIndex = 45;
            // 
            // ofdImage
            // 
            this.ofdImage.FileName = "SelectedImage";
            this.ofdImage.Filter = "*.jpeg|*.png";
            this.ofdImage.Title = "Select Image ";
            // 
            // btnAddSubjects
            // 
            this.btnAddSubjects.Location = new System.Drawing.Point(1025, 492);
            this.btnAddSubjects.Name = "btnAddSubjects";
            this.btnAddSubjects.Size = new System.Drawing.Size(75, 23);
            this.btnAddSubjects.TabIndex = 46;
            this.btnAddSubjects.Text = "Add Subject";
            this.btnAddSubjects.UseVisualStyleBackColor = true;
            this.btnAddSubjects.Click += new System.EventHandler(this.btnAddSubjects_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(784, 492);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 47;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // frmStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1210, 557);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAddSubjects);
            this.Controls.Add(this.lbxModules);
            this.Controls.Add(this.cbxGender);
            this.Controls.Add(this.tbnBrowse);
            this.Controls.Add(this.dtpDOB);
            this.Controls.Add(this.txbxImagePath);
            this.Controls.Add(this.txbxSurname);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.dgvOne);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txbxAddress);
            this.Controls.Add(this.txbxPhone);
            this.Controls.Add(this.txbxNumber);
            this.Controls.Add(this.txbxName);
            this.Controls.Add(this.lblModuleCodes);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.lblDOB);
            this.Controls.Add(this.lblImage);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblStudentNmbr);
            this.Controls.Add(this.tbxSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnDeleteStudent);
            this.Controls.Add(this.btnUpdateStudent);
            this.Controls.Add(this.btnAddStudent);
            this.Controls.Add(this.btnViewStudent);
            this.Controls.Add(this.btnViewCourse);
            this.Name = "frmStudents";
            this.Text = "frmStudents";
            this.Load += new System.EventHandler(this.frmStudents_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOne)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnViewCourse;
        private System.Windows.Forms.Button btnViewStudent;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.Button btnUpdateStudent;
        private System.Windows.Forms.Button btnDeleteStudent;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox tbxSearch;
        private System.Windows.Forms.TextBox txbxAddress;
        private System.Windows.Forms.TextBox txbxPhone;
        private System.Windows.Forms.TextBox txbxNumber;
        private System.Windows.Forms.TextBox txbxName;
        private System.Windows.Forms.Label lblModuleCodes;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.Label lblImage;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblStudentNmbr;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGridView dgvOne;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.TextBox txbxSurname;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.TextBox txbxImagePath;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.Button tbnBrowse;
        private System.Windows.Forms.ComboBox cbxGender;
        private System.Windows.Forms.ListBox lbxModules;
        private System.Windows.Forms.OpenFileDialog ofdImage;
        private System.Windows.Forms.Button btnAddSubjects;
        private System.Windows.Forms.Button btnClear;
    }
}