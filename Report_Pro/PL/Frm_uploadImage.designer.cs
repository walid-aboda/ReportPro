namespace Report_Pro.PL
{
    partial class Frm_uploadImage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_uploadImage));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.ribbonBar1 = new DevComponents.DotNetBar.RibbonBar();
            this.BNew = new DevComponents.DotNetBar.ButtonItem();
            this.btnAddFromScan = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem1 = new DevComponents.DotNetBar.ButtonItem();
            this.BSave = new DevComponents.DotNetBar.ButtonItem();
            this.btnEdle = new DevComponents.DotNetBar.ButtonItem();
            this.BExit = new DevComponents.DotNetBar.ButtonItem();
            this.tabControl1 = new DevComponents.DotNetBar.TabControl();
            this.tabControlPanel1 = new DevComponents.DotNetBar.TabControlPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabItem1 = new DevComponents.DotNetBar.TabItem(this.components);
            this.tabControlPanel3 = new DevComponents.DotNetBar.TabControlPanel();
            this.dgv2 = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabItem3 = new DevComponents.DotNetBar.TabItem(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tabControl1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabControlPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControlPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv2)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "background1.jpg");
            this.imageList1.Images.SetKeyName(1, "background2.jpg");
            this.imageList1.Images.SetKeyName(2, "adope_image.jpg");
            // 
            // ribbonBar1
            // 
            this.ribbonBar1.AutoOverflowEnabled = true;
            this.ribbonBar1.AutoSizeItems = false;
            this.ribbonBar1.ContainerControlProcessDialogKey = true;
            this.ribbonBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ribbonBar1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ribbonBar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.BNew,
            this.btnAddFromScan,
            this.buttonItem1,
            this.BSave,
            this.btnEdle,
            this.BExit});
            this.ribbonBar1.Location = new System.Drawing.Point(0, 0);
            this.ribbonBar1.Margin = new System.Windows.Forms.Padding(4);
            this.ribbonBar1.Name = "ribbonBar1";
            this.ribbonBar1.Size = new System.Drawing.Size(1168, 41);
            this.ribbonBar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.ribbonBar1.TabIndex = 0;
            this.ribbonBar1.Text = "ribbonBar1";
            this.ribbonBar1.TitleVisible = false;
            // 
            // BNew
            // 
            this.BNew.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.BNew.Image = global::Report_Pro.Properties.Resources.Attachment_icon1;
            this.BNew.ImageFixedSize = new System.Drawing.Size(24, 24);
            this.BNew.Name = "BNew";
            this.BNew.SubItemsExpandWidth = 14;
            this.BNew.Text = "اضافة مرفق";
            this.BNew.Click += new System.EventHandler(this.BNew_Click);
            // 
            // btnAddFromScan
            // 
            this.btnAddFromScan.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnAddFromScan.Image = global::Report_Pro.Properties.Resources.iconfinder_attachment_3671672;
            this.btnAddFromScan.ItemAlignment = DevComponents.DotNetBar.eItemAlignment.Far;
            this.btnAddFromScan.Name = "btnAddFromScan";
            this.btnAddFromScan.RibbonWordWrap = false;
            this.btnAddFromScan.SubItemsExpandWidth = 14;
            this.btnAddFromScan.Text = "اضافة مرفق من الماسح";
            this.btnAddFromScan.Click += new System.EventHandler(this.btnAddFromScan_Click);
            // 
            // buttonItem1
            // 
            this.buttonItem1.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem1.Image = global::Report_Pro.Properties.Resources.scanner_icon;
            this.buttonItem1.ImageFixedSize = new System.Drawing.Size(24, 24);
            this.buttonItem1.ItemAlignment = DevComponents.DotNetBar.eItemAlignment.Far;
            this.buttonItem1.Name = "buttonItem1";
            this.buttonItem1.RibbonWordWrap = false;
            this.buttonItem1.SubItemsExpandWidth = 14;
            this.buttonItem1.Text = "تحديد الماسح";
            this.buttonItem1.Click += new System.EventHandler(this.buttonItem1_Click);
            // 
            // BSave
            // 
            this.BSave.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.BSave.Image = global::Report_Pro.Properties.Resources.save_Icon;
            this.BSave.Name = "BSave";
            this.BSave.SubItemsExpandWidth = 14;
            this.BSave.Text = "حفظ";
            this.BSave.Click += new System.EventHandler(this.BSave_Click);
            // 
            // btnEdle
            // 
            this.btnEdle.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnEdle.Image = global::Report_Pro.Properties.Resources.deleteAttach_icon;
            this.btnEdle.Name = "btnEdle";
            this.btnEdle.SubItemsExpandWidth = 14;
            this.btnEdle.Text = "حذف";
            this.btnEdle.Click += new System.EventHandler(this.btnEdle_Click);
            // 
            // BExit
            // 
            this.BExit.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.BExit.Image = global::Report_Pro.Properties.Resources.logout;
            this.BExit.ItemAlignment = DevComponents.DotNetBar.eItemAlignment.Far;
            this.BExit.Name = "BExit";
            this.BExit.RibbonWordWrap = false;
            this.BExit.SubItemsExpandWidth = 14;
            this.BExit.Text = "خروج";
            this.BExit.Click += new System.EventHandler(this.BExit_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tabControl1.CanReorderTabs = true;
            this.tabControl1.Controls.Add(this.tabControlPanel1);
            this.tabControl1.Controls.Add(this.tabControlPanel3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 41);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedTabFont = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.tabControl1.SelectedTabIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1168, 391);
            this.tabControl1.Style = DevComponents.DotNetBar.eTabStripStyle.Office2007Document;
            this.tabControl1.TabIndex = 13;
            this.tabControl1.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.FixedWithNavigationBox;
            this.tabControl1.Tabs.Add(this.tabItem1);
            this.tabControl1.Tabs.Add(this.tabItem3);
            this.tabControl1.Text = "tabControl1";
            // 
            // tabControlPanel1
            // 
            this.tabControlPanel1.Controls.Add(this.dataGridView1);
            this.tabControlPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPanel1.Location = new System.Drawing.Point(0, 29);
            this.tabControlPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tabControlPanel1.Name = "tabControlPanel1";
            this.tabControlPanel1.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tabControlPanel1.Size = new System.Drawing.Size(1168, 362);
            this.tabControlPanel1.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(254)))));
            this.tabControlPanel1.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(188)))), ((int)(((byte)(227)))));
            this.tabControlPanel1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tabControlPanel1.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(165)))), ((int)(((byte)(199)))));
            this.tabControlPanel1.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right) 
            | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tabControlPanel1.Style.GradientAngle = 90;
            this.tabControlPanel1.TabIndex = 1;
            this.tabControlPanel1.TabItem = this.tabItem1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(2, 1);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1164, 360);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // tabItem1
            // 
            this.tabItem1.AttachedControl = this.tabControlPanel1;
            this.tabItem1.Name = "tabItem1";
            this.tabItem1.Text = "عرض المرفقات";
            // 
            // tabControlPanel3
            // 
            this.tabControlPanel3.Controls.Add(this.dgv2);
            this.tabControlPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPanel3.Location = new System.Drawing.Point(0, 29);
            this.tabControlPanel3.Margin = new System.Windows.Forms.Padding(4);
            this.tabControlPanel3.Name = "tabControlPanel3";
            this.tabControlPanel3.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tabControlPanel3.Size = new System.Drawing.Size(1168, 362);
            this.tabControlPanel3.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(254)))));
            this.tabControlPanel3.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(188)))), ((int)(((byte)(227)))));
            this.tabControlPanel3.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tabControlPanel3.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(165)))), ((int)(((byte)(199)))));
            this.tabControlPanel3.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right) 
            | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tabControlPanel3.Style.GradientAngle = 90;
            this.tabControlPanel3.TabIndex = 3;
            this.tabControlPanel3.TabItem = this.tabItem3;
            // 
            // dgv2
            // 
            this.dgv2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv2.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgv2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv2.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgv2.Location = new System.Drawing.Point(2, 1);
            this.dgv2.Margin = new System.Windows.Forms.Padding(4);
            this.dgv2.Name = "dgv2";
            this.dgv2.Size = new System.Drawing.Size(1164, 360);
            this.dgv2.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "مسار الملف";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 450;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "اسم الملف";
            this.Column2.Name = "Column2";
            this.Column2.Width = 120;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "نوع الملف";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 80;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "اسم الجهاز";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 80;
            // 
            // tabItem3
            // 
            this.tabItem3.AttachedControl = this.tabControlPanel3;
            this.tabItem3.Name = "tabItem3";
            this.tabItem3.Text = "تحميل المرفقات";
            // 
            // Frm_uploadImage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1168, 432);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.ribbonBar1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frm_uploadImage";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "تحميل المرفقات الي قاعدة البيانات";
            this.Load += new System.EventHandler(this.Frm_uploadImage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabControl1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabControlPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControlPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList imageList1;
        private DevComponents.DotNetBar.RibbonBar ribbonBar1;
        private DevComponents.DotNetBar.ButtonItem BNew;
        private DevComponents.DotNetBar.ButtonItem BSave;
        private DevComponents.DotNetBar.ButtonItem BExit;
        private DevComponents.DotNetBar.TabControl tabControl1;
        private DevComponents.DotNetBar.TabControlPanel tabControlPanel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DevComponents.DotNetBar.TabItem tabItem1;
        private DevComponents.DotNetBar.TabControlPanel tabControlPanel3;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgv2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private DevComponents.DotNetBar.TabItem tabItem3;
        private DevComponents.DotNetBar.ButtonItem btnAddFromScan;
        private DevComponents.DotNetBar.ButtonItem buttonItem1;
        private DevComponents.DotNetBar.ButtonItem btnEdle;
    }
}