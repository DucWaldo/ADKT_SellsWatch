using ADKT_SellsWatch.Forms_Code.Form_StaffManager;
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
    public partial class frmStaffManager : Form
    {
        cStaffManager cStaffManagers = new cStaffManager();

        public frmStaffManager()
        {
            InitializeComponent();
        }

        private void frmStaffManager_Load(object sender, EventArgs e)
        {
            cStaffManagers.StaffManager_Load(dgvStaff);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            cStaffManagers.Update_Click(dgvStaff, txtUserName, txtPassword, txtName, txtAddress, rbtMale, dtpBirthDay, dtpWorkDay, txtPhone, txtSalary, rbtStill);
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            cStaffManagers.Delete_Click(txtUserName, dgvStaff);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            cStaffManagers.Search_TextChanged(txtSearch.Text, dgvStaff);
        }

        private void dgvStaff_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cStaffManagers.Staff_CellClick(e.RowIndex, e.ColumnIndex, dgvStaff, txtUserName, txtPassword, txtName, txtAddress, rbtMale, rbtFemale, dtpBirthDay, dtpWorkDay, txtPhone, txtSalary, rbtStill, rbtRetired);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            cStaffManagers.Reset_Click(txtUserName, txtPassword, txtName, txtAddress, rbtMale, rbtFemale, dtpBirthDay, dtpWorkDay, txtPhone, txtSalary, rbtStill, rbtRetired);
        }
    }
}
