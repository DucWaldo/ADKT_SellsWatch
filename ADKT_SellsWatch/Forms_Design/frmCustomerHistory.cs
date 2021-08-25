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
    public partial class frmCustomerHistory : Form
    {
        string IDHis;
        string NAMEHis;
        ADKTContextDB _dbContext = new ADKTContextDB();


        public frmCustomerHistory()
        {
            InitializeComponent();
        }

        public frmCustomerHistory(string ID, string NAME)
        {
            InitializeComponent();
            this.IDHis = ID;
            this.NAMEHis = NAME;
        }

        private void frmCustomerHistory_Load(object sender, EventArgs e)
        {
            List<Receipt_Details> receipts = _dbContext.Receipt_Details.Where(p => p.Receipt.CustomerID == IDHis).ToList();

            lblID.Text = IDHis.ToString();
            lblName.Text = NAMEHis.ToString();
            dgvHistory.Rows.Clear();
            foreach (var item in receipts)
            {
                int index = dgvHistory.Rows.Add();
                dgvHistory.Rows[index].Cells[0].Value = item.WatchID;
                dgvHistory.Rows[index].Cells[1].Value = item.Receipt.Date;
                dgvHistory.Rows[index].Cells[2].Value = item.numOfWatch;
                dgvHistory.Rows[index].Cells[3].Value = item.Watch.Price * item.numOfWatch;
            }
        }

        private void dtpBuyDay(object sender, EventArgs e)
        {
            List<Receipt_Details> receipts = _dbContext.Receipt_Details.Where(p => p.Receipt.CustomerID == IDHis && p.Receipt.Date >= dtpBegin.Value && p.Receipt.Date < dtpEnd.Value).ToList();

            dgvHistory.Rows.Clear();
            foreach (var item in receipts)
            {
                int index = dgvHistory.Rows.Add();
                dgvHistory.Rows[index].Cells[0].Value = item.WatchID;
                dgvHistory.Rows[index].Cells[1].Value = item.Receipt.Date;
                dgvHistory.Rows[index].Cells[2].Value = item.numOfWatch;
                dgvHistory.Rows[index].Cells[3].Value = item.Watch.Price * item.numOfWatch;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            dtpBegin.Value = dtpEnd.Value = DateTime.Now;
            frmCustomerHistory_Load(sender, e);
        }
    }
}
