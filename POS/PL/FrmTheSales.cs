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

namespace POS.PL
{
    public partial class FrmTheSales: Form
    {
        DB_SMP db_smp =new DB_SMP();
        TB_Sales tb_sales = new TB_Sales();
        BL.LibraryProject lp = new BL.LibraryProject();
        EPL.FrmDialog dlg = new EPL.FrmDialog();
        EPL.FrmToast  toast =  new  FrmToast();
        public int id;
        public FrmTheSales()
        {
            InitializeComponent();

           
            POS.DB_SMP dbContext = new POS.DB_SMP();
            // Call the LoadAsync method to asynchronously get the data for the given DbSet from the database.
            dbContext.TB_Sales.LoadAsync().ContinueWith(loadTask =>
            {
    // Bind data to control when loading complete
    gridControltable.DataSource = dbContext.TB_Sales.Local.ToBindingList();
            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            PL.Frm_editreoprt frmthesalesadd = new Frm_editreoprt();
            frmthesalesadd.ID = 0;
            frmthesalesadd.btn_insert.Text = "ADD";
            frmthesalesadd.Show();
        }

        private void btnUpdata_Click(object sender, EventArgs e)
        {
            PL.Frm_editreoprt frmthesalesadd = new Frm_editreoprt();
            id = Convert.ToInt32(gridView1.GetFocusedRowCellValue("ID"));
            tb_sales = db_smp.TB_Sales.Where(x => x.ID == id).FirstOrDefault();
            frmthesalesadd.txt_name.Text = tb_sales.Sell_Name;
            frmthesalesadd.txt_cus.Text = tb_sales.Sell_cus;


            //frmpurchasesAdd.com_cat.Text = tb_sales.Pur_Cat;
            //frmpurchasesAdd.com_supp.Text = tb_sales.Pur_Supp;
            //frmpurchasesAdd.txt_det.Text = tb_sales.Pur_Det;


            //frmpurchasesAdd.edt_buy.Text = tb_sales.Pur_Buy.ToString();
            //frmpurchasesAdd.edt_sell.Text = tb_sales.Pur__sell.ToString();
            //frmpurchasesAdd.edt_qt.Text = tb_sales.Pur_Qt.ToString();
            //frmpurchasesAdd.edt_tsell.Text = tb_sales.Pur_Tsell.ToString();
            //frmpurchasesAdd.edt_tbuy.Text = tb_sales.Pur_Tbuy.ToString();
            //frmpurchasesAdd.edt_trev.Text = tb_sales.Pur_TRev.ToString();
            //frmpurchasesAdd.imageuser.Image = Image.FromStream(lp.convetImg());
            frmthesalesadd.ID = id;
            frmthesalesadd.btn_insert.Text = "UPDATA";
            frmthesalesadd.Show();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            EPL.FrmToast frmToast = new FrmToast();
            EPL.FrmDialog frmdialog = new FrmDialog();
            id = Convert.ToInt32(gridView1.GetFocusedRowCellValue("ID"));
            if (id > 0)
            {
                try
                {
                    DialogResult result = MessageBox.Show("Are Sure Of The Deleting Process", "Deletion process", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                    if (result == DialogResult.Yes)
                    {
                        tb_sales = db_smp.TB_Sales.Where(x => x.ID == id).FirstOrDefault();
                        db_smp.Entry(tb_sales).State = EntityState.Deleted;
                        db_smp.SaveChanges();
                        toast.txtCaption.Text = "Sale has been removed";
                        toast.Show();
                        UpdateData();
                    }
                }
                catch
                {
                   
                }
            }
            else
            {
                frmdialog.txtCaption.Text = "There is no Sale to delete";
                frmdialog.Width = this.Width;
                frmdialog.Show();
            }
        }

        private void btnreload_Click(object sender, EventArgs e)
        {
            UpdateData();
        }
        public void UpdateData()
        {
            db_smp = new DB_SMP();
            gridControltable.DataSource = db_smp.TB_Sales.ToList();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            var _search = txtsearch.Text;

            gridControltable.DataSource = db_smp.TB_Sales.Where(x => x.Sell_Name.Contains(_search)|| x.Sell_cus.Contains(_search)).ToList();
        }
    }
}
