﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PoePart1
{
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();
        }

        private void MainMenuForm_Load(object sender, EventArgs e)
        {
            
        }

        private void btnOpenReportIssuesForm_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            ReportIssuesForm reportIssuesForm = new ReportIssuesForm(this);
            reportIssuesForm.Show();
        }
    }
}
