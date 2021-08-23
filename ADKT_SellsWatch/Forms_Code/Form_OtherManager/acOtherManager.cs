using ADKT_SellsWatch.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADKT_SellsWatch.Forms_Code.Form_OtherManager
{
    class acOtherManager
    {
        ADKTContextDB _dbContext = new ADKTContextDB();

        private Brand brand(TextBox txtBrandID, TextBox txtBrandName, RichTextBox rtbInfo)
        {
            return new Brand()
            {
                BrandID = int.Parse(txtBrandID.Text),
                BrandName = txtBrandName.Text,
                Info = rtbInfo.Text
            };
        }

        private void AddBrindView(List<Brand> brands, DataGridView dgvBrand)
        {
            dgvBrand.Rows.Clear();
            foreach (var item in brands)
            {
                int index = dgvBrand.Rows.Add();
                dgvBrand.Rows[index].Cells[0].Value = item.BrandID;
                dgvBrand.Rows[index].Cells[1].Value = item.BrandName;
                dgvBrand.Rows[index].Cells[2].Value = item.Info;
            }
        }

        public void BrindView(DataGridView dgvBrand)
        {
            List<Brand> brands = _dbContext.Brands.ToList();
            if (brands != null)
            {
                AddBrindView(brands, dgvBrand);
            }
        }

        public void Update(TextBox txtBrandID, TextBox txtBrandName, RichTextBox rtbInfo)
        {
            Check(txtBrandID);
            if (MessageBox.Show("Bạn có muốn cập nhật nhãn hiệu này?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                _dbContext.Brands.AddOrUpdate(brand(txtBrandID, txtBrandName, rtbInfo));
                _dbContext.SaveChanges();
            }
        }

        public void Delete(TextBox txtBrandID)
        {
            Brand brands = _dbContext.Brands.FirstOrDefault(p => p.BrandID == int.Parse(txtBrandID.Text));
            Check(txtBrandID);
            if (MessageBox.Show("Bạn có muốn xoá nhãn hàng này?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (brands != null)
                {
                    _dbContext.Brands.Remove(brands);
                    _dbContext.SaveChanges();
                }
            }
            else
            {
                throw new Exception("Hệ thống bị lỗi!");
            }
        }

        public void Check(TextBox txtBrandID)
        {
            if (txtBrandID.Text == string.Empty)
            {
                throw new Exception("Vui lòng nhập mã nhãn hiệu");
            }
        }

        public void CellClick(int R, int C, DataGridView dgvBrand, TextBox txtBrandID, TextBox txtBrandName, RichTextBox rtbInfo)
        {
            if (R > -1 && C > -1)
            {
                if (dgvBrand.Rows[R].Cells[C].Value != null)
                {
                    dgvBrand.CurrentRow.Selected = true;
                    txtBrandID.Text = dgvBrand.Rows[R].Cells["clnBrandID"].FormattedValue.ToString();
                    txtBrandName.Text = dgvBrand.Rows[R].Cells["clnBrandName"].FormattedValue.ToString();
                    rtbInfo.Text = dgvBrand.Rows[R].Cells["clnInfo"].FormattedValue.ToString();
                }
            }
        }

        public void Reset(TextBox txtBrandID, TextBox txtBrandName, RichTextBox rtbInfo)
        {
            txtBrandID.Text = txtBrandName.Text = rtbInfo.Text = string.Empty;
        }
    }
}
