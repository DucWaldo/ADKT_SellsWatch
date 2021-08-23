using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADKT_SellsWatch.Forms_Code.Form_CustomerManager
{
    class cCustomerManager
    {
        acCustomerManager acCustomerManagers = new acCustomerManager();

        public void CustomerManager_Load(DataGridView dgvMembership)
        {
            try
            {
                acCustomerManagers.BindGrid(dgvMembership);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK);
            }
        }

        public void Update_Click(DataGridView dgvMembership, TextBox txtCustomerID, TextBox txtCustomerName, DateTimePicker dtpBirthDay, RadioButton rbnMale, DateTimePicker dtpCardDay, TextBox txtPhone)
        {
            try
            {
                acCustomerManagers.Update(txtCustomerID, txtCustomerName, dtpBirthDay, rbnMale, dtpCardDay, txtPhone);
                acCustomerManagers.BindGrid(dgvMembership);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK);
            }
        }

        public void Delete_Click(DataGridView dgvMembership, TextBox txtCustomerID)
        {
            try
            {
                acCustomerManagers.Delete(txtCustomerID);
                acCustomerManagers.BindGrid(dgvMembership);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK);
            }
        }

        public void Membership_CellClick(int R, int C, DataGridView dgvMembership, TextBox txtCustomerID, TextBox txtCustomerName, DateTimePicker dtpBirthDay, RadioButton rbnMale, RadioButton rbnFemale, DateTimePicker dtpCardDay, TextBox txtPhone, TextBox txtRank)
        {
            try
            {
                acCustomerManagers.CellClick(R, C, dgvMembership, txtCustomerID, txtCustomerName, dtpBirthDay, rbnMale, rbnFemale, dtpCardDay, txtPhone, txtRank);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK);
            }
        }

        public void Search_TextChanged(string infoSearch, DataGridView dgvMembership)
        {
            if (infoSearch != string.Empty)
            {
                acCustomerManagers.Search(infoSearch, dgvMembership);
            }
            else
            {
                acCustomerManagers.BindGrid(dgvMembership);
            }
        }
        
        public void Reset_Click(TextBox txtCustomerID, TextBox txtCustomerName, DateTimePicker dtpBirthDay, RadioButton rbnMale, RadioButton rbnFemale, DateTimePicker dtpCardDay, TextBox txtPhone, TextBox txtSearch)
        {
            acCustomerManagers.Reset(txtCustomerID, txtCustomerName, dtpBirthDay, rbnMale, rbnFemale, dtpCardDay, txtPhone, txtSearch);
        }

        public void _ValueChanged(DateTimePicker dtpA, DateTimePicker dtpB)
        {
            try
            {
                acCustomerManagers.CheckDateTime(dtpA, dtpB);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK);
            }
        }
    }
}
