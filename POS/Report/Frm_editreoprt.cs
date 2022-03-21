using DevExpress.XtraReports.UI;
using POS.PL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS.Report
{
    public partial class Frm_editreoprt : Form
    {
        
        DB_SMP db_smp = new DB_SMP();
        PL.FrmReport frmReport = new PL.FrmReport();
        PL.XtraReport1 report = new XtraReport1();
        public Frm_editreoprt()
        { 

            InitializeComponent();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {

            pn_cont.Controls.Clear();
            pn_cont.Controls.Add(frmReport.pn_report);
            db_smp = new DB_SMP();
            report.ShowDesigner();
        }

        private void btn_see_Click(object sender, EventArgs e)
        {
            pn_cont.Controls.Clear();
            pn_cont.Controls.Add(frmReport.pn_report);
            db_smp = new DB_SMP();
            report.ShowPreview();
        }
    }
}
