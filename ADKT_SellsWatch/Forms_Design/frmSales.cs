using ADKT_SellsWatch.Forms_Code.Form_Sales;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADKT_SellsWatch.Forms_Design
{
    public partial class frmSales : Form
    {
        cSales cSaless = new cSales();
        public frmSales()
        {
            InitializeComponent();
        }

        private void frmSales_Load(object sender, EventArgs e)
        {
            cSaless.Sales_Load(dgvReceipt, cbbWatch);
            cbbWatch.Text = string.Empty;
        }

        private void btnCheckWatch_Click(object sender, EventArgs e)
        {
            cSaless.CheckWatch_Click(txtWatchID);
        }

        private void btnCheckCustomer_Click(object sender, EventArgs e)
        {
            cSaless.CheckCustomer_Click(txtCustomerID);
        }

        private void nudNumOfItem_ValueChanged(object sender, EventArgs e)
        {
            cSaless.NumOfItem_ValueChanged(txtWatchID, nudNumOfItem);
        }

        private void txtWatchID_TextChanged(object sender, EventArgs e)
        {
            nudNumOfItem.Enabled = true;
        }

        private void cbbWatch_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtWatchID.Text = cbbWatch.Text;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            cSaless.Add_Click(dgvDetails, txtWatchID, nudNumOfItem, txtTotalPrice);
        }

        private void dgvDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cSaless.Details_CellClick(e.RowIndex);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            cSaless.Delete_Click(dgvDetails, txtTotalPrice);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            cSaless.Reset_Click(dgvDetails, txtWatchID, nudNumOfItem, txtTotalPrice, cbbWatch, txtCustomerID);
        }

        private void btnPay_Click(object sender, EventArgs e)
        {

        }
    }
}
