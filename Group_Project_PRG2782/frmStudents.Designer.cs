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
            this.txbxModuleCode = new System.Windows.Forms.TextBox();
            this.txbxAddress = new System.Windows.Forms.TextBox();
            this.txbxPhone = new System.Windows.Forms.TextBox();
            this.txbxNumber = new System.Windows.Forms.TextBox();
            this.txbxNameSurname = new System.Windows.Forms.TextBox();
            this.lblModuleCodes = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblDOB = new System.Windows.Forms.Label();
            this.lblImage = new System.Windows.Forms.Label();
            this.lblNameAndSurname = new System.Windows.Forms.Label();
            this.lblStudentNmbr = new System.Windows.Forms.Label();
            this.lstVw = new System.Windows.Forms.ListView();
            this.clmCatID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmCatName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnExit = new System.Windows.Forms.Button();
            this.dgvOne = new System.Windows.Forms.DataGridView();
            this.lblSearch = new System.Windows.Forms.Label();
            this.lblHeader = new System.Windows.Forms.Label();
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
            // txbxModuleCode
            // 
            this.txbxModuleCode.Location = new System.Drawing.Point(901, 259);
            this.txbxModuleCode.Margin = new System.Windows.Forms.Padding(2);
            this.txbxModuleCode.Name = "txbxModuleCode";
            this.txbxModuleCode.Size = new System.Drawing.Size(144, 20);
            this.txbxModuleCode.TabIndex = 33;
            // 
            // txbxAddress
            // 
            this.txbxAddress.Location = new System.Drawing.Point(901, 232);
            this.txbxAddress.Margin = new System.Windows.Forms.Padding(2);
            this.txbxAddress.Name = "txbxAddress";
            this.txbxAddress.Size = new System.Drawing.Size(144, 20);
            this.txbxAddress.TabIndex = 32;
            // 
            // txbxPhone
            // 
            this.txbxPhone.Location = new System.Drawing.Point(901, 207);
            this.txbxPhone.Margin = new System.Windows.Forms.Padding(2);
            this.txbxPhone.Name = "txbxPhone";
            this.txbxPhone.Size = new System.Drawing.Size(144, 20);
            this.txbxPhone.TabIndex = 31;
            // 
            // txbxNumber
            // 
            this.txbxNumber.Location = new System.Drawing.Point(901, 73);
            this.txbxNumber.Margin = new System.Windows.Forms.Padding(2);
            this.txbxNumber.Name = "txbxNumber";
            this.txbxNumber.Size = new System.Drawing.Size(144, 20);
            this.txbxNumber.TabIndex = 30;
            // 
            // txbxNameSurname
            // 
            this.txbxNameSurname.Location = new System.Drawing.Point(901, 101);
            this.txbxNameSurname.Margin = new System.Windows.Forms.Padding(2);
            this.txbxNameSurname.Name = "txbxNameSurname";
            this.txbxNameSurname.Size = new System.Drawing.Size(144, 20);
            this.txbxNameSurname.TabIndex = 29;
            // 
            // lblModuleCodes
            // 
            this.lblModuleCodes.AutoSize = true;
            this.lblModuleCodes.Location = new System.Drawing.Point(784, 264);
            this.lblModuleCodes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblModuleCodes.Name = "lblModuleCodes";
            this.lblModuleCodes.Size = new System.Drawing.Size(75, 13);
            this.lblModuleCodes.TabIndex = 28;
            this.lblModuleCodes.Text = "Module Codes";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(784, 237);
            this.lblAddress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(45, 13);
            this.lblAddress.TabIndex = 27;
            this.lblAddress.Text = "Address";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(784, 212);
            this.lblPhone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(38, 13);
            this.lblPhone.TabIndex = 26;
            this.lblPhone.Text = "Phone";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(784, 184);
            this.lblGender.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(42, 13);
            this.lblGender.TabIndex = 25;
            this.lblGender.Text = "Gender";
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Location = new System.Drawing.Point(784, 157);
            this.lblDOB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(66, 13);
            this.lblDOB.TabIndex = 24;
            this.lblDOB.Text = "Date of Birth";
            // 
            // lblImage
            // 
            this.lblImage.AutoSize = true;
            this.lblImage.Location = new System.Drawing.Point(784, 129);
            this.lblImage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblImage.Name = "lblImage";
            this.lblImage.Size = new System.Drawing.Size(36, 13);
            this.lblImage.TabIndex = 23;
            this.lblImage.Text = "Image";
            // 
            // lblNameAndSurname
            // 
            this.lblNameAndSurname.AutoSize = true;
            this.lblNameAndSurname.Location = new System.Drawing.Point(784, 103);
            this.lblNameAndSurname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNameAndSurname.Name = "lblNameAndSurname";
            this.lblNameAndSurname.Size = new System.Drawing.Size(101, 13);
            this.lblNameAndSurname.TabIndex = 22;
            this.lblNameAndSurname.Text = "Name and Surname";
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
            // lstVw
            // 
            this.lstVw.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmCatID,
            this.clmCatName});
            this.lstVw.FullRowSelect = true;
            this.lstVw.HideSelection = false;
            this.lstVw.Location = new System.Drawing.Point(787, 310);
            this.lstVw.Margin = new System.Windows.Forms.Padding(2);
            this.lstVw.Name = "lstVw";
            this.lstVw.Size = new System.Drawing.Size(294, 214);
            this.lstVw.TabIndex = 34;
            this.lstVw.UseCompatibleStateImageBehavior = false;
            this.lstVw.View = System.Windows.Forms.View.Details;
            // 
            // clmCatID
            // 
            this.clmCatID.Text = "Category ID";
            // 
            // clmCatName
            // 
            this.clmCatName.Text = "Category Name";
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
            // frmStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1098, 557);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.dgvOne);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lstVw);
            this.Controls.Add(this.txbxModuleCode);
            this.Controls.Add(this.txbxAddress);
            this.Controls.Add(this.txbxPhone);
            this.Controls.Add(this.txbxNumber);
            this.Controls.Add(this.txbxNameSurname);
            this.Controls.Add(this.lblModuleCodes);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.lblDOB);
            this.Controls.Add(this.lblImage);
            this.Controls.Add(this.lblNameAndSurname);
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
        private System.Windows.Forms.TextBox txbxModuleCode;
        private System.Windows.Forms.TextBox txbxAddress;
        private System.Windows.Forms.TextBox txbxPhone;
        private System.Windows.Forms.TextBox txbxNumber;
        private System.Windows.Forms.TextBox txbxNameSurname;
        private System.Windows.Forms.Label lblModuleCodes;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.Label lblImage;
        private System.Windows.Forms.Label lblNameAndSurname;
        private System.Windows.Forms.Label lblStudentNmbr;
        private System.Windows.Forms.ListView lstVw;
        private System.Windows.Forms.ColumnHeader clmCatID;
        private System.Windows.Forms.ColumnHeader clmCatName;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGridView dgvOne;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Label lblHeader;
    }
}