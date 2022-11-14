namespace Group_Project_PRG2782
{
    partial class Delete_Module
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
            this.btnMain = new System.Windows.Forms.Button();
            this.btnDeleteModule = new System.Windows.Forms.Button();
            this.tbxModuleCode = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvModuleDetails = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModuleDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMain
            // 
            this.btnMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMain.Location = new System.Drawing.Point(816, 189);
            this.btnMain.Name = "btnMain";
            this.btnMain.Size = new System.Drawing.Size(144, 77);
            this.btnMain.TabIndex = 36;
            this.btnMain.Text = "Back To Main Menu";
            this.btnMain.UseVisualStyleBackColor = true;
            this.btnMain.Click += new System.EventHandler(this.btnMain_Click);
            // 
            // btnDeleteModule
            // 
            this.btnDeleteModule.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteModule.Location = new System.Drawing.Point(613, 189);
            this.btnDeleteModule.Name = "btnDeleteModule";
            this.btnDeleteModule.Size = new System.Drawing.Size(144, 77);
            this.btnDeleteModule.TabIndex = 35;
            this.btnDeleteModule.Text = "Delete Module";
            this.btnDeleteModule.UseVisualStyleBackColor = true;
            this.btnDeleteModule.Click += new System.EventHandler(this.btnDeleteModule_Click);
            // 
            // tbxModuleCode
            // 
            this.tbxModuleCode.Location = new System.Drawing.Point(734, 71);
            this.tbxModuleCode.Name = "tbxModuleCode";
            this.tbxModuleCode.Size = new System.Drawing.Size(140, 20);
            this.tbxModuleCode.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkOrange;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.label3.Location = new System.Drawing.Point(609, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 31);
            this.label3.TabIndex = 27;
            this.label3.Text = "Module Code:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dgvModuleDetails
            // 
            this.dgvModuleDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvModuleDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvModuleDetails.Location = new System.Drawing.Point(12, 65);
            this.dgvModuleDetails.Name = "dgvModuleDetails";
            this.dgvModuleDetails.Size = new System.Drawing.Size(587, 257);
            this.dgvModuleDetails.TabIndex = 26;
            this.dgvModuleDetails.SelectionChanged += new System.EventHandler(this.dgvModuleDetails_SelectionChanged);
            // 
            // Delete_Module
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SaddleBrown;
            this.ClientSize = new System.Drawing.Size(972, 339);
            this.Controls.Add(this.btnMain);
            this.Controls.Add(this.btnDeleteModule);
            this.Controls.Add(this.tbxModuleCode);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvModuleDetails);
            this.Name = "Delete_Module";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Delete Module";
            this.Load += new System.EventHandler(this.Delete_Module_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvModuleDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMain;
        private System.Windows.Forms.Button btnDeleteModule;
        private System.Windows.Forms.TextBox tbxModuleCode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvModuleDetails;
    }
}