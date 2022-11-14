namespace Group_Project_PRG2782
{
    partial class Read_Modules
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
            this.dgvModuleDetails = new System.Windows.Forms.DataGridView();
            this.btnMain = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModuleDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvModuleDetails
            // 
            this.dgvModuleDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvModuleDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvModuleDetails.Location = new System.Drawing.Point(33, 26);
            this.dgvModuleDetails.Name = "dgvModuleDetails";
            this.dgvModuleDetails.Size = new System.Drawing.Size(587, 257);
            this.dgvModuleDetails.TabIndex = 0;
            // 
            // btnMain
            // 
            this.btnMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMain.Location = new System.Drawing.Point(244, 320);
            this.btnMain.Name = "btnMain";
            this.btnMain.Size = new System.Drawing.Size(144, 77);
            this.btnMain.TabIndex = 20;
            this.btnMain.Text = "Back To Main Menu";
            this.btnMain.UseVisualStyleBackColor = true;
            this.btnMain.Click += new System.EventHandler(this.btnMain_Click);
            // 
            // Read_Modules
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(650, 412);
            this.Controls.Add(this.btnMain);
            this.Controls.Add(this.dgvModuleDetails);
            this.Name = "Read_Modules";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Read_Modules";
            this.Load += new System.EventHandler(this.Read_Modules_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvModuleDetails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvModuleDetails;
        private System.Windows.Forms.Button btnMain;
    }
}