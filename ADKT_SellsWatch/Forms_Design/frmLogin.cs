using ADKT_SellsWatch.Form_For_Manager;
using ADKT_SellsWatch.Forms_Code.Form_Login;
using ADKT_SellsWatch.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADKT_SellsWatch.Forms_Design
{
    public partial class frmLogin : Form
    {
        cLogin cLogins = new cLogin();
        acLogin acLogins = new acLogin();

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            frmMain frmM = new frmMain(acLogins.user(txtUsername, txtPassword));
            frmMainManager frmMM = new frmMainManager();
            cLogins.Login_Click(this, frmM, frmMM, txtUsername, txtPassword, errUS, errPW);
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            cLogins.Username_TextChanged(txtUsername, errUS);
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            cLogins.Password_TextChanged(txtPassword, errPW);
        }

        private void cbbShowPass_CheckedChanged(object sender, EventArgs e)
        {
            cLogins.ShowPass_CheckedChanged(txtPassword, chbShowPass);
        }
    }
}
