using ADKT_SellsWatch.Form_For_Manager;
using ADKT_SellsWatch.Forms_Design;
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
        int R_index = -1;
        int priceT = 0;

        public acSales()
        {
            
        }

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
                dgvReceipt.Rows[index].Cells[0].Value = item.ReceiptID;
                dgvReceipt.Rows[index].Cells[1].Value = item.CustomerID;
                dgvReceipt.Rows[index].Cells[2].Value = item.Date.Value.ToString("dd/MM/yyyy");
                dgvReceipt.Rows[index].Cells[3].Value = item.TotalPrice;
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

        public void CheckCustomer(TextBox txtCustomerID, Button btnPay)
        {
            if (txtCustomerID.Text != string.Empty)
            {
                if (checkCus(txtCustomerID) == true)
                {
                    MessageBox.Show("Đã có khách hàng này!");
                    btnPay.Enabled = true;
                }
                else
                {
                    if (MessageBox.Show("Chưa có khách hàng này, bạn có muốn thêm khách hàng mới không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        frmAddMembership frmAM = new frmAddMembership(txtCustomerID.Text);
                        frmAM.Show();
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

        public bool checkCus(TextBox txtCustomerID)
        {
            Membership Cus = _dbContext.Memberships.FirstOrDefault(p => p.CustomerID == txtCustomerID.Text);
            if (Cus != null)
            {
                return true;
            }
            return false;
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
            if (Prices != 0)
            {
                return priceT += Prices;
            }
            return 0;
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
                    txtTotalPrice.Text = PriceTotal(-int.Parse(temp)).ToString();
                    dgvDetails.Rows.RemoveAt(R_index);
                }
            }
        }

        public void Reset(DataGridView dgvDetails, TextBox txtWatchID, NumericUpDown nudNumOfItem, TextBox txtTotalPrice, ComboBox cbbWatch, TextBox txtCustomerID)
        {
            nudNumOfItem.Value = 0;
            PriceTotal(0);
            priceT = 0;
            txtWatchID.Text = txtTotalPrice.Text = txtCustomerID.Text = cbbWatch.Text = string.Empty;
            dgvDetails.Rows.Clear();
        }

        public void PayBill(TextBox txtTotalPrice, TextBox txtCustomerID, DataGridView dgvDetails, string userReceive)
        {
            if (txtCustomerID.Text != string.Empty && txtTotalPrice.Text != string.Empty)
            {
                if (MessageBox.Show("Bạn có muốn thanh toán hoá đơn với giá: " + txtTotalPrice.Text, "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    string temp = userReceive;
                    Receipt receipts = new Receipt() { CustomerID = txtCustomerID.Text, StaffID = temp, Date = DateTime.Now, TotalPrice = int.Parse(txtTotalPrice.Text) };

                    _dbContext.Receipts.Add(receipts);

                    /*Receipt temp = _dbContext.Receipts.Last();
                    int ReID = temp.ReceiptID;*/

                    string ID = string.Empty;
                    string NUM = string.Empty;

                    for (int i = 0; i < dgvDetails.Rows.Count; i++)
                    {
                        if (dgvDetails.Rows[i].Cells[0].Value != null && dgvDetails.Rows[i].Cells[1].Value != null)
                        {
                            ID = dgvDetails.Rows[i].Cells[0].Value.ToString();
                            NUM = dgvDetails.Rows[i].Cells[1].Value.ToString();

                            Receipt_Details RECEIPT = new Receipt_Details()
                            {
                                WatchID = ID,
                                ReceiptID = receipts.ReceiptID,
                                numOfWatch = int.Parse(NUM)
                            };

                            _dbContext.Receipt_Details.Add(RECEIPT);
                            _dbContext.SaveChanges();

                            Watch watchs = _dbContext.Watches.FirstOrDefault(p => p.WatchID == ID);
                            if (watchs != null)
                            {
                                watchs.NumOfItem -= int.Parse(NUM);
                                _dbContext.SaveChanges();
                            }
                        }
                    }
                    _dbContext.SaveChanges();
                }
            }
            else
            {
                throw new Exception("Chưa có thông tin gì để thanh toán");
            }
            updateRank();
        }

        public void updateRank()
        {
            List<Membership> memberships = _dbContext.Memberships.ToList();
            for (int i = 0; i < _dbContext.Memberships.Count(); i++)
            {
                Membership MemberUpdate = memberships[i];
                List<Receipt> numRank = _dbContext.Receipts.Where(p => p.CustomerID == MemberUpdate.CustomerID).ToList();
                int numRanks = _dbContext.Receipts.Where(p => p.CustomerID == MemberUpdate.CustomerID).Count();
                if (CheckRank(numRanks) != 0)
                {
                    MemberUpdate.RankID = CheckRank(numRank.Count);
                    _dbContext.SaveChanges();
                }
                else
                {
                    MemberUpdate.RankID = 0;
                    _dbContext.SaveChanges();
                }
            }
        }

        public int CheckRank(int numRank)
        {
            if (numRank >= 5)
            {
                return 1;
            }
            if (numRank >= 10)
            {
                return 2;
            }
            if (numRank >= 15)
            {
                return 3;
            }
            return 0;
        }
    }
}

