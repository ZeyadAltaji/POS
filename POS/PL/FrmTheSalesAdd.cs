using POS.BL;
using POS.EPL;
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
    public partial class Frm_editreoprt: Form
    {
        DB_SMP db_smp = new DB_SMP();
        TB_Sales tb_sales = new TB_Sales();
        LibraryProject lp = new LibraryProject();
        FrmTheSales frm_sales = new FrmTheSales();
        TB_Pur tb_Pur=new TB_Pur();
        double preQt, newQt, ruqOt;

        public int ID;
        public Frm_editreoprt()
        {
            InitializeComponent();
        }


        private void Frm_salesAdd_Activated(object sender, EventArgs e)
        {
            var res1 = db_smp.TB_Pur.Select(x => x.pur_Name).ToList();
            var res2 = db_smp.TB_Cus.Select(x => x.Name_Cus).ToList();
            txt_name.DataSource = res1;
            txt_cus.DataSource = res2;
            AutoCompleteStringCollection ACSC1 = new AutoCompleteStringCollection();
            AutoCompleteStringCollection ACSC2 = new AutoCompleteStringCollection();
            ACSC1.AddRange(res1.ToArray());
            ACSC2.AddRange(res2.ToArray());
            txt_name.AutoCompleteCustomSource = ACSC1;
            txt_cus.AutoCompleteCustomSource = ACSC2;

            tb_Pur = db_smp.TB_Pur.Where(x => x.pur_Name == txt_name.Text).FirstOrDefault();
            lbl_buy.Text =tb_Pur.Pur_Buy.ToString();
            lbl_sell.Text = tb_Pur.Pur__sell.ToString();
            lbl_qt.Text = tb_Pur.Pur_Qt.ToString();
        }
        private void link_lbl_add_cat_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PL.FrmCatorgyAdd catorgyAdd = new FrmCatorgyAdd();
            catorgyAdd.ID = 0;
            catorgyAdd.btnInsert.Text = "ADD";
            catorgyAdd.Show();
        }

        private void link_lbl_add_supp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PL.FrmCustomersAdd cusadd = new FrmCustomersAdd();
            cusadd.ID = 0;
            cusadd.btn_insert.Text = "ADD";
            cusadd.Show();
        }

        private void txt_name_SelectedIndexChanged(object sender, EventArgs e)
        {

            tb_Pur = db_smp.TB_Pur.Where(x => x.pur_Name == txt_name.Text).FirstOrDefault();
            lbl_buy.Text = tb_Pur.Pur_Buy.ToString();
            lbl_sell.Text = tb_Pur.Pur__sell.ToString();
            lbl_qt.Text = tb_Pur.Pur_Qt.ToString();
            txt_sell.Text = tb_Pur.Pur__sell.ToString();
        }

        private void btn_insert_Click_1(object sender, EventArgs e)
        {
            FrmDialog frmDialog = new FrmDialog();
            FrmToast frmToast = new FrmToast();
            preQt =Convert.ToDouble(lbl_qt.Text);
            newQt = Convert.ToDouble(txt_qt.Text);
            ruqOt = preQt - newQt;
            if (txt_name.Text == "" || txt_cus.Text == "" || txt_sell.Text == "" || txt_qt.Text == "")
            {
                frmDialog.Width = this.Width;
                frmDialog.txtCaption.Text = "Article name is required";
                frmDialog.Show();
            }
            else
            {
                // check if add or edit
                if (ID == 0)
                {
                    if(ruqOt >= 0)
                    {

                        // add
                        //imageuser.Image.Save(lp.ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                        tb_sales.Sell_Name = txt_name.Text;
                        tb_sales.Sell_cus = txt_cus.Text;

                        tb_sales.Sell_price = Convert.ToDouble(txt_sell.Text);
                        tb_sales.Sell_Qt = Convert.ToDouble(txt_qt.Text);
                        tb_sales.Sell_TPrice = (Convert.ToDouble(lbl_qt.Text))*Convert.ToDouble(lbl_sell.Text);
                        tb_sales.Sell_Date = DateTime.Now;

                        db_smp.TB_Sales.Add(tb_sales);
                        tb_Pur.Pur_Qt = ruqOt;
                        db_smp.Entry(tb_Pur).State = System.Data.Entity.EntityState.Modified;
                        db_smp.SaveChanges();
                        frmToast.txtCaption.Text = "Purchase has been made";
                        frmToast.Show();
                        db_smp = new DB_SMP();
                        frm_sales.gridControltable.DataSource = db_smp.TB_Sales.ToList();
                        this.Close();
                    }
                    else
                    {
                        lbl_message.Visible = true;
                    }
                    
                }
                //else
                //{
                //    tb_sales.ID = ID;
                //    tb_sales.Sell_Name = txt_name.Text;
                //    tb_sales.Sell_cus = txt_cus.Text;


                //    //tb_sales.Pur_Cat = com_cat.Text;
                //    //tb_sales.Pur_Supp = com_supp.Text;
                //    //tb_sales.Pur_Det = txt_det.Text;


                //    tb_sales.Sell_price = Convert.ToDouble(txt_sell.Text);
                //    tb_sales.Sell_Qt = Convert.ToDouble(txt_qt.Text);
                //    //tb_sales.Pur_Qt = Convert.ToDouble(edt_qt.Text);
                //    //tb_sales.Pur_Tbuy = Convert.ToDouble(edt_tbuy.Text);
                //    //tb_sales.Pur_Tsell = Convert.ToDouble(edt_tsell.Text);
                //    //tb_sales.Pur_TRev = Convert.ToDouble(edt_trev.Text);

                //    db_smp.Entry(tb_sales).State = System.Data.Entity.EntityState.Modified;

                //    db_smp.SaveChanges();
                //    frmToast.txtCaption.Text = "Purchase process modified";
                //    frmToast.Show();
                //    db_smp = new DB_SMP();
                //    frm_sales.gridControltable.DataSource = db_smp.TB_Pur.ToList();
                //    this.Close();
                //}
            }
        }

        private void pro_call()
        {

           
            //buy =Convert.ToDouble(txt_sell.Text);
            //qt=Convert.ToDouble(txt_qt.Value);
            //tsell = sell * qt;
            //tbuy = buy * qt;
            //trev = tsell - tbuy;
            //lbl_sell.Text = tsell.ToString();
            //lbl_buy.Text = tbuy.ToString();
            //lbl_qt.Text = trev.ToString();

        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            
        }
    }
}
