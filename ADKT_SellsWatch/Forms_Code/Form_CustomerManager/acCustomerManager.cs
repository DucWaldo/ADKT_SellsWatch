using ADKT_SellsWatch.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADKT_SellsWatch.Forms_Code.Form_CustomerManager
{
    class acCustomerManager
    {
        bool rbtGender;
        int firstRank = 0;

        ADKTContextDB _dbContext = new ADKTContextDB();
        private Membership membership(TextBox txtCustomerID, TextBox txtCustomerName, DateTimePicker dtpBirthDay, RadioButton rbnMale, DateTimePicker dtpCardDay, TextBox txtPhone)
        {
            if (rbnMale.Checked == true)
            {
                rbtGender = false;
            }
            else
            {
                rbtGender = true;
            }

            return new Membership()
            {
                CustomerID = txtCustomerID.Text,
                CustomerName = txtCustomerName.Text,
                BirthDay = dtpBirthDay.Value,
                Genner = rbtGender,
                CardDay = dtpCardDay.Value,
                Phone = int.Parse(txtPhone.Text),
                RankID = firstRank
            };
        }

        public void BindGrid(DataGridView dgvMembership)
        {
            List<Membership> listMembership = _dbContext.Memberships.ToList();
            AddBindGrid(listMembership, dgvMembership);
        }

        private void AddBindGrid(List<Membership> listtemp, DataGridView dgvMembership)
        {
            dgvMembership.Rows.Clear();
            foreach (var item in listtemp)
            {
                int index = dgvMembership.Rows.Add();
                dgvMembership.Rows[index].Cells[0].Value = item.CustomerID;
                dgvMembership.Rows[index].Cells[1].Value = item.CustomerName;
                dgvMembership.Rows[index].Cells[2].Value = item.BirthDay.Value.ToString("dd/MM/yyyy");
                if (item.Genner == true)
                {
                    dgvMembership.Rows[index].Cells[3].Value = "Nữ";
                }
                else
                {
                    dgvMembership.Rows[index].Cells[3].Value = "Nam";
                }
                dgvMembership.Rows[index].Cells[4].Value = item.CardDay.Value.ToString("dd/MM/yyyy");
                dgvMembership.Rows[index].Cells[5].Value = item.Phone;
                dgvMembership.Rows[index].Cells[6].Value = item.Rank.RankName;
            }
        }

        public void Update(TextBox txtCustomerID, TextBox txtCustomerName, DateTimePicker dtpBirthDay, RadioButton rbnMale, DateTimePicker dtpCardDay, TextBox txtPhone)
        {
            Check(txtCustomerID);
            if (MessageBox.Show("Bạn có muốn cập nhật khách hàng?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                _dbContext.Memberships.AddOrUpdate(membership(txtCustomerID, txtCustomerName, dtpBirthDay, rbnMale, dtpCardDay, txtPhone));
                _dbContext.SaveChanges();
            }
        }

        public void Delete(TextBox txtCustomerID)
        {
            Membership membership = _dbContext.Memberships.FirstOrDefault(s => s.CustomerID == txtCustomerID.Text);
            if (txtCustomerID.Text != string.Empty)
            {
                if (membership != null)
                {
                    if (MessageBox.Show("Bạn có muốn xoá khách hàng này!", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        _dbContext.Memberships.Remove(membership);
                        _dbContext.SaveChanges();
                    }
                }
                else
                {
                    throw new Exception("Không tìm thấy tài khoản này!");
                }
            }
            else
            {
                throw new Exception("Vui lòng CMND/ CCCD của khách hàng cần xoá!");
            }
        }

        public void Search(string infoSearch, DataGridView dgvMembership)
        {
            List<Membership> searchList = _dbContext.Memberships.Where(p => p.CustomerID.Contains(infoSearch) == true || p.CustomerName.Contains(infoSearch) == true).ToList();

            if (searchList.Count > -1)
            {
                AddBindGrid(searchList, dgvMembership);
            }
        }

        public void CellClick(int R, int C, DataGridView dgvMembership, TextBox txtCustomerID, TextBox txtCustomerName, DateTimePicker dtpBirthDay, RadioButton rbnMale, RadioButton rbnFemale, DateTimePicker dtpCardDay, TextBox txtPhone, TextBox txtRank)
        {
            if (R > -1 && C > -1)
            {
                if (dgvMembership.Rows[R].Cells[C].Value != null)
                {
                    dgvMembership.CurrentRow.Selected = true;
                    txtCustomerID.Text = dgvMembership.Rows[R].Cells["clnCustomerID"].FormattedValue.ToString();
                    txtCustomerName.Text = dgvMembership.Rows[R].Cells["clnCustomerName"].FormattedValue.ToString();
                    dtpBirthDay.Value = DateTime.Parse(dgvMembership.Rows[R].Cells["clnBirthDay"].FormattedValue.ToString());
                    if (dgvMembership.Rows[R].Cells["clnGenner"].FormattedValue.ToString() == "Nam")
                    {
                        rbnMale.Checked = true;
                    }
                    else
                    {
                        rbnFemale.Checked = true;
                    }
                    dtpCardDay.Value = DateTime.Parse(dgvMembership.Rows[R].Cells["clnCardDay"].FormattedValue.ToString());
                    txtPhone.Text = dgvMembership.Rows[R].Cells["clnPhone"].FormattedValue.ToString();
                    txtRank.Text = dgvMembership.Rows[R].Cells["clnRankName"].FormattedValue.ToString();
                }
            }
        }

        private void Check(TextBox txtCustomerID)
        {
            if (txtCustomerID.Text == string.Empty)
            {
                throw new Exception("Vui lòng nhập CMND/ CCCD");
            }
        }

        public void Reset(TextBox txtCustomerID, TextBox txtCustomerName, DateTimePicker dtpBirthDay, RadioButton rbnMale, RadioButton rbnFemale, DateTimePicker dtpCardDay, TextBox txtPhone, TextBox txtSearch)
        {
            txtCustomerID.Text = txtCustomerName.Text = txtPhone.Text = txtSearch.Text = string.Empty;
            dtpBirthDay.Value = dtpCardDay.Value = DateTime.Now;
            rbnMale.Checked = rbnFemale.Checked = false;
        }

        public void CheckDateTime(DateTimePicker dtpA, DateTimePicker dtpB)
        {
            if (dtpA.Value > DateTime.Now)
            {
                dtpA.Value = DateTime.Now;
                throw new Exception("Ngày sinh không được quá ngày hiện tại");
            }

            if (dtpB.Value < dtpA.Value.AddDays(-1))
            {
                dtpB.Value = DateTime.Now;
                throw new Exception("Ngày làm thẻ không được trước ngày sinh!");
            }

        }


    }
}
