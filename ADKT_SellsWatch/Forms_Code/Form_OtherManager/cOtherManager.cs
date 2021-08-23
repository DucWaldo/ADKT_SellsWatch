using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADKT_SellsWatch.Forms_Code.Form_OtherManager
{
    class cOtherManager
    {
        acOtherManager acOtherManagers = new acOtherManager();

        public void OtherManager_Load(DataGridView dgvBrand)
        {
            acOtherManagers.BrindView(dgvBrand);
        }

        public void Update_Click(DataGridView dgvBrand, TextBox txtBrandID, TextBox txtBrandName, RichTextBox rtbInfo)
        {
            try
            {
                acOtherManagers.Update(txtBrandID, txtBrandName, rtbInfo);
                acOtherManagers.BrindView(dgvBrand);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK);
            }

        }

        public void Delete_Click(DataGridView dgvBrand, TextBox txtBrandID)
        {
            try
            {
                acOtherManagers.Delete(txtBrandID);
                acOtherManagers.BrindView(dgvBrand);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK);
            }
        }

        public void Brand_CellClick(int R, int C, DataGridView dgvBrand, TextBox txtBrandID, TextBox txtBrandName, RichTextBox rtbInfo)
        {
            acOtherManagers.CellClick(R, C, dgvBrand, txtBrandID, txtBrandName, rtbInfo);
        }

        public void Reset_Click(TextBox txtBrandID, TextBox txtBrandName, RichTextBox rtbInfo)
        {
            acOtherManagers.Reset(txtBrandID, txtBrandName, rtbInfo);
        }
    }
}
