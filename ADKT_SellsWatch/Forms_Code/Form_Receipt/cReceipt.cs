using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADKT_SellsWatch.Forms_Code.Form_Receipt
{
    class cReceipt
    {
        acReceipt acReceipts = new acReceipt();
        public void ReceiptManager_Load(DataGridView dgvUp)
        {
            acReceipts.BindGrid(dgvUp);
        }

        public void Up_CellClick(int R, int C, DataGridView dgvUp, DataGridView dgvDown)
        {
            acReceipts.CellClick(R, C, dgvUp, dgvDown);
        }

        public void dtpChange(DateTimePicker dtpBegin, DateTimePicker dtpEnd, DataGridView dgvUp)
        {
            try
            {
                acReceipts.Datetimes(dtpBegin, dtpEnd, dgvUp);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK);
            }
        }

        public void Search_TextChanged(TextBox txtSearch, DataGridView dgvUp)
        {
            acReceipts.Search(txtSearch, dgvUp);
        }
    }
}
