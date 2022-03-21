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
    public partial class FrmSuppAdd: Form
    {
        DB_SMP db_smp = new DB_SMP();
        TB_supp tbsupp =new TB_supp();
        LibraryProject lp = new LibraryProject();
        FrmSupp frmSupp = new FrmSupp();
        public int ID;

        public FrmSuppAdd()
        {
            InitializeComponent();
        }



        private void btn_insert_Click(object sender, EventArgs e)
        {

            FrmDialog frmDialog = new FrmDialog();
            FrmToast frmToast = new FrmToast();
            if (txtname.Text == "" || txtphone.Text=="" || txtemail.Text == "")
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
                    imageuser.Image.Save(lp.ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    tbsupp.Name_supp = txtname.Text;
                    tbsupp.Phone_supp = txtphone.Text;
                    tbsupp.Email_supp = txtemail.Text;
                    tbsupp.img_supp = lp.convertByte();
                    db_smp.TB_supp.Add(tbsupp);
                    db_smp.SaveChanges();
                    frmToast.txtCaption.Text = "A new supplier has been added";
                    frmToast.Show();  
                    db_smp = new DB_SMP();
                    frmSupp.gridControltable.DataSource = db_smp.TB_supp.ToList();
                    this.Close();
                }
                else
                {
                    //edit
                    imageuser.Image.Save(lp.ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    tbsupp.Name_supp = txtname.Text;
                    tbsupp.Phone_supp = txtphone.Text;
                    tbsupp.Email_supp = txtemail.Text;
                    //tbsupp.ID_supp = ID;
                    tbsupp.img_supp = lp.convertByte();
                    db_smp.Entry(tbsupp).State = System.Data.Entity.EntityState.Modified;
                    db_smp.SaveChanges();
                    frmToast.txtCaption.Text = "A new supplier has been Upadta";
                    frmToast.Show();
                    db_smp = new DB_SMP();
                    frmSupp.gridControltable.DataSource = db_smp.TB_supp.ToList();
                    this.Close();

                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
