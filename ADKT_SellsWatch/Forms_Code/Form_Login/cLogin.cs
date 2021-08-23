using ADKT_SellsWatch.Forms_Design;
using ADKT_SellsWatch.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADKT_SellsWatch.Forms_Code.Form_Login
{
    class cLogin
    {
        acLogin acLogins = new acLogin();
        public void Login_Click(Form A, Form B, Form C, TextBox US, TextBox PW, ErrorProvider errUS, ErrorProvider errPW)
        {
            try
            {
                if (acLogins.accountAdmin(US, PW) == true)
                {
                    //A.Hide();
                    C.Show();
                    A.Show();
                }
                else
                {
                    acLogins.CheckLogin(US, PW, errUS, errPW);
                    //A.Hide();
                    B.Show();
                    A.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK);
            }
        }

        public void Username_TextChanged(TextBox US, ErrorProvider ERROR)
        {
            try
            {
                if (US.Text == string.Empty)
                {
                    ERROR.SetError(US, "Chưa nhập tài khoản!");
                    return;
                }
                else
                {
                    ERROR.Clear();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Password_TextChanged(TextBox PW, ErrorProvider ERROR)
        {
            try
            {
                if (PW.Text == string.Empty)
                {
                    ERROR.SetError(PW, "Chưa nhập mật khẩu!");
                    return;
                }
                else
                {
                    ERROR.Clear();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void ShowPass_CheckedChanged(TextBox PW, CheckBox CBB)
        {
            if (CBB.Checked == true)
            {
                PW.UseSystemPasswordChar = false;
            }
            else
            {
                PW.UseSystemPasswordChar = true;
            }
        }
    }
}
