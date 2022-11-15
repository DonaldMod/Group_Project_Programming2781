namespace Group_Project_PRG2782
{
    partial class frmAddSubjects
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
            this.lbxModules = new System.Windows.Forms.ListBox();
            this.dgvSubjects = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblHead = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubjects)).BeginInit();
            this.SuspendLayout();
            // 
            // lbxModules
            // 
            this.lbxModules.FormattingEnabled = true;
            this.lbxModules.Location = new System.Drawing.Point(363, 53);
            this.lbxModules.Name = "lbxModules";
            this.lbxModules.Size = new System.Drawing.Size(171, 238);
            this.lbxModules.TabIndex = 0;
            // 
            // dgvSubjects
            // 
            this.dgvSubjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSubjects.Location = new System.Drawing.Point(12, 53);
            this.dgvSubjects.Name = "dgvSubjects";
            this.dgvSubjects.Size = new System.Drawing.Size(325, 232);
            this.dgvSubjects.TabIndex = 1;
            this.dgvSubjects.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSubjects_CellContentClick);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 291);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(101, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add Selected";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(136, 291);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(101, 23);
            this.btnRemove.TabIndex = 3;
            this.btnRemove.Text = "Remove Selected";
            this.btnRemove.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(12, 331);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(101, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // lblHead
            // 
            this.lblHead.AutoSize = true;
            this.lblHead.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHead.Location = new System.Drawing.Point(26, 13);
            this.lblHead.Name = "lblHead";
            this.lblHead.Size = new System.Drawing.Size(140, 24);
            this.lblHead.TabIndex = 5;
            this.lblHead.Text = "Select Modules";
            // 
            // frmAddSubjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 366);
            this.Controls.Add(this.lblHead);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvSubjects);
            this.Controls.Add(this.lbxModules);
            this.Name = "frmAddSubjects";
            this.Text = "frmAddSubjects";
            this.Load += new System.EventHandler(this.frmAddSubjects_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubjects)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxModules;
        private System.Windows.Forms.DataGridView dgvSubjects;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblHead;
    }
}