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
    public partial class FrmCustomersAdd: Form
    {
        DB_SMP db_smp = new DB_SMP();
        TB_Cus tb_cus =new TB_Cus();
        LibraryProject lp = new LibraryProject();
        FrmCustomers frmcus = new FrmCustomers();
        public int ID;

        public FrmCustomersAdd()
        {
            InitializeComponent();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_insert_Click_1(object sender, EventArgs e)
        {
            FrmDialog frmDialog = new FrmDialog();
            FrmToast frmToast = new FrmToast();
            if (txtname.Text == "" || txtphone.Text == "" || txtemail.Text == "")
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
                    tb_cus.Name_Cus = txtname.Text;
                    tb_cus.Phone_Cus = txtphone.Text;
                    tb_cus.Email_Cus = txtemail.Text;
                    tb_cus.img_Cus = lp.convertByte();
                    db_smp.TB_Cus.Add(tb_cus);
                    db_smp.SaveChanges();
                    frmToast.txtCaption.Text = "A new Customer has been added";
                    frmToast.Show();
                    db_smp = new DB_SMP();
                    frmcus.gridControltable.DataSource = db_smp.TB_Cus.ToList();
                    this.Close();
                }
                else
                {
                    //edit
                    imageuser.Image.Save(lp.ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    tb_cus.Name_Cus = txtname.Text;
                    tb_cus.Phone_Cus = txtphone.Text;
                    tb_cus.Email_Cus = txtemail.Text;
                    //tbsupp.ID_supp = ID;
                    tb_cus.img_Cus = lp.convertByte();
                    db_smp.Entry(tb_cus).State = System.Data.Entity.EntityState.Modified;
                    db_smp.SaveChanges();
                    frmToast.txtCaption.Text = "A new Customer has been Upadta";
                    frmToast.Show();
                    db_smp = new DB_SMP();
                    frmcus.gridControltable.DataSource = db_smp.TB_Cus.ToList();
                    this.Close();

                }
            }
        }
    }
}
