namespace POS.PL
{
    partial class Frm_empAdd
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.imageuser = new DevExpress.XtraEditors.PictureEdit();
            this.btn_insert = new DevExpress.XtraEditors.SimpleButton();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_roll = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txt_user = new System.Windows.Forms.TextBox();
            this.lbl_titlepaga = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imageuser.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnClose.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnClose.ImageOptions.SvgImage")));
            this.btnClose.Location = new System.Drawing.Point(798, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnClose.Size = new System.Drawing.Size(50, 37);
            this.btnClose.TabIndex = 19;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // imageuser
            // 
            this.imageuser.EditValue = global::POS.Properties.Resources.download_removebg_preview;
            this.imageuser.Location = new System.Drawing.Point(510, 125);
            this.imageuser.Name = "imageuser";
            this.imageuser.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.imageuser.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.imageuser.Size = new System.Drawing.Size(269, 331);
            this.imageuser.TabIndex = 0;
            // 
            // btn_insert
            // 
            this.btn_insert.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_insert.ImageOptions.SvgImage")));
            this.btn_insert.Location = new System.Drawing.Point(57, 413);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(403, 43);
            this.btn_insert.TabIndex = 4;
            this.btn_insert.Text = "add Employee";
            this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Uighur", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(559, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 45);
            this.label5.TabIndex = 0;
            this.label5.Text = "Add Employee";
            // 
            // txt_roll
            // 
            this.txt_roll.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_roll.FormattingEnabled = true;
            this.txt_roll.Items.AddRange(new object[] {
            "ADMIN",
            "USER"});
            this.txt_roll.Location = new System.Drawing.Point(147, 184);
            this.txt_roll.Name = "txt_roll";
            this.txt_roll.Size = new System.Drawing.Size(269, 33);
            this.txt_roll.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Uighur", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(86, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 28);
            this.label3.TabIndex = 22;
            this.label3.Text = "Roll :";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Uighur", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(63, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 28);
            this.label2.TabIndex = 23;
            this.label2.Text = "Password :";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(147, 125);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(269, 35);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_user
            // 
            this.txt_user.Location = new System.Drawing.Point(147, 77);
            this.txt_user.Multiline = true;
            this.txt_user.Name = "txt_user";
            this.txt_user.Size = new System.Drawing.Size(269, 35);
            this.txt_user.TabIndex = 1;
            this.txt_user.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_titlepaga
            // 
            this.lbl_titlepaga.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_titlepaga.AutoSize = true;
            this.lbl_titlepaga.Font = new System.Drawing.Font("Microsoft Uighur", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titlepaga.ForeColor = System.Drawing.Color.Gray;
            this.lbl_titlepaga.Location = new System.Drawing.Point(14, 77);
            this.lbl_titlepaga.Name = "lbl_titlepaga";
            this.lbl_titlepaga.Size = new System.Drawing.Size(115, 28);
            this.lbl_titlepaga.TabIndex = 25;
            this.lbl_titlepaga.Text = "Employee Name :";
            // 
            // Frm_empAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(860, 502);
            this.Controls.Add(this.txt_roll);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txt_user);
            this.Controls.Add(this.lbl_titlepaga);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_insert);
            this.Controls.Add(this.imageuser);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_empAdd";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCatorgyAdd";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.imageuser.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton btnClose;
        public DevExpress.XtraEditors.PictureEdit imageuser;
        public DevExpress.XtraEditors.SimpleButton btn_insert;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtPassword;
        public System.Windows.Forms.TextBox txt_user;
        private System.Windows.Forms.Label lbl_titlepaga;
        public System.Windows.Forms.ComboBox txt_roll;
    }
}