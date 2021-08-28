
namespace ADKT_SellsWatch.Form_For_Manager
{
    partial class frmMainManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainManager));
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.btnStatistical = new FontAwesome.Sharp.IconButton();
            this.btnReceipt = new FontAwesome.Sharp.IconButton();
            this.btnOther = new FontAwesome.Sharp.IconButton();
            this.btnCustomer = new FontAwesome.Sharp.IconButton();
            this.btnLogout = new FontAwesome.Sharp.IconButton();
            this.btnStaff = new FontAwesome.Sharp.IconButton();
            this.btnWatch = new FontAwesome.Sharp.IconButton();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.pnlLeft.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLeft
            // 
            this.pnlLeft.BackColor = System.Drawing.Color.DarkSalmon;
            this.pnlLeft.Controls.Add(this.btnStatistical);
            this.pnlLeft.Controls.Add(this.btnReceipt);
            this.pnlLeft.Controls.Add(this.btnOther);
            this.pnlLeft.Controls.Add(this.btnCustomer);
            this.pnlLeft.Controls.Add(this.btnLogout);
            this.pnlLeft.Controls.Add(this.btnStaff);
            this.pnlLeft.Controls.Add(this.btnWatch);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(250, 847);
            this.pnlLeft.TabIndex = 1;
            // 
            // btnStatistical
            // 
            this.btnStatistical.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStatistical.FlatAppearance.BorderSize = 0;
            this.btnStatistical.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStatistical.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStatistical.IconChar = FontAwesome.Sharp.IconChar.FileAlt;
            this.btnStatistical.IconColor = System.Drawing.Color.Black;
            this.btnStatistical.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnStatistical.Location = new System.Drawing.Point(0, 500);
            this.btnStatistical.Name = "btnStatistical";
            this.btnStatistical.Size = new System.Drawing.Size(250, 100);
            this.btnStatistical.TabIndex = 7;
            this.btnStatistical.Text = "THỐNG KÊ";
            this.btnStatistical.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnStatistical.UseVisualStyleBackColor = true;
            this.btnStatistical.Click += new System.EventHandler(this.btnStatistical_Click);
            // 
            // btnReceipt
            // 
            this.btnReceipt.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReceipt.FlatAppearance.BorderSize = 0;
            this.btnReceipt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReceipt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReceipt.IconChar = FontAwesome.Sharp.IconChar.Receipt;
            this.btnReceipt.IconColor = System.Drawing.Color.Black;
            this.btnReceipt.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnReceipt.Location = new System.Drawing.Point(0, 400);
            this.btnReceipt.Name = "btnReceipt";
            this.btnReceipt.Size = new System.Drawing.Size(250, 100);
            this.btnReceipt.TabIndex = 5;
            this.btnReceipt.Text = "HOÁ ĐƠN";
            this.btnReceipt.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnReceipt.UseVisualStyleBackColor = true;
            this.btnReceipt.Click += new System.EventHandler(this.btnReceipt_Click);
            // 
            // btnOther
            // 
            this.btnOther.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOther.FlatAppearance.BorderSize = 0;
            this.btnOther.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOther.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOther.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.btnOther.IconColor = System.Drawing.Color.Black;
            this.btnOther.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnOther.Location = new System.Drawing.Point(0, 300);
            this.btnOther.Name = "btnOther";
            this.btnOther.Size = new System.Drawing.Size(250, 100);
            this.btnOther.TabIndex = 4;
            this.btnOther.Text = "KHÁC";
            this.btnOther.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnOther.UseVisualStyleBackColor = true;
            this.btnOther.Click += new System.EventHandler(this.btnOther_Click);
            // 
            // btnCustomer
            // 
            this.btnCustomer.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCustomer.FlatAppearance.BorderSize = 0;
            this.btnCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomer.IconChar = FontAwesome.Sharp.IconChar.User;
            this.btnCustomer.IconColor = System.Drawing.Color.Black;
            this.btnCustomer.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCustomer.Location = new System.Drawing.Point(0, 200);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(250, 100);
            this.btnCustomer.TabIndex = 3;
            this.btnCustomer.Text = "KHÁCH HÀNG";
            this.btnCustomer.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnCustomer.UseVisualStyleBackColor = true;
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.btnLogout.IconColor = System.Drawing.Color.Black;
            this.btnLogout.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLogout.Location = new System.Drawing.Point(0, 747);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(250, 100);
            this.btnLogout.TabIndex = 2;
            this.btnLogout.Text = "ĐĂNG XUẤT";
            this.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnStaff
            // 
            this.btnStaff.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStaff.FlatAppearance.BorderSize = 0;
            this.btnStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStaff.IconChar = FontAwesome.Sharp.IconChar.PeopleCarry;
            this.btnStaff.IconColor = System.Drawing.Color.Black;
            this.btnStaff.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnStaff.Location = new System.Drawing.Point(0, 100);
            this.btnStaff.Name = "btnStaff";
            this.btnStaff.Size = new System.Drawing.Size(250, 100);
            this.btnStaff.TabIndex = 1;
            this.btnStaff.Text = "NHÂN VIÊN";
            this.btnStaff.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnStaff.UseVisualStyleBackColor = true;
            this.btnStaff.Click += new System.EventHandler(this.btnStaff_Click);
            // 
            // btnWatch
            // 
            this.btnWatch.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnWatch.FlatAppearance.BorderSize = 0;
            this.btnWatch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWatch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWatch.IconChar = FontAwesome.Sharp.IconChar.Clock;
            this.btnWatch.IconColor = System.Drawing.Color.Black;
            this.btnWatch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnWatch.Location = new System.Drawing.Point(0, 0);
            this.btnWatch.Name = "btnWatch";
            this.btnWatch.Size = new System.Drawing.Size(250, 100);
            this.btnWatch.TabIndex = 0;
            this.btnWatch.Text = "ĐỒNG HỒ";
            this.btnWatch.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnWatch.UseVisualStyleBackColor = true;
            this.btnWatch.Click += new System.EventHandler(this.btnWatch_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(250, 0);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(1161, 847);
            this.pnlContent.TabIndex = 2;
            // 
            // frmMainManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1411, 847);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlLeft);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMainManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hello: Admin@manager.com";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlLeft.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlLeft;
        private FontAwesome.Sharp.IconButton btnStatistical;
        private FontAwesome.Sharp.IconButton btnReceipt;
        private FontAwesome.Sharp.IconButton btnOther;
        private FontAwesome.Sharp.IconButton btnCustomer;
        private FontAwesome.Sharp.IconButton btnLogout;
        private FontAwesome.Sharp.IconButton btnStaff;
        private FontAwesome.Sharp.IconButton btnWatch;
        private System.Windows.Forms.Panel pnlContent;
    }
}