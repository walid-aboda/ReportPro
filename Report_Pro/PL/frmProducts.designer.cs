namespace Report_Pro.PL
{
    partial class frmProducts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProducts));
            this.ribbonBar1 = new DevComponents.DotNetBar.RibbonBar();
            this.BNew = new DevComponents.DotNetBar.ButtonItem();
            this.BSave = new DevComponents.DotNetBar.ButtonItem();
            this.BEdit = new DevComponents.DotNetBar.ButtonItem();
            this.BSearch = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem1 = new DevComponents.DotNetBar.ButtonItem();
            this.BtnEmail = new DevComponents.DotNetBar.ButtonItem();
            this.BtnAttache = new DevComponents.DotNetBar.ButtonItem();
            this.BtnCalc = new DevComponents.DotNetBar.ButtonItem();
            this.BExit = new DevComponents.DotNetBar.ButtonItem();
            this.print_sand = new DevComponents.DotNetBar.ButtonItem();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.textBoxX5 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtCode = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX9 = new DevComponents.DotNetBar.LabelX();
            this.labelX8 = new DevComponents.DotNetBar.LabelX();
            this.comboBoxEx2 = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboBoxEx1 = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.textBoxX4 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.textBoxX3 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.textBoxX2 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.textBoxX1 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.tabControl1 = new DevComponents.DotNetBar.TabControl();
            this.tabItem1 = new DevComponents.DotNetBar.TabItem(this.components);
            this.tabControlPanel1 = new DevComponents.DotNetBar.TabControlPanel();
            this.tabItem2 = new DevComponents.DotNetBar.TabItem(this.components);
            this.tabControlPanel2 = new DevComponents.DotNetBar.TabControlPanel();
            this.tabItem3 = new DevComponents.DotNetBar.TabItem(this.components);
            this.tabControlPanel3 = new DevComponents.DotNetBar.TabControlPanel();
            this.uc_Group1 = new Report_Pro.MyControls.Uc_Group();
            this.groupPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabControl1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbonBar1
            // 
            this.ribbonBar1.AutoOverflowEnabled = true;
            this.ribbonBar1.ContainerControlProcessDialogKey = true;
            this.ribbonBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ribbonBar1.Font = new System.Drawing.Font("Tahoma", 9F);
            this.ribbonBar1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ribbonBar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.BNew,
            this.BSave,
            this.BEdit,
            this.BSearch,
            this.buttonItem1,
            this.BtnEmail,
            this.BtnAttache,
            this.BtnCalc,
            this.BExit,
            this.print_sand});
            this.ribbonBar1.Location = new System.Drawing.Point(0, 0);
            this.ribbonBar1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ribbonBar1.Name = "ribbonBar1";
            this.ribbonBar1.Size = new System.Drawing.Size(1293, 43);
            this.ribbonBar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.ribbonBar1.TabIndex = 103;
            this.ribbonBar1.Text = "ribbonBar1";
            this.ribbonBar1.TitleVisible = false;
            // 
            // BNew
            // 
            this.BNew.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.BNew.Image = ((System.Drawing.Image)(resources.GetObject("BNew.Image")));
            this.BNew.ImagePaddingHorizontal = 15;
            this.BNew.Name = "BNew";
            this.BNew.SubItemsExpandWidth = 14;
            this.BNew.Text = "جديد";
            // 
            // BSave
            // 
            this.BSave.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.BSave.Image = ((System.Drawing.Image)(resources.GetObject("BSave.Image")));
            this.BSave.ImagePaddingHorizontal = 15;
            this.BSave.Name = "BSave";
            this.BSave.SubItemsExpandWidth = 14;
            this.BSave.Text = "حفظ";
            // 
            // BEdit
            // 
            this.BEdit.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.BEdit.Enabled = false;
            this.BEdit.FontBold = true;
            this.BEdit.Image = ((System.Drawing.Image)(resources.GetObject("BEdit.Image")));
            this.BEdit.ImagePaddingHorizontal = 15;
            this.BEdit.Name = "BEdit";
            this.BEdit.SubItemsExpandWidth = 14;
            this.BEdit.Text = "تعديل";
            // 
            // BSearch
            // 
            this.BSearch.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.BSearch.Image = ((System.Drawing.Image)(resources.GetObject("BSearch.Image")));
            this.BSearch.ImagePaddingHorizontal = 15;
            this.BSearch.Name = "BSearch";
            this.BSearch.SubItemsExpandWidth = 14;
            this.BSearch.Text = "بحث";
            // 
            // buttonItem1
            // 
            this.buttonItem1.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem1.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem1.Image")));
            this.buttonItem1.ImagePaddingHorizontal = 15;
            this.buttonItem1.Name = "buttonItem1";
            this.buttonItem1.SubItemsExpandWidth = 14;
            this.buttonItem1.Text = "طباعة";
            // 
            // BtnEmail
            // 
            this.BtnEmail.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.BtnEmail.Image = ((System.Drawing.Image)(resources.GetObject("BtnEmail.Image")));
            this.BtnEmail.ImagePaddingHorizontal = 15;
            this.BtnEmail.Name = "BtnEmail";
            this.BtnEmail.SubItemsExpandWidth = 14;
            this.BtnEmail.Text = "ارسال بالبريد";
            // 
            // BtnAttache
            // 
            this.BtnAttache.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.BtnAttache.Image = ((System.Drawing.Image)(resources.GetObject("BtnAttache.Image")));
            this.BtnAttache.ImagePaddingHorizontal = 15;
            this.BtnAttache.Name = "BtnAttache";
            this.BtnAttache.SubItemsExpandWidth = 14;
            this.BtnAttache.Text = "المرفقات";
            // 
            // BtnCalc
            // 
            this.BtnCalc.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.BtnCalc.Image = ((System.Drawing.Image)(resources.GetObject("BtnCalc.Image")));
            this.BtnCalc.ImagePaddingHorizontal = 15;
            this.BtnCalc.Name = "BtnCalc";
            this.BtnCalc.SubItemsExpandWidth = 14;
            this.BtnCalc.Text = "الحاسبة";
            // 
            // BExit
            // 
            this.BExit.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.BExit.Image = ((System.Drawing.Image)(resources.GetObject("BExit.Image")));
            this.BExit.ImagePaddingHorizontal = 15;
            this.BExit.ItemAlignment = DevComponents.DotNetBar.eItemAlignment.Far;
            this.BExit.Name = "BExit";
            this.BExit.RibbonWordWrap = false;
            this.BExit.SubItemsExpandWidth = 14;
            this.BExit.Text = "خروج";
            // 
            // print_sand
            // 
            this.print_sand.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.print_sand.Image = ((System.Drawing.Image)(resources.GetObject("print_sand.Image")));
            this.print_sand.ImagePaddingHorizontal = 15;
            this.print_sand.Name = "print_sand";
            this.print_sand.SubItemsExpandWidth = 14;
            this.print_sand.Text = "طباعة السند";
            // 
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.textBoxX5);
            this.groupPanel1.Controls.Add(this.txtCode);
            this.groupPanel1.Controls.Add(this.labelX9);
            this.groupPanel1.Controls.Add(this.labelX8);
            this.groupPanel1.Controls.Add(this.comboBoxEx2);
            this.groupPanel1.Controls.Add(this.comboBoxEx1);
            this.groupPanel1.Controls.Add(this.textBoxX4);
            this.groupPanel1.Controls.Add(this.labelX6);
            this.groupPanel1.Controls.Add(this.labelX7);
            this.groupPanel1.Controls.Add(this.labelX5);
            this.groupPanel1.Controls.Add(this.uc_Group1);
            this.groupPanel1.Controls.Add(this.textBoxX3);
            this.groupPanel1.Controls.Add(this.labelX4);
            this.groupPanel1.Controls.Add(this.textBoxX2);
            this.groupPanel1.Controls.Add(this.labelX3);
            this.groupPanel1.Controls.Add(this.textBoxX1);
            this.groupPanel1.Controls.Add(this.labelX2);
            this.groupPanel1.Controls.Add(this.labelX1);
            this.groupPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupPanel1.Location = new System.Drawing.Point(0, 43);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(1293, 267);
            // 
            // 
            // 
            this.groupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel1.Style.BackColorGradientAngle = 90;
            this.groupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderBottomWidth = 1;
            this.groupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderLeftWidth = 1;
            this.groupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderRightWidth = 1;
            this.groupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderTopWidth = 1;
            this.groupPanel1.Style.CornerDiameter = 4;
            this.groupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            this.groupPanel1.TabIndex = 104;
            // 
            // textBoxX5
            // 
            // 
            // 
            // 
            this.textBoxX5.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.textBoxX5.Border.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(130)))), ((int)(((byte)(132)))));
            this.textBoxX5.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.textBoxX5.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.textBoxX5.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.textBoxX5.Border.Class = "TextBoxBorder";
            this.textBoxX5.Location = new System.Drawing.Point(119, 175);
            this.textBoxX5.Name = "textBoxX5";
            this.textBoxX5.Size = new System.Drawing.Size(200, 27);
            this.textBoxX5.TabIndex = 19;
            // 
            // txtCode
            // 
            // 
            // 
            // 
            this.txtCode.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtCode.Border.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(130)))), ((int)(((byte)(132)))));
            this.txtCode.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtCode.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtCode.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtCode.Border.Class = "TextBoxBorder";
            this.txtCode.Location = new System.Drawing.Point(119, 41);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(203, 27);
            this.txtCode.TabIndex = 18;
            // 
            // labelX9
            // 
            this.labelX9.AutoSize = true;
            this.labelX9.BackColor = System.Drawing.Color.Transparent;
            this.labelX9.Location = new System.Drawing.Point(15, 211);
            this.labelX9.Name = "labelX9";
            this.labelX9.Size = new System.Drawing.Size(98, 22);
            this.labelX9.TabIndex = 17;
            this.labelX9.Text = "Dim Category";
            // 
            // labelX8
            // 
            this.labelX8.AutoSize = true;
            this.labelX8.BackColor = System.Drawing.Color.Transparent;
            this.labelX8.Location = new System.Drawing.Point(328, 211);
            this.labelX8.Name = "labelX8";
            this.labelX8.Size = new System.Drawing.Size(66, 22);
            this.labelX8.TabIndex = 16;
            this.labelX8.Text = "Category";
            // 
            // comboBoxEx2
            // 
            this.comboBoxEx2.DisplayMember = "Text";
            this.comboBoxEx2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxEx2.FormattingEnabled = true;
            this.comboBoxEx2.ItemHeight = 21;
            this.comboBoxEx2.Location = new System.Drawing.Point(399, 209);
            this.comboBoxEx2.Name = "comboBoxEx2";
            this.comboBoxEx2.Size = new System.Drawing.Size(200, 27);
            this.comboBoxEx2.TabIndex = 15;
            // 
            // comboBoxEx1
            // 
            this.comboBoxEx1.DisplayMember = "Text";
            this.comboBoxEx1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxEx1.FormattingEnabled = true;
            this.comboBoxEx1.ItemHeight = 21;
            this.comboBoxEx1.Location = new System.Drawing.Point(119, 209);
            this.comboBoxEx1.Name = "comboBoxEx1";
            this.comboBoxEx1.Size = new System.Drawing.Size(200, 27);
            this.comboBoxEx1.TabIndex = 14;
            // 
            // textBoxX4
            // 
            // 
            // 
            // 
            this.textBoxX4.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.textBoxX4.Border.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(130)))), ((int)(((byte)(132)))));
            this.textBoxX4.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.textBoxX4.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.textBoxX4.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.textBoxX4.Border.Class = "TextBoxBorder";
            this.textBoxX4.Location = new System.Drawing.Point(399, 175);
            this.textBoxX4.Name = "textBoxX4";
            this.textBoxX4.Size = new System.Drawing.Size(200, 27);
            this.textBoxX4.TabIndex = 13;
            // 
            // labelX6
            // 
            this.labelX6.AutoSize = true;
            this.labelX6.BackColor = System.Drawing.Color.Transparent;
            this.labelX6.Location = new System.Drawing.Point(357, 177);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(37, 22);
            this.labelX6.TabIndex = 12;
            this.labelX6.Text = "Style";
            // 
            // labelX7
            // 
            this.labelX7.AutoSize = true;
            this.labelX7.BackColor = System.Drawing.Color.Transparent;
            this.labelX7.Location = new System.Drawing.Point(70, 177);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(44, 22);
            this.labelX7.TabIndex = 10;
            this.labelX7.Text = "Brand";
            // 
            // labelX5
            // 
            this.labelX5.AutoSize = true;
            this.labelX5.BackColor = System.Drawing.Color.Transparent;
            this.labelX5.Location = new System.Drawing.Point(69, 141);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(45, 22);
            this.labelX5.TabIndex = 9;
            this.labelX5.Text = "Group";
            // 
            // textBoxX3
            // 
            // 
            // 
            // 
            this.textBoxX3.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.textBoxX3.Border.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(130)))), ((int)(((byte)(132)))));
            this.textBoxX3.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.textBoxX3.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.textBoxX3.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.textBoxX3.Border.Class = "TextBoxBorder";
            this.textBoxX3.Location = new System.Drawing.Point(119, 107);
            this.textBoxX3.Name = "textBoxX3";
            this.textBoxX3.Size = new System.Drawing.Size(480, 27);
            this.textBoxX3.TabIndex = 7;
            // 
            // labelX4
            // 
            this.labelX4.AutoSize = true;
            this.labelX4.BackColor = System.Drawing.Color.Transparent;
            this.labelX4.Location = new System.Drawing.Point(31, 109);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(83, 22);
            this.labelX4.TabIndex = 6;
            this.labelX4.Text = "Latin Name";
            // 
            // textBoxX2
            // 
            // 
            // 
            // 
            this.textBoxX2.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.textBoxX2.Border.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(130)))), ((int)(((byte)(132)))));
            this.textBoxX2.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.textBoxX2.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.textBoxX2.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.textBoxX2.Border.Class = "TextBoxBorder";
            this.textBoxX2.Location = new System.Drawing.Point(119, 74);
            this.textBoxX2.Name = "textBoxX2";
            this.textBoxX2.Size = new System.Drawing.Size(480, 27);
            this.textBoxX2.TabIndex = 5;
            // 
            // labelX3
            // 
            this.labelX3.AutoSize = true;
            this.labelX3.BackColor = System.Drawing.Color.Transparent;
            this.labelX3.Location = new System.Drawing.Point(22, 76);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(92, 22);
            this.labelX3.TabIndex = 4;
            this.labelX3.Text = "Arabic Name";
            // 
            // textBoxX1
            // 
            // 
            // 
            // 
            this.textBoxX1.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.textBoxX1.Border.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(130)))), ((int)(((byte)(132)))));
            this.textBoxX1.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.textBoxX1.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.textBoxX1.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.textBoxX1.Border.Class = "TextBoxBorder";
            this.textBoxX1.Location = new System.Drawing.Point(396, 41);
            this.textBoxX1.Name = "textBoxX1";
            this.textBoxX1.Size = new System.Drawing.Size(203, 27);
            this.textBoxX1.TabIndex = 3;
            // 
            // labelX2
            // 
            this.labelX2.AutoSize = true;
            this.labelX2.BackColor = System.Drawing.Color.Transparent;
            this.labelX2.Location = new System.Drawing.Point(329, 43);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(62, 22);
            this.labelX2.TabIndex = 2;
            this.labelX2.Text = "BarCode";
            // 
            // labelX1
            // 
            this.labelX1.AutoSize = true;
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            this.labelX1.Location = new System.Drawing.Point(77, 43);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(38, 22);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "Code";
            // 
            // tabControl1
            // 
            this.tabControl1.CanReorderTabs = true;
            this.tabControl1.Controls.Add(this.tabControlPanel1);
            this.tabControl1.Controls.Add(this.tabControlPanel2);
            this.tabControl1.Controls.Add(this.tabControlPanel3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.Location = new System.Drawing.Point(0, 310);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedTabFont = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.tabControl1.SelectedTabIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1293, 264);
            this.tabControl1.TabIndex = 105;
            this.tabControl1.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.FixedWithNavigationBox;
            this.tabControl1.Tabs.Add(this.tabItem1);
            this.tabControl1.Tabs.Add(this.tabItem2);
            this.tabControl1.Tabs.Add(this.tabItem3);
            this.tabControl1.Text = "tabControl1";
            // 
            // tabItem1
            // 
            this.tabItem1.AttachedControl = this.tabControlPanel1;
            this.tabItem1.Name = "tabItem1";
            this.tabItem1.Text = "Specifications";
            // 
            // tabControlPanel1
            // 
            this.tabControlPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPanel1.Location = new System.Drawing.Point(0, 30);
            this.tabControlPanel1.Name = "tabControlPanel1";
            this.tabControlPanel1.Padding = new System.Windows.Forms.Padding(1);
            this.tabControlPanel1.Size = new System.Drawing.Size(1293, 234);
            this.tabControlPanel1.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(179)))), ((int)(((byte)(231)))));
            this.tabControlPanel1.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
            this.tabControlPanel1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tabControlPanel1.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(156)))));
            this.tabControlPanel1.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right) 
            | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tabControlPanel1.Style.GradientAngle = 90;
            this.tabControlPanel1.TabIndex = 1;
            this.tabControlPanel1.TabItem = this.tabItem1;
            // 
            // tabItem2
            // 
            this.tabItem2.AttachedControl = this.tabControlPanel2;
            this.tabItem2.Name = "tabItem2";
            this.tabItem2.Text = "Units";
            // 
            // tabControlPanel2
            // 
            this.tabControlPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPanel2.Location = new System.Drawing.Point(0, 30);
            this.tabControlPanel2.Name = "tabControlPanel2";
            this.tabControlPanel2.Padding = new System.Windows.Forms.Padding(1);
            this.tabControlPanel2.Size = new System.Drawing.Size(1293, 234);
            this.tabControlPanel2.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(179)))), ((int)(((byte)(231)))));
            this.tabControlPanel2.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
            this.tabControlPanel2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tabControlPanel2.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(156)))));
            this.tabControlPanel2.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right) 
            | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tabControlPanel2.Style.GradientAngle = 90;
            this.tabControlPanel2.TabIndex = 2;
            this.tabControlPanel2.TabItem = this.tabItem2;
            // 
            // tabItem3
            // 
            this.tabItem3.AttachedControl = this.tabControlPanel3;
            this.tabItem3.Name = "tabItem3";
            this.tabItem3.Text = "tabItem3";
            // 
            // tabControlPanel3
            // 
            this.tabControlPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPanel3.Location = new System.Drawing.Point(0, 30);
            this.tabControlPanel3.Name = "tabControlPanel3";
            this.tabControlPanel3.Padding = new System.Windows.Forms.Padding(1);
            this.tabControlPanel3.Size = new System.Drawing.Size(1293, 234);
            this.tabControlPanel3.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(179)))), ((int)(((byte)(231)))));
            this.tabControlPanel3.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
            this.tabControlPanel3.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tabControlPanel3.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(156)))));
            this.tabControlPanel3.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right) 
            | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tabControlPanel3.Style.GradientAngle = 90;
            this.tabControlPanel3.TabIndex = 3;
            this.tabControlPanel3.TabItem = this.tabItem3;
            // 
            // uc_Group1
            // 
            this.uc_Group1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.uc_Group1.Location = new System.Drawing.Point(119, 140);
            this.uc_Group1.Margin = new System.Windows.Forms.Padding(0);
            this.uc_Group1.Name = "uc_Group1";
            this.uc_Group1.Size = new System.Drawing.Size(480, 29);
            this.uc_Group1.TabIndex = 8;
            // 
            // frmProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1293, 572);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupPanel1);
            this.Controls.Add(this.ribbonBar1);
            this.Name = "frmProducts";
            this.Text = "frmProducts";
            this.groupPanel1.ResumeLayout(false);
            this.groupPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabControl1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.RibbonBar ribbonBar1;
        private DevComponents.DotNetBar.ButtonItem BNew;
        private DevComponents.DotNetBar.ButtonItem BSave;
        private DevComponents.DotNetBar.ButtonItem BEdit;
        private DevComponents.DotNetBar.ButtonItem BSearch;
        private DevComponents.DotNetBar.ButtonItem buttonItem1;
        private DevComponents.DotNetBar.ButtonItem BtnEmail;
        private DevComponents.DotNetBar.ButtonItem BtnAttache;
        private DevComponents.DotNetBar.ButtonItem BtnCalc;
        private DevComponents.DotNetBar.ButtonItem BExit;
        private DevComponents.DotNetBar.ButtonItem print_sand;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxX5;
        private DevComponents.DotNetBar.Controls.TextBoxX txtCode;
        private DevComponents.DotNetBar.LabelX labelX9;
        private DevComponents.DotNetBar.LabelX labelX8;
        private DevComponents.DotNetBar.Controls.ComboBoxEx comboBoxEx2;
        private DevComponents.DotNetBar.Controls.ComboBoxEx comboBoxEx1;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxX4;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.DotNetBar.LabelX labelX5;
        private MyControls.Uc_Group uc_Group1;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxX3;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxX2;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxX1;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.TabControl tabControl1;
        private DevComponents.DotNetBar.TabControlPanel tabControlPanel1;
        private DevComponents.DotNetBar.TabItem tabItem1;
        private DevComponents.DotNetBar.TabControlPanel tabControlPanel2;
        private DevComponents.DotNetBar.TabItem tabItem2;
        private DevComponents.DotNetBar.TabControlPanel tabControlPanel3;
        private DevComponents.DotNetBar.TabItem tabItem3;
    }
}