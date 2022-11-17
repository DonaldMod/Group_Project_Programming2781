namespace Group_Project_PRG2782
{
    partial class MainMenu
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
            this.btnStudents = new System.Windows.Forms.Button();
            this.btnModules = new System.Windows.Forms.Button();
            this.btnTest = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.PanelOptyions = new System.Windows.Forms.Panel();
            this.PanelOptyions.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStudents
            // 
            this.btnStudents.BackColor = System.Drawing.Color.Black;
            this.btnStudents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStudents.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudents.ForeColor = System.Drawing.SystemColors.Window;
            this.btnStudents.Location = new System.Drawing.Point(-1, 149);
            this.btnStudents.Name = "btnStudents";
            this.btnStudents.Size = new System.Drawing.Size(180, 62);
            this.btnStudents.TabIndex = 0;
            this.btnStudents.Text = "Students Form";
            this.btnStudents.UseVisualStyleBackColor = false;
            this.btnStudents.Click += new System.EventHandler(this.btnStudents_Click);
            this.btnStudents.MouseLeave += new System.EventHandler(this.btnStudents_MouseLeave);
            this.btnStudents.MouseHover += new System.EventHandler(this.btnStudents_MouseHover);
            // 
            // btnModules
            // 
            this.btnModules.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnModules.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModules.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModules.ForeColor = System.Drawing.Color.MistyRose;
            this.btnModules.Location = new System.Drawing.Point(0, 206);
            this.btnModules.Name = "btnModules";
            this.btnModules.Size = new System.Drawing.Size(180, 63);
            this.btnModules.TabIndex = 1;
            this.btnModules.Text = "Modules Form";
            this.btnModules.UseVisualStyleBackColor = false;
            this.btnModules.Click += new System.EventHandler(this.btnModules_Click);
            this.btnModules.MouseLeave += new System.EventHandler(this.btnModules_MouseLeave);
            this.btnModules.MouseHover += new System.EventHandler(this.btnModules_MouseHover);
            // 
            // btnTest
            // 
            this.btnTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTest.ForeColor = System.Drawing.SystemColors.Window;
            this.btnTest.Location = new System.Drawing.Point(-1, 452);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(180, 48);
            this.btnTest.TabIndex = 4;
            this.btnTest.Text = "Test Connection";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // btnExit
            // 
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Red;
            this.btnExit.Location = new System.Drawing.Point(0, 506);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(180, 41);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // PanelOptyions
            // 
            this.PanelOptyions.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PanelOptyions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelOptyions.Controls.Add(this.btnStudents);
            this.PanelOptyions.Controls.Add(this.btnTest);
            this.PanelOptyions.Controls.Add(this.btnExit);
            this.PanelOptyions.Controls.Add(this.btnModules);
            this.PanelOptyions.Location = new System.Drawing.Point(0, 1);
            this.PanelOptyions.Name = "PanelOptyions";
            this.PanelOptyions.Size = new System.Drawing.Size(180, 561);
            this.PanelOptyions.TabIndex = 6;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::Group_Project_PRG2782.Properties.Resources.Back;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1261, 560);
            this.Controls.Add(this.PanelOptyions);
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.PanelOptyions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStudents;
        private System.Windows.Forms.Button btnModules;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel PanelOptyions;
    }
}