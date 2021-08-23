using ADKT_SellsWatch.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADKT_SellsWatch.Forms_Code.Form_WatchManager
{
    class cWatchManager
    {
        acWatchManager acWatchManagers = new acWatchManager();
        public void WatchManager_Load(DataGridView dgvWatch, ComboBox cbbBrand)
        {
            try
            {
                acWatchManagers.BindGrid(dgvWatch);
                acWatchManagers.FillBrandCombobox(cbbBrand);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK);
            }
        }

        public void Watch_CellClick(int R, int C, DataGridView dgvWatch, TextBox txtWatchID, TextBox txtWatchName, RadioButton rbtMale, RadioButton rbtFemale, TextBox txtGlass, TextBox txtWaterproof, TextBox txtStrap, TextBox txtPrice, ComboBox cbbBrandName, NumericUpDown nudNumOfItem)
        {
            try
            {
                acWatchManagers.CellLick(R, C, dgvWatch, txtWatchID, txtWatchName, rbtMale, rbtFemale, txtGlass, txtWaterproof, txtStrap, txtPrice, cbbBrandName, nudNumOfItem);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK);
            }
        }

        public void Update_Click(DataGridView dgvWatch, TextBox txtWatchID, TextBox txtWatchName, RadioButton rbtMale, RadioButton rbtFemale, TextBox txtGlass, TextBox txtWaterproof, TextBox txtStrap, TextBox txtPrice, ComboBox cbbBrandName, NumericUpDown nudNumOfItem, Panel pnlInput)
        {
            try
            {
                if (MessageBox.Show("Bạn có muốn cập nhật đồng hồ này không", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    acWatchManagers.Update(txtWatchID, txtWatchName, rbtMale, rbtFemale, txtGlass, txtWaterproof, txtStrap, txtPrice, cbbBrandName, nudNumOfItem, pnlInput);
                    acWatchManagers.BindGrid(dgvWatch);
                    throw new Exception("Cập nhật thành công!");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK);
            }
        }

        public void Delete_Click(DataGridView dgvWatch, TextBox txtWatchID)
        {
            try
            {
                if (MessageBox.Show("Bạn có muốn xoá đồng hồ này không", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    acWatchManagers.Delete(txtWatchID);
                    acWatchManagers.BindGrid(dgvWatch);
                    throw new Exception("Đã xoá thành công!");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK);
            }
        }

        public void Search_TextChanged(string infoSearch, DataGridView dgvWatch)
        {
            acWatchManagers.Search(infoSearch, dgvWatch);
        }

        public void Reset_Click(DataGridView dgvWatch, ComboBox cbbBrand, TextBox txtWatchID, TextBox txtWatchName, RadioButton rbtMale, RadioButton rbtFemale, TextBox txtGlass, TextBox txtWaterproof, TextBox txtStrap, TextBox txtPrice, NumericUpDown nudNumOfItem, TextBox txtSearch)
        {
            acWatchManagers.Reset(txtWatchID, txtWatchName, rbtMale, rbtFemale, txtGlass, txtWaterproof, txtStrap, txtPrice, nudNumOfItem, txtSearch);
            WatchManager_Load(dgvWatch, cbbBrand);
        }
    }
}
