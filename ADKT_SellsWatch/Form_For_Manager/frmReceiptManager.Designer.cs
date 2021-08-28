
namespace ADKT_SellsWatch.Form_For_Manager
{
    partial class frmReceiptManager
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.dtpBegin = new System.Windows.Forms.DateTimePicker();
            this.dgvDown = new System.Windows.Forms.DataGridView();
            this.clnWatchID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnNumOfItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvUp = new System.Windows.Forms.DataGridView();
            this.clnSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnCustomerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnCustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnTotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chbTime = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUp)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.CadetBlue;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.dgvDown);
            this.panel1.Controls.Add(this.dgvUp);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1428, 815);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.chbTime);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtSearch);
            this.panel2.Controls.Add(this.btnReset);
            this.panel2.Controls.Add(this.dtpEnd);
            this.panel2.Controls.Add(this.dtpBegin);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 750);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1428, 65);
            this.panel2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(600, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tìm kiếm";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(695, 18);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(409, 29);
            this.txtSearch.TabIndex = 3;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(488, 21);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(106, 29);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // dtpEnd
            // 
            this.dtpEnd.CustomFormat = "dd/MM/yyyy";
            this.dtpEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEnd.Location = new System.Drawing.Point(299, 19);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(129, 29);
            this.dtpEnd.TabIndex = 1;
            this.dtpEnd.ValueChanged += new System.EventHandler(this.dtpChange);
            // 
            // dtpBegin
            // 
            this.dtpBegin.CustomFormat = "dd/MM/yyyy";
            this.dtpBegin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBegin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBegin.Location = new System.Drawing.Point(137, 19);
            this.dtpBegin.Name = "dtpBegin";
            this.dtpBegin.Size = new System.Drawing.Size(129, 29);
            this.dtpBegin.TabIndex = 0;
            this.dtpBegin.ValueChanged += new System.EventHandler(this.dtpChange);
            // 
            // dgvDown
            // 
            this.dgvDown.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDown.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDown.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnWatchID,
            this.clnNumOfItem,
            this.clnPrice,
            this.clnTotal});
            this.dgvDown.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvDown.Location = new System.Drawing.Point(0, 375);
            this.dgvDown.Name = "dgvDown";
            this.dgvDown.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDown.Size = new System.Drawing.Size(1428, 375);
            this.dgvDown.TabIndex = 1;
            // 
            // clnWatchID
            // 
            this.clnWatchID.HeaderText = "Mã đồng hồ";
            this.clnWatchID.Name = "clnWatchID";
            // 
            // clnNumOfItem
            // 
            this.clnNumOfItem.HeaderText = "Số lượng";
            this.clnNumOfItem.Name = "clnNumOfItem";
            // 
            // clnPrice
            // 
            this.clnPrice.HeaderText = "Đơn giá";
            this.clnPrice.Name = "clnPrice";
            // 
            // clnTotal
            // 
            this.clnTotal.HeaderText = "Thánh giá";
            this.clnTotal.Name = "clnTotal";
            // 
            // dgvUp
            // 
            this.dgvUp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnSTT,
            this.clnCustomerID,
            this.clnCustomerName,
            this.clnDate,
            this.clnTotalPrice});
            this.dgvUp.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvUp.Location = new System.Drawing.Point(0, 0);
            this.dgvUp.Name = "dgvUp";
            this.dgvUp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUp.Size = new System.Drawing.Size(1428, 375);
            this.dgvUp.TabIndex = 0;
            this.dgvUp.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUp_CellClick);
            // 
            // clnSTT
            // 
            this.clnSTT.HeaderText = "Mã";
            this.clnSTT.Name = "clnSTT";
            // 
            // clnCustomerID
            // 
            this.clnCustomerID.HeaderText = "Mã khách hàng";
            this.clnCustomerID.Name = "clnCustomerID";
            // 
            // clnCustomerName
            // 
            this.clnCustomerName.HeaderText = "Tên khách hàng";
            this.clnCustomerName.Name = "clnCustomerName";
            // 
            // clnDate
            // 
            this.clnDate.HeaderText = "Ngày mua";
            this.clnDate.Name = "clnDate";
            // 
            // clnTotalPrice
            // 
            this.clnTotalPrice.HeaderText = "Giá";
            this.clnTotalPrice.Name = "clnTotalPrice";
            // 
            // chbTime
            // 
            this.chbTime.AutoSize = true;
            this.chbTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbTime.Location = new System.Drawing.Point(51, 20);
            this.chbTime.Name = "chbTime";
            this.chbTime.Size = new System.Drawing.Size(80, 28);
            this.chbTime.TabIndex = 5;
            this.chbTime.Text = "Lọc từ";
            this.chbTime.UseVisualStyleBackColor = true;
            this.chbTime.CheckedChanged += new System.EventHandler(this.chbTime_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(272, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "~";
            // 
            // frmReceiptManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1452, 839);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Name = "frmReceiptManager";
            this.Load += new System.EventHandler(this.frmReceiptManager_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvUp;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvDown;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnWatchID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnNumOfItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnSTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnCustomerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnCustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnTotalPrice;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.DateTimePicker dtpBegin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chbTime;
    }
}