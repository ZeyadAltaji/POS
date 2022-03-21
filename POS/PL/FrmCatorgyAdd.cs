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
    public partial class FrmCatorgyAdd : Form
    {
        DB_SMP db_smp = new DB_SMP();
        TB_catogary tbCatogy = new TB_catogary();
        LibraryProject lp = new LibraryProject();
        FrmCategory frmcatorage = new FrmCategory();
        public int ID;

        public FrmCatorgyAdd()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            FrmDialog frmDialog = new FrmDialog();
            FrmToast frmToast = new FrmToast();
            if (txtNameADD.Text == "")
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
                    image_edit.Image.Save(lp.ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    tbCatogy.cat_name = txtNameADD.Text;
                    tbCatogy.cat_cover = lp.convertByte();
                    db_smp.TB_catogary.Add(tbCatogy);
                    db_smp.SaveChanges();
                    frmToast.txtCaption.Text = "A new category has been added";
                    frmToast.Show();
                    db_smp = new DB_SMP();
                    frmcatorage.gridControltable.DataSource = db_smp.TB_catogary.ToList();
                    this.Close();
                }
                else
                {
                    //edit
                    image_edit.Image.Save(lp.ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    tbCatogy.cat_name = txtNameADD.Text;
                    tbCatogy.ID = ID;
                    tbCatogy.cat_cover = lp.convertByte();
                    db_smp.Entry(tbCatogy).State = System.Data.Entity.EntityState.Modified;
                    db_smp.SaveChanges();
                    frmToast.txtCaption.Text = "A new category has been Upadta";
                    frmToast.Show();
                    db_smp = new DB_SMP();
                    frmcatorage.gridControltable.DataSource = db_smp.TB_catogary.ToList();
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
