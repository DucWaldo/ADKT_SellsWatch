using ADKT_SellsWatch.Forms_Code.Form_CustomerManager;
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
    public partial class frmCustomerManager : Form
    {
        cCustomerManager cCustomerManagers = new cCustomerManager();
        public frmCustomerManager()
        {
            InitializeComponent();
        }

        private void frmCustomerManager_Load(object sender, EventArgs e)
        {
            cCustomerManagers.CustomerManager_Load(dgvMembership);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            cCustomerManagers.Update_Click(dgvMembership, txtCustomerID, txtCustomerName, dtpBirthDay, rbnMale, dtpCardDay, txtPhone);
            frmCustomerManager_Load(sender, e);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            cCustomerManagers.Delete_Click(dgvMembership, txtCustomerID);
        }

        private void dgvMembership_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cCustomerManagers.Membership_CellClick(e.RowIndex, e.ColumnIndex, dgvMembership, txtCustomerID, txtCustomerName, dtpBirthDay, rbnMale, rbnFemale, dtpCardDay, txtPhone, txtRank);
        }


        private void btnSearch_TextChanged(object sender, EventArgs e)
        {
            cCustomerManagers.Search_TextChanged(txtSearch.Text, dgvMembership);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            cCustomerManagers.Reset_Click(txtCustomerID, txtCustomerName, dtpBirthDay, rbnMale, rbnFemale, dtpCardDay, txtPhone, txtSearch);
        }

        private void dtp_ValueChanged(object sender, EventArgs e)
        {
            cCustomerManagers._ValueChanged(dtpBirthDay, dtpCardDay);
        }
    }
}
