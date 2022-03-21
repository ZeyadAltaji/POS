using DevExpress.XtraSplashScreen;
using POS.PL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace POS
{
    public partial class FrmStart : SplashScreen
    {

        DB_SMP db_smp = new DB_SMP();
        TB_User tb_user = new TB_User();
        FrmMain  frmMain = new FrmMain();
        FrmLogin login = new FrmLogin();
        public FrmStart()
        {
            InitializeComponent();
            this.labelCopyright.Text = "Copyright © 2020 -" + DateTime.Now.Year.ToString()+ " ALL RIGHT RESERVED BY TAJI-COMPANY";
        }

        #region Overrides

        public override void ProcessCommand(Enum cmd, object arg)
        {
            base.ProcessCommand(cmd, arg);
        }

        #endregion

        public enum SplashScreenCommand
        {
        }

        private void FrmStart_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tb_user = db_smp.TB_User.Where(x => x.User_state=="True").FirstOrDefault();
            if (tb_user != null)
            {
                frmMain.lblUsername.Text = tb_user.User_Name;
                frmMain.lblRoll.Text = tb_user.User_Roll;
                frmMain.Show();
            }
            else
            {
                login.Show();
            }
            this.Hide();
            timer1.Enabled = false;
        }

        private void labelCopyright_Click(object sender, EventArgs e)
        {

        }
    }
}