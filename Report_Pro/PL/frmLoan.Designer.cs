namespace Report_Pro.PL
{
    partial class frmLoan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLoan));
            this.ribbonBar1 = new DevComponents.DotNetBar.RibbonBar();
            this.BNew = new DevComponents.DotNetBar.ButtonItem();
            this.BSave = new DevComponents.DotNetBar.ButtonItem();
            this.BEdit = new DevComponents.DotNetBar.ButtonItem();
            this.BSearch = new DevComponents.DotNetBar.ButtonItem();
            this.BExit = new DevComponents.DotNetBar.ButtonItem();
            this.btnStatment = new DevComponents.DotNetBar.ButtonItem();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.BName = new Report_Pro.MyControls.UC_Acc();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.loanPanel = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.label27 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLoanId = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtIntrestRate = new DevComponents.Editors.DoubleInput();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.txtLoanRefrance = new System.Windows.Forms.TextBox();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.NoOfPayments = new DevComponents.Editors.IntegerInput();
            this.txtLoanPurpose = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtLoanAcc = new Report_Pro.MyControls.UC_Acc();
            this.txtLoanNo = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtLoanValue = new DevComponents.Editors.DoubleInput();
            this.panel1.SuspendLayout();
            this.loanPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtIntrestRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NoOfPayments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLoanValue)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonBar1
            // 
            this.ribbonBar1.AutoOverflowEnabled = true;
            this.ribbonBar1.AutoSizeItems = false;
            this.ribbonBar1.ContainerControlProcessDialogKey = true;
            resources.ApplyResources(this.ribbonBar1, "ribbonBar1");
            this.ribbonBar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.BNew,
            this.BSave,
            this.BEdit,
            this.BSearch,
            this.BExit,
            this.btnStatment});
            this.ribbonBar1.Name = "ribbonBar1";
            this.ribbonBar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.ribbonBar1.TitleVisible = false;
            // 
            // BNew
            // 
            this.BNew.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.BNew.Image = global::Report_Pro.Properties.Resources.Add_Icon;
            this.BNew.Name = "BNew";
            this.BNew.SubItemsExpandWidth = 14;
            resources.ApplyResources(this.BNew, "BNew");
            // 
            // BSave
            // 
            this.BSave.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.BSave.Image = global::Report_Pro.Properties.Resources.save_Icon;
            this.BSave.Name = "BSave";
            this.BSave.SubItemsExpandWidth = 14;
            resources.ApplyResources(this.BSave, "BSave");
            this.BSave.Click += new System.EventHandler(this.BSave_Click);
            // 
            // BEdit
            // 
            this.BEdit.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.BEdit.Image = global::Report_Pro.Properties.Resources.update1;
            this.BEdit.Name = "BEdit";
            this.BEdit.SubItemsExpandWidth = 14;
            resources.ApplyResources(this.BEdit, "BEdit");
            // 
            // BSearch
            // 
            this.BSearch.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.BSearch.Image = global::Report_Pro.Properties.Resources.Search_icon1;
            this.BSearch.Name = "BSearch";
            this.BSearch.SubItemsExpandWidth = 14;
            resources.ApplyResources(this.BSearch, "BSearch");
            this.BSearch.Click += new System.EventHandler(this.BSearch_Click);
            // 
            // BExit
            // 
            this.BExit.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.BExit.Image = global::Report_Pro.Properties.Resources.Exit_icon;
            this.BExit.Name = "BExit";
            resources.ApplyResources(this.BExit, "BExit");
            this.BExit.SubItemsExpandWidth = 14;
            // 
            // btnStatment
            // 
            this.btnStatment.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnStatment.Image = global::Report_Pro.Properties.Resources.Reports2;
            this.btnStatment.ImageFixedSize = new System.Drawing.Size(16, 16);
            this.btnStatment.Name = "btnStatment";
            this.btnStatment.SubItemsExpandWidth = 14;
            resources.ApplyResources(this.btnStatment, "btnStatment");
            // 
            // flowLayoutPanel1
            // 
            resources.ApplyResources(this.flowLayoutPanel1, "flowLayoutPanel1");
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label1.Name = "label1";
            // 
            // BName
            // 
            this.BName.BackColor = System.Drawing.Color.Transparent;
            this.BName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            resources.ApplyResources(this.BName, "BName");
            this.BName.Name = "BName";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label9.Name = "label9";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label2.Name = "label2";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.loanPanel);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // loanPanel
            // 
            this.loanPanel.CanvasColor = System.Drawing.SystemColors.Control;
            this.loanPanel.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.loanPanel.Controls.Add(this.label27);
            this.loanPanel.Controls.Add(this.label26);
            this.loanPanel.Controls.Add(this.label25);
            this.loanPanel.Controls.Add(this.label24);
            this.loanPanel.Controls.Add(this.label23);
            this.loanPanel.Controls.Add(this.label3);
            this.loanPanel.Controls.Add(this.txtLoanId);
            this.loanPanel.Controls.Add(this.txtIntrestRate);
            this.loanPanel.Controls.Add(this.labelX5);
            this.loanPanel.Controls.Add(this.txtLoanRefrance);
            this.loanPanel.Controls.Add(this.labelX4);
            this.loanPanel.Controls.Add(this.NoOfPayments);
            this.loanPanel.Controls.Add(this.flowLayoutPanel1);
            this.loanPanel.Controls.Add(this.label1);
            this.loanPanel.Controls.Add(this.txtLoanPurpose);
            this.loanPanel.Controls.Add(this.label2);
            this.loanPanel.Controls.Add(this.label11);
            this.loanPanel.Controls.Add(this.label12);
            this.loanPanel.Controls.Add(this.label13);
            this.loanPanel.Controls.Add(this.txtLoanAcc);
            this.loanPanel.Controls.Add(this.txtLoanNo);
            this.loanPanel.Controls.Add(this.txtLoanValue);
            this.loanPanel.Controls.Add(this.BName);
            this.loanPanel.Controls.Add(this.label9);
            resources.ApplyResources(this.loanPanel, "loanPanel");
            this.loanPanel.Name = "loanPanel";
            // 
            // 
            // 
            this.loanPanel.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.loanPanel.Style.BackColorGradientAngle = 90;
            this.loanPanel.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.loanPanel.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.loanPanel.Style.BorderBottomWidth = 1;
            this.loanPanel.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.loanPanel.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.loanPanel.Style.BorderLeftWidth = 1;
            this.loanPanel.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.loanPanel.Style.BorderRightWidth = 1;
            this.loanPanel.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.loanPanel.Style.BorderTopWidth = 1;
            this.loanPanel.Style.CornerDiameter = 4;
            this.loanPanel.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.loanPanel.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.loanPanel.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.loanPanel.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            this.loanPanel.TabStop = true;
            // 
            // label27
            // 
            this.label27.BackColor = System.Drawing.Color.Navy;
            this.label27.ForeColor = System.Drawing.SystemColors.Window;
            resources.ApplyResources(this.label27, "label27");
            this.label27.Name = "label27";
            // 
            // label26
            // 
            this.label26.BackColor = System.Drawing.Color.Navy;
            this.label26.ForeColor = System.Drawing.SystemColors.Window;
            resources.ApplyResources(this.label26, "label26");
            this.label26.Name = "label26";
            // 
            // label25
            // 
            this.label25.BackColor = System.Drawing.Color.Navy;
            this.label25.ForeColor = System.Drawing.SystemColors.Window;
            resources.ApplyResources(this.label25, "label25");
            this.label25.Name = "label25";
            // 
            // label24
            // 
            this.label24.BackColor = System.Drawing.Color.Navy;
            this.label24.ForeColor = System.Drawing.SystemColors.Window;
            resources.ApplyResources(this.label24, "label24");
            this.label24.Name = "label24";
            // 
            // label23
            // 
            this.label23.BackColor = System.Drawing.Color.Navy;
            this.label23.ForeColor = System.Drawing.SystemColors.Window;
            resources.ApplyResources(this.label23, "label23");
            this.label23.Name = "label23";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label3.Name = "label3";
            // 
            // txtLoanId
            // 
            // 
            // 
            // 
            this.txtLoanId.Border.Class = "TextBoxBorder";
            resources.ApplyResources(this.txtLoanId, "txtLoanId");
            this.txtLoanId.Name = "txtLoanId";
            this.txtLoanId.TextChanged += new System.EventHandler(this.txtLoanId_TextChanged);
            // 
            // txtIntrestRate
            // 
            // 
            // 
            // 
            this.txtIntrestRate.BackgroundStyle.Class = "DateTimeInputBackground";
            this.txtIntrestRate.BackgroundStyle.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.txtIntrestRate.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.txtIntrestRate.Increment = 0.01D;
            resources.ApplyResources(this.txtIntrestRate, "txtIntrestRate");
            this.txtIntrestRate.MinValue = 0D;
            this.txtIntrestRate.Name = "txtIntrestRate";
            // 
            // labelX5
            // 
            resources.ApplyResources(this.labelX5, "labelX5");
            this.labelX5.BackColor = System.Drawing.Color.Transparent;
            this.labelX5.Name = "labelX5";
            // 
            // txtLoanRefrance
            // 
            resources.ApplyResources(this.txtLoanRefrance, "txtLoanRefrance");
            this.txtLoanRefrance.Name = "txtLoanRefrance";
            // 
            // labelX4
            // 
            resources.ApplyResources(this.labelX4, "labelX4");
            this.labelX4.BackColor = System.Drawing.Color.Transparent;
            this.labelX4.Name = "labelX4";
            // 
            // NoOfPayments
            // 
            // 
            // 
            // 
            this.NoOfPayments.BackgroundStyle.Class = "DateTimeInputBackground";
            this.NoOfPayments.BackgroundStyle.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.NoOfPayments.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.NoOfPayments.IsInputReadOnly = true;
            resources.ApplyResources(this.NoOfPayments, "NoOfPayments");
            this.NoOfPayments.MinValue = 1;
            this.NoOfPayments.Name = "NoOfPayments";
            this.NoOfPayments.ShowUpDown = true;
            this.NoOfPayments.Value = 1;
            this.NoOfPayments.ValueChanged += new System.EventHandler(this.NoOfPayments_ValueChanged);
            // 
            // txtLoanPurpose
            // 
            this.txtLoanPurpose.FormattingEnabled = true;
            this.txtLoanPurpose.Items.AddRange(new object[] {
            resources.GetString("txtLoanPurpose.Items"),
            resources.GetString("txtLoanPurpose.Items1"),
            resources.GetString("txtLoanPurpose.Items2")});
            resources.ApplyResources(this.txtLoanPurpose, "txtLoanPurpose");
            this.txtLoanPurpose.Name = "txtLoanPurpose";
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label11.Name = "label11";
            // 
            // label12
            // 
            resources.ApplyResources(this.label12, "label12");
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label12.Name = "label12";
            // 
            // label13
            // 
            resources.ApplyResources(this.label13, "label13");
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label13.Name = "label13";
            // 
            // txtLoanAcc
            // 
            this.txtLoanAcc.BackColor = System.Drawing.Color.Transparent;
            this.txtLoanAcc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            resources.ApplyResources(this.txtLoanAcc, "txtLoanAcc");
            this.txtLoanAcc.Name = "txtLoanAcc";
            // 
            // txtLoanNo
            // 
            // 
            // 
            // 
            this.txtLoanNo.Border.Class = "TextBoxBorder";
            resources.ApplyResources(this.txtLoanNo, "txtLoanNo");
            this.txtLoanNo.Name = "txtLoanNo";
            // 
            // txtLoanValue
            // 
            // 
            // 
            // 
            this.txtLoanValue.BackgroundStyle.Class = "DateTimeInputBackground";
            this.txtLoanValue.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.txtLoanValue.Increment = 1D;
            resources.ApplyResources(this.txtLoanValue, "txtLoanValue");
            this.txtLoanValue.Name = "txtLoanValue";
            // 
            // frmLoan
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ribbonBar1);
            this.Name = "frmLoan";
            this.Load += new System.EventHandler(this.frmLoan_Load);
            this.panel1.ResumeLayout(false);
            this.loanPanel.ResumeLayout(false);
            this.loanPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtIntrestRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NoOfPayments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLoanValue)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.RibbonBar ribbonBar1;
        private DevComponents.DotNetBar.ButtonItem BNew;
        private DevComponents.DotNetBar.ButtonItem BSave;
        private DevComponents.DotNetBar.ButtonItem BEdit;
        private DevComponents.DotNetBar.ButtonItem BSearch;
        private DevComponents.DotNetBar.ButtonItem BExit;
        private DevComponents.DotNetBar.ButtonItem btnStatment;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private MyControls.UC_Acc BName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtLoanRefrance;
        private System.Windows.Forms.ComboBox txtLoanPurpose;
        private DevComponents.DotNetBar.Controls.GroupPanel loanPanel;
        private DevComponents.DotNetBar.Controls.TextBoxX txtLoanId;
        private DevComponents.Editors.DoubleInput txtIntrestRate;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.Editors.IntegerInput NoOfPayments;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private MyControls.UC_Acc txtLoanAcc;
        private DevComponents.DotNetBar.Controls.TextBoxX txtLoanNo;
        private DevComponents.Editors.DoubleInput txtLoanValue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
    }
}