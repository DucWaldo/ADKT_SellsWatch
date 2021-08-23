using ADKT_SellsWatch.Forms_Code.Form_OtherManager;
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
    public partial class frmOtherManager : Form
    {
        cOtherManager cOtherManagers = new cOtherManager();
        public frmOtherManager()
        {
            InitializeComponent();
        }

        private void frmOtherManager_Load(object sender, EventArgs e)
        {
            cOtherManagers.OtherManager_Load(dgvBrand);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            cOtherManagers.Update_Click(dgvBrand, txtBrandID, txtBrandName, rtbInfo);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            cOtherManagers.Delete_Click(dgvBrand, txtBrandID);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            cOtherManagers.Reset_Click(txtBrandID, txtBrandName, rtbInfo);
        }

        private void dgvBrand_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cOtherManagers.Brand_CellClick(e.RowIndex, e.ColumnIndex, dgvBrand, txtBrandID, txtBrandName, rtbInfo);
        }
    }
}
