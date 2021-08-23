using ADKT_SellsWatch.Analysis;
using ADKT_SellsWatch.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADKT_SellsWatch.Forms_Code.Form_StaffManager
{
    class acStaffManager
    {
        bool rbtGender;
        bool rbtStatus;
        ADKTContextDB _dbContext = new ADKTContextDB();

        private Staff staff(TextBox txtUserName, TextBox txtPassword, TextBox txtName, TextBox txtAddress, RadioButton rbtMale, DateTimePicker dtpBirthDay, DateTimePicker dtpWorkDay, TextBox txtPhone, TextBox txtSalary, RadioButton rbtStill)
        {
            if (rbtMale.Checked == true)
            {
                rbtGender = false;
            }
            else
            {
                rbtGender = true;
            }
            if (rbtStill.Checked == true)
            {
                rbtStatus = true;
            }
            else
            {
                rbtStatus = false;
            }
            return new Staff()
            {
                UserName = txtUserName.Text,
                Password = EncryptAndDecrypt.EncryptData(txtPassword.Text),
                Name = txtName.Text,
                Address = txtAddress.Text,
                Gender = rbtGender,
                BirthDay = dtpBirthDay.Value,
                WorkDay = dtpWorkDay.Value,
                Phone = txtPhone.Text,
                Salary = int.Parse(txtSalary.Text),
                Status = rbtStatus
            };
        }

        public void BindGrid(DataGridView dgvWatch)
        {
            List<Staff> listWatch = _dbContext.Staffs.ToList();
            AddBindGrid(dgvWatch, listWatch);
        }

        private void AddBindGrid(DataGridView dgvWatch, List<Staff> listWatch)
        {
            dgvWatch.Rows.Clear();
            foreach (var item in listWatch)
            {
                int index = dgvWatch.Rows.Add();
                dgvWatch.Rows[index].Cells[0].Value = item.UserName;
                dgvWatch.Rows[index].Cells[1].Value = item.Password;
                dgvWatch.Rows[index].Cells[2].Value = item.Name;
                dgvWatch.Rows[index].Cells[3].Value = item.Address;
                if (item.Gender == true)
                {
                    dgvWatch.Rows[index].Cells[4].Value = "Nữ";
                }
                else
                {
                    dgvWatch.Rows[index].Cells[4].Value = "Nam";
                }
                dgvWatch.Rows[index].Cells[5].Value = item.BirthDay.Value.ToString("dd/MM/yyyy");
                dgvWatch.Rows[index].Cells[6].Value = item.WorkDay.Value.ToString("dd/MM/yyyy");
                dgvWatch.Rows[index].Cells[7].Value = item.Phone;
                dgvWatch.Rows[index].Cells[8].Value = item.Salary;
                if (item.Status == false)
                {
                    dgvWatch.Rows[index].Cells[9].Value = "Đã Nghỉ";
                }
                else
                {
                    dgvWatch.Rows[index].Cells[9].Value = "Còn Làm";
                }
            }
        }

        public void Update(TextBox txtUserName, TextBox txtPassword, TextBox txtName, TextBox txtAddress, RadioButton rbtMale, DateTimePicker dtpBirthDay, DateTimePicker dtpWorkDay, TextBox txtPhone, TextBox txtSalary, RadioButton rbtStill)
        {
            Check(txtUserName, txtPassword);
            _dbContext.Staffs.AddOrUpdate(staff(txtUserName, txtPassword, txtName, txtAddress, rbtMale, dtpBirthDay, dtpWorkDay, txtPhone, txtSalary, rbtStill));
            _dbContext.SaveChanges();
        }

        public void Delete(TextBox txtUserName)
        {
            Staff staff = _dbContext.Staffs.FirstOrDefault(s => s.UserName == txtUserName.Text);
            if (txtUserName.Text != string.Empty)
            {
                if (staff != null)
                {
                    _dbContext.Staffs.Remove(staff);
                    _dbContext.SaveChanges();
                }
                else
                {
                    throw new Exception("Không tìm thấy tài khoản này!");
                }
            }
            else
            {
                throw new Exception("Vui lòng nhập tài khoản cần xoá!");
            }
        }

        private void Check(TextBox txtUserName, TextBox txtPassword)
        {
            if (txtUserName.Text == string.Empty)
            {
                throw new Exception("Vui lòng nhập tài khoản nhân viên");
            }
            if (txtPassword.Text == string.Empty)
            {
                throw new Exception("Vui lòng nhập mật khẩu nhân viên");
            }
        }

        public void Search(string infoSearch, DataGridView dgvStaff)
        {
            List<Staff> searchList = _dbContext.Staffs.Where(p => p.Name.Contains(infoSearch) == true || p.UserName.Contains(infoSearch) == true).ToList();

            if (searchList != null)
            {
                AddBindGrid(dgvStaff, searchList);
            }
        }

        public void CellClick(int R, int C, DataGridView dgvStaff, TextBox txtUserName, TextBox txtPassword, TextBox txtName, TextBox txtAddress, RadioButton rbtMale, RadioButton rbtFemale, DateTimePicker dtpBirthDay, DateTimePicker dtpWorkDay, TextBox txtPhone, TextBox txtSalary, RadioButton rbtStill, RadioButton rbtRetired)
        {
            if (R > -1 && C > -1)
            {
                if (dgvStaff.Rows[R].Cells[C].Value != null)
                {
                    dgvStaff.CurrentRow.Selected = true;
                    txtUserName.Text = dgvStaff.Rows[R].Cells["clnUserName"].FormattedValue.ToString();
                    txtPassword.Text = EncryptAndDecrypt.DecryptString(dgvStaff.Rows[R].Cells["clnPassword"].FormattedValue.ToString());
                    txtName.Text = dgvStaff.Rows[R].Cells["clnName"].FormattedValue.ToString();
                    txtAddress.Text = dgvStaff.Rows[R].Cells["clnAddress"].FormattedValue.ToString();
                    if (dgvStaff.Rows[R].Cells["clnGender"].FormattedValue.ToString() == "Nam")
                    {
                        rbtMale.Checked = true;
                    }
                    else
                    {
                        rbtFemale.Checked = true;
                    }
                    dtpBirthDay.Value = DateTime.Parse(dgvStaff.Rows[R].Cells["clnBirthDay"].FormattedValue.ToString());
                    dtpWorkDay.Value = DateTime.Parse(dgvStaff.Rows[R].Cells["clnWorkDay"].FormattedValue.ToString());
                    txtPhone.Text = dgvStaff.Rows[R].Cells["clnPhone"].FormattedValue.ToString();
                    txtSalary.Text = dgvStaff.Rows[R].Cells["clnSalary"].FormattedValue.ToString();
                    if (dgvStaff.Rows[R].Cells["clnStatus"].FormattedValue.ToString() == "Còn Làm")
                    {
                        rbtStill.Checked = true;
                    }
                    else
                    {
                        rbtRetired.Checked = true;
                    }
                }
            }
        }

        public void Reset(TextBox txtUserName, TextBox txtPassword, TextBox txtName, TextBox txtAddress, RadioButton rbtMale, RadioButton rbtFemale, DateTimePicker dtpBirthDay, DateTimePicker dtpWorkDay, TextBox txtPhone, TextBox txtSalary, RadioButton rbtStill, RadioButton rbtRetired)
        {
            txtUserName.Text = txtPassword.Text = txtName.Text = txtAddress.Text = txtPhone.Text = txtSalary.Text = string.Empty;
            rbtFemale.Checked = rbtMale.Checked = rbtStill.Checked = rbtRetired.Checked = false;
            dtpBirthDay.Value = dtpWorkDay.Value = DateTime.Now;
        }

    }
}
