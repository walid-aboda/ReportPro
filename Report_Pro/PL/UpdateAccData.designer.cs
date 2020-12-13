namespace Report_Pro.PL
{
    partial class UpdateAccData
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
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.Desc = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.adress = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.Desc_L = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.ch_facility = new System.Windows.Forms.CheckBox();
            this.lbl_Building = new DevComponents.DotNetBar.LabelX();
            this.txt_Building = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txt_Block = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lbl_Block = new DevComponents.DotNetBar.LabelX();
            this.txt_Road = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lbl_Road = new DevComponents.DotNetBar.LabelX();
            this.txt_Area = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txt_VatNo = new System.Windows.Forms.MaskedTextBox();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.UC_Acc = new Report_Pro.MyControls.UC_Acc();
            this.groupPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.Location = new System.Drawing.Point(324, 176);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(102, 23);
            this.buttonX1.TabIndex = 2;
            this.buttonX1.Text = "تحديث";
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // Desc
            // 
            this.Desc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.Desc.Border.Class = "TextBoxBorder";
            this.Desc.Location = new System.Drawing.Point(324, 62);
            this.Desc.Name = "Desc";
            this.Desc.Size = new System.Drawing.Size(259, 20);
            this.Desc.TabIndex = 7;
            // 
            // adress
            // 
            this.adress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.adress.Border.Class = "TextBoxBorder";
            this.adress.Location = new System.Drawing.Point(19, 111);
            this.adress.Name = "adress";
            this.adress.Size = new System.Drawing.Size(300, 20);
            this.adress.TabIndex = 8;
            this.adress.Visible = false;
            // 
            // labelX1
            // 
            this.labelX1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelX1.AutoSize = true;
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            this.labelX1.Location = new System.Drawing.Point(625, 36);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(43, 17);
            this.labelX1.TabIndex = 10;
            this.labelX1.Text = "الحساب";
            // 
            // labelX2
            // 
            this.labelX2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelX2.AutoSize = true;
            this.labelX2.BackColor = System.Drawing.Color.Transparent;
            this.labelX2.Location = new System.Drawing.Point(589, 116);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(36, 17);
            this.labelX2.TabIndex = 11;
            this.labelX2.Text = "العنوان";
            // 
            // labelX3
            // 
            this.labelX3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelX3.AutoSize = true;
            this.labelX3.BackColor = System.Drawing.Color.Transparent;
            this.labelX3.Location = new System.Drawing.Point(187, 64);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(68, 17);
            this.labelX3.TabIndex = 13;
            this.labelX3.Text = "الرقم الضريبي";
            // 
            // labelX4
            // 
            this.labelX4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelX4.AutoSize = true;
            this.labelX4.BackColor = System.Drawing.Color.Transparent;
            this.labelX4.Location = new System.Drawing.Point(589, 64);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(96, 17);
            this.labelX4.TabIndex = 148;
            this.labelX4.Text = "اسم الحساب عربي";
            // 
            // labelX5
            // 
            this.labelX5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelX5.AutoSize = true;
            this.labelX5.BackColor = System.Drawing.Color.Transparent;
            this.labelX5.Location = new System.Drawing.Point(589, 90);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(99, 17);
            this.labelX5.TabIndex = 149;
            this.labelX5.Text = "اسم الحساب لاتيني";
            // 
            // Desc_L
            // 
            this.Desc_L.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.Desc_L.Border.Class = "TextBoxBorder";
            this.Desc_L.Location = new System.Drawing.Point(324, 88);
            this.Desc_L.Name = "Desc_L";
            this.Desc_L.Size = new System.Drawing.Size(259, 20);
            this.Desc_L.TabIndex = 150;
            // 
            // ch_facility
            // 
            this.ch_facility.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ch_facility.AutoSize = true;
            this.ch_facility.BackColor = System.Drawing.Color.Transparent;
            this.ch_facility.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ch_facility.Location = new System.Drawing.Point(61, 88);
            this.ch_facility.Name = "ch_facility";
            this.ch_facility.Size = new System.Drawing.Size(141, 17);
            this.ch_facility.TabIndex = 152;
            this.ch_facility.Text = "تسهيلات ائتمانية معتمده";
            this.ch_facility.UseVisualStyleBackColor = false;
            // 
            // lbl_Building
            // 
            this.lbl_Building.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Building.AutoSize = true;
            this.lbl_Building.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Building.Location = new System.Drawing.Point(338, 116);
            this.lbl_Building.Name = "lbl_Building";
            this.lbl_Building.Size = new System.Drawing.Size(44, 17);
            this.lbl_Building.TabIndex = 153;
            this.lbl_Building.Text = "Building";
            this.lbl_Building.Click += new System.EventHandler(this.labelX6_Click);
            // 
            // txt_Building
            // 
            this.txt_Building.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txt_Building.Border.Class = "TextBoxBorder";
            this.txt_Building.Location = new System.Drawing.Point(385, 114);
            this.txt_Building.Name = "txt_Building";
            this.txt_Building.Size = new System.Drawing.Size(80, 20);
            this.txt_Building.TabIndex = 154;
            this.txt_Building.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_Building_KeyUp);
            // 
            // txt_Block
            // 
            this.txt_Block.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txt_Block.Border.Class = "TextBoxBorder";
            this.txt_Block.Location = new System.Drawing.Point(385, 140);
            this.txt_Block.Name = "txt_Block";
            this.txt_Block.Size = new System.Drawing.Size(80, 20);
            this.txt_Block.TabIndex = 156;
            this.txt_Block.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_Block_KeyUp);
            // 
            // lbl_Block
            // 
            this.lbl_Block.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Block.AutoSize = true;
            this.lbl_Block.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Block.Location = new System.Drawing.Point(350, 142);
            this.lbl_Block.Name = "lbl_Block";
            this.lbl_Block.Size = new System.Drawing.Size(32, 17);
            this.lbl_Block.TabIndex = 155;
            this.lbl_Block.Text = "Block";
            // 
            // txt_Road
            // 
            this.txt_Road.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txt_Road.Border.Class = "TextBoxBorder";
            this.txt_Road.Location = new System.Drawing.Point(508, 114);
            this.txt_Road.Name = "txt_Road";
            this.txt_Road.Size = new System.Drawing.Size(75, 20);
            this.txt_Road.TabIndex = 158;
            this.txt_Road.TextChanged += new System.EventHandler(this.txt_Road_TextChanged);
            this.txt_Road.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_Road_KeyUp);
            // 
            // lbl_Road
            // 
            this.lbl_Road.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Road.AutoSize = true;
            this.lbl_Road.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Road.Location = new System.Drawing.Point(474, 116);
            this.lbl_Road.Name = "lbl_Road";
            this.lbl_Road.Size = new System.Drawing.Size(31, 17);
            this.lbl_Road.TabIndex = 157;
            this.lbl_Road.Text = "Road";
            // 
            // txt_Area
            // 
            this.txt_Area.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txt_Area.Border.Class = "TextBoxBorder";
            this.txt_Area.Location = new System.Drawing.Point(471, 140);
            this.txt_Area.Name = "txt_Area";
            this.txt_Area.Size = new System.Drawing.Size(109, 20);
            this.txt_Area.TabIndex = 159;
            this.txt_Area.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_Area_KeyUp);
            // 
            // txt_VatNo
            // 
            this.txt_VatNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_VatNo.Culture = new System.Globalization.CultureInfo("ar-001");
            this.txt_VatNo.Location = new System.Drawing.Point(70, 62);
            this.txt_VatNo.Mask = "00000-00000-00000";
            this.txt_VatNo.Name = "txt_VatNo";
            this.txt_VatNo.Size = new System.Drawing.Size(111, 20);
            this.txt_VatNo.TabIndex = 160;
            this.txt_VatNo.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.txt_VatNo);
            this.groupPanel1.Controls.Add(this.labelX1);
            this.groupPanel1.Controls.Add(this.buttonX1);
            this.groupPanel1.Controls.Add(this.UC_Acc);
            this.groupPanel1.Controls.Add(this.adress);
            this.groupPanel1.Controls.Add(this.ch_facility);
            this.groupPanel1.Controls.Add(this.labelX4);
            this.groupPanel1.Controls.Add(this.txt_Area);
            this.groupPanel1.Controls.Add(this.labelX3);
            this.groupPanel1.Controls.Add(this.Desc);
            this.groupPanel1.Controls.Add(this.txt_Block);
            this.groupPanel1.Controls.Add(this.lbl_Road);
            this.groupPanel1.Controls.Add(this.lbl_Block);
            this.groupPanel1.Controls.Add(this.txt_Road);
            this.groupPanel1.Controls.Add(this.lbl_Building);
            this.groupPanel1.Controls.Add(this.txt_Building);
            this.groupPanel1.Controls.Add(this.labelX5);
            this.groupPanel1.Controls.Add(this.Desc_L);
            this.groupPanel1.Controls.Add(this.labelX2);
            this.groupPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupPanel1.Location = new System.Drawing.Point(0, 0);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(700, 232);
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
            this.groupPanel1.TabIndex = 162;
            // 
            // UC_Acc
            // 
            this.UC_Acc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.UC_Acc.BackColor = System.Drawing.Color.Transparent;
            this.UC_Acc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.UC_Acc.Location = new System.Drawing.Point(294, 36);
            this.UC_Acc.Margin = new System.Windows.Forms.Padding(0);
            this.UC_Acc.Name = "UC_Acc";
            this.UC_Acc.Size = new System.Drawing.Size(328, 23);
            this.UC_Acc.TabIndex = 151;
            this.UC_Acc.Load += new System.EventHandler(this.UC_Acc_Load);
            // 
            // UpdateAccData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 232);
            this.Controls.Add(this.groupPanel1);
            this.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.KeyPreview = true;
            this.Name = "UpdateAccData";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "تحديث بيانات العملاء";
            this.Load += new System.EventHandler(this.UpdateAccData_Load);
            this.groupPanel1.ResumeLayout(false);
            this.groupPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX buttonX1;
        private DevComponents.DotNetBar.Controls.TextBoxX adress;
        private DevComponents.DotNetBar.Controls.TextBoxX Desc;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.Controls.TextBoxX Desc_L;
        private MyControls.UC_Acc UC_Acc;
        private System.Windows.Forms.CheckBox ch_facility;
        private DevComponents.DotNetBar.LabelX lbl_Building;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_Building;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_Block;
        private DevComponents.DotNetBar.LabelX lbl_Block;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_Road;
        private DevComponents.DotNetBar.LabelX lbl_Road;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_Area;
        private System.Windows.Forms.MaskedTextBox txt_VatNo;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
    }
}