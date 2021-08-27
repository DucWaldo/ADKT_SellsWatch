
namespace ADKT_SellsWatch.Form_For_Manager
{
    partial class frmStatisticalManager
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
            this.tcnStatistical = new System.Windows.Forms.TabControl();
            this.tpeRevenue = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnShow = new System.Windows.Forms.Button();
            this.dtpYear = new System.Windows.Forms.DateTimePicker();
            this.dtpMonth = new System.Windows.Forms.DateTimePicker();
            this.rbnYear = new System.Windows.Forms.RadioButton();
            this.rbnMonth = new System.Windows.Forms.RadioButton();
            this.rbnAll = new System.Windows.Forms.RadioButton();
            this.rpvWatchReport = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tpeSalary = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAction = new System.Windows.Forms.Button();
            this.dtpSalary = new System.Windows.Forms.DateTimePicker();
            this.rvrSalaryStaff = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panel1.SuspendLayout();
            this.tcnStatistical.SuspendLayout();
            this.tpeRevenue.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tpeSalary.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.tcnStatistical);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1428, 838);
            this.panel1.TabIndex = 0;
            // 
            // tcnStatistical
            // 
            this.tcnStatistical.Controls.Add(this.tpeRevenue);
            this.tcnStatistical.Controls.Add(this.tpeSalary);
            this.tcnStatistical.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcnStatistical.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcnStatistical.Location = new System.Drawing.Point(0, 0);
            this.tcnStatistical.Name = "tcnStatistical";
            this.tcnStatistical.SelectedIndex = 0;
            this.tcnStatistical.Size = new System.Drawing.Size(1428, 838);
            this.tcnStatistical.TabIndex = 0;
            // 
            // tpeRevenue
            // 
            this.tpeRevenue.BackColor = System.Drawing.Color.Beige;
            this.tpeRevenue.Controls.Add(this.panel2);
            this.tpeRevenue.Controls.Add(this.rpvWatchReport);
            this.tpeRevenue.Location = new System.Drawing.Point(4, 33);
            this.tpeRevenue.Name = "tpeRevenue";
            this.tpeRevenue.Padding = new System.Windows.Forms.Padding(3);
            this.tpeRevenue.Size = new System.Drawing.Size(1420, 801);
            this.tpeRevenue.TabIndex = 0;
            this.tpeRevenue.Text = "Doanh Thu";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnShow);
            this.panel2.Controls.Add(this.dtpYear);
            this.panel2.Controls.Add(this.dtpMonth);
            this.panel2.Controls.Add(this.rbnYear);
            this.panel2.Controls.Add(this.rbnMonth);
            this.panel2.Controls.Add(this.rbnAll);
            this.panel2.Location = new System.Drawing.Point(6, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(176, 347);
            this.panel2.TabIndex = 1;
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(4, 306);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(169, 38);
            this.btnShow.TabIndex = 9;
            this.btnShow.Text = "Xuất";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // dtpYear
            // 
            this.dtpYear.CustomFormat = "yyyy";
            this.dtpYear.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpYear.Location = new System.Drawing.Point(3, 184);
            this.dtpYear.Name = "dtpYear";
            this.dtpYear.Size = new System.Drawing.Size(170, 29);
            this.dtpYear.TabIndex = 8;
            // 
            // dtpMonth
            // 
            this.dtpMonth.CustomFormat = "MM/yyyy";
            this.dtpMonth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpMonth.Location = new System.Drawing.Point(3, 115);
            this.dtpMonth.MaxDate = new System.DateTime(9998, 12, 1, 0, 0, 0, 0);
            this.dtpMonth.Name = "dtpMonth";
            this.dtpMonth.Size = new System.Drawing.Size(170, 29);
            this.dtpMonth.TabIndex = 2;
            this.dtpMonth.Value = new System.DateTime(2021, 8, 1, 0, 0, 0, 0);
            // 
            // rbnYear
            // 
            this.rbnYear.AutoSize = true;
            this.rbnYear.Location = new System.Drawing.Point(3, 150);
            this.rbnYear.Name = "rbnYear";
            this.rbnYear.Size = new System.Drawing.Size(151, 28);
            this.rbnYear.TabIndex = 6;
            this.rbnYear.TabStop = true;
            this.rbnYear.Text = "Xuất theo năm";
            this.rbnYear.UseVisualStyleBackColor = true;
            this.rbnYear.CheckedChanged += new System.EventHandler(this.rbnYear_CheckedChanged);
            // 
            // rbnMonth
            // 
            this.rbnMonth.AutoSize = true;
            this.rbnMonth.Location = new System.Drawing.Point(3, 82);
            this.rbnMonth.Name = "rbnMonth";
            this.rbnMonth.Size = new System.Drawing.Size(161, 28);
            this.rbnMonth.TabIndex = 2;
            this.rbnMonth.TabStop = true;
            this.rbnMonth.Text = "Xuất theo tháng";
            this.rbnMonth.UseVisualStyleBackColor = true;
            this.rbnMonth.CheckedChanged += new System.EventHandler(this.rbnMonth_CheckedChanged);
            // 
            // rbnAll
            // 
            this.rbnAll.AutoSize = true;
            this.rbnAll.Location = new System.Drawing.Point(3, 14);
            this.rbnAll.Name = "rbnAll";
            this.rbnAll.Size = new System.Drawing.Size(109, 28);
            this.rbnAll.TabIndex = 0;
            this.rbnAll.TabStop = true;
            this.rbnAll.Text = "Xuất tổng";
            this.rbnAll.UseVisualStyleBackColor = true;
            this.rbnAll.CheckedChanged += new System.EventHandler(this.rbnAll_CheckedChanged);
            // 
            // rpvWatchReport
            // 
            this.rpvWatchReport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rpvWatchReport.Location = new System.Drawing.Point(188, 6);
            this.rpvWatchReport.Name = "rpvWatchReport";
            this.rpvWatchReport.ServerReport.BearerToken = null;
            this.rpvWatchReport.Size = new System.Drawing.Size(1226, 789);
            this.rpvWatchReport.TabIndex = 0;
            // 
            // tpeSalary
            // 
            this.tpeSalary.Controls.Add(this.groupBox1);
            this.tpeSalary.Controls.Add(this.rvrSalaryStaff);
            this.tpeSalary.Location = new System.Drawing.Point(4, 33);
            this.tpeSalary.Name = "tpeSalary";
            this.tpeSalary.Padding = new System.Windows.Forms.Padding(3);
            this.tpeSalary.Size = new System.Drawing.Size(1420, 801);
            this.tpeSalary.TabIndex = 1;
            this.tpeSalary.Text = "Nhân Viên";
            this.tpeSalary.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAction);
            this.groupBox1.Controls.Add(this.dtpSalary);
            this.groupBox1.Location = new System.Drawing.Point(385, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(655, 159);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lương nhân viên";
            // 
            // btnAction
            // 
            this.btnAction.Location = new System.Drawing.Point(324, 74);
            this.btnAction.Name = "btnAction";
            this.btnAction.Size = new System.Drawing.Size(177, 29);
            this.btnAction.TabIndex = 1;
            this.btnAction.Text = "Xuất";
            this.btnAction.UseVisualStyleBackColor = true;
            this.btnAction.Click += new System.EventHandler(this.btnAction_Click);
            // 
            // dtpSalary
            // 
            this.dtpSalary.CustomFormat = "MM/yyyy";
            this.dtpSalary.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpSalary.Location = new System.Drawing.Point(183, 74);
            this.dtpSalary.Name = "dtpSalary";
            this.dtpSalary.Size = new System.Drawing.Size(110, 29);
            this.dtpSalary.TabIndex = 0;
            // 
            // rvrSalaryStaff
            // 
            this.rvrSalaryStaff.Location = new System.Drawing.Point(6, 359);
            this.rvrSalaryStaff.Name = "rvrSalaryStaff";
            this.rvrSalaryStaff.ServerReport.BearerToken = null;
            this.rvrSalaryStaff.Size = new System.Drawing.Size(1408, 436);
            this.rvrSalaryStaff.TabIndex = 0;
            // 
            // frmStatisticalManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1452, 862);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Name = "frmStatisticalManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Load += new System.EventHandler(this.frmStatisticalManager_Load);
            this.panel1.ResumeLayout(false);
            this.tcnStatistical.ResumeLayout(false);
            this.tpeRevenue.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tpeSalary.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tcnStatistical;
        private System.Windows.Forms.TabPage tpeRevenue;
        private System.Windows.Forms.TabPage tpeSalary;
        private Microsoft.Reporting.WinForms.ReportViewer rpvWatchReport;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rbnYear;
        private System.Windows.Forms.RadioButton rbnMonth;
        private System.Windows.Forms.RadioButton rbnAll;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.DateTimePicker dtpYear;
        private System.Windows.Forms.DateTimePicker dtpMonth;
        private Microsoft.Reporting.WinForms.ReportViewer rvrSalaryStaff;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAction;
        private System.Windows.Forms.DateTimePicker dtpSalary;
    }
}