namespace Report_Pro.PL
{
    partial class Frm_Banks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Banks));
            this.ribbonBar1 = new DevComponents.DotNetBar.RibbonBar();
            this.BNew = new DevComponents.DotNetBar.ButtonItem();
            this.BSave = new DevComponents.DotNetBar.ButtonItem();
            this.BSearch = new DevComponents.DotNetBar.ButtonItem();
            this.BExit = new DevComponents.DotNetBar.ButtonItem();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.BNameA = new DevExpress.XtraEditors.TextEdit();
            this.label16 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.txtLcAcc = new Report_Pro.MyControls.UC_Acc();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.txt_Facility = new DevComponents.Editors.DoubleInput();
            this.Loans_Rate = new DevComponents.Editors.DoubleInput();
            this.txt_Margin = new System.Windows.Forms.TextBox();
            this.BFax = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtComnication = new DevComponents.Editors.DoubleInput();
            this.BAccept = new DevComponents.Editors.DoubleInput();
            this.BNameE = new System.Windows.Forms.TextBox();
            this.UC_Acc = new Report_Pro.MyControls.UC_Acc();
            this.BTel = new System.Windows.Forms.TextBox();
            this.BAccNo = new System.Windows.Forms.TextBox();
            this.txt_Iban = new System.Windows.Forms.TextBox();
            this.txt_accName = new System.Windows.Forms.TextBox();
            this.BEmail = new System.Windows.Forms.TextBox();
            this.txt_accNameE = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.BID = new System.Windows.Forms.TextBox();
            this.groupPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BNameA.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Facility)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Loans_Rate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtComnication)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BAccept)).BeginInit();
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
            this.BSearch,
            this.BExit});
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
            this.BNew.Click += new System.EventHandler(this.BNew_Click);
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
            this.BExit.Click += new System.EventHandler(this.BExit_Click);
            // 
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.BID);
            this.groupPanel1.Controls.Add(this.BNameA);
            this.groupPanel1.Controls.Add(this.label16);
            this.groupPanel1.Controls.Add(this.label20);
            this.groupPanel1.Controls.Add(this.txtLcAcc);
            this.groupPanel1.Controls.Add(this.label19);
            this.groupPanel1.Controls.Add(this.label18);
            this.groupPanel1.Controls.Add(this.txt_Facility);
            this.groupPanel1.Controls.Add(this.Loans_Rate);
            this.groupPanel1.Controls.Add(this.txt_Margin);
            this.groupPanel1.Controls.Add(this.BFax);
            this.groupPanel1.Controls.Add(this.label17);
            this.groupPanel1.Controls.Add(this.txtComnication);
            this.groupPanel1.Controls.Add(this.BAccept);
            this.groupPanel1.Controls.Add(this.BNameE);
            this.groupPanel1.Controls.Add(this.UC_Acc);
            this.groupPanel1.Controls.Add(this.BTel);
            this.groupPanel1.Controls.Add(this.BAccNo);
            this.groupPanel1.Controls.Add(this.txt_Iban);
            this.groupPanel1.Controls.Add(this.txt_accName);
            this.groupPanel1.Controls.Add(this.BEmail);
            this.groupPanel1.Controls.Add(this.txt_accNameE);
            this.groupPanel1.Controls.Add(this.label15);
            this.groupPanel1.Controls.Add(this.label14);
            this.groupPanel1.Controls.Add(this.label13);
            this.groupPanel1.Controls.Add(this.label12);
            this.groupPanel1.Controls.Add(this.label11);
            this.groupPanel1.Controls.Add(this.label10);
            this.groupPanel1.Controls.Add(this.label9);
            this.groupPanel1.Controls.Add(this.label1);
            this.groupPanel1.Controls.Add(this.label2);
            this.groupPanel1.Controls.Add(this.label3);
            this.groupPanel1.Controls.Add(this.label4);
            this.groupPanel1.Controls.Add(this.label5);
            this.groupPanel1.Controls.Add(this.label8);
            this.groupPanel1.Controls.Add(this.label6);
            this.groupPanel1.Controls.Add(this.label7);
            resources.ApplyResources(this.groupPanel1, "groupPanel1");
            this.groupPanel1.Name = "groupPanel1";
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
            this.groupPanel1.Click += new System.EventHandler(this.groupPanel1_Click);
            // 
            // BNameA
            // 
            resources.ApplyResources(this.BNameA, "BNameA");
            this.BNameA.Name = "BNameA";
            // 
            // label16
            // 
            resources.ApplyResources(this.label16, "label16");
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label16.Name = "label16";
            // 
            // label20
            // 
            resources.ApplyResources(this.label20, "label20");
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label20.Name = "label20";
            // 
            // txtLcAcc
            // 
            resources.ApplyResources(this.txtLcAcc, "txtLcAcc");
            this.txtLcAcc.BackColor = System.Drawing.Color.Transparent;
            this.txtLcAcc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtLcAcc.Name = "txtLcAcc";
            // 
            // label19
            // 
            resources.ApplyResources(this.label19, "label19");
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label19.Name = "label19";
            // 
            // label18
            // 
            resources.ApplyResources(this.label18, "label18");
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label18.Name = "label18";
            // 
            // txt_Facility
            // 
            resources.ApplyResources(this.txt_Facility, "txt_Facility");
            // 
            // 
            // 
            this.txt_Facility.BackgroundStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txt_Facility.BackgroundStyle.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txt_Facility.BackgroundStyle.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txt_Facility.BackgroundStyle.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txt_Facility.BackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txt_Facility.BackgroundStyle.Class = "DateTimeInputBackground";
            this.txt_Facility.Increment = 1D;
            this.txt_Facility.Name = "txt_Facility";
            // 
            // Loans_Rate
            // 
            resources.ApplyResources(this.Loans_Rate, "Loans_Rate");
            // 
            // 
            // 
            this.Loans_Rate.BackgroundStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.Loans_Rate.BackgroundStyle.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Loans_Rate.BackgroundStyle.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.Loans_Rate.BackgroundStyle.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.Loans_Rate.BackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.Loans_Rate.BackgroundStyle.Class = "DateTimeInputBackground";
            this.Loans_Rate.Increment = 1D;
            this.Loans_Rate.Name = "Loans_Rate";
            // 
            // txt_Margin
            // 
            resources.ApplyResources(this.txt_Margin, "txt_Margin");
            this.txt_Margin.Name = "txt_Margin";
            // 
            // BFax
            // 
            resources.ApplyResources(this.BFax, "BFax");
            this.BFax.Name = "BFax";
            // 
            // label17
            // 
            resources.ApplyResources(this.label17, "label17");
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label17.Name = "label17";
            // 
            // txtComnication
            // 
            resources.ApplyResources(this.txtComnication, "txtComnication");
            // 
            // 
            // 
            this.txtComnication.BackgroundStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtComnication.BackgroundStyle.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtComnication.BackgroundStyle.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtComnication.BackgroundStyle.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtComnication.BackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtComnication.BackgroundStyle.Class = "DateTimeInputBackground";
            this.txtComnication.Increment = 1D;
            this.txtComnication.Name = "txtComnication";
            // 
            // BAccept
            // 
            resources.ApplyResources(this.BAccept, "BAccept");
            // 
            // 
            // 
            this.BAccept.BackgroundStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.BAccept.BackgroundStyle.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BAccept.BackgroundStyle.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.BAccept.BackgroundStyle.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.BAccept.BackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.BAccept.BackgroundStyle.Class = "DateTimeInputBackground";
            this.BAccept.Increment = 1D;
            this.BAccept.Name = "BAccept";
            this.BAccept.ValueChanged += new System.EventHandler(this.doubleInput1_ValueChanged);
            // 
            // BNameE
            // 
            resources.ApplyResources(this.BNameE, "BNameE");
            this.BNameE.Name = "BNameE";
            // 
            // UC_Acc
            // 
            resources.ApplyResources(this.UC_Acc, "UC_Acc");
            this.UC_Acc.BackColor = System.Drawing.Color.Transparent;
            this.UC_Acc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.UC_Acc.Name = "UC_Acc";
            // 
            // BTel
            // 
            resources.ApplyResources(this.BTel, "BTel");
            this.BTel.Name = "BTel";
            // 
            // BAccNo
            // 
            resources.ApplyResources(this.BAccNo, "BAccNo");
            this.BAccNo.Name = "BAccNo";
            // 
            // txt_Iban
            // 
            resources.ApplyResources(this.txt_Iban, "txt_Iban");
            this.txt_Iban.Name = "txt_Iban";
            // 
            // txt_accName
            // 
            resources.ApplyResources(this.txt_accName, "txt_accName");
            this.txt_accName.Name = "txt_accName";
            // 
            // BEmail
            // 
            resources.ApplyResources(this.BEmail, "BEmail");
            this.BEmail.Name = "BEmail";
            // 
            // txt_accNameE
            // 
            resources.ApplyResources(this.txt_accNameE, "txt_accNameE");
            this.txt_accNameE.Name = "txt_accNameE";
            // 
            // label15
            // 
            resources.ApplyResources(this.label15, "label15");
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label15.Name = "label15";
            // 
            // label14
            // 
            resources.ApplyResources(this.label14, "label14");
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label14.Name = "label14";
            // 
            // label13
            // 
            resources.ApplyResources(this.label13, "label13");
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label13.Name = "label13";
            // 
            // label12
            // 
            resources.ApplyResources(this.label12, "label12");
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label12.Name = "label12";
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label11.Name = "label11";
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label10.Name = "label10";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label9.Name = "label9";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label4.Name = "label4";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label5.Name = "label5";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label8.Name = "label8";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label6.Name = "label6";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label7.Name = "label7";
            // 
            // BID
            // 
            resources.ApplyResources(this.BID, "BID");
            this.BID.Name = "BID";
            // 
            // Frm_Banks
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ControlBox = false;
            this.Controls.Add(this.groupPanel1);
            this.Controls.Add(this.ribbonBar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Frm_Banks";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.Frm_Banks_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Frm_Banks_KeyDown);
            this.groupPanel1.ResumeLayout(false);
            this.groupPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BNameA.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Facility)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Loans_Rate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtComnication)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BAccept)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevComponents.DotNetBar.RibbonBar ribbonBar1;
        private DevComponents.DotNetBar.ButtonItem BNew;
        private DevComponents.DotNetBar.ButtonItem BSave;
        private DevComponents.DotNetBar.ButtonItem BSearch;
        private DevComponents.DotNetBar.ButtonItem BExit;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private System.Windows.Forms.Label label11;
        private DevComponents.Editors.DoubleInput txt_Facility;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_Margin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox BNameE;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox BAccNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Iban;
        private System.Windows.Forms.TextBox BTel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox BFax;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox BEmail;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_accNameE;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private MyControls.UC_Acc UC_Acc;
        private DevComponents.Editors.DoubleInput Loans_Rate;
        private DevComponents.Editors.DoubleInput BAccept;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label19;
        private DevComponents.Editors.DoubleInput txtComnication;
        private System.Windows.Forms.Label label20;
        private MyControls.UC_Acc txtLcAcc;
        private System.Windows.Forms.TextBox txt_accName;
        //private DevExpress.XtraLayout.LayoutControlItem layoutControlItem13;
        private System.Windows.Forms.Label label16;
        private DevExpress.XtraEditors.TextEdit BNameA;
        private System.Windows.Forms.TextBox BID;
    }
}