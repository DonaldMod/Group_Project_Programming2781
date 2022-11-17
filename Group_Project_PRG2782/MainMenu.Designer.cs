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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.btnStudents = new System.Windows.Forms.Button();
            this.btnModules = new System.Windows.Forms.Button();
            this.btnTest = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.PanelOptyions = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PanelFrms = new System.Windows.Forms.Panel();
            this.PanelOptyions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.btnModules.Location = new System.Drawing.Point(-1, 229);
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
            this.btnTest.MouseLeave += new System.EventHandler(this.btnTest_MouseLeave);
            this.btnTest.MouseHover += new System.EventHandler(this.btnTest_MouseHover);
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
            this.btnExit.MouseLeave += new System.EventHandler(this.btnExit_MouseLeave);
            this.btnExit.MouseHover += new System.EventHandler(this.btnExit_MouseHover);
            // 
            // PanelOptyions
            // 
            this.PanelOptyions.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PanelOptyions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelOptyions.Controls.Add(this.pictureBox1);
            this.PanelOptyions.Controls.Add(this.btnStudents);
            this.PanelOptyions.Controls.Add(this.btnTest);
            this.PanelOptyions.Controls.Add(this.btnExit);
            this.PanelOptyions.Controls.Add(this.btnModules);
            this.PanelOptyions.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelOptyions.Location = new System.Drawing.Point(0, 0);
            this.PanelOptyions.Name = "PanelOptyions";
            this.PanelOptyions.Size = new System.Drawing.Size(180, 592);
            this.PanelOptyions.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Group_Project_PRG2782.Properties.Resources.BC_Logo_5;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(0, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(179, 153);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // PanelFrms
            // 
            this.PanelFrms.BackgroundImage = global::Group_Project_PRG2782.Properties.Resources.Back;
            this.PanelFrms.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PanelFrms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelFrms.Location = new System.Drawing.Point(180, 0);
            this.PanelFrms.Name = "PanelFrms";
            this.PanelFrms.Size = new System.Drawing.Size(1111, 592);
            this.PanelFrms.TabIndex = 7;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1291, 592);
            this.ControlBox = false;
            this.Controls.Add(this.PanelFrms);
            this.Controls.Add(this.PanelOptyions);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainMenu";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "MainMenu";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.PanelOptyions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStudents;
        private System.Windows.Forms.Button btnModules;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel PanelOptyions;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel PanelFrms;
    }
}