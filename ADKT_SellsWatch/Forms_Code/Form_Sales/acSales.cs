﻿using ADKT_SellsWatch.Form_For_Manager;
using ADKT_SellsWatch.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADKT_SellsWatch.Forms_Code.Form_Sales
{
    class acSales
    {
        ADKTContextDB _dbContext = new ADKTContextDB();
        frmCustomerManager frmCM = new frmCustomerManager();
        int R_index = -1;
        int price = 0;

        public void BindGrid(DataGridView dgvReceipt)
        {
            List<Receipt> receipts = _dbContext.Receipts.ToList();
            AddBindGrid(receipts, dgvReceipt);
        }

        private void AddBindGrid(List<Receipt> receipts, DataGridView dgvReceipt)
        {
            dgvReceipt.Rows.Clear();
            foreach (var item in receipts)
            {
                int index = dgvReceipt.Rows.Add();
                dgvReceipt.Rows[index].Cells[0].Value = item.CustomerID;
                dgvReceipt.Rows[index].Cells[1].Value = item.Date;
                dgvReceipt.Rows[index].Cells[2].Value = item.TotalPrice;
            }
        }

        private Watch watch(TextBox txtWatchID)
        {
            return _dbContext.Watches.FirstOrDefault(p => p.WatchID == txtWatchID.Text);
        }

        public void CheckWatch(TextBox txtWatchID)
        {
            if (txtWatchID.Text != string.Empty)
            {
                if (watch(txtWatchID) != null)
                {
                    int num = watch(txtWatchID).NumOfItem.Value;
                    if (num > 0)
                    {
                        MessageBox.Show("Sản phẩm còn: " + num, "Thông báo", MessageBoxButtons.OK);
                    }
                    else
                    {
                        MessageBox.Show("Hết hàng", "Thông báo", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    throw new Exception("Không có mặt hàng này!");
                }
            }
        }
        public void CBBWatch(ComboBox cbbWatch)
        {
            List<Watch> watches = _dbContext.Watches.ToList();

            cbbWatch.DataSource = watches;
            cbbWatch.DisplayMember = "WatchID";
            //cbbWatch.ValueMember = "BrandID";
        }

        /*private bool CheckWatchBool(Watch watch)
        {
            if (watch != null)
            {
                int num = watch.NumOfItem.Value;
                if (num > 0)
                {
                    MessageBox.Show("Sản phẩm còn: " + num, "Thông báo", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Hết hàng", "Thông báo", MessageBoxButtons.OK);
                }
                return true;
            }
            else
            {
                throw new Exception("Không có mặt hàng này!");
                return false;
            }
        }*/

        public void CheckCustomer(TextBox txtCustomerID)
        {
            if (txtCustomerID.Text != string.Empty)
            {
                Membership watch = _dbContext.Memberships.FirstOrDefault(p => p.CustomerID == txtCustomerID.Text);

                if (watch != null)
                {
                    MessageBox.Show("Đã có khách hàng này!");
                }
                else
                {
                    if (MessageBox.Show("Chưa có khách hàng này, bạn có muốn thêm khách hàng mới không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        frmCM.Show();
                    }
                    else
                    {
                        throw new Exception("Không thể thực hiện thanh toán!");
                    }
                }
            }
            else
            {
                throw new Exception("Vui lòng nhập CMND/ CCCD khách hàng!");
            }
        }

        public void NumOfItem_ValueChanged(TextBox txtWatchID, NumericUpDown nudNumOfItem)
        {
            if (txtWatchID.Text != string.Empty)
            {
                if (watch(txtWatchID) != null)
                {
                    if (nudNumOfItem.Value > watch(txtWatchID).NumOfItem)
                    {
                        nudNumOfItem.Value = watch(txtWatchID).NumOfItem.Value;
                        throw new Exception("Đã quá số lượng tồn kho!");
                    }
                }
                else
                {
                    nudNumOfItem.Value = 0;
                    nudNumOfItem.Enabled = false;
                    throw new Exception("Không có mặt hàng, vui lòng kiểm tra lại");
                }
            }
            else
            {
                throw new Exception("Chưa có sản phẩm, vui lòng nhập");
            }
        }

        public void AddReceiptTemp(DataGridView dgvDetails, TextBox txtWatchID, NumericUpDown nudNumOfItem, TextBox txtTotalPrice)
        {
            if (nudNumOfItem.Value != 0)
            {
                Watch watchtemp = _dbContext.Watches.FirstOrDefault(p => p.WatchID == txtWatchID.Text);
                int index = dgvDetails.Rows.Add();
                dgvDetails.Rows[index].Cells[0].Value = txtWatchID.Text;
                dgvDetails.Rows[index].Cells[1].Value = nudNumOfItem.Value;
                dgvDetails.Rows[index].Cells[2].Value = watchtemp.Price;
                int prices = int.Parse(watchtemp.Price.ToString()) * int.Parse(nudNumOfItem.Value.ToString());
                txtTotalPrice.Text = PriceTotal(prices).ToString();
            }
            else
            {
                throw new Exception("Chưa nhập số lượng");
            }
        }

        public int PriceTotal(int Prices)
        {
            return price += Prices;
        }

        public void CellClick(int R)
        {
            R_index = R;
        }

        public void DeleteTemp(DataGridView dgvDetails, TextBox txtTotalPrice)
        {
            if (R_index > -1)
            {
                if (dgvDetails.Rows[R_index].Cells[2].Value != null)
                {
                    string temp = dgvDetails.Rows[R_index].Cells[2].Value.ToString();
                    txtTotalPrice.Text = PriceTotal(- int.Parse(temp)).ToString();
                    dgvDetails.Rows.RemoveAt(R_index);
                }
            }
        }

        public void Reset(DataGridView dgvDetails, TextBox txtWatchID, NumericUpDown nudNumOfItem, TextBox txtTotalPrice, ComboBox cbbWatch, TextBox txtCustomerID)
        {
            nudNumOfItem.Value = 0;
            txtWatchID.Text = txtTotalPrice.Text = txtCustomerID.Text = cbbWatch.Text = string.Empty;
            dgvDetails.Rows.Clear();
        }

        public void PayBill(TextBox txtTotalPrice)
        {
            if (MessageBox.Show("Bạn có muốn thanh toán hoá đơn với giá: " + txtTotalPrice.Text, "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

            }
        }
    }
}
