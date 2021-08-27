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
    public partial class frmAddMembership : Form
    {
        bool Gen;
        string id;
        public frmAddMembership()
        {
            InitializeComponent();
        }

        public frmAddMembership(string ID)
        {
            InitializeComponent();
            this.id = ID;
        }

        ADKTContextDB _dbContext = new ADKTContextDB();

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (rbnMale.Checked == true)
            {
                Gen = false;
            }
            if (MessageBox.Show("Bạn có muốn thêm khách hàng mới?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Membership membership = new Membership()
                {
                    CustomerID = txtCustomerID.Text,
                    CustomerName = txtCustomerName.Text,
                    BirthDay = dtpBirthDay.Value,
                    Genner = Gen,
                    CardDay = DateTime.Now,
                    Phone = int.Parse(txtPhone.Text),
                    RankID = 0
                };

                _dbContext.Memberships.Add(membership);
                _dbContext.SaveChanges();
            }

            MessageBox.Show("Đã thêm thành công!", "Thông báo", MessageBoxButtons.OK);
            this.Close();
        }

        private void frmAddMembership_Load(object sender, EventArgs e)
        {
            txtCustomerID.Text = id;
        }
    }
}
