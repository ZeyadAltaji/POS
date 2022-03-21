using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS.PL
{
    public partial class FRmHome : Form
    {
        DB_SMP db_smp =new DB_SMP();
        public FRmHome()
        {
            InitializeComponent();
            List<TB_catogary>listcat =db_smp.TB_catogary.ToList();
            lbl_cat.Text=listcat.Count.ToString();
            List<TB_supp>listsupp=db_smp.TB_supp.ToList();
            lbl_supp.Text=listsupp.Count.ToString();
            List<TB_Sales> listsell = db_smp.TB_Sales.ToList();
            lbl_sell.Text = listsell.Count.ToString();
            List<TB_Cus> Listcus = db_smp.TB_Cus.ToList();
            lbl_cus.Text = Listcus.Count.ToString();
            List<TB_Pur> listpur = db_smp.TB_Pur.ToList();
            lbl_pur.Text = listpur.Count.ToString();
           
        }

        private void btn_cat_Click(object sender, EventArgs e)
        {
            PL.FrmCatorgyAdd catorgyAdd = new FrmCatorgyAdd();
            catorgyAdd.ID = 0;
            catorgyAdd.btnInsert.Text = "ADD";
            catorgyAdd.Show();
        }
        private void btn_supp(object sender, EventArgs e)
        {
            PL.FrmSuppAdd suppadd = new FrmSuppAdd();
            suppadd.ID = 0;
            suppadd.btn_insert.Text = "ADD";
            suppadd.Show();
        }

        private void btn_cus(object sender, EventArgs e)
        {
            PL.FrmCustomersAdd frmcustomersadd = new FrmCustomersAdd();
            frmcustomersadd.ID = 0;
            frmcustomersadd.btn_insert.Text = "ADD";
            frmcustomersadd.Show();
        }

        private void btn_sell(object sender, EventArgs e)
        {
            PL.Frm_editreoprt frmthesalesadd = new Frm_editreoprt();
            frmthesalesadd.ID = 0;
            frmthesalesadd.btn_insert.Text = "ADD";
            frmthesalesadd.Show();
        }

        private void btn_buy(object sender, EventArgs e)
        {
            PL.Frm_puradd frmpurchasesAdd = new Frm_puradd();
            frmpurchasesAdd.ID = 0;
            frmpurchasesAdd.btn_insert.Text = "ADD";
            frmpurchasesAdd.Show();
        }
    }
}
