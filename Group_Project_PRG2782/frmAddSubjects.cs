﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group_Project_PRG2782
{
    public partial class frmAddSubjects : Form
    {
        AddModulesCRUD modulesCRUD = new AddModulesCRUD();
        frmStudents students =  new frmStudents();
        public List<string> Modules = new List<string>();
        public frmAddSubjects()
        {
            InitializeComponent();
        }

        private void frmAddSubjects_Load(object sender, EventArgs e)
        {
            modulesCRUD.SelectModule();
            dgvSubjects.DataSource = modulesCRUD.bs;
        }

        private void dgvSubjects_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DbDataRecord record = modulesCRUD.bs.Current as DbDataRecord;
                if (record != null)
                {
                    lbxModules.Items.Add(record[0].ToString());
                }
            }
            catch (Exception t)
            {
                MessageBox.Show(t.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                SelectedModules();
                this.Close();
            }
            catch (Exception t)
            {

                throw;
            }
        }
        public void SelectedModules()
        {
            foreach (var item in lbxModules.Items)
            {
                Modules.Add(item.ToString());
            }
           
        }
    }
}
