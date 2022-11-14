namespace Group_Project_PRG2782
{
    partial class Update_Modules
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
            this.tbxModuleResource = new System.Windows.Forms.TextBox();
            this.tbxModuleDesc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxModuleName = new System.Windows.Forms.TextBox();
            this.tbxModuleCode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnMain = new System.Windows.Forms.Button();
            this.btnUpdateModule = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModuleDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvModuleDetails
            // 
            this.dgvModuleDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvModuleDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvModuleDetails.Location = new System.Drawing.Point(353, 37);
            this.dgvModuleDetails.Name = "dgvModuleDetails";
            this.dgvModuleDetails.Size = new System.Drawing.Size(587, 257);
            this.dgvModuleDetails.TabIndex = 1;
            this.dgvModuleDetails.SelectionChanged += new System.EventHandler(this.dgvModuleDetails_SelectionChanged);
            // 
            // tbxModuleResource
            // 
            this.tbxModuleResource.Location = new System.Drawing.Point(164, 267);
            this.tbxModuleResource.Name = "tbxModuleResource";
            this.tbxModuleResource.Size = new System.Drawing.Size(140, 20);
            this.tbxModuleResource.TabIndex = 23;
            // 
            // tbxModuleDesc
            // 
            this.tbxModuleDesc.Location = new System.Drawing.Point(164, 176);
            this.tbxModuleDesc.Multiline = true;
            this.tbxModuleDesc.Name = "tbxModuleDesc";
            this.tbxModuleDesc.Size = new System.Drawing.Size(140, 60);
            this.tbxModuleDesc.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkOrange;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.label1.Location = new System.Drawing.Point(4, 247);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 40);
            this.label1.TabIndex = 21;
            this.label1.Text = "Resource Link:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkOrange;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.label4.Location = new System.Drawing.Point(4, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 31);
            this.label4.TabIndex = 20;
            this.label4.Text = "Description:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbxModuleName
            // 
            this.tbxModuleName.Location = new System.Drawing.Point(164, 122);
            this.tbxModuleName.Name = "tbxModuleName";
            this.tbxModuleName.Size = new System.Drawing.Size(140, 20);
            this.tbxModuleName.TabIndex = 19;
            // 
            // tbxModuleCode
            // 
            this.tbxModuleCode.Location = new System.Drawing.Point(164, 48);
            this.tbxModuleCode.Name = "tbxModuleCode";
            this.tbxModuleCode.Size = new System.Drawing.Size(140, 20);
            this.tbxModuleCode.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkOrange;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.label2.Location = new System.Drawing.Point(4, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 28);
            this.label2.TabIndex = 17;
            this.label2.Text = "Module Name:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkOrange;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.label3.Location = new System.Drawing.Point(4, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 31);
            this.label3.TabIndex = 16;
            this.label3.Text = "Module Code:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnMain
            // 
            this.btnMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMain.Location = new System.Drawing.Point(311, 329);
            this.btnMain.Name = "btnMain";
            this.btnMain.Size = new System.Drawing.Size(144, 77);
            this.btnMain.TabIndex = 25;
            this.btnMain.Text = "Back To Main Menu";
            this.btnMain.UseVisualStyleBackColor = true;
            this.btnMain.Click += new System.EventHandler(this.btnMain_Click);
            // 
            // btnUpdateModule
            // 
            this.btnUpdateModule.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateModule.Location = new System.Drawing.Point(30, 329);
            this.btnUpdateModule.Name = "btnUpdateModule";
            this.btnUpdateModule.Size = new System.Drawing.Size(144, 77);
            this.btnUpdateModule.TabIndex = 24;
            this.btnUpdateModule.Text = "Update Module";
            this.btnUpdateModule.UseVisualStyleBackColor = true;
            this.btnUpdateModule.Click += new System.EventHandler(this.btnUpdateModule_Click);
            // 
            // Update_Modules
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.ClientSize = new System.Drawing.Size(952, 450);
            this.Controls.Add(this.btnMain);
            this.Controls.Add(this.btnUpdateModule);
            this.Controls.Add(this.tbxModuleResource);
            this.Controls.Add(this.tbxModuleDesc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbxModuleName);
            this.Controls.Add(this.tbxModuleCode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvModuleDetails);
            this.Name = "Update_Modules";
            this.Text = "Update Modules";
            this.Load += new System.EventHandler(this.Update_Modules_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvModuleDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvModuleDetails;
        private System.Windows.Forms.TextBox tbxModuleResource;
        private System.Windows.Forms.TextBox tbxModuleDesc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxModuleName;
        private System.Windows.Forms.TextBox tbxModuleCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnMain;
        private System.Windows.Forms.Button btnUpdateModule;
    }
}