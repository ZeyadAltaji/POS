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
    public partial class Frm_puradd: Form
    {
        DB_SMP db_smp = new DB_SMP();
        TB_Pur tb_Pur = new TB_Pur();
        LibraryProject lp = new LibraryProject();
        FrmPurchases frm_pur = new FrmPurchases();
        double buy, sell, qt, tbuy, tsell, trev;

        public int ID;
        public Frm_puradd()
        {
            InitializeComponent();
        }

       
        private void Frm_puradd_Activated(object sender, EventArgs e)
        {

            com_cat.DataSource = db_smp.TB_catogary.Select(x => x.cat_name).ToList();
            com_supp.DataSource = db_smp.TB_supp.Select(x => x.Name_supp).ToList();
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
            PL.FrmSuppAdd suppadd = new FrmSuppAdd();
            suppadd.ID = 0;
            suppadd.btn_insert.Text = "ADD";
            suppadd.Show();
        }
        private void pro_call()
        {

            sell = Convert.ToDouble(edt_sell.Text);
            buy=Convert.ToDouble(edt_buy.Text);
            qt=Convert.ToDouble(edt_qt.Value);
            tsell = sell * qt;
            tbuy = buy * qt;
            trev = tsell - tbuy;
            edt_tsell.Text = tsell.ToString();
            edt_tbuy.Text = tbuy.ToString();
            edt_trev.Text = trev.ToString();

        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            FrmDialog frmDialog = new FrmDialog();
            FrmToast frmToast = new FrmToast();
            if (txtname.Text == "" || txt_type.Text == "" || com_cat.Text == "" || com_supp.Text == "" || edt_sell.Text == "" || edt_buy.Text==" ")
            {
                frmDialog.Width = this.Width;
                frmDialog.txtCaption.Text = "This field is required";
                frmDialog.Show();
            }
            else
            {
                // check if add or edit
                if (ID == 0)
                {
                    //add
                    //imageuser.Image.Save(lp.ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    tb_Pur.pur_Name = txtname.Text;
                    tb_Pur.Pur_type = txt_type.Text;
                    tb_Pur.Pur_Cat = com_cat.Text;
                    tb_Pur.Pur_Supp =com_supp.Text;
                    tb_Pur.Pur_Det =txt_det.Text;
                    tb_Pur.Pur_Buy = Convert.ToDouble(edt_buy.Text);
                    tb_Pur.Pur__sell = Convert.ToDouble(edt_sell.Text);
                    tb_Pur.Pur_Qt = Convert.ToDouble(edt_qt.Text);
                    tb_Pur.Pur_Tbuy = Convert.ToDouble(edt_tbuy.Text);
                    tb_Pur.Pur_Tsell = Convert.ToDouble(edt_tsell.Text);
                    tb_Pur.Pur_TRev = Convert.ToDouble(edt_trev.Text);

                    db_smp.TB_Pur.Add(tb_Pur);
                    db_smp.SaveChanges();
                    frmToast.txtCaption.Text = "Purchase has been made";
                    frmToast.Show();
                    db_smp = new DB_SMP();
                    frm_pur.gridControltable.DataSource = db_smp.TB_Pur.ToList();
                    this.Close();
                }
                else
                {
                    tb_Pur.ID = ID;
                    tb_Pur.pur_Name = txtname.Text;
                    tb_Pur.Pur_type = txt_type.Text;
                    tb_Pur.Pur_Cat = com_cat.Text;
                    tb_Pur.Pur_Supp = com_supp.Text;
                    tb_Pur.Pur_Det = txt_det.Text;
                    tb_Pur.Pur_Buy = Convert.ToDouble(edt_buy.Text);
                    tb_Pur.Pur__sell = Convert.ToDouble(edt_sell.Text);
                    tb_Pur.Pur_Qt = Convert.ToDouble(edt_qt.Text);
                    tb_Pur.Pur_Tbuy = Convert.ToDouble(edt_tbuy.Text);
                    tb_Pur.Pur_Tsell = Convert.ToDouble(edt_tsell.Text);
                    tb_Pur.Pur_TRev = Convert.ToDouble(edt_trev.Text);

                    db_smp.Entry(tb_Pur).State = System.Data.Entity.EntityState.Modified;

                    db_smp.SaveChanges();
                    frmToast.txtCaption.Text = "Purchase process modified";
                    frmToast.Show();
                    db_smp = new DB_SMP();
                    frm_pur.gridControltable.DataSource = db_smp.TB_Pur.ToList();
                    this.Close();
                    ////edit
                    //imageuser.Image.Save(lp.ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    //tbsupp.Name_supp = txtname.Text;
                    ////tbsupp.Phone_supp = txtphone.Text;
                    ////tbsupp.Email_supp = txtemail.Text;
                    ////tbsupp.ID_supp = ID;
                    //tbsupp.img_supp = lp.convertByte();
                    //db_smp.Entry(tbsupp).State = System.Data.Entity.EntityState.Modified;
                    //db_smp.SaveChanges();
                    //frmToast.txtCaption.Text = "A new supplier has been Upadta";
                    //frmToast.Show();
                    //db_smp = new DB_SMP();
                    //frmSupp.gridControltable.DataSource = db_smp.TB_catogary.ToList();
                    //this.Close();

                }
            }
        }

        private void edt_buy_TextChanged(object sender, EventArgs e)
        {
            pro_call();
        }

        private void edt_sell_TextChanged(object sender, EventArgs e)
        {
            pro_call();
        }

        private void edt_qt_EditValueChanged(object sender, EventArgs e)
        {
            pro_call();
        }
    }
}
