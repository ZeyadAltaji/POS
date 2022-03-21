namespace POS.PL
{
    partial class Frm_editreoprt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_editreoprt));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_cus = new System.Windows.Forms.ComboBox();
            this.txt_name = new System.Windows.Forms.ComboBox();
            this.link_lbl_add_supp = new System.Windows.Forms.LinkLabel();
            this.link_lbl_add_cat = new System.Windows.Forms.LinkLabel();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_titlepaga = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txt_qt = new DevExpress.XtraEditors.SpinEdit();
            this.lbl = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.txt_sell = new System.Windows.Forms.TextBox();
            this.btn_insert = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_qt = new System.Windows.Forms.Label();
            this.lbl_sell = new System.Windows.Forms.Label();
            this.lbl_buy = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbl_message = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_qt.Properties)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_cus);
            this.groupBox2.Controls.Add(this.txt_name);
            this.groupBox2.Controls.Add(this.link_lbl_add_supp);
            this.groupBox2.Controls.Add(this.link_lbl_add_cat);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.lbl_titlepaga);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(42, 26);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(518, 162);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Basic information";
            // 
            // txt_cus
            // 
            this.txt_cus.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txt_cus.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txt_cus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cus.FormattingEnabled = true;
            this.txt_cus.Location = new System.Drawing.Point(229, 88);
            this.txt_cus.Name = "txt_cus";
            this.txt_cus.Size = new System.Drawing.Size(237, 28);
            this.txt_cus.TabIndex = 2;
            // 
            // txt_name
            // 
            this.txt_name.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txt_name.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txt_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name.FormattingEnabled = true;
            this.txt_name.Location = new System.Drawing.Point(229, 47);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(237, 28);
            this.txt_name.TabIndex = 1;
            this.txt_name.SelectedIndexChanged += new System.EventHandler(this.txt_name_SelectedIndexChanged);
            // 
            // link_lbl_add_supp
            // 
            this.link_lbl_add_supp.AutoSize = true;
            this.link_lbl_add_supp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.link_lbl_add_supp.Location = new System.Drawing.Point(180, 95);
            this.link_lbl_add_supp.Name = "link_lbl_add_supp";
            this.link_lbl_add_supp.Size = new System.Drawing.Size(33, 18);
            this.link_lbl_add_supp.TabIndex = 0;
            this.link_lbl_add_supp.TabStop = true;
            this.link_lbl_add_supp.Text = "Add";
            this.link_lbl_add_supp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_lbl_add_supp_LinkClicked);
            // 
            // link_lbl_add_cat
            // 
            this.link_lbl_add_cat.AutoSize = true;
            this.link_lbl_add_cat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.link_lbl_add_cat.Location = new System.Drawing.Point(180, 54);
            this.link_lbl_add_cat.Name = "link_lbl_add_cat";
            this.link_lbl_add_cat.Size = new System.Drawing.Size(33, 18);
            this.link_lbl_add_cat.TabIndex = 0;
            this.link_lbl_add_cat.TabStop = true;
            this.link_lbl_add_cat.Text = "Add";
            this.link_lbl_add_cat.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_lbl_add_cat_LinkClicked_1);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Uighur", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Gray;
            this.label7.Location = new System.Drawing.Point(38, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 28);
            this.label7.TabIndex = 0;
            this.label7.Text = "Customers :";
            // 
            // lbl_titlepaga
            // 
            this.lbl_titlepaga.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_titlepaga.AutoSize = true;
            this.lbl_titlepaga.Font = new System.Drawing.Font("Microsoft Uighur", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titlepaga.ForeColor = System.Drawing.Color.Gray;
            this.lbl_titlepaga.Location = new System.Drawing.Point(38, 52);
            this.lbl_titlepaga.Name = "lbl_titlepaga";
            this.lbl_titlepaga.Size = new System.Drawing.Size(96, 28);
            this.lbl_titlepaga.TabIndex = 0;
            this.lbl_titlepaga.Text = "Name Article :";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txt_qt);
            this.groupBox3.Controls.Add(this.lbl);
            this.groupBox3.Controls.Add(this.label19);
            this.groupBox3.Controls.Add(this.txt_sell);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(42, 211);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(518, 162);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Sale";
            // 
            // txt_qt
            // 
            this.txt_qt.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txt_qt.Location = new System.Drawing.Point(212, 77);
            this.txt_qt.Name = "txt_qt";
            this.txt_qt.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_qt.Properties.Appearance.Options.UseFont = true;
            this.txt_qt.Properties.AutoHeight = false;
            this.txt_qt.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txt_qt.Size = new System.Drawing.Size(236, 28);
            this.txt_qt.TabIndex = 4;
            // 
            // lbl
            // 
            this.lbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Microsoft Uighur", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.ForeColor = System.Drawing.Color.Gray;
            this.lbl.Location = new System.Drawing.Point(21, 77);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(65, 28);
            this.lbl.TabIndex = 0;
            this.lbl.Text = "Quantity";
            // 
            // label19
            // 
            this.label19.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Uighur", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.Gray;
            this.label19.Location = new System.Drawing.Point(21, 32);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(84, 28);
            this.label19.TabIndex = 0;
            this.label19.Text = "Selling Price";
            // 
            // txt_sell
            // 
            this.txt_sell.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sell.Location = new System.Drawing.Point(212, 27);
            this.txt_sell.Multiline = true;
            this.txt_sell.Name = "txt_sell";
            this.txt_sell.Size = new System.Drawing.Size(236, 28);
            this.txt_sell.TabIndex = 3;
            this.txt_sell.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_insert
            // 
            this.btn_insert.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_insert.ImageOptions.SvgImage")));
            this.btn_insert.Location = new System.Drawing.Point(42, 421);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(128, 43);
            this.btn_insert.TabIndex = 5;
            this.btn_insert.Text = "add";
            this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.lbl_qt);
            this.groupBox1.Controls.Add(this.lbl_sell);
            this.groupBox1.Controls.Add(this.lbl_buy);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Location = new System.Drawing.Point(600, 28);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(389, 366);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(389, 71);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(125, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Article details";
            // 
            // lbl_qt
            // 
            this.lbl_qt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_qt.AutoSize = true;
            this.lbl_qt.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_qt.ForeColor = System.Drawing.Color.Red;
            this.lbl_qt.Location = new System.Drawing.Point(182, 322);
            this.lbl_qt.Name = "lbl_qt";
            this.lbl_qt.Size = new System.Drawing.Size(24, 28);
            this.lbl_qt.TabIndex = 0;
            this.lbl_qt.Text = "0";
            // 
            // lbl_sell
            // 
            this.lbl_sell.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_sell.AutoSize = true;
            this.lbl_sell.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sell.ForeColor = System.Drawing.Color.Red;
            this.lbl_sell.Location = new System.Drawing.Point(182, 240);
            this.lbl_sell.Name = "lbl_sell";
            this.lbl_sell.Size = new System.Drawing.Size(24, 28);
            this.lbl_sell.TabIndex = 0;
            this.lbl_sell.Text = "0";
            // 
            // lbl_buy
            // 
            this.lbl_buy.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_buy.AutoSize = true;
            this.lbl_buy.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_buy.ForeColor = System.Drawing.Color.Red;
            this.lbl_buy.Location = new System.Drawing.Point(182, 154);
            this.lbl_buy.Name = "lbl_buy";
            this.lbl_buy.Size = new System.Drawing.Size(24, 28);
            this.lbl_buy.TabIndex = 0;
            this.lbl_buy.Text = "0";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 18.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Gray;
            this.label11.Location = new System.Drawing.Point(136, 281);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(116, 25);
            this.label11.TabIndex = 0;
            this.label11.Text = "Quantity";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 18.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Gray;
            this.label10.Location = new System.Drawing.Point(104, 198);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(181, 25);
            this.label10.TabIndex = 0;
            this.label10.Text = "Selling Price";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 18.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Gray;
            this.label9.Location = new System.Drawing.Point(84, 102);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(220, 25);
            this.label9.TabIndex = 0;
            this.label9.Text = "Purchasing price";
            // 
            // lbl_message
            // 
            this.lbl_message.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_message.AutoSize = true;
            this.lbl_message.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 18.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_message.ForeColor = System.Drawing.Color.Red;
            this.lbl_message.Location = new System.Drawing.Point(608, 427);
            this.lbl_message.Name = "lbl_message";
            this.lbl_message.Size = new System.Drawing.Size(350, 25);
            this.lbl_message.TabIndex = 0;
            this.lbl_message.Text = "Quantity is not enough !!!";
            this.lbl_message.Visible = false;
            // 
            // FrmTheSalesAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1029, 484);
            this.Controls.Add(this.lbl_message);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_insert);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Name = "FrmTheSalesAdd";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.Activated += new System.EventHandler(this.Frm_salesAdd_Activated);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_qt.Properties)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.LinkLabel link_lbl_add_supp;
        private System.Windows.Forms.LinkLabel link_lbl_add_cat;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl_titlepaga;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label label19;
        public System.Windows.Forms.TextBox txt_sell;
        public DevExpress.XtraEditors.SimpleButton btn_insert;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.ComboBox txt_cus;
        public System.Windows.Forms.ComboBox txt_name;
        public System.Windows.Forms.Label lbl_qt;
        public System.Windows.Forms.Label lbl_sell;
        public DevExpress.XtraEditors.SpinEdit txt_qt;
        public System.Windows.Forms.Label lbl_buy;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_message;
    }
}