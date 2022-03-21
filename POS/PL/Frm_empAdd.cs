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
    public partial class Frm_empAdd : Form
    {
        DB_SMP db_smp = new DB_SMP();
        TB_User tb_user =new TB_User();
        LibraryProject lp = new LibraryProject();
        Frm_emp frmemp = new Frm_emp();
        public int ID;

        public Frm_empAdd()
        {
            InitializeComponent();
        }



        private void btn_insert_Click(object sender, EventArgs e)
        {

            FrmDialog frmDialog = new FrmDialog();
            FrmToast frmToast = new FrmToast();
            if (txt_user.Text == "" || txtPassword.Text=="" || txt_roll.Text == "")
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
                    tb_user.User_Name = txt_user.Text;
                    tb_user.User_Pass = txtPassword.Text;
                    tb_user.User_Roll = txt_roll.Text;
                    tb_user.User_state = "False";
                    //tb_user.img_supp = lp.convertByte();
                    db_smp.TB_User.Add(tb_user);
                    db_smp.SaveChanges();
                    frmToast.txtCaption.Text = "A new Employee has been added";
                    frmToast.Show();  
                    db_smp = new DB_SMP();
                    frmemp.gridControltable.DataSource = db_smp.TB_User.ToList();
                    this.Close();
                }
                else
                {
                    //edit
                    tb_user.ID = ID;
                    tb_user.User_Name = txt_user.Text;
                    tb_user.User_Pass = txtPassword.Text;
                    tb_user.User_Roll = txt_roll.Text;
                    tb_user.User_state="False";
                    db_smp.Entry(tb_user).State = System.Data.Entity.EntityState.Modified;
                    db_smp.SaveChanges();
                    frmToast.txtCaption.Text = "The current employee has been modified";
                    frmToast.Show();
                    db_smp = new DB_SMP();
                    frmemp.gridControltable.DataSource = db_smp.TB_User.ToList();
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
