using ADKT_SellsWatch.Analysis;
using ADKT_SellsWatch.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADKT_SellsWatch.Forms_Code.Form_Login
{
    class acLogin
    {
        ADKTContextDB _dbContext = new ADKTContextDB();

        private List<Staff> loginList()
        {
            using (ADKTContextDB _dbContext = new ADKTContextDB())
            {
                return _dbContext.Staffs.ToList();
            }
        }

        public Staff user(TextBox US, TextBox PW)
        {
            string temp = EncryptAndDecrypt.EncryptData(PW.Text);
            return _dbContext.Staffs.Where(p => p.UserName == US.Text && p.Password == temp && p.Status == true).FirstOrDefault();
        }
        public void CheckLogin(TextBox US, TextBox PW, ErrorProvider errUS, ErrorProvider errPW)
        {
            if (US.Text == "" || PW.Text == "")
            {
                errUS.SetError(US, "Chưa nhập tài khoản!");
                errPW.SetError(PW, "Chưa nhập mật khẩu!");
                throw new Exception("Vui lòng nhập đầy đủ!");
            }
            if (user(US, PW) == null)
            {
                throw new Exception("Tài khoản hoặc mật khẩu không đúng");
            }
        }

        public bool accountAdmin(TextBox US, TextBox PW)
        {
            string temp = EncryptAndDecrypt.EncryptData(PW.Text);
            if (US.Text == "Admin@manager.com" && temp == "0brPmd1avIEUMF/1we1mrQ==")
            {
                return true;
            }
            return false;
        }
    }
}
