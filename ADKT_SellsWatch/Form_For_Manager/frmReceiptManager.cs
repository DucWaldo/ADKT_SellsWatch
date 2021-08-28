using ADKT_SellsWatch.Forms_Code.Form_Receipt;
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
    public partial class frmReceiptManager : Form
    {
        cReceipt cReceipts = new cReceipt();
        public frmReceiptManager()
        {
            InitializeComponent();
        }

        private void frmReceiptManager_Load(object sender, EventArgs e)
        {
            dtpBegin.Enabled = dtpEnd.Enabled = false;
            dtpBegin.Value = DateTime.Now.AddDays(-1);
            cReceipts.ReceiptManager_Load(dgvUp);
        }

        private void dgvUp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cReceipts.Up_CellClick(e.RowIndex, e.ColumnIndex, dgvUp, dgvDown);
        }

        private void dtpChange(object sender, EventArgs e)
        {
            cReceipts.dtpChange(dtpBegin, dtpEnd, dgvUp);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            dtpBegin.Value = DateTime.Now.AddDays(-1);
            dtpEnd.Value = DateTime.Now;
            chbTime.Checked = false;
            dgvDown.Rows.Clear();
            frmReceiptManager_Load(sender, e);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text != string.Empty)
            {
                cReceipts.Search_TextChanged(txtSearch, dgvUp);
            }
            else
            {
                frmReceiptManager_Load(sender, e);
                dgvDown.Rows.Clear();
            }
        }

        private void chbTime_CheckedChanged(object sender, EventArgs e)
        {
            if (chbTime.Checked == true)
            {
                dtpBegin.Enabled = dtpEnd.Enabled = true;
            }
            else
            {
                dtpBegin.Enabled = dtpEnd.Enabled = false;
                btnReset_Click(sender, e);
            }
        }
    }
}
