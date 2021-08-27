using ADKT_SellsWatch.Models;
using ADKT_SellsWatch.Report;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADKT_SellsWatch.Form_For_Manager
{
    public partial class frmStatisticalManager : Form
    {
        ADKTContextDB _dbContext = new ADKTContextDB();
        public frmStatisticalManager()
        {
            InitializeComponent();
        }

        private void frmStatisticalManager_Load(object sender, EventArgs e)
        {
            dtpMonth.Enabled = dtpYear.Enabled = false;
            btnShow.Enabled = false;
            this.rpvWatchReport.RefreshReport();
            this.rvrSalaryStaff.RefreshReport();
        }

        private void rbnAll_CheckedChanged(object sender, EventArgs e)
        {
            if (rbnAll.Checked == true)
            {
                btnShow.Enabled = true;
            }
            else
            {
                btnShow.Enabled = false;
            }
        }

        private void rbnMonth_CheckedChanged(object sender, EventArgs e)
        {
            if (rbnMonth.Checked == true)
            {
                dtpMonth.Enabled = true;
                btnShow.Enabled = true;
            }
            else
            {
                dtpMonth.Enabled = false;
                btnShow.Enabled = false;
            }
        }

        private void rbnYear_CheckedChanged(object sender, EventArgs e)
        {
            if (rbnYear.Checked == true)
            {
                dtpYear.Enabled = true;
                btnShow.Enabled = true;
            }
            else
            {
                dtpYear.Enabled = false;
                btnShow.Enabled = false;
            }
        }

        private void AddReportWatch(List<RevenueWatchReport> list, ReportParameter param)
        {
            rpvWatchReport.LocalReport.ReportPath = "./Form_Report/frmRevenueWatchReport.rdlc";
            rpvWatchReport.LocalReport.SetParameters(param);
            var reportDataSource = new ReportDataSource("RevenueWatchDataSet", list);
            rpvWatchReport.LocalReport.DataSources.Clear();
            rpvWatchReport.LocalReport.DataSources.Add(reportDataSource);
            rpvWatchReport.LocalReport.DisplayName = "Phiếu doanh thu đồng hồ!";
            rpvWatchReport.RefreshReport();
        }

        private void ReportAll()
        {
            List<Watch> watches = _dbContext.Watches.ToList();
            List<RevenueWatchReport> reports = new List<RevenueWatchReport>();

            foreach (Watch item in watches)
            {
                RevenueWatchReport temp = new RevenueWatchReport();
                temp.WatchID = item.WatchID;
                temp.Num = item.Receipt_Details.Sum(p => p.numOfWatch);
                temp.Price = double.Parse(item.Price.ToString());
                temp.Cost = temp.Num * temp.Price;
                reports.Add(temp);
            }
            ReportParameter parma = new ReportParameter("Time", "Doanh thu tổng thể");
            AddReportWatch(reports, parma);
        }

        private void ReportMonth()
        {
            List<Watch> watches = _dbContext.Watches.ToList();
            List<RevenueWatchReport> reports = new List<RevenueWatchReport>();

            foreach (Watch item in watches)
            {
                RevenueWatchReport temp = new RevenueWatchReport();
                temp.WatchID = item.WatchID;
                temp.Num = item.Receipt_Details.Where(p => p.Receipt.Date.Value.Month == dtpMonth.Value.Month && p.Receipt.Date.Value.Year == dtpMonth.Value.Year).Sum(p => p.numOfWatch);
                temp.Price = double.Parse(item.Price.ToString());
                temp.Cost = temp.Num * temp.Price;
                reports.Add(temp);
            }
            ReportParameter parma = new ReportParameter("Time", "Doanh thu tháng " + dtpMonth.Value.Month + " Năm " + dtpMonth.Value.Year);
            AddReportWatch(reports, parma);
        }

        private void ReportYear()
        {
            List<Watch> watches = _dbContext.Watches.ToList();
            List<RevenueWatchReport> reports = new List<RevenueWatchReport>();

            foreach (Watch item in watches)
            {
                RevenueWatchReport temp = new RevenueWatchReport();
                temp.WatchID = item.WatchID;
                temp.Num = item.Receipt_Details.Where(p => p.Receipt.Date.Value.Year == dtpYear.Value.Year).Sum(p => p.numOfWatch);
                temp.Price = double.Parse(item.Price.ToString());
                temp.Cost = temp.Num * temp.Price;
                reports.Add(temp);
            }
            ReportParameter parma = new ReportParameter("Time", "Doanh thu Năm " + dtpYear.Value.Year);
            AddReportWatch(reports, parma);
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if (rbnAll.Checked == true)
            {
                ReportAll();
            }
            if (rbnMonth.Checked == true)
            {
                ReportMonth();
            }
            if (rbnYear.Checked == true)
            {
                ReportYear();
            }
        }


        private void AddReportSalary(List<SalaryStaffReport> list, ReportParameter param)
        {
            rvrSalaryStaff.LocalReport.ReportPath = "./Form_Report/frmSalaryReport.rdlc";
            rvrSalaryStaff.LocalReport.SetParameters(param);
            var reportDataSource = new ReportDataSource("SalaryStaffDataSet", list);
            rvrSalaryStaff.LocalReport.DataSources.Clear();
            rvrSalaryStaff.LocalReport.DataSources.Add(reportDataSource);
            rvrSalaryStaff.LocalReport.DisplayName = "Phiếu lương nhân viên!";
            rvrSalaryStaff.RefreshReport();
        }

        private void btnAction_Click(object sender, EventArgs e)
        {
            List<Staff> staffs = _dbContext.Staffs.Where(p => p.Status == true).ToList();
            List<Receipt> receipts = _dbContext.Receipts.Where(p => p.Date.Value.Month == dtpSalary.Value.Month && p.Date.Value.Year == dtpSalary.Value.Year).ToList();
            List<SalaryStaffReport> reports = new List<SalaryStaffReport>();

            foreach (Staff item in staffs)
            {
                SalaryStaffReport temp = new SalaryStaffReport();
                temp.StaffID = item.UserName;
                temp.StaffName = item.Name;
                temp.Salary = int.Parse(item.Salary.ToString());
                temp.Bonus = receipts.Where(p => p.StaffID == temp.StaffID).Count() * 100000;
                temp.MainSalary = temp.Salary + temp.Bonus;
                reports.Add(temp);
            }
            ReportParameter param = new ReportParameter("Time", "Tháng " + dtpSalary.Value.Month + " năm " + dtpSalary.Value.Year);
            AddReportSalary(reports, param);
        }
    }
}
