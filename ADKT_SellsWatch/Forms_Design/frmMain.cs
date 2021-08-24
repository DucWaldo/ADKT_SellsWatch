using ADKT_SellsWatch.ColorChange;
using ADKT_SellsWatch.Form_For_Manager;
using ADKT_SellsWatch.Forms_Code.Form_CustomerManager;
using ADKT_SellsWatch.Forms_Code.Form_Main;
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
    public partial class frmMain : Form
    {
        ChangeColor CC = new ChangeColor();
        Staff userReceive;

        public frmMain()
        {
            InitializeComponent();
        }

        public frmMain(Staff userReceive)
        {
            InitializeComponent();
            this.userReceive = userReceive;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            CC.OpenChildForm(new frmSales(), pnlContent, pnlLeft, btnSales);
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            CC.OpenChildForm(new frmCustomerManager(), pnlContent, pnlLeft, btnCustomer);
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            this.Text = "Hello: " + userReceive.UserName.ToString();
            lblHello.Text = userReceive.Name.ToString();
        }
    }
}
