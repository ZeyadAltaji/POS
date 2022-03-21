using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using POS.EPL;
using DevExpress.XtraReports.UI;

namespace POS.PL
{
    public partial class FrmReport: Form
    {
        PL.XtraReport1 report1 = new XtraReport1();
        all_report.XtraPurchasingReport xtraPurchasing = new all_report.XtraPurchasingReport();
        all_report.XtraCustomerReport xtraCustomer = new all_report.XtraCustomerReport();
        all_report.XtraSuppliersReport xtraSuppliers = new all_report.XtraSuppliersReport();
        all_report.XtraSystemLogs xtraSystemLogs = new all_report.XtraSystemLogs();
        public FrmReport()
        {
            InitializeComponent();
            CustomizeDesing(); 
        }
        public void CustomizeDesing()
        {
            coll1.Visible = false;
            coll2.Visible = false;
            coll3.Visible = false;
            coll4.Visible = false;
            coll5.Visible = false;
            coll6.Visible = false;
        }
        public void hideSubMenu()
        {

            if (coll1.Visible == true)
            {
                coll1.Visible = false;
            }
            else if (coll2.Visible == true)
            {
                coll2.Visible = false;
            }
            else if (coll3.Visible == true)
            {
                coll3.Visible = false;
            }
            else if (coll4.Visible == true)
            {
                coll4.Visible = false;
            }
            else if (coll5.Visible == true)
            {
                coll5.Visible = false;
            }
            else if (coll6.Visible == true)
            {
                coll6.Visible = false;
            }
        }
        private void showMenu(Panel Coll)
        {
            if (Coll.Visible == false)
            {
                hideSubMenu();
                Coll.Visible = true;
            }
            else
                Coll.Visible = false;
        }

        private void btn_sell_Click(object sender, EventArgs e)
        {

            Report.Frm_editreoprt edit = new Report.Frm_editreoprt();
            edit.ShowDialog();

        }

        private void btncoll_sell_Click(object sender, EventArgs e)
        {
            showMenu(coll1);
        }

        private void btn_purRe_Click(object sender, EventArgs e)
        {
            showMenu(coll2);
        }

        private void btn_Earnings_Click(object sender, EventArgs e)
        {
            showMenu(coll3);
        }

        private void btn_CusRE_Click(object sender, EventArgs e)
        {
            showMenu(coll4);
        }

        private void btn_SuppRe_Click(object sender, EventArgs e)
        {
            showMenu(coll5);
        }

        private void btn_work_summ_Click(object sender, EventArgs e)
        {
            showMenu(coll6);
        }

        private void btneditRebo_Click(object sender, EventArgs e)
        {
            report1.ShowDesigner();
        }

        private void btnsee_Click(object sender, EventArgs e)
        {
            report1.ShowPreview();
        }
        private void btn_edit_pur(object sender, EventArgs e)
        {
            xtraPurchasing.ShowDesigner();
        }

        private void btn_see_pur(object sender, EventArgs e)
        {
            xtraPurchasing.ShowPreview();
        }

        private void btn_edit_cus(object sender, EventArgs e)
        {
            xtraCustomer.ShowDesigner();    
        }

        private void btn_see_cus(object sender, EventArgs e)
        {
            xtraCustomer.ShowPreview(); 
        }

        private void btn_edit_supp(object sender, EventArgs e)
        {
            xtraSuppliers.ShowDesigner();
        }

        private void btn_see_supp(object sender, EventArgs e)
        {
            xtraSuppliers.ShowPreview();
        }

        private void btn_edit_worc(object sender, EventArgs e)
        {
            xtraSystemLogs.ShowDesigner();
        }

        private void btn_see_work(object sender, EventArgs e)
        {
            xtraSystemLogs.ShowPreview();
        }
    }
}
