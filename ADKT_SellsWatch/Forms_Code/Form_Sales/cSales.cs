using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADKT_SellsWatch.Forms_Code.Form_Sales
{
    class cSales
    {
        acSales acSaless = new acSales();
        public void Sales_Load(DataGridView dgvReceipt, ComboBox cbbWatch)
        {
            acSaless.BindGrid(dgvReceipt);
            acSaless.CBBWatch(cbbWatch);
            acSaless.updateRank();
        }

        public void CheckWatch_Click(TextBox txtWatchID)
        {
            try
            {
                acSaless.CheckWatch(txtWatchID);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK);
            }
        }

        public void CheckCustomer_Click(TextBox txtCustomerID, Button btnPay)
        {
            try
            {
                acSaless.CheckCustomer(txtCustomerID, btnPay);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK);
            }
        }

        public void NumOfItem_ValueChanged(TextBox txtWatchID, NumericUpDown nudNumOfItem)
        {
            try
            {
                acSaless.NumOfItem_ValueChanged(txtWatchID, nudNumOfItem);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK);
            }
        }

        public void Add_Click(DataGridView dgvDetails, TextBox txtWatchID, NumericUpDown nudNumOfItem, TextBox txtTotalPrice)
        {
            try
            {
                acSaless.AddReceiptTemp(dgvDetails, txtWatchID, nudNumOfItem, txtTotalPrice);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK);
            }
        }

        public void Details_CellClick(int R)
        {
            acSaless.CellClick(R);
        }

        public void Delete_Click(DataGridView dgvDetails, TextBox txtTotalPrice)
        {
            acSaless.DeleteTemp(dgvDetails, txtTotalPrice);
        }

        public void Reset_Click(DataGridView dgvDetails, TextBox txtWatchID, NumericUpDown nudNumOfItem, TextBox txtTotalPrice, ComboBox cbbWatch, TextBox txtCustomerID)
        {
            if (MessageBox.Show("Bạn có muốn tạo đơn mới không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                acSaless.Reset(dgvDetails, txtWatchID, nudNumOfItem, txtTotalPrice, cbbWatch, txtCustomerID);
            }
        }

        public void Pay_Click(TextBox txtTotalPrice, TextBox txtCustomerID, DataGridView dgvReceipt, ComboBox cbbWatch, DataGridView dgvDetails, string userReceive)
        {
            try
            {
                    acSaless.PayBill(txtTotalPrice, txtCustomerID, dgvDetails, userReceive);
                    Sales_Load(dgvReceipt, cbbWatch);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK);
            }
        }
    }
}
