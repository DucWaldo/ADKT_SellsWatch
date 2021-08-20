﻿using ADKT_SellsWatch.ColorChange;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADKT_SellsWatch.Form_For_Manager
{
    public partial class frmMainManager : Form
    {
        ChangeColor CC = new ChangeColor();
        public frmMainManager()
        {
            InitializeComponent();
        }

        private void btnWatch_Click(object sender, EventArgs e)
        {
            CC.OpenChildForm(new frmWatchManager(), pnlContent, pnlLeft, btnWatch);
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            CC.OpenChildForm(new frmStaffManager(), pnlContent, pnlLeft, btnStaff);
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            CC.OpenChildForm(new frmCustomerManager(), pnlContent, pnlLeft, btnCustomer);
        }

        private void btnBrand_Click(object sender, EventArgs e)
        {
            CC.OpenChildForm(new frmBrandManager(), pnlContent, pnlLeft, btnBrand);
        }

        private void btnReceipt_Click(object sender, EventArgs e)
        {
            CC.OpenChildForm(new frmReceiptManager(), pnlContent, pnlLeft, btnReceipt);
        }

        private void btnRank_Click(object sender, EventArgs e)
        {
            CC.OpenChildForm(new frmRankManager(), pnlContent, pnlLeft, btnRank);
        }

        private void btnStatistical_Click(object sender, EventArgs e)
        {
            CC.OpenChildForm(new frmStaffManager(), pnlContent, pnlLeft, btnStaff);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
