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
    public partial class frmReceipt_Details : Form
    {
        int Link;
        String ID;
        String TPRICE;
        ADKTContextDB _dbContext = new ADKTContextDB();
        public frmReceipt_Details()
        {
            InitializeComponent();
        }

        public frmReceipt_Details(string link, string id, string tprice)
        {
            InitializeComponent();
            this.Link = int.Parse(link);
            this.ID = id;
            this.TPRICE = tprice;
        }

        private void frmReceipt_Details_Load(object sender, EventArgs e)
        {
            Membership memberships = _dbContext.Memberships.FirstOrDefault(p => p.CustomerID == ID);
            List<Receipt_Details> list = _dbContext.Receipt_Details.Where(p => p.ReceiptID == Link).ToList();

            lblID.Text = memberships.CustomerID;
            lblName.Text = memberships.CustomerName;

            if (list != null)
            {
                dgvReceipt_Details.Rows.Clear();
                foreach (var item in list)
                {
                    int index = dgvReceipt_Details.Rows.Add();
                    dgvReceipt_Details.Rows[index].Cells[0].Value = item.WatchID;
                    dgvReceipt_Details.Rows[index].Cells[1].Value = item.numOfWatch;
                    dgvReceipt_Details.Rows[index].Cells[2].Value = item.Watch.Price;
                }
                lblTotalPrice.Text = TPRICE;
            }
        }
    }
}
