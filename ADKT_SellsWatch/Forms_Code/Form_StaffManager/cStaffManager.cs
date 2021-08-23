using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADKT_SellsWatch.Forms_Code.Form_StaffManager
{
    class cStaffManager
    {
        acStaffManager acStaffManagers = new acStaffManager();
        public void StaffManager_Load(DataGridView dgvStaff)
        {
            try
            {
                acStaffManagers.BindGrid(dgvStaff);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK);
            }
        }

        public void Update_Click(DataGridView dgvWatch, TextBox txtUserName, TextBox txtPassword, TextBox txtName, TextBox txtAddress, RadioButton rbtMale, DateTimePicker dtpBirthDay, DateTimePicker dtpWorkDay, TextBox txtPhone, TextBox txtSalary, RadioButton rbtStill)
        {
            try
            {
                if (MessageBox.Show("Bạn có muốn cập nhật nhân viên này không", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    acStaffManagers.Update(txtUserName, txtPassword, txtName, txtAddress, rbtMale, dtpBirthDay, dtpWorkDay, txtPhone, txtSalary, rbtStill);
                    acStaffManagers.BindGrid(dgvWatch);
                    throw new Exception("Đã cập nhật thành công");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK);
            }
        }

        public void Delete_Click(TextBox txtUserName, DataGridView dgvWatch)
        {
            try
            {
                if (MessageBox.Show("Bạn có muốn xoá không!", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    acStaffManagers.Delete(txtUserName);
                    acStaffManagers.BindGrid(dgvWatch);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK);
            }
        }

        public void Search_TextChanged(string infoSearch, DataGridView dgvStaff)
        {
            acStaffManagers.Search(infoSearch, dgvStaff);
        }

        public void Staff_CellClick(int R, int C, DataGridView dgvStaff, TextBox txtUserName, TextBox txtPassword, TextBox txtName, TextBox txtAddress, RadioButton rbtMale, RadioButton rbtFemale, DateTimePicker dtpBirthDay, DateTimePicker dtpWorkDay, TextBox txtPhone, TextBox txtSalary, RadioButton rbtStill, RadioButton rbtRetired)
        {
            acStaffManagers.CellClick(R , C, dgvStaff, txtUserName, txtPassword, txtName, txtAddress, rbtMale, rbtFemale, dtpBirthDay, dtpWorkDay, txtPhone, txtSalary, rbtStill, rbtRetired);
        }

        public void Reset_Click(TextBox txtUserName, TextBox txtPassword, TextBox txtName, TextBox txtAddress, RadioButton rbtMale, RadioButton rbtFemale, DateTimePicker dtpBirthDay, DateTimePicker dtpWorkDay, TextBox txtPhone, TextBox txtSalary, RadioButton rbtStill, RadioButton rbtRetired)
        {
            acStaffManagers.Reset(txtUserName, txtPassword, txtName, txtAddress, rbtMale, rbtFemale, dtpBirthDay, dtpWorkDay, txtPhone, txtSalary, rbtStill, rbtRetired);
        }
    }
}
