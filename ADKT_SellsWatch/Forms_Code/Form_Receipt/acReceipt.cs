using ADKT_SellsWatch.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADKT_SellsWatch.Forms_Code.Form_Receipt
{
    class acReceipt
    {
        ADKTContextDB _dbContext = new ADKTContextDB();

        public void BindGrid(DataGridView dgvUp)
        {
            List<Receipt> receipts = _dbContext.Receipts.ToList();
            AddBindGridUp(receipts, dgvUp);
        }

        private void AddBindGridUp(List<Receipt> receipts, DataGridView dgvUp)
        {
            dgvUp.Rows.Clear();
            foreach (var item in receipts)
            {
                int index = dgvUp.Rows.Add();
                dgvUp.Rows[index].Cells[0].Value = item.ReceiptID;
                dgvUp.Rows[index].Cells[1].Value = item.CustomerID;
                dgvUp.Rows[index].Cells[2].Value = item.Membership.CustomerName;
                dgvUp.Rows[index].Cells[3].Value = item.Date.Value.ToString("dd/MM/yyyy");
                dgvUp.Rows[index].Cells[4].Value = item.TotalPrice;
            }
        }

        public void CellClick(int R, int C, DataGridView dgvUp, DataGridView dgvDown)
        {
            if (R > -1 && C > -1 && dgvUp.Rows[R].Cells[C].Value != null)
            {
                int ID = int.Parse(dgvUp.Rows[R].Cells[0].Value.ToString());
                List<Receipt_Details> receipt_s = _dbContext.Receipt_Details.Where(p => p.ReceiptID == ID).ToList();

                AddBindGridDown(receipt_s, dgvDown);
            }
        }

        private void AddBindGridDown(List<Receipt_Details> receipts, DataGridView dgvDown)
        {
            dgvDown.Rows.Clear();
            foreach (var item in receipts)
            {
                int index = dgvDown.Rows.Add();
                dgvDown.Rows[index].Cells[0].Value = item.WatchID;
                dgvDown.Rows[index].Cells[1].Value = item.numOfWatch;
                dgvDown.Rows[index].Cells[2].Value = item.Watch.Price;
                dgvDown.Rows[index].Cells[3].Value = item.numOfWatch * item.Watch.Price;
            }
        }

        public void Datetimes(DateTimePicker dtpBegin, DateTimePicker dtpEnd, DataGridView dgvUp)
        {
            CheckDTP(dtpBegin, dtpEnd);
            List<Receipt> receipts = _dbContext.Receipts.ToList().Where(p => p.Date >= dtpBegin.Value.Date && p.Date <= dtpEnd.Value.Date).ToList();
            AddBindGridUp(receipts, dgvUp);
        }

        private void CheckDTP(DateTimePicker dtpBegin, DateTimePicker dtpEnd)
        {
            if (dtpEnd.Value > DateTime.Now)
            {
                dtpEnd.Value = DateTime.Now;
                throw new Exception("Thời gian sau không được quá thời gian hiện tại!");
            }
        }

        public void Search(TextBox txtSearch, DataGridView dgvUp)
        {
            List<Receipt> receipts = _dbContext.Receipts.Where(p => p.CustomerID.Contains(txtSearch.Text) == true || p.Membership.CustomerName.Contains(txtSearch.Text) == true).ToList();

            AddBindGridUp(receipts, dgvUp);
        }
    }
}
