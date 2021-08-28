
namespace ADKT_SellsWatch.Forms_Design
{
    partial class frmSales
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvReceipt = new System.Windows.Forms.DataGridView();
            this.clnReceiptID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnCustomerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnTotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnPay = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtTotalPrice = new System.Windows.Forms.TextBox();
            this.dgvDetails = new System.Windows.Forms.DataGridView();
            this.clnWatchID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnnumOfWatch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.cbbWatch = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCheckCustomer = new System.Windows.Forms.Button();
            this.btnCheckWatch = new System.Windows.Forms.Button();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.nudNumOfItem = new System.Windows.Forms.NumericUpDown();
            this.txtWatchID = new System.Windows.Forms.TextBox();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceipt)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetails)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumOfItem)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.IndianRed;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1421, 826);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgvReceipt);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 402);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1421, 424);
            this.panel3.TabIndex = 1;
            // 
            // dgvReceipt
            // 
            this.dgvReceipt.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReceipt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReceipt.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnReceiptID,
            this.clnCustomerID,
            this.clnDate,
            this.clnTotalPrice});
            this.dgvReceipt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvReceipt.Location = new System.Drawing.Point(0, 0);
            this.dgvReceipt.Name = "dgvReceipt";
            this.dgvReceipt.ReadOnly = true;
            this.dgvReceipt.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReceipt.Size = new System.Drawing.Size(1421, 424);
            this.dgvReceipt.TabIndex = 0;
            this.dgvReceipt.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReceipt_CellDoubleClick);
            // 
            // clnReceiptID
            // 
            this.clnReceiptID.HeaderText = "Mã";
            this.clnReceiptID.Name = "clnReceiptID";
            this.clnReceiptID.ReadOnly = true;
            // 
            // clnCustomerID
            // 
            this.clnCustomerID.HeaderText = "CMND/ CCCD";
            this.clnCustomerID.Name = "clnCustomerID";
            this.clnCustomerID.ReadOnly = true;
            // 
            // clnDate
            // 
            this.clnDate.HeaderText = "Ngày mua hàng";
            this.clnDate.Name = "clnDate";
            this.clnDate.ReadOnly = true;
            // 
            // clnTotalPrice
            // 
            this.clnTotalPrice.HeaderText = "Tổng tiền";
            this.clnTotalPrice.Name = "clnTotalPrice";
            this.clnTotalPrice.ReadOnly = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtDiscount);
            this.panel2.Controls.Add(this.btnPay);
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.txtTotalPrice);
            this.panel2.Controls.Add(this.dgvDetails);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1421, 402);
            this.panel2.TabIndex = 0;
            // 
            // btnPay
            // 
            this.btnPay.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPay.Location = new System.Drawing.Point(1289, 349);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(129, 39);
            this.btnPay.TabIndex = 8;
            this.btnPay.Text = "Chốt đơn";
            this.btnPay.UseVisualStyleBackColor = true;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(642, 349);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(110, 39);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Xoá";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtTotalPrice.Enabled = false;
            this.txtTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalPrice.Location = new System.Drawing.Point(774, 353);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.Size = new System.Drawing.Size(280, 29);
            this.txtTotalPrice.TabIndex = 5;
            // 
            // dgvDetails
            // 
            this.dgvDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnWatchID,
            this.clnnumOfWatch,
            this.clnPrice});
            this.dgvDetails.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvDetails.Location = new System.Drawing.Point(636, 0);
            this.dgvDetails.Name = "dgvDetails";
            this.dgvDetails.Size = new System.Drawing.Size(785, 337);
            this.dgvDetails.TabIndex = 1;
            this.dgvDetails.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetails_CellClick);
            // 
            // clnWatchID
            // 
            this.clnWatchID.HeaderText = "Sản phẩm";
            this.clnWatchID.Name = "clnWatchID";
            // 
            // clnnumOfWatch
            // 
            this.clnnumOfWatch.HeaderText = "Số lượng";
            this.clnnumOfWatch.Name = "clnnumOfWatch";
            // 
            // clnPrice
            // 
            this.clnPrice.HeaderText = "Giá";
            this.clnPrice.Name = "clnPrice";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(636, 402);
            this.panel4.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.Controls.Add(this.cbbWatch);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.btnAdd);
            this.panel5.Controls.Add(this.btnReset);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.btnCheckCustomer);
            this.panel5.Controls.Add(this.btnCheckWatch);
            this.panel5.Controls.Add(this.txtCustomerID);
            this.panel5.Controls.Add(this.nudNumOfItem);
            this.panel5.Controls.Add(this.txtWatchID);
            this.panel5.Location = new System.Drawing.Point(3, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(627, 393);
            this.panel5.TabIndex = 0;
            // 
            // cbbWatch
            // 
            this.cbbWatch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbWatch.FormattingEnabled = true;
            this.cbbWatch.Location = new System.Drawing.Point(75, 228);
            this.cbbWatch.Name = "cbbWatch";
            this.cbbWatch.Size = new System.Drawing.Size(354, 32);
            this.cbbWatch.TabIndex = 10;
            this.cbbWatch.TextChanged += new System.EventHandler(this.cbbWatch_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(217, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "Số lượng";
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(457, 134);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(110, 39);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(3, 346);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(129, 39);
            this.btnReset.TabIndex = 7;
            this.btnReset.Text = "Tạo đơn mới";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(134, 323);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tên khách hàng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(71, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Mã đồng hồ";
            // 
            // btnCheckCustomer
            // 
            this.btnCheckCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckCustomer.Location = new System.Drawing.Point(514, 346);
            this.btnCheckCustomer.Name = "btnCheckCustomer";
            this.btnCheckCustomer.Size = new System.Drawing.Size(110, 39);
            this.btnCheckCustomer.TabIndex = 4;
            this.btnCheckCustomer.Text = "Kiểm tra";
            this.btnCheckCustomer.UseVisualStyleBackColor = true;
            this.btnCheckCustomer.Click += new System.EventHandler(this.btnCheckCustomer_Click);
            // 
            // btnCheckWatch
            // 
            this.btnCheckWatch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckWatch.Location = new System.Drawing.Point(457, 72);
            this.btnCheckWatch.Name = "btnCheckWatch";
            this.btnCheckWatch.Size = new System.Drawing.Size(110, 39);
            this.btnCheckWatch.TabIndex = 3;
            this.btnCheckWatch.Text = "Kiểm tra";
            this.btnCheckWatch.UseVisualStyleBackColor = true;
            this.btnCheckWatch.Click += new System.EventHandler(this.btnCheckWatch_Click);
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerID.Location = new System.Drawing.Point(154, 350);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.Size = new System.Drawing.Size(354, 29);
            this.txtCustomerID.TabIndex = 2;
            this.txtCustomerID.TextChanged += new System.EventHandler(this.txtCustomerID_TextChanged);
            // 
            // nudNumOfItem
            // 
            this.nudNumOfItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudNumOfItem.Location = new System.Drawing.Point(309, 139);
            this.nudNumOfItem.Name = "nudNumOfItem";
            this.nudNumOfItem.Size = new System.Drawing.Size(120, 29);
            this.nudNumOfItem.TabIndex = 1;
            this.nudNumOfItem.ValueChanged += new System.EventHandler(this.nudNumOfItem_ValueChanged);
            // 
            // txtWatchID
            // 
            this.txtWatchID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWatchID.Location = new System.Drawing.Point(75, 76);
            this.txtWatchID.Name = "txtWatchID";
            this.txtWatchID.Size = new System.Drawing.Size(354, 29);
            this.txtWatchID.TabIndex = 0;
            this.txtWatchID.TextChanged += new System.EventHandler(this.txtWatchID_TextChanged);
            // 
            // txtDiscount
            // 
            this.txtDiscount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDiscount.Enabled = false;
            this.txtDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiscount.Location = new System.Drawing.Point(1060, 353);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(223, 29);
            this.txtDiscount.TabIndex = 9;
            this.txtDiscount.Text = "0";
            // 
            // frmSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1445, 850);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Name = "frmSales";
            this.Load += new System.EventHandler(this.frmSales_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceipt)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetails)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumOfItem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtTotalPrice;
        private System.Windows.Forms.DataGridView dgvDetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnWatchID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnnumOfWatch;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnPrice;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnCheckCustomer;
        private System.Windows.Forms.Button btnCheckWatch;
        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.NumericUpDown nudNumOfItem;
        private System.Windows.Forms.TextBox txtWatchID;
        private System.Windows.Forms.DataGridView dgvReceipt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbbWatch;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnReceiptID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnCustomerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnTotalPrice;
        private System.Windows.Forms.TextBox txtDiscount;
    }
}