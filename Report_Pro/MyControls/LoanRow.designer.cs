namespace Report_Pro.MyControls
{
    partial class LoanRow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoanRow));
            this.PayValue = new DevComponents.Editors.DoubleInput();
            this.paySer = new DevComponents.Editors.IntegerInput();
            this.startDate = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.maturityDate = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.intrestRate = new DevComponents.Editors.DoubleInput();
            ((System.ComponentModel.ISupportInitialize)(this.PayValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paySer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maturityDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.intrestRate)).BeginInit();
            this.SuspendLayout();
            // 
            // PayValue
            // 
            resources.ApplyResources(this.PayValue, "PayValue");
            // 
            // 
            // 
            this.PayValue.BackgroundStyle.Class = "DateTimeInputBackground";
            this.PayValue.ButtonClear.DisplayPosition = ((int)(resources.GetObject("PayValue.ButtonClear.DisplayPosition")));
            this.PayValue.ButtonClear.Image = ((System.Drawing.Image)(resources.GetObject("PayValue.ButtonClear.Image")));
            this.PayValue.ButtonClear.Text = resources.GetString("PayValue.ButtonClear.Text");
            this.PayValue.ButtonCustom.DisplayPosition = ((int)(resources.GetObject("PayValue.ButtonCustom.DisplayPosition")));
            this.PayValue.ButtonCustom.Image = ((System.Drawing.Image)(resources.GetObject("PayValue.ButtonCustom.Image")));
            this.PayValue.ButtonCustom.Text = resources.GetString("PayValue.ButtonCustom.Text");
            this.PayValue.ButtonCustom2.DisplayPosition = ((int)(resources.GetObject("PayValue.ButtonCustom2.DisplayPosition")));
            this.PayValue.ButtonCustom2.Image = ((System.Drawing.Image)(resources.GetObject("PayValue.ButtonCustom2.Image")));
            this.PayValue.ButtonCustom2.Text = resources.GetString("PayValue.ButtonCustom2.Text");
            this.PayValue.ButtonDropDown.DisplayPosition = ((int)(resources.GetObject("PayValue.ButtonDropDown.DisplayPosition")));
            this.PayValue.ButtonDropDown.Image = ((System.Drawing.Image)(resources.GetObject("PayValue.ButtonDropDown.Image")));
            this.PayValue.ButtonDropDown.Text = resources.GetString("PayValue.ButtonDropDown.Text");
            this.PayValue.ButtonFreeText.DisplayPosition = ((int)(resources.GetObject("PayValue.ButtonFreeText.DisplayPosition")));
            this.PayValue.ButtonFreeText.Image = ((System.Drawing.Image)(resources.GetObject("PayValue.ButtonFreeText.Image")));
            this.PayValue.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.PayValue.ButtonFreeText.Text = resources.GetString("PayValue.ButtonFreeText.Text");
            this.PayValue.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.PayValue.Increment = 1D;
            this.PayValue.Name = "PayValue";
            this.PayValue.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PayValue_KeyDown);
            // 
            // paySer
            // 
            resources.ApplyResources(this.paySer, "paySer");
            // 
            // 
            // 
            this.paySer.BackgroundStyle.Class = "DateTimeInputBackground";
            this.paySer.BackgroundStyle.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.paySer.ButtonClear.DisplayPosition = ((int)(resources.GetObject("paySer.ButtonClear.DisplayPosition")));
            this.paySer.ButtonClear.Image = ((System.Drawing.Image)(resources.GetObject("paySer.ButtonClear.Image")));
            this.paySer.ButtonClear.Text = resources.GetString("paySer.ButtonClear.Text");
            this.paySer.ButtonCustom.DisplayPosition = ((int)(resources.GetObject("paySer.ButtonCustom.DisplayPosition")));
            this.paySer.ButtonCustom.Image = ((System.Drawing.Image)(resources.GetObject("paySer.ButtonCustom.Image")));
            this.paySer.ButtonCustom.Text = resources.GetString("paySer.ButtonCustom.Text");
            this.paySer.ButtonCustom2.DisplayPosition = ((int)(resources.GetObject("paySer.ButtonCustom2.DisplayPosition")));
            this.paySer.ButtonCustom2.Image = ((System.Drawing.Image)(resources.GetObject("paySer.ButtonCustom2.Image")));
            this.paySer.ButtonCustom2.Text = resources.GetString("paySer.ButtonCustom2.Text");
            this.paySer.ButtonDropDown.DisplayPosition = ((int)(resources.GetObject("paySer.ButtonDropDown.DisplayPosition")));
            this.paySer.ButtonDropDown.Image = ((System.Drawing.Image)(resources.GetObject("paySer.ButtonDropDown.Image")));
            this.paySer.ButtonDropDown.Text = resources.GetString("paySer.ButtonDropDown.Text");
            this.paySer.ButtonFreeText.DisplayPosition = ((int)(resources.GetObject("paySer.ButtonFreeText.DisplayPosition")));
            this.paySer.ButtonFreeText.Image = ((System.Drawing.Image)(resources.GetObject("paySer.ButtonFreeText.Image")));
            this.paySer.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.paySer.ButtonFreeText.Text = resources.GetString("paySer.ButtonFreeText.Text");
            this.paySer.DisabledBackColor = System.Drawing.Color.Navy;
            this.paySer.DisabledForeColor = System.Drawing.SystemColors.Window;
            this.paySer.Name = "paySer";
            // 
            // startDate
            // 
            resources.ApplyResources(this.startDate, "startDate");
            // 
            // 
            // 
            this.startDate.BackgroundStyle.Class = "DateTimeInputBackground";
            this.startDate.ButtonClear.DisplayPosition = ((int)(resources.GetObject("startDate.ButtonClear.DisplayPosition")));
            this.startDate.ButtonClear.Image = ((System.Drawing.Image)(resources.GetObject("startDate.ButtonClear.Image")));
            this.startDate.ButtonClear.Text = resources.GetString("startDate.ButtonClear.Text");
            this.startDate.ButtonCustom.DisplayPosition = ((int)(resources.GetObject("startDate.ButtonCustom.DisplayPosition")));
            this.startDate.ButtonCustom.Image = ((System.Drawing.Image)(resources.GetObject("startDate.ButtonCustom.Image")));
            this.startDate.ButtonCustom.Text = resources.GetString("startDate.ButtonCustom.Text");
            this.startDate.ButtonCustom2.DisplayPosition = ((int)(resources.GetObject("startDate.ButtonCustom2.DisplayPosition")));
            this.startDate.ButtonCustom2.Image = ((System.Drawing.Image)(resources.GetObject("startDate.ButtonCustom2.Image")));
            this.startDate.ButtonCustom2.Text = resources.GetString("startDate.ButtonCustom2.Text");
            this.startDate.ButtonDropDown.DisplayPosition = ((int)(resources.GetObject("startDate.ButtonDropDown.DisplayPosition")));
            this.startDate.ButtonDropDown.Image = ((System.Drawing.Image)(resources.GetObject("startDate.ButtonDropDown.Image")));
            this.startDate.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.startDate.ButtonDropDown.Text = resources.GetString("startDate.ButtonDropDown.Text");
            this.startDate.ButtonDropDown.Visible = true;
            this.startDate.ButtonFreeText.DisplayPosition = ((int)(resources.GetObject("startDate.ButtonFreeText.DisplayPosition")));
            this.startDate.ButtonFreeText.Image = ((System.Drawing.Image)(resources.GetObject("startDate.ButtonFreeText.Image")));
            this.startDate.ButtonFreeText.Text = resources.GetString("startDate.ButtonFreeText.Text");
            this.startDate.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            // 
            // 
            // 
            this.startDate.MonthCalendar.AnnuallyMarkedDates = ((System.DateTime[])(resources.GetObject("startDate.MonthCalendar.AnnuallyMarkedDates")));
            // 
            // 
            // 
            this.startDate.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.startDate.MonthCalendar.Category = resources.GetString("startDate.MonthCalendar.Category");
            this.startDate.MonthCalendar.ClearButtonVisible = true;
            this.startDate.MonthCalendar.CommandParameter = ((object)(resources.GetObject("startDate.MonthCalendar.CommandParameter")));
            // 
            // 
            // 
            this.startDate.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.startDate.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.startDate.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.startDate.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.startDate.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.startDate.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.startDate.MonthCalendar.DayNames = ((string[])(resources.GetObject("startDate.MonthCalendar.DayNames")));
            this.startDate.MonthCalendar.Description = resources.GetString("startDate.MonthCalendar.Description");
            this.startDate.MonthCalendar.DisplayMonth = new System.DateTime(2020, 7, 1, 0, 0, 0, 0);
            this.startDate.MonthCalendar.MarkedDates = ((System.DateTime[])(resources.GetObject("startDate.MonthCalendar.MarkedDates")));
            this.startDate.MonthCalendar.MonthlyMarkedDates = ((System.DateTime[])(resources.GetObject("startDate.MonthCalendar.MonthlyMarkedDates")));
            // 
            // 
            // 
            this.startDate.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.startDate.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.startDate.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.startDate.MonthCalendar.Tag = resources.GetString("startDate.MonthCalendar.Tag");
            this.startDate.MonthCalendar.Text = resources.GetString("startDate.MonthCalendar.Text");
            this.startDate.MonthCalendar.TodayButtonVisible = true;
            this.startDate.MonthCalendar.Tooltip = resources.GetString("startDate.MonthCalendar.Tooltip");
            this.startDate.MonthCalendar.WeeklyMarkedDays = ((System.DayOfWeek[])(resources.GetObject("startDate.MonthCalendar.WeeklyMarkedDays")));
            this.startDate.Name = "startDate";
            this.startDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.startDate_KeyDown);
            // 
            // maturityDate
            // 
            resources.ApplyResources(this.maturityDate, "maturityDate");
            // 
            // 
            // 
            this.maturityDate.BackgroundStyle.Class = "DateTimeInputBackground";
            this.maturityDate.ButtonClear.DisplayPosition = ((int)(resources.GetObject("maturityDate.ButtonClear.DisplayPosition")));
            this.maturityDate.ButtonClear.Image = ((System.Drawing.Image)(resources.GetObject("maturityDate.ButtonClear.Image")));
            this.maturityDate.ButtonClear.Text = resources.GetString("maturityDate.ButtonClear.Text");
            this.maturityDate.ButtonCustom.DisplayPosition = ((int)(resources.GetObject("maturityDate.ButtonCustom.DisplayPosition")));
            this.maturityDate.ButtonCustom.Image = ((System.Drawing.Image)(resources.GetObject("maturityDate.ButtonCustom.Image")));
            this.maturityDate.ButtonCustom.Text = resources.GetString("maturityDate.ButtonCustom.Text");
            this.maturityDate.ButtonCustom2.DisplayPosition = ((int)(resources.GetObject("maturityDate.ButtonCustom2.DisplayPosition")));
            this.maturityDate.ButtonCustom2.Image = ((System.Drawing.Image)(resources.GetObject("maturityDate.ButtonCustom2.Image")));
            this.maturityDate.ButtonCustom2.Text = resources.GetString("maturityDate.ButtonCustom2.Text");
            this.maturityDate.ButtonDropDown.DisplayPosition = ((int)(resources.GetObject("maturityDate.ButtonDropDown.DisplayPosition")));
            this.maturityDate.ButtonDropDown.Image = ((System.Drawing.Image)(resources.GetObject("maturityDate.ButtonDropDown.Image")));
            this.maturityDate.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.maturityDate.ButtonDropDown.Text = resources.GetString("maturityDate.ButtonDropDown.Text");
            this.maturityDate.ButtonDropDown.Visible = true;
            this.maturityDate.ButtonFreeText.DisplayPosition = ((int)(resources.GetObject("maturityDate.ButtonFreeText.DisplayPosition")));
            this.maturityDate.ButtonFreeText.Image = ((System.Drawing.Image)(resources.GetObject("maturityDate.ButtonFreeText.Image")));
            this.maturityDate.ButtonFreeText.Text = resources.GetString("maturityDate.ButtonFreeText.Text");
            this.maturityDate.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            // 
            // 
            // 
            this.maturityDate.MonthCalendar.AnnuallyMarkedDates = ((System.DateTime[])(resources.GetObject("maturityDate.MonthCalendar.AnnuallyMarkedDates")));
            // 
            // 
            // 
            this.maturityDate.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.maturityDate.MonthCalendar.Category = resources.GetString("maturityDate.MonthCalendar.Category");
            this.maturityDate.MonthCalendar.ClearButtonVisible = true;
            this.maturityDate.MonthCalendar.CommandParameter = ((object)(resources.GetObject("maturityDate.MonthCalendar.CommandParameter")));
            // 
            // 
            // 
            this.maturityDate.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.maturityDate.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.maturityDate.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.maturityDate.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.maturityDate.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.maturityDate.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.maturityDate.MonthCalendar.DayNames = ((string[])(resources.GetObject("maturityDate.MonthCalendar.DayNames")));
            this.maturityDate.MonthCalendar.Description = resources.GetString("maturityDate.MonthCalendar.Description");
            this.maturityDate.MonthCalendar.DisplayMonth = new System.DateTime(2020, 7, 1, 0, 0, 0, 0);
            this.maturityDate.MonthCalendar.MarkedDates = ((System.DateTime[])(resources.GetObject("maturityDate.MonthCalendar.MarkedDates")));
            this.maturityDate.MonthCalendar.MonthlyMarkedDates = ((System.DateTime[])(resources.GetObject("maturityDate.MonthCalendar.MonthlyMarkedDates")));
            // 
            // 
            // 
            this.maturityDate.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.maturityDate.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.maturityDate.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.maturityDate.MonthCalendar.Tag = resources.GetString("maturityDate.MonthCalendar.Tag");
            this.maturityDate.MonthCalendar.Text = resources.GetString("maturityDate.MonthCalendar.Text");
            this.maturityDate.MonthCalendar.TodayButtonVisible = true;
            this.maturityDate.MonthCalendar.Tooltip = resources.GetString("maturityDate.MonthCalendar.Tooltip");
            this.maturityDate.MonthCalendar.WeeklyMarkedDays = ((System.DayOfWeek[])(resources.GetObject("maturityDate.MonthCalendar.WeeklyMarkedDays")));
            this.maturityDate.Name = "maturityDate";
            this.maturityDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.maturityDate_KeyDown);
            // 
            // intrestRate
            // 
            resources.ApplyResources(this.intrestRate, "intrestRate");
            // 
            // 
            // 
            this.intrestRate.BackgroundStyle.Class = "DateTimeInputBackground";
            this.intrestRate.ButtonClear.DisplayPosition = ((int)(resources.GetObject("intrestRate.ButtonClear.DisplayPosition")));
            this.intrestRate.ButtonClear.Image = ((System.Drawing.Image)(resources.GetObject("intrestRate.ButtonClear.Image")));
            this.intrestRate.ButtonClear.Text = resources.GetString("intrestRate.ButtonClear.Text");
            this.intrestRate.ButtonCustom.DisplayPosition = ((int)(resources.GetObject("intrestRate.ButtonCustom.DisplayPosition")));
            this.intrestRate.ButtonCustom.Image = ((System.Drawing.Image)(resources.GetObject("intrestRate.ButtonCustom.Image")));
            this.intrestRate.ButtonCustom.Text = resources.GetString("intrestRate.ButtonCustom.Text");
            this.intrestRate.ButtonCustom2.DisplayPosition = ((int)(resources.GetObject("intrestRate.ButtonCustom2.DisplayPosition")));
            this.intrestRate.ButtonCustom2.Image = ((System.Drawing.Image)(resources.GetObject("intrestRate.ButtonCustom2.Image")));
            this.intrestRate.ButtonCustom2.Text = resources.GetString("intrestRate.ButtonCustom2.Text");
            this.intrestRate.ButtonDropDown.DisplayPosition = ((int)(resources.GetObject("intrestRate.ButtonDropDown.DisplayPosition")));
            this.intrestRate.ButtonDropDown.Image = ((System.Drawing.Image)(resources.GetObject("intrestRate.ButtonDropDown.Image")));
            this.intrestRate.ButtonDropDown.Text = resources.GetString("intrestRate.ButtonDropDown.Text");
            this.intrestRate.ButtonFreeText.DisplayPosition = ((int)(resources.GetObject("intrestRate.ButtonFreeText.DisplayPosition")));
            this.intrestRate.ButtonFreeText.Image = ((System.Drawing.Image)(resources.GetObject("intrestRate.ButtonFreeText.Image")));
            this.intrestRate.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.intrestRate.ButtonFreeText.Text = resources.GetString("intrestRate.ButtonFreeText.Text");
            this.intrestRate.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.intrestRate.Increment = 0.01D;
            this.intrestRate.MinValue = 0D;
            this.intrestRate.Name = "intrestRate";
            this.intrestRate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.intrestRate_KeyDown);
            // 
            // LoanRow
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.intrestRate);
            this.Controls.Add(this.maturityDate);
            this.Controls.Add(this.startDate);
            this.Controls.Add(this.paySer);
            this.Controls.Add(this.PayValue);
            this.Name = "LoanRow";
            ((System.ComponentModel.ISupportInitialize)(this.PayValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paySer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maturityDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.intrestRate)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public DevComponents.Editors.DoubleInput PayValue;
        public DevComponents.Editors.IntegerInput paySer;
        public DevComponents.Editors.DateTimeAdv.DateTimeInput startDate;
        public DevComponents.Editors.DateTimeAdv.DateTimeInput maturityDate;
        public DevComponents.Editors.DoubleInput intrestRate;
    }
}
