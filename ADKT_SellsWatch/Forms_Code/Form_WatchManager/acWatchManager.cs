using ADKT_SellsWatch.Form_For_Manager;
using ADKT_SellsWatch.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity.Migrations;

namespace ADKT_SellsWatch.Forms_Code.Form_WatchManager
{
    class acWatchManager
    {
        bool rbtGender;
        ADKTContextDB _dbContext = new ADKTContextDB();

        private Watch watch(TextBox txtWatchID, TextBox txtWatchName, RadioButton rbtMale, RadioButton rbtFemale, TextBox txtGlass, TextBox txtWaterproof, TextBox txtStrap, TextBox txtPrice, ComboBox cbbBrandName, NumericUpDown nudNumOfItem)
        {
            if (rbtMale.Checked == true)
            {
                rbtGender = false;
            }
            else
            {
                rbtGender = true;
            }
            return new Watch()
            {
                WatchID = txtWatchID.Text,
                WatchName = txtWatchName.Text,
                Gender = rbtGender,
                Glass = txtGlass.Text,
                Waterproof = txtWaterproof.Text,
                Strap = txtStrap.Text,
                Price = int.Parse(txtPrice.Text),
                BrandID = int.Parse(cbbBrandName.SelectedValue.ToString()),
                NumOfItem = int.Parse(nudNumOfItem.Value.ToString())
            };
        }
        public void FillBrandCombobox(ComboBox cbbBrand)
        {
            List<Brand> listBrand = _dbContext.Brands.ToList();
            cbbBrand.DataSource = listBrand;
            cbbBrand.DisplayMember = "BrandName";
            cbbBrand.ValueMember = "BrandID";
        }

        public void BindGrid(DataGridView dgvWatch)
        {
            List<Watch> listWatch = _dbContext.Watches.ToList();
            AddBindGrid(listWatch, dgvWatch);
        }

        private void AddBindGrid(List<Watch> listWatch, DataGridView dgvWatch)
        {
            dgvWatch.Rows.Clear();
            foreach (var item in listWatch)
            {
                int index = dgvWatch.Rows.Add();
                dgvWatch.Rows[index].Cells[0].Value = item.WatchID;
                dgvWatch.Rows[index].Cells[1].Value = item.WatchName;
                if (item.Gender == false)
                {
                    dgvWatch.Rows[index].Cells[2].Value = "Nam";
                }
                else
                {
                    dgvWatch.Rows[index].Cells[2].Value = "Nữ";
                }
                dgvWatch.Rows[index].Cells[3].Value = item.Glass;
                dgvWatch.Rows[index].Cells[4].Value = item.Waterproof;
                dgvWatch.Rows[index].Cells[5].Value = item.Strap;
                dgvWatch.Rows[index].Cells[6].Value = item.Price;
                dgvWatch.Rows[index].Cells[7].Value = item.Brand.BrandName;
                dgvWatch.Rows[index].Cells[8].Value = item.NumOfItem;
            }
        }

        public void CellLick(int R, int C, DataGridView dgvWatch, TextBox txtWatchID, TextBox txtWatchName, RadioButton rbtMale, RadioButton rbtFemale, TextBox txtGlass, TextBox txtWaterproof, TextBox txtStrap, TextBox txtPrice, ComboBox cbbBrandName, NumericUpDown nudNumOfItem)
        {
            if (R > -1 && C > -1)
            {
                if (dgvWatch.Rows[R].Cells[C].Value != null)
                {
                    dgvWatch.CurrentRow.Selected = true;
                    txtWatchID.Text = dgvWatch.Rows[R].Cells["clnWatchID"].FormattedValue.ToString();
                    txtWatchName.Text = dgvWatch.Rows[R].Cells["clnWatchName"].FormattedValue.ToString();
                    if (dgvWatch.Rows[R].Cells["clnGender"].FormattedValue.ToString() == "Nam")
                    {
                        rbtMale.Checked = true;
                    }
                    else
                    {
                        rbtFemale.Checked = true;
                    }
                    txtGlass.Text = dgvWatch.Rows[R].Cells["clnGlass"].FormattedValue.ToString();
                    txtWaterproof.Text = dgvWatch.Rows[R].Cells["clnWaterproof"].FormattedValue.ToString();
                    txtStrap.Text = dgvWatch.Rows[R].Cells["clnStrap"].FormattedValue.ToString();
                    txtPrice.Text = dgvWatch.Rows[R].Cells["clnPrice"].FormattedValue.ToString();
                    cbbBrandName.Text = dgvWatch.Rows[R].Cells["clnBrand"].FormattedValue.ToString();
                    nudNumOfItem.Value = int.Parse(dgvWatch.Rows[R].Cells["clnNumberOfItem"].FormattedValue.ToString());
                }
            }
        }

        public void Update(TextBox txtWatchID, TextBox txtWatchName, RadioButton rbtMale, RadioButton rbtFemale, TextBox txtGlass, TextBox txtWaterproof, TextBox txtStrap, TextBox txtPrice, ComboBox cbbBrandName, NumericUpDown nudNumOfItem, Panel pnlInput)
        {
            Check(txtWatchID, txtPrice);
            _dbContext.Watches.AddOrUpdate(watch(txtWatchID, txtWatchName, rbtMale, rbtFemale, txtGlass, txtWaterproof, txtStrap, txtPrice, cbbBrandName, nudNumOfItem));
            _dbContext.SaveChanges();
        }

        public void Delete(TextBox txtWatchID)
        {
            Watch watch = _dbContext.Watches.FirstOrDefault(w => w.WatchID == txtWatchID.Text);

            if (watch != null)
            {
                _dbContext.Watches.Remove(watch);
                _dbContext.SaveChanges();
            }
            else
            {
                throw new Exception("Không tìm thấy đồng hồ này!");
            }
        }

        public void Search(string infoSearch, DataGridView dgvWatch)
        {
            List<Watch> searchList = _dbContext.Watches.Where(p => p.WatchID.Contains(infoSearch) == true || p.Brand.BrandName.Contains(infoSearch) == true).ToList();

            if (searchList != null)
            {
                AddBindGrid(searchList, dgvWatch);
            }
        }

        public void Reset(TextBox txtWatchID, TextBox txtWatchName, RadioButton rbtMale, RadioButton rbtFemale, TextBox txtGlass, TextBox txtWaterproof, TextBox txtStrap, TextBox txtPrice, NumericUpDown nudNumOfItem, TextBox txtSearch)
        {
            txtWatchID.Text = txtWatchName.Text = txtGlass.Text = txtWaterproof.Text = txtStrap.Text = txtPrice.Text = txtSearch.Text = string.Empty;
            rbtFemale.Checked = rbtMale.Checked = false;
            nudNumOfItem.Value = 0;
        }
    
        private void Check(TextBox txtWatchID, TextBox txtPrice)
        {
            if (txtWatchID.Text == string.Empty)
            {
                throw new Exception("Vui lòng nhập mã sản phẩm");
            }
            if (txtPrice.Text == string.Empty)
            {
                throw new Exception("Vui lòng nhập giá sản phẩm");
            }
        }
    
    }
}
