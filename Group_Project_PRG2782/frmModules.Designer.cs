namespace Group_Project_PRG2782
{
    partial class frmModules
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
            this.dgvModules = new System.Windows.Forms.DataGridView();
            this.txbxCode = new System.Windows.Forms.TextBox();
            this.txbxName = new System.Windows.Forms.TextBox();
            this.rtxDescription = new System.Windows.Forms.RichTextBox();
            this.rtbResources = new System.Windows.Forms.RichTextBox();
            this.lblCode = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblResources = new System.Windows.Forms.Label();
            this.btnDeleteCoure = new System.Windows.Forms.Button();
            this.btnUpdateCourse = new System.Windows.Forms.Button();
            this.btnAddCourse = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.lblSearch = new System.Windows.Forms.Label();
            this.tbxSearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModules)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvModules
            // 
            this.dgvModules.BackgroundColor = System.Drawing.SystemColors.WindowFrame;
            this.dgvModules.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvModules.Location = new System.Drawing.Point(120, 93);
            this.dgvModules.Name = "dgvModules";
            this.dgvModules.Size = new System.Drawing.Size(518, 381);
            this.dgvModules.TabIndex = 0;
            this.dgvModules.SelectionChanged += new System.EventHandler(this.dgvModules_SelectionChanged);
            // 
            // txbxCode
            // 
            this.txbxCode.Location = new System.Drawing.Point(734, 104);
            this.txbxCode.Name = "txbxCode";
            this.txbxCode.Size = new System.Drawing.Size(217, 20);
            this.txbxCode.TabIndex = 1;
            // 
            // txbxName
            // 
            this.txbxName.Location = new System.Drawing.Point(734, 161);
            this.txbxName.Name = "txbxName";
            this.txbxName.Size = new System.Drawing.Size(217, 20);
            this.txbxName.TabIndex = 2;
            // 
            // rtxDescription
            // 
            this.rtxDescription.Location = new System.Drawing.Point(734, 226);
            this.rtxDescription.Name = "rtxDescription";
            this.rtxDescription.Size = new System.Drawing.Size(217, 80);
            this.rtxDescription.TabIndex = 3;
            this.rtxDescription.Text = "";
            this.rtxDescription.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // rtbResources
            // 
            this.rtbResources.Location = new System.Drawing.Point(734, 342);
            this.rtbResources.Name = "rtbResources";
            this.rtbResources.Size = new System.Drawing.Size(217, 80);
            this.rtbResources.TabIndex = 4;
            this.rtbResources.Text = "";
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.BackColor = System.Drawing.Color.Red;
            this.lblCode.ForeColor = System.Drawing.Color.White;
            this.lblCode.Location = new System.Drawing.Point(648, 107);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(70, 13);
            this.lblCode.TabIndex = 5;
            this.lblCode.Text = "Module Code";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Red;
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(648, 168);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(73, 13);
            this.lblName.TabIndex = 6;
            this.lblName.Text = "Module Name";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.BackColor = System.Drawing.Color.Red;
            this.lblDescription.ForeColor = System.Drawing.Color.White;
            this.lblDescription.Location = new System.Drawing.Point(648, 229);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(60, 13);
            this.lblDescription.TabIndex = 7;
            this.lblDescription.Text = "Description";
            // 
            // lblResources
            // 
            this.lblResources.AutoSize = true;
            this.lblResources.BackColor = System.Drawing.Color.Red;
            this.lblResources.ForeColor = System.Drawing.Color.White;
            this.lblResources.Location = new System.Drawing.Point(648, 342);
            this.lblResources.Name = "lblResources";
            this.lblResources.Size = new System.Drawing.Size(58, 13);
            this.lblResources.TabIndex = 8;
            this.lblResources.Text = "Resources";
            this.lblResources.Click += new System.EventHandler(this.label4_Click);
            // 
            // btnDeleteCoure
            // 
            this.btnDeleteCoure.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDeleteCoure.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteCoure.ForeColor = System.Drawing.Color.Yellow;
            this.btnDeleteCoure.Location = new System.Drawing.Point(26, 187);
            this.btnDeleteCoure.Name = "btnDeleteCoure";
            this.btnDeleteCoure.Size = new System.Drawing.Size(75, 41);
            this.btnDeleteCoure.TabIndex = 40;
            this.btnDeleteCoure.Text = "Delete Course";
            this.btnDeleteCoure.UseVisualStyleBackColor = false;
            this.btnDeleteCoure.Click += new System.EventHandler(this.btnDeleteCoure_Click);
            // 
            // btnUpdateCourse
            // 
            this.btnUpdateCourse.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnUpdateCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateCourse.ForeColor = System.Drawing.Color.Yellow;
            this.btnUpdateCourse.Location = new System.Drawing.Point(26, 140);
            this.btnUpdateCourse.Name = "btnUpdateCourse";
            this.btnUpdateCourse.Size = new System.Drawing.Size(75, 41);
            this.btnUpdateCourse.TabIndex = 39;
            this.btnUpdateCourse.Text = "Update Course";
            this.btnUpdateCourse.UseVisualStyleBackColor = false;
            this.btnUpdateCourse.Click += new System.EventHandler(this.btnUpdateCourse_Click);
            // 
            // btnAddCourse
            // 
            this.btnAddCourse.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAddCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCourse.ForeColor = System.Drawing.Color.Yellow;
            this.btnAddCourse.Location = new System.Drawing.Point(26, 93);
            this.btnAddCourse.Name = "btnAddCourse";
            this.btnAddCourse.Size = new System.Drawing.Size(75, 41);
            this.btnAddCourse.TabIndex = 38;
            this.btnAddCourse.Text = "Add new Course";
            this.btnAddCourse.UseVisualStyleBackColor = false;
            this.btnAddCourse.Click += new System.EventHandler(this.btnAddCourse_Click);
            // 
            // btnView
            // 
            this.btnView.BackColor = System.Drawing.Color.Black;
            this.btnView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnView.ForeColor = System.Drawing.Color.White;
            this.btnView.Location = new System.Drawing.Point(522, 41);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(116, 46);
            this.btnView.TabIndex = 37;
            this.btnView.Text = "Search";
            this.btnView.UseVisualStyleBackColor = false;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.BackColor = System.Drawing.Color.Red;
            this.lblSearch.ForeColor = System.Drawing.Color.White;
            this.lblSearch.Location = new System.Drawing.Point(288, 31);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(107, 13);
            this.lblSearch.TabIndex = 44;
            this.lblSearch.Text = "Search Module Code";
            // 
            // tbxSearch
            // 
            this.tbxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxSearch.Location = new System.Drawing.Point(120, 47);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(396, 29);
            this.tbxSearch.TabIndex = 43;
            // 
            // frmModules
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Group_Project_PRG2782.Properties.Resources.patternpad;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1005, 498);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.tbxSearch);
            this.Controls.Add(this.btnDeleteCoure);
            this.Controls.Add(this.btnUpdateCourse);
            this.Controls.Add(this.btnAddCourse);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.lblResources);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblCode);
            this.Controls.Add(this.rtbResources);
            this.Controls.Add(this.rtxDescription);
            this.Controls.Add(this.txbxName);
            this.Controls.Add(this.txbxCode);
            this.Controls.Add(this.dgvModules);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmModules";
            this.Text = "frmModules";
            this.Load += new System.EventHandler(this.frmModules_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvModules)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvModules;
        private System.Windows.Forms.TextBox txbxCode;
        private System.Windows.Forms.TextBox txbxName;
        private System.Windows.Forms.RichTextBox rtxDescription;
        private System.Windows.Forms.RichTextBox rtbResources;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblResources;
        private System.Windows.Forms.Button btnDeleteCoure;
        private System.Windows.Forms.Button btnUpdateCourse;
        private System.Windows.Forms.Button btnAddCourse;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox tbxSearch;
    }
}