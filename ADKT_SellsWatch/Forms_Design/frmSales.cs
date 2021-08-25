using ADKT_SellsWatch.Forms_Code.Form_Sales;
using ADKT_SellsWatch.Models;
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
            btnPay.Enabled = false;
        }

        private void btnCheckWatch_Click(object sender, EventArgs e)
        {
            cSaless.CheckWatch_Click(txtWatchID);
        }

        private void btnCheckCustomer_Click(object sender, EventArgs e)
        {
            cSaless.CheckCustomer_Click(txtCustomerID, btnPay);
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
            nudNumOfItem.Value = 0;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            cSaless.Add_Click(dgvDetails, txtWatchID, nudNumOfItem, txtTotalPrice);
            nudNumOfItem.Value = 0;
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
            cSaless.Pay_Click(txtTotalPrice, txtCustomerID, dgvReceipt, cbbWatch, dgvDetails);
            dgvDetails.Rows.Clear();
            txtCustomerID.Text = txtTotalPrice.Text = txtWatchID.Text = cbbWatch.Text = string.Empty;
            nudNumOfItem.Value = 0;
        }

        private void txtCustomerID_TextChanged(object sender, EventArgs e)
        {
            if (txtCustomerID.Text == string.Empty)
            {
                btnPay.Enabled = false;
            }
        }

        private void dgvReceipt_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                string Link = dgvReceipt.Rows[e.RowIndex].Cells[0].Value.ToString();
                string ID = dgvReceipt.Rows[e.RowIndex].Cells[1].Value.ToString();
                string TPRICE = dgvReceipt.Rows[e.RowIndex].Cells[3].Value.ToString();
                frmReceipt_Details frm = new frmReceipt_Details(Link, ID, TPRICE);
                frm.Show();
            }
        }
    }
}
