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
            this.btnCreateNewModule = new System.Windows.Forms.Button();
            this.btnReadModule = new System.Windows.Forms.Button();
            this.btnUpdateModule = new System.Windows.Forms.Button();
            this.btnDeleteModules = new System.Windows.Forms.Button();
            this.btnTest = new System.Windows.Forms.Button();
            this.btnSearchModule = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCreateNewModule
            // 
            this.btnCreateNewModule.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateNewModule.Location = new System.Drawing.Point(71, 25);
            this.btnCreateNewModule.Name = "btnCreateNewModule";
            this.btnCreateNewModule.Size = new System.Drawing.Size(144, 77);
            this.btnCreateNewModule.TabIndex = 0;
            this.btnCreateNewModule.Text = "Create New Module";
            this.btnCreateNewModule.UseVisualStyleBackColor = true;
            this.btnCreateNewModule.Click += new System.EventHandler(this.btnCreateNewModule_Click);
            // 
            // btnReadModule
            // 
            this.btnReadModule.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReadModule.Location = new System.Drawing.Point(257, 25);
            this.btnReadModule.Name = "btnReadModule";
            this.btnReadModule.Size = new System.Drawing.Size(144, 77);
            this.btnReadModule.TabIndex = 1;
            this.btnReadModule.Text = "Read Module";
            this.btnReadModule.UseVisualStyleBackColor = true;
            this.btnReadModule.Click += new System.EventHandler(this.btnReadModule_Click);
            // 
            // btnUpdateModule
            // 
            this.btnUpdateModule.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateModule.Location = new System.Drawing.Point(433, 25);
            this.btnUpdateModule.Name = "btnUpdateModule";
            this.btnUpdateModule.Size = new System.Drawing.Size(144, 77);
            this.btnUpdateModule.TabIndex = 2;
            this.btnUpdateModule.Text = "Update Module";
            this.btnUpdateModule.UseVisualStyleBackColor = true;
            this.btnUpdateModule.Click += new System.EventHandler(this.btnUpdateModule_Click);
            // 
            // btnDeleteModules
            // 
            this.btnDeleteModules.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteModules.Location = new System.Drawing.Point(603, 25);
            this.btnDeleteModules.Name = "btnDeleteModules";
            this.btnDeleteModules.Size = new System.Drawing.Size(144, 77);
            this.btnDeleteModules.TabIndex = 3;
            this.btnDeleteModules.Text = "Delete Module";
            this.btnDeleteModules.UseVisualStyleBackColor = true;
            this.btnDeleteModules.Click += new System.EventHandler(this.btnDeleteModules_Click);
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(665, 373);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(114, 31);
            this.btnTest.TabIndex = 4;
            this.btnTest.Text = "Test Connection";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // btnSearchModule
            // 
            this.btnSearchModule.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchModule.Location = new System.Drawing.Point(332, 125);
            this.btnSearchModule.Name = "btnSearchModule";
            this.btnSearchModule.Size = new System.Drawing.Size(144, 77);
            this.btnSearchModule.TabIndex = 5;
            this.btnSearchModule.Text = "Search For Module";
            this.btnSearchModule.UseVisualStyleBackColor = true;
            this.btnSearchModule.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.DarkRed;
            this.btnLogout.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLogout.Location = new System.Drawing.Point(12, 387);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(144, 51);
            this.btnLogout.TabIndex = 6;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnSearchModule);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.btnDeleteModules);
            this.Controls.Add(this.btnUpdateModule);
            this.Controls.Add(this.btnReadModule);
            this.Controls.Add(this.btnCreateNewModule);
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCreateNewModule;
        private System.Windows.Forms.Button btnReadModule;
        private System.Windows.Forms.Button btnUpdateModule;
        private System.Windows.Forms.Button btnDeleteModules;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Button btnSearchModule;
        private System.Windows.Forms.Button btnLogout;
    }
}