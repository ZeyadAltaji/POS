namespace POS.PL
{
    partial class FrmCategory
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
            DevExpress.XtraEditors.TableLayout.TableColumnDefinition tableColumnDefinition1 = new DevExpress.XtraEditors.TableLayout.TableColumnDefinition();
            DevExpress.XtraEditors.TableLayout.TableRowDefinition tableRowDefinition1 = new DevExpress.XtraEditors.TableLayout.TableRowDefinition();
            DevExpress.XtraEditors.TableLayout.TableRowDefinition tableRowDefinition2 = new DevExpress.XtraEditors.TableLayout.TableRowDefinition();
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement1 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement2 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCategory));
            this.colcat_name = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.colcat_cover = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.pnCatorage = new System.Windows.Forms.Panel();
            this.gridControltable = new DevExpress.XtraGrid.GridControl();
            this.tileView1 = new DevExpress.XtraGrid.Views.Tile.TileView();
            this.colID = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnsearch = new DevExpress.XtraEditors.SimpleButton();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.btnreload = new DevExpress.XtraEditors.SimpleButton();
            this.btndelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnUpdata = new DevExpress.XtraEditors.SimpleButton();
            this.btnInsert = new DevExpress.XtraEditors.SimpleButton();
            this.pnCatorage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControltable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileView1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // colcat_name
            // 
            this.colcat_name.FieldName = "cat_name";
            this.colcat_name.Name = "colcat_name";
            this.colcat_name.Visible = true;
            this.colcat_name.VisibleIndex = 1;
            // 
            // colcat_cover
            // 
            this.colcat_cover.FieldName = "cat_cover";
            this.colcat_cover.Name = "colcat_cover";
            this.colcat_cover.Visible = true;
            this.colcat_cover.VisibleIndex = 0;
            // 
            // pnCatorage
            // 
            this.pnCatorage.Controls.Add(this.gridControltable);
            this.pnCatorage.Controls.Add(this.panel3);
            this.pnCatorage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnCatorage.Location = new System.Drawing.Point(0, 0);
            this.pnCatorage.Name = "pnCatorage";
            this.pnCatorage.Size = new System.Drawing.Size(965, 522);
            this.pnCatorage.TabIndex = 0;
            // 
            // gridControltable
            // 
            this.gridControltable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControltable.Location = new System.Drawing.Point(0, 0);
            this.gridControltable.MainView = this.tileView1;
            this.gridControltable.Name = "gridControltable";
            this.gridControltable.Size = new System.Drawing.Size(965, 461);
            this.gridControltable.TabIndex = 4;
            this.gridControltable.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.tileView1});
            // 
            // tileView1
            // 
            this.tileView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colcat_cover,
            this.colcat_name,
            this.colID});
            this.tileView1.GridControl = this.gridControltable;
            this.tileView1.Name = "tileView1";
            this.tileView1.OptionsTiles.RowCount = 0;
            this.tileView1.TileColumns.Add(tableColumnDefinition1);
            this.tileView1.TileRows.Add(tableRowDefinition1);
            this.tileView1.TileRows.Add(tableRowDefinition2);
            tileViewItemElement1.Column = this.colcat_name;
            tileViewItemElement1.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement1.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Squeeze;
            tileViewItemElement1.Text = "colcat_name";
            tileViewItemElement1.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement2.Column = this.colcat_cover;
            tileViewItemElement2.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement2.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Squeeze;
            tileViewItemElement2.RowIndex = 1;
            tileViewItemElement2.Text = "colcat_cover";
            tileViewItemElement2.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.tileView1.TileTemplate.Add(tileViewItemElement1);
            this.tileView1.TileTemplate.Add(tileViewItemElement2);
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.Visible = true;
            this.colID.VisibleIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.btnsearch);
            this.panel3.Controls.Add(this.txtsearch);
            this.panel3.Controls.Add(this.btnreload);
            this.panel3.Controls.Add(this.btndelete);
            this.panel3.Controls.Add(this.btnUpdata);
            this.panel3.Controls.Add(this.btnInsert);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 461);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(965, 61);
            this.panel3.TabIndex = 3;
            // 
            // btnsearch
            // 
            this.btnsearch.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnsearch.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnsearch.ImageOptions.SvgImage")));
            this.btnsearch.Location = new System.Drawing.Point(884, 12);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnsearch.Size = new System.Drawing.Size(50, 35);
            this.btnsearch.TabIndex = 0;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // txtsearch
            // 
            this.txtsearch.Location = new System.Drawing.Point(654, 12);
            this.txtsearch.Multiline = true;
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(200, 35);
            this.txtsearch.TabIndex = 0;
            this.txtsearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnreload
            // 
            this.btnreload.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnreload.ImageOptions.SvgImage")));
            this.btnreload.Location = new System.Drawing.Point(330, 12);
            this.btnreload.Name = "btnreload";
            this.btnreload.Size = new System.Drawing.Size(98, 43);
            this.btnreload.TabIndex = 0;
            this.btnreload.Text = "RELOAD";
            this.btnreload.Click += new System.EventHandler(this.btnreload_Click);
            // 
            // btndelete
            // 
            this.btndelete.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btndelete.ImageOptions.SvgImage")));
            this.btndelete.Location = new System.Drawing.Point(224, 12);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(98, 43);
            this.btndelete.TabIndex = 0;
            this.btndelete.Text = "DELETE";
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnUpdata
            // 
            this.btnUpdata.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnUpdata.ImageOptions.SvgImage")));
            this.btnUpdata.Location = new System.Drawing.Point(118, 12);
            this.btnUpdata.Name = "btnUpdata";
            this.btnUpdata.Size = new System.Drawing.Size(98, 43);
            this.btnUpdata.TabIndex = 0;
            this.btnUpdata.Text = "UPDATA";
            this.btnUpdata.Click += new System.EventHandler(this.btnUpdata_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnInsert.ImageOptions.SvgImage")));
            this.btnInsert.Location = new System.Drawing.Point(12, 12);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(98, 43);
            this.btnInsert.TabIndex = 0;
            this.btnInsert.Text = "ADD";
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // FrmCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 522);
            this.Controls.Add(this.pnCatorage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCategory";
            this.Text = "FrmCategory";
            this.pnCatorage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControltable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private DevExpress.XtraEditors.SimpleButton btnsearch;
        private System.Windows.Forms.TextBox txtsearch;
        private DevExpress.XtraEditors.SimpleButton btnreload;
        private DevExpress.XtraEditors.SimpleButton btndelete;
        private DevExpress.XtraEditors.SimpleButton btnUpdata;
        private DevExpress.XtraEditors.SimpleButton btnInsert;
        public System.Windows.Forms.Panel pnCatorage;
        private DevExpress.XtraGrid.Views.Tile.TileView tileView1;
        private DevExpress.XtraGrid.Columns.TileViewColumn colcat_cover;
        private DevExpress.XtraGrid.Columns.TileViewColumn colcat_name;
        private DevExpress.XtraGrid.Columns.TileViewColumn colID;
        public DevExpress.XtraGrid.GridControl gridControltable;
    }
}