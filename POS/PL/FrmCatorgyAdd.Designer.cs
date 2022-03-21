namespace POS.PL
{
    partial class FrmCatorgyAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCatorgyAdd));
            this.btnInsert = new DevExpress.XtraEditors.SimpleButton();
            this.txtNameADD = new System.Windows.Forms.TextBox();
            this.lbl_titlepaga = new System.Windows.Forms.Label();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.image_edit = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.image_edit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnInsert
            // 
            this.btnInsert.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnInsert.ImageOptions.SvgImage")));
            this.btnInsert.Location = new System.Drawing.Point(305, 397);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(128, 43);
            this.btnInsert.TabIndex = 23;
            this.btnInsert.Text = "ADD";
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // txtNameADD
            // 
            this.txtNameADD.Location = new System.Drawing.Point(85, 87);
            this.txtNameADD.Multiline = true;
            this.txtNameADD.Name = "txtNameADD";
            this.txtNameADD.Size = new System.Drawing.Size(269, 35);
            this.txtNameADD.TabIndex = 21;
            this.txtNameADD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_titlepaga
            // 
            this.lbl_titlepaga.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_titlepaga.AutoSize = true;
            this.lbl_titlepaga.Font = new System.Drawing.Font("Microsoft Uighur", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titlepaga.ForeColor = System.Drawing.Color.Gray;
            this.lbl_titlepaga.Location = new System.Drawing.Point(156, 48);
            this.lbl_titlepaga.Name = "lbl_titlepaga";
            this.lbl_titlepaga.Size = new System.Drawing.Size(133, 36);
            this.lbl_titlepaga.TabIndex = 20;
            this.lbl_titlepaga.Text = "Name Category";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnClose.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnClose.ImageOptions.SvgImage")));
            this.btnClose.Location = new System.Drawing.Point(408, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnClose.Size = new System.Drawing.Size(50, 37);
            this.btnClose.TabIndex = 19;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // image_edit
            // 
            this.image_edit.EditValue = global::POS.Properties.Resources._206_2069856_action_clipart_action_item_action_item_icon_png;
            this.image_edit.Location = new System.Drawing.Point(85, 174);
            this.image_edit.Name = "image_edit";
            this.image_edit.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.image_edit.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.image_edit.Size = new System.Drawing.Size(269, 203);
            this.image_edit.TabIndex = 24;
            // 
            // FrmCatorgyAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(470, 464);
            this.Controls.Add(this.image_edit);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.txtNameADD);
            this.Controls.Add(this.lbl_titlepaga);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCatorgyAdd";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCatorgyAdd";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.image_edit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public DevExpress.XtraEditors.SimpleButton btnInsert;
        public System.Windows.Forms.TextBox txtNameADD;
        private System.Windows.Forms.Label lbl_titlepaga;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        public DevExpress.XtraEditors.PictureEdit image_edit;
    }
}