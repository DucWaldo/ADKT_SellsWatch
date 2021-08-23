
namespace ADKT_SellsWatch.Form_For_Manager
{
    partial class frmWatchManager
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlInput = new System.Windows.Forms.Panel();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.nudNumOfItem = new System.Windows.Forms.NumericUpDown();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.cbbBrandName = new System.Windows.Forms.ComboBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.txtStrap = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.txtWaterproof = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtGlass = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rbtFemale = new System.Windows.Forms.RadioButton();
            this.rbtMale = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtWatchName = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtWatchID = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvWatch = new System.Windows.Forms.DataGridView();
            this.clnWatchID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnWatchName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnGlass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnWaterproof = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnStrap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnBrand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnNumberOfItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.pnlInput.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.groupBox10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumOfItem)).BeginInit();
            this.groupBox9.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWatch)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pnlInput);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1428, 319);
            this.panel2.TabIndex = 0;
            // 
            // pnlInput
            // 
            this.pnlInput.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlInput.Controls.Add(this.groupBox11);
            this.pnlInput.Controls.Add(this.groupBox10);
            this.pnlInput.Controls.Add(this.groupBox9);
            this.pnlInput.Controls.Add(this.groupBox8);
            this.pnlInput.Controls.Add(this.groupBox7);
            this.pnlInput.Controls.Add(this.groupBox6);
            this.pnlInput.Controls.Add(this.groupBox5);
            this.pnlInput.Controls.Add(this.groupBox4);
            this.pnlInput.Controls.Add(this.groupBox3);
            this.pnlInput.Controls.Add(this.groupBox2);
            this.pnlInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlInput.Location = new System.Drawing.Point(3, 3);
            this.pnlInput.Name = "pnlInput";
            this.pnlInput.Size = new System.Drawing.Size(1219, 313);
            this.pnlInput.TabIndex = 1;
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.btnReset);
            this.groupBox11.Controls.Add(this.txtSearch);
            this.groupBox11.Location = new System.Drawing.Point(6, 249);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(551, 61);
            this.groupBox11.TabIndex = 3;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Tìm kiếm theo mã hoặc thương hiệu";
            // 
            // btnReset
            // 
            this.btnReset.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(405, 25);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(143, 33);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(3, 25);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(397, 29);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.nudNumOfItem);
            this.groupBox10.Location = new System.Drawing.Point(421, 137);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(200, 61);
            this.groupBox10.TabIndex = 3;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Số lượng";
            // 
            // nudNumOfItem
            // 
            this.nudNumOfItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudNumOfItem.Location = new System.Drawing.Point(3, 25);
            this.nudNumOfItem.Name = "nudNumOfItem";
            this.nudNumOfItem.Size = new System.Drawing.Size(194, 29);
            this.nudNumOfItem.TabIndex = 0;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.txtPrice);
            this.groupBox9.Location = new System.Drawing.Point(6, 137);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(403, 61);
            this.groupBox9.TabIndex = 2;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Giá bán";
            // 
            // txtPrice
            // 
            this.txtPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPrice.Location = new System.Drawing.Point(3, 25);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(397, 29);
            this.txtPrice.TabIndex = 0;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.cbbBrandName);
            this.groupBox8.Location = new System.Drawing.Point(830, 70);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(383, 61);
            this.groupBox8.TabIndex = 4;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Thương hiệu";
            // 
            // cbbBrandName
            // 
            this.cbbBrandName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbbBrandName.FormattingEnabled = true;
            this.cbbBrandName.Location = new System.Drawing.Point(3, 25);
            this.cbbBrandName.Name = "cbbBrandName";
            this.cbbBrandName.Size = new System.Drawing.Size(377, 32);
            this.cbbBrandName.TabIndex = 0;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.txtStrap);
            this.groupBox7.Location = new System.Drawing.Point(624, 70);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(200, 61);
            this.groupBox7.TabIndex = 3;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Dây đeo";
            // 
            // txtStrap
            // 
            this.txtStrap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtStrap.Location = new System.Drawing.Point(3, 25);
            this.txtStrap.Name = "txtStrap";
            this.txtStrap.Size = new System.Drawing.Size(194, 29);
            this.txtStrap.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.txtWaterproof);
            this.groupBox6.Location = new System.Drawing.Point(418, 70);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(200, 61);
            this.groupBox6.TabIndex = 2;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Chống nước";
            // 
            // txtWaterproof
            // 
            this.txtWaterproof.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtWaterproof.Location = new System.Drawing.Point(3, 25);
            this.txtWaterproof.Name = "txtWaterproof";
            this.txtWaterproof.Size = new System.Drawing.Size(194, 29);
            this.txtWaterproof.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtGlass);
            this.groupBox5.Location = new System.Drawing.Point(212, 70);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(200, 61);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Kính";
            // 
            // txtGlass
            // 
            this.txtGlass.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtGlass.Location = new System.Drawing.Point(3, 25);
            this.txtGlass.Name = "txtGlass";
            this.txtGlass.Size = new System.Drawing.Size(194, 29);
            this.txtGlass.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rbtFemale);
            this.groupBox4.Controls.Add(this.rbtMale);
            this.groupBox4.Location = new System.Drawing.Point(6, 70);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 61);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Giới tính";
            // 
            // rbtFemale
            // 
            this.rbtFemale.AutoSize = true;
            this.rbtFemale.Location = new System.Drawing.Point(80, 27);
            this.rbtFemale.Name = "rbtFemale";
            this.rbtFemale.Size = new System.Drawing.Size(53, 28);
            this.rbtFemale.TabIndex = 3;
            this.rbtFemale.TabStop = true;
            this.rbtFemale.Text = "Nữ";
            this.rbtFemale.UseVisualStyleBackColor = true;
            // 
            // rbtMale
            // 
            this.rbtMale.AutoSize = true;
            this.rbtMale.Location = new System.Drawing.Point(6, 27);
            this.rbtMale.Name = "rbtMale";
            this.rbtMale.Size = new System.Drawing.Size(68, 28);
            this.rbtMale.TabIndex = 2;
            this.rbtMale.TabStop = true;
            this.rbtMale.Text = "Nam";
            this.rbtMale.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtWatchName);
            this.groupBox3.Location = new System.Drawing.Point(209, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1007, 61);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tên đồng hồ";
            // 
            // txtWatchName
            // 
            this.txtWatchName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtWatchName.Location = new System.Drawing.Point(3, 25);
            this.txtWatchName.Name = "txtWatchName";
            this.txtWatchName.Size = new System.Drawing.Size(1001, 29);
            this.txtWatchName.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtWatchID);
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 61);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Mã đồng hồ";
            // 
            // txtWatchID
            // 
            this.txtWatchID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtWatchID.Location = new System.Drawing.Point(3, 25);
            this.txtWatchID.Name = "txtWatchID";
            this.txtWatchID.Size = new System.Drawing.Size(194, 29);
            this.txtWatchID.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnDelete);
            this.panel3.Controls.Add(this.btnUpdate);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(1228, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 319);
            this.panel3.TabIndex = 0;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(33, 183);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(143, 47);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Xoá";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(33, 104);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(143, 47);
            this.btnUpdate.TabIndex = 0;
            this.btnUpdate.Text = "Thêm / Sửa";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvWatch);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 319);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1428, 519);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách";
            // 
            // dgvWatch
            // 
            this.dgvWatch.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvWatch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWatch.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnWatchID,
            this.clnWatchName,
            this.clnGender,
            this.clnGlass,
            this.clnWaterproof,
            this.clnStrap,
            this.clnPrice,
            this.clnBrand,
            this.clnNumberOfItem});
            this.dgvWatch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvWatch.Location = new System.Drawing.Point(3, 25);
            this.dgvWatch.Name = "dgvWatch";
            this.dgvWatch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvWatch.Size = new System.Drawing.Size(1422, 491);
            this.dgvWatch.TabIndex = 0;
            this.dgvWatch.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvWatch_CellClick);
            // 
            // clnWatchID
            // 
            this.clnWatchID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.clnWatchID.Frozen = true;
            this.clnWatchID.HeaderText = "Mã đồng hồ";
            this.clnWatchID.Name = "clnWatchID";
            this.clnWatchID.ReadOnly = true;
            this.clnWatchID.Width = 153;
            // 
            // clnWatchName
            // 
            this.clnWatchName.HeaderText = "Tên đồng hồ";
            this.clnWatchName.Name = "clnWatchName";
            // 
            // clnGender
            // 
            this.clnGender.HeaderText = "Giới tính";
            this.clnGender.Name = "clnGender";
            // 
            // clnGlass
            // 
            this.clnGlass.HeaderText = "Kính";
            this.clnGlass.Name = "clnGlass";
            // 
            // clnWaterproof
            // 
            this.clnWaterproof.HeaderText = "Chống nước";
            this.clnWaterproof.Name = "clnWaterproof";
            // 
            // clnStrap
            // 
            this.clnStrap.HeaderText = "Dây đeo";
            this.clnStrap.Name = "clnStrap";
            // 
            // clnPrice
            // 
            this.clnPrice.HeaderText = "Giá";
            this.clnPrice.Name = "clnPrice";
            // 
            // clnBrand
            // 
            this.clnBrand.HeaderText = "Thương hiệu";
            this.clnBrand.Name = "clnBrand";
            // 
            // clnNumberOfItem
            // 
            this.clnNumberOfItem.HeaderText = "Số lượng";
            this.clnNumberOfItem.Name = "clnNumberOfItem";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1428, 838);
            this.panel1.TabIndex = 0;
            // 
            // frmWatchManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1452, 862);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Name = "frmWatchManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmWatchManager_Load);
            this.panel2.ResumeLayout(false);
            this.pnlInput.ResumeLayout(false);
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudNumOfItem)).EndInit();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvWatch)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnlInput;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvWatch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.NumericUpDown nudNumOfItem;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.ComboBox cbbBrandName;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TextBox txtStrap;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox txtWaterproof;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtGlass;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rbtFemale;
        private System.Windows.Forms.RadioButton rbtMale;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtWatchName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtWatchID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnWatchID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnWatchName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnGender;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnGlass;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnWaterproof;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnStrap;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnBrand;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnNumberOfItem;
    }
}