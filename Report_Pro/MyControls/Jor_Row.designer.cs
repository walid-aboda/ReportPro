namespace Report_Pro.MyControls
{
    partial class Jor_Row
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtDebit = new DevComponents.Editors.DoubleInput();
            this.ser_ = new DevComponents.DotNetBar.LabelX();
            this.txtAccDesc = new DevComponents.DotNetBar.LabelX();
            this.txtCostDesc = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.txtBalance = new DevComponents.DotNetBar.LabelX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.txtCatDesc = new DevComponents.DotNetBar.LabelX();
            this.dateTimeInput1 = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.button1 = new System.Windows.Forms.Button();
            this.branchID = new System.Windows.Forms.TextBox();
            this.txtDocument = new Report_Pro.MyControls.myText();
            this.txtCostID = new Report_Pro.MyControls.myText();
            this.txtCatID = new Report_Pro.MyControls.myText();
            this.txtAccNo = new Report_Pro.MyControls.myText();
            this.txtDescription = new Report_Pro.MyControls.myText();
            ((System.ComponentModel.ISupportInitialize)(this.txtDebit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTimeInput1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDebit
            // 
            // 
            // 
            // 
            this.txtDebit.BackgroundStyle.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.txtDebit.BackgroundStyle.Class = "TextBoxBorder";
            this.txtDebit.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.txtDebit.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtDebit.Increment = 1D;
            this.txtDebit.Location = new System.Drawing.Point(1554, 6);
            this.txtDebit.Name = "txtDebit";
            this.txtDebit.Size = new System.Drawing.Size(122, 27);
            this.txtDebit.TabIndex = 5;
            this.txtDebit.ValueChanged += new System.EventHandler(this.txtDebit_ValueChanged);
            this.txtDebit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDebit_KeyDown);
            // 
            // ser_
            // 
            this.ser_.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ser_.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ser_.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ser_.Location = new System.Drawing.Point(1680, 0);
            this.ser_.Margin = new System.Windows.Forms.Padding(0);
            this.ser_.Name = "ser_";
            this.ser_.Size = new System.Drawing.Size(56, 75);
            this.ser_.TabIndex = 6;
            this.ser_.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // txtAccDesc
            // 
            this.txtAccDesc.BackColor = System.Drawing.Color.GhostWhite;
            // 
            // 
            // 
            this.txtAccDesc.BackgroundStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtAccDesc.BackgroundStyle.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.txtAccDesc.BackgroundStyle.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtAccDesc.BackgroundStyle.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtAccDesc.BackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtAccDesc.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAccDesc.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtAccDesc.Location = new System.Drawing.Point(589, 6);
            this.txtAccDesc.Name = "txtAccDesc";
            this.txtAccDesc.Size = new System.Drawing.Size(300, 65);
            this.txtAccDesc.TabIndex = 7;
            this.txtAccDesc.Click += new System.EventHandler(this.txtAccDesc_Click);
            // 
            // txtCostDesc
            // 
            this.txtCostDesc.BackColor = System.Drawing.Color.GhostWhite;
            // 
            // 
            // 
            this.txtCostDesc.BackgroundStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtCostDesc.BackgroundStyle.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.txtCostDesc.BackgroundStyle.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtCostDesc.BackgroundStyle.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtCostDesc.BackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtCostDesc.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCostDesc.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtCostDesc.Location = new System.Drawing.Point(176, 6);
            this.txtCostDesc.Name = "txtCostDesc";
            this.txtCostDesc.Size = new System.Drawing.Size(300, 27);
            this.txtCostDesc.TabIndex = 8;
            // 
            // labelX3
            // 
            this.labelX3.AutoSize = true;
            this.labelX3.BackColor = System.Drawing.Color.Transparent;
            this.labelX3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.labelX3.Location = new System.Drawing.Point(428, 43);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(86, 22);
            this.labelX3.TabIndex = 9;
            this.labelX3.Text = "رقم المستند";
            // 
            // txtBalance
            // 
            this.txtBalance.BackColor = System.Drawing.Color.GhostWhite;
            // 
            // 
            // 
            this.txtBalance.BackgroundStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtBalance.BackgroundStyle.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.txtBalance.BackgroundStyle.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtBalance.BackgroundStyle.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtBalance.BackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtBalance.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtBalance.Location = new System.Drawing.Point(6, 6);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.Size = new System.Drawing.Size(161, 23);
            this.txtBalance.TabIndex = 11;
            // 
            // labelX5
            // 
            this.labelX5.AutoSize = true;
            this.labelX5.BackColor = System.Drawing.Color.Transparent;
            this.labelX5.ForeColor = System.Drawing.SystemColors.WindowText;
            this.labelX5.Location = new System.Drawing.Point(162, 43);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(93, 22);
            this.labelX5.TabIndex = 12;
            this.labelX5.Text = "تاريخ المستند";
            // 
            // txtCatDesc
            // 
            this.txtCatDesc.BackColor = System.Drawing.Color.LightCyan;
            // 
            // 
            // 
            this.txtCatDesc.BackgroundStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtCatDesc.BackgroundStyle.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.txtCatDesc.BackgroundStyle.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtCatDesc.BackgroundStyle.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtCatDesc.BackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtCatDesc.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtCatDesc.Location = new System.Drawing.Point(945, 42);
            this.txtCatDesc.Name = "txtCatDesc";
            this.txtCatDesc.Size = new System.Drawing.Size(330, 28);
            this.txtCatDesc.TabIndex = 15;
            // 
            // dateTimeInput1
            // 
            // 
            // 
            // 
            this.dateTimeInput1.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dateTimeInput1.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dateTimeInput1.ButtonDropDown.Visible = true;
            this.dateTimeInput1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.dateTimeInput1.Location = new System.Drawing.Point(17, 41);
            // 
            // 
            // 
            this.dateTimeInput1.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dateTimeInput1.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.dateTimeInput1.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dateTimeInput1.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dateTimeInput1.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dateTimeInput1.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dateTimeInput1.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dateTimeInput1.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dateTimeInput1.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dateTimeInput1.MonthCalendar.DisplayMonth = new System.DateTime(2020, 7, 1, 0, 0, 0, 0);
            this.dateTimeInput1.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dateTimeInput1.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dateTimeInput1.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dateTimeInput1.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dateTimeInput1.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dateTimeInput1.MonthCalendar.TodayButtonVisible = true;
            this.dateTimeInput1.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.dateTimeInput1.Name = "dateTimeInput1";
            this.dateTimeInput1.Size = new System.Drawing.Size(134, 27);
            this.dateTimeInput1.TabIndex = 18;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Yellow;
            this.button1.BackgroundImage = global::Report_Pro.Properties.Resources.Cross_icon;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.button1.Location = new System.Drawing.Point(1737, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(39, 66);
            this.button1.TabIndex = 4;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // branchID
            // 
            this.branchID.ForeColor = System.Drawing.SystemColors.WindowText;
            this.branchID.Location = new System.Drawing.Point(1677, 45);
            this.branchID.Name = "branchID";
            this.branchID.Size = new System.Drawing.Size(47, 27);
            this.branchID.TabIndex = 19;
            this.branchID.Visible = false;
            // 
            // txtDocument
            // 
            this.txtDocument.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtDocument.Location = new System.Drawing.Point(272, 39);
            this.txtDocument.Name = "txtDocument";
            this.txtDocument.Size = new System.Drawing.Size(150, 30);
            this.txtDocument.TabIndex = 24;
            // 
            // txtCostID
            // 
            this.txtCostID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtCostID.Location = new System.Drawing.Point(482, 6);
            this.txtCostID.Name = "txtCostID";
            this.txtCostID.Size = new System.Drawing.Size(98, 30);
            this.txtCostID.TabIndex = 23;
            // 
            // txtCatID
            // 
            this.txtCatID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtCatID.Location = new System.Drawing.Point(1282, 41);
            this.txtCatID.Name = "txtCatID";
            this.txtCatID.Size = new System.Drawing.Size(122, 30);
            this.txtCatID.TabIndex = 22;
            // 
            // txtAccNo
            // 
            this.txtAccNo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtAccNo.Location = new System.Drawing.Point(1417, 6);
            this.txtAccNo.Margin = new System.Windows.Forms.Padding(0);
            this.txtAccNo.Name = "txtAccNo";
            this.txtAccNo.Size = new System.Drawing.Size(134, 30);
            this.txtAccNo.TabIndex = 21;
            this.txtAccNo.Load += new System.EventHandler(this.txtAccNo_TextChanged);
            this.txtAccNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAccNo_KeyDown);
            // 
            // txtDescription
            // 
            this.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtDescription.Location = new System.Drawing.Point(895, 6);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(0);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(518, 30);
            this.txtDescription.TabIndex = 20;
            // 
            // Jor_Row
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.txtDocument);
            this.Controls.Add(this.txtCostID);
            this.Controls.Add(this.txtCatID);
            this.Controls.Add(this.txtAccNo);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.branchID);
            this.Controls.Add(this.dateTimeInput1);
            this.Controls.Add(this.txtCatDesc);
            this.Controls.Add(this.labelX5);
            this.Controls.Add(this.txtBalance);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.txtCostDesc);
            this.Controls.Add(this.txtAccDesc);
            this.Controls.Add(this.ser_);
            this.Controls.Add(this.txtDebit);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "Jor_Row";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.Size = new System.Drawing.Size(1785, 80);
            this.Load += new System.EventHandler(this.Jor_Row_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtDebit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTimeInput1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        public DevComponents.Editors.DoubleInput txtDebit;
        private DevComponents.DotNetBar.LabelX txtAccDesc;
        private DevComponents.DotNetBar.LabelX txtCostDesc;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX txtBalance;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.LabelX txtCatDesc;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dateTimeInput1;
        public DevComponents.DotNetBar.LabelX ser_;
        public System.Windows.Forms.TextBox branchID;
        private myText txtDescription;
        private myText txtAccNo;
        private myText txtCostID;
        private myText txtDocument;
        public myText txtCatID;
    }
}
