namespace Report_Pro.Forms
{
    partial class frm_Master
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Master));
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar_1 = new DevExpress.XtraBars.Bar();
            this.btn_Save = new DevExpress.XtraBars.BarButtonItem();
            this.btn_New = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Delete = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Print = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Search = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Top;
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.OptionsBar.AllowQuickCustomization = false;
            this.bar1.OptionsBar.DisableClose = true;
            this.bar1.OptionsBar.DisableCustomization = true;
            this.bar1.OptionsBar.UseWholeRow = true;
            resources.ApplyResources(this.bar1, "bar1");
            // 
            // bar2
            // 
            this.bar2.BarName = "Tools";
            this.bar2.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Top;
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.OptionsBar.AllowQuickCustomization = false;
            this.bar2.OptionsBar.DisableClose = true;
            this.bar2.OptionsBar.DisableCustomization = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            resources.ApplyResources(this.bar2, "bar2");
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar_1});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btn_Save,
            this.btn_New,
            this.btn_Delete,
            this.btn_Print,
            this.btn_Search});
            this.barManager1.MaxItemId = 6;
            // 
            // bar_1
            // 
            this.bar_1.BarName = "Tools";
            this.bar_1.DockCol = 0;
            this.bar_1.DockRow = 0;
            this.bar_1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar_1.FloatLocation = new System.Drawing.Point(859, 249);
            this.bar_1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btn_Save, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btn_New, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btn_Delete, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btn_Print, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btn_Search, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar_1.OptionsBar.AllowDelete = true;
            this.bar_1.OptionsBar.AllowQuickCustomization = false;
            this.bar_1.OptionsBar.DisableClose = true;
            this.bar_1.OptionsBar.DisableCustomization = true;
            this.bar_1.OptionsBar.UseWholeRow = true;
            resources.ApplyResources(this.bar_1, "bar_1");
            // 
            // btn_Save
            // 
            resources.ApplyResources(this.btn_Save, "btn_Save");
            this.btn_Save.Id = 0;
            this.btn_Save.ImageOptions.ImageIndex = ((int)(resources.GetObject("btn_Save.ImageOptions.ImageIndex")));
            this.btn_Save.ImageOptions.LargeImageIndex = ((int)(resources.GetObject("btn_Save.ImageOptions.LargeImageIndex")));
            this.btn_Save.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_Save.ImageOptions.SvgImage")));
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_Save_ItemClick);
            // 
            // btn_New
            // 
            resources.ApplyResources(this.btn_New, "btn_New");
            this.btn_New.Id = 1;
            this.btn_New.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_New.ImageOptions.Image")));
            this.btn_New.ImageOptions.ImageIndex = ((int)(resources.GetObject("btn_New.ImageOptions.ImageIndex")));
            this.btn_New.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_New.ImageOptions.LargeImage")));
            this.btn_New.ImageOptions.LargeImageIndex = ((int)(resources.GetObject("btn_New.ImageOptions.LargeImageIndex")));
            this.btn_New.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_New.ImageOptions.SvgImage")));
            this.btn_New.Name = "btn_New";
            this.btn_New.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_New_ItemClick);
            // 
            // btn_Delete
            // 
            resources.ApplyResources(this.btn_Delete, "btn_Delete");
            this.btn_Delete.Id = 2;
            this.btn_Delete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Delete.ImageOptions.Image")));
            this.btn_Delete.ImageOptions.ImageIndex = ((int)(resources.GetObject("btn_Delete.ImageOptions.ImageIndex")));
            this.btn_Delete.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_Delete.ImageOptions.LargeImage")));
            this.btn_Delete.ImageOptions.LargeImageIndex = ((int)(resources.GetObject("btn_Delete.ImageOptions.LargeImageIndex")));
            this.btn_Delete.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_Delete.ImageOptions.SvgImage")));
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // btn_Print
            // 
            resources.ApplyResources(this.btn_Print, "btn_Print");
            this.btn_Print.Id = 3;
            this.btn_Print.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Print.ImageOptions.Image")));
            this.btn_Print.ImageOptions.ImageIndex = ((int)(resources.GetObject("btn_Print.ImageOptions.ImageIndex")));
            this.btn_Print.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_Print.ImageOptions.LargeImage")));
            this.btn_Print.ImageOptions.LargeImageIndex = ((int)(resources.GetObject("btn_Print.ImageOptions.LargeImageIndex")));
            this.btn_Print.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_Print.ImageOptions.SvgImage")));
            this.btn_Print.Name = "btn_Print";
            this.btn_Print.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick);
            // 
            // btn_Search
            // 
            resources.ApplyResources(this.btn_Search, "btn_Search");
            this.btn_Search.Id = 5;
            this.btn_Search.ImageOptions.ImageIndex = ((int)(resources.GetObject("btn_Search.ImageOptions.ImageIndex")));
            this.btn_Search.ImageOptions.LargeImageIndex = ((int)(resources.GetObject("btn_Search.ImageOptions.LargeImageIndex")));
            this.btn_Search.ImageOptions.SvgImage = global::Report_Pro.Properties.Resources.find;
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_Search_ItemClick);
            // 
            // barDockControlTop
            // 
            resources.ApplyResources(this.barDockControlTop, "barDockControlTop");
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Manager = this.barManager1;
            // 
            // barDockControlBottom
            // 
            resources.ApplyResources(this.barDockControlBottom, "barDockControlBottom");
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Manager = this.barManager1;
            // 
            // barDockControlLeft
            // 
            resources.ApplyResources(this.barDockControlLeft, "barDockControlLeft");
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Manager = this.barManager1;
            // 
            // barDockControlRight
            // 
            resources.ApplyResources(this.barDockControlRight, "barDockControlRight");
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Manager = this.barManager1;
            // 
            // frm_Master
            // 
            resources.ApplyResources(this, "$this");
            this.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.None;
            this.KeyPreview = true;
            this.Name = "frm_Master";
            this.Load += new System.EventHandler(this.frm_Master_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_Master_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar_1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        public DevExpress.XtraBars.BarButtonItem btn_Save;
        public DevExpress.XtraBars.BarButtonItem btn_New;
        public DevExpress.XtraBars.BarButtonItem btn_Delete;
        public DevExpress.XtraBars.BarButtonItem btn_Print;
        public DevExpress.XtraBars.BarButtonItem btn_Search;
    }
}