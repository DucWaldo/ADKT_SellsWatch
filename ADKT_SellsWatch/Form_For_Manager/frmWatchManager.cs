using ADKT_SellsWatch.Forms_Code.Form_WatchManager;
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
    public partial class frmWatchManager : Form
    {
        cWatchManager cWatchManagers = new cWatchManager();
        public frmWatchManager()
        {
            InitializeComponent();
        }

        private void frmWatchManager_Load(object sender, EventArgs e)
        {
            cWatchManagers.WatchManager_Load(dgvWatch, cbbBrandName);
        }

        private void dgvWatch_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cWatchManagers.Watch_CellClick(e.RowIndex, e.ColumnIndex, dgvWatch, txtWatchID, txtWatchName, rbtMale, rbtFemale, txtGlass, txtWaterproof, txtStrap, txtPrice, cbbBrandName, nudNumOfItem);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            cWatchManagers.Update_Click(dgvWatch, txtWatchID, txtWatchName, rbtMale, rbtFemale, txtGlass, txtWaterproof, txtStrap, txtPrice, cbbBrandName, nudNumOfItem);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            cWatchManagers.Delete_Click(dgvWatch, txtWatchID);
        }
    }
}
