using POS.PL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS
{
    public partial class FrmMain : Form
    {
        DB_SMP db_smp = new DB_SMP();
        PL.FRmHome frmHome = new PL.FRmHome();
        PL.FrmCategory frmCatorage = new PL.FrmCategory();
        PL.FrmSupp frmSupp = new PL.FrmSupp();
        PL.FrmPurchases frmPurchases = new PL.FrmPurchases();
        PL.FrmCustomers frmCustomers = new PL.FrmCustomers();
        PL.FrmTheSales frmtheseles =new PL.FrmTheSales();   
        PL.FrmReport frm_report =new PL.FrmReport();
        PL.Frm_emp frmemp =new PL.Frm_emp();
        TB_User tb_user = new TB_User();
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do You Exit to App ?", "warring", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                Environment.Exit(0);
        }

        private void btnMAX_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        private void btnmin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;

        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            pn_cont.Controls.Clear();
            pn_cont.Controls.Add(frmHome.pn_home);
            if(lblRoll.Text== "ADMIN")
            {
                btn_emp.Enabled=true;
            }
            else
            {
                btn_emp.Enabled = false;
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            pn_cont.Controls.Clear();
            pn_cont.Controls.Add(frmHome.pn_home);
        }

       

      

        private void btncollapse_Click(object sender, EventArgs e)
        {
            if (pn_navbar.Width == 250)
            {
                pn_navbar.Width = 44;
                pn_titleNavbar.Visible=false;
                pn_headernavbar.Height = 200;

            }
            else
            {
                pn_navbar.Width = 250;
                pn_titleNavbar.Visible = true;
                pn_headernavbar.Height = 250;
            }
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do You Exit to App ?", "warring", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                Environment.Exit(0);
        }

        private void btnMAX_Click_1(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        private void btnmin_Click_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;

        }
        private void btnItem_Click(object sender, EventArgs e)
        {
            pn_cont.Controls.Clear();
            pn_cont.Controls.Add(frmCatorage.pnCatorage);
            db_smp = new DB_SMP();
            lbl_titlepaga.Text = "Category";
        }
        private void btnSuppliers(object sender, EventArgs e)
        {
            pn_cont.Controls.Clear();
            pn_cont.Controls.Add(frmSupp.pnSupp);
            db_smp = new DB_SMP();
            lbl_titlepaga.Text = "Suppliers";
        }
        private void btn_Pur_Click(object sender, EventArgs e)
        {
            pn_cont.Controls.Clear();
            pn_cont.Controls.Add(frmPurchases.pn_pur);
            db_smp = new DB_SMP();
            lbl_titlepaga.Text = "Purchases";
        }

        private void btnCtom_Click(object sender, EventArgs e)
        {
            pn_cont.Controls.Clear();
            pn_cont.Controls.Add(frmCustomers.pnctom);
            db_smp = new DB_SMP();
            lbl_titlepaga.Text = "Customers";
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            pn_cont.Controls.Clear();
            pn_cont.Controls.Add(frmtheseles.pn_theselaes);
            db_smp = new DB_SMP();
            lbl_titlepaga.Text = "The Sales";
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            pn_cont.Controls.Clear();
            pn_cont.Controls.Add(frm_report.pn_report);
            db_smp = new DB_SMP();
            lbl_titlepaga.Text = "Reports";
        }

        private void btn_emp_Click(object sender, EventArgs e)
        {
            pn_cont.Controls.Clear();
            pn_cont.Controls.Add(frmemp.pn_emp);
            db_smp = new DB_SMP();
            lbl_titlepaga.Text = "Employee";
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            FrmLogin frmLogin = new FrmLogin();
            tb_user = db_smp.TB_User.Where(x => x.User_state=="True").FirstOrDefault();
            tb_user.User_state = "False";
            db_smp.Entry(tb_user).State = System.Data.Entity.EntityState.Modified;
            db_smp.SaveChanges();
            this.Enabled = false;
            frmLogin.Show();
            this.Hide();


        }

        private void btn_About_Click(object sender, EventArgs e)
        {
            BL.Frm_about fRM_about = new BL.Frm_about();
            fRM_about.Show();
        }
    }
}
