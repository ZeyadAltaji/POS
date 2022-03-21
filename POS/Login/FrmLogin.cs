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
    public partial class FrmLogin: Form
    {
        DB_SMP db_smp = new DB_SMP();
        TB_User tb_user =new TB_User();
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {

            FrmDialog frmDialog = new FrmDialog();
            FrmToast frmToast = new FrmToast();
            if (txt_user.Text == "")
            {
                frmDialog.Width = this.Width;
                frmDialog.txtCaption.Text = "User Name is required";
                frmDialog.Show();
            }
            else if (txtPassword.Text == "")
            {
                frmDialog.Width = this.Width;
                frmDialog.txtCaption.Text = "Password is required";
                frmDialog.Show();
            }
            else
            {
                // login 


                tb_user = db_smp.TB_User.Where(x => x.User_Name == txt_user.Text && x.User_Pass == txtPassword.Text).FirstOrDefault();
                if (tb_user != null)
                {
                    FrmMain frmMain = new FrmMain();

                    tb_user.User_state = "True";
                    db_smp.Entry(tb_user).State = System.Data.Entity.EntityState.Modified;
                    frmMain.lblUsername.Text = tb_user.User_Name;
                    frmMain.lblRoll.Text = tb_user.User_Roll;
                    frmMain.Enabled = true;
                    db_smp.SaveChanges();
                    this.Hide();
                    frmMain.ShowDialog();
                    this.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Unable To Login, Please Try again Later");

                }


            }
        }
        private void btn_Exit_Click(object sender, EventArgs e)
        {
           Application.Exit();
        }
    }
}
