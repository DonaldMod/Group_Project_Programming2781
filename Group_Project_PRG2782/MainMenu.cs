﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group_Project_PRG2782
{
    public partial class MainMenu : Form
    {
        DataHandler dB = new DataHandler();
        frmStudents students= new frmStudents();
        frmModules modules= new frmModules();
        public MainMenu()
        {
            InitializeComponent();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            dB.TestConnection();
        }

        private void btnStudents_Click(object sender, EventArgs e)
        {
            students.ShowDialog();
            
        }

        private void btnModules_Click(object sender, EventArgs e)
        {
            modules.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
