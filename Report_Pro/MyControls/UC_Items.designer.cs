namespace Report_Pro.MyControls
{
    partial class UC_Items
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Items));
            this.Desc = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btn1 = new DevComponents.DotNetBar.ButtonX();
            this.ID = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.itemPrice = new DevComponents.Editors.DoubleInput();
            this.itemWeight = new DevComponents.Editors.DoubleInput();
            this.itemUnit = new DevComponents.DotNetBar.Controls.TextBoxX();
            ((System.ComponentModel.ISupportInitialize)(this.itemPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemWeight)).BeginInit();
            this.SuspendLayout();
            // 
            // Desc
            // 
            // 
            // 
            // 
            this.Desc.Border.Class = "TextBoxBorder";
            resources.ApplyResources(this.Desc, "Desc");
            this.Desc.Name = "Desc";
            this.Desc.ReadOnly = true;
            this.Desc.TextChanged += new System.EventHandler(this.Desc_TextChanged);
            // 
            // btn1
            // 
            this.btn1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn1.Image = global::Report_Pro.Properties.Resources.search_16;
            resources.ApplyResources(this.btn1, "btn1");
            this.btn1.Name = "btn1";
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // ID
            // 
            // 
            // 
            // 
            this.ID.Border.Class = "TextBoxBorder";
            resources.ApplyResources(this.ID, "ID");
            this.ID.Name = "ID";
            this.ID.TextChanged += new System.EventHandler(this.ID_TextChanged);
            this.ID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ID_KeyDown);
            this.ID.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ID_KeyUp);
            // 
            // itemPrice
            // 
            // 
            // 
            // 
            this.itemPrice.BackgroundStyle.Class = "DateTimeInputBackground";
            this.itemPrice.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.itemPrice.Increment = 1D;
            resources.ApplyResources(this.itemPrice, "itemPrice");
            this.itemPrice.Name = "itemPrice";
            this.itemPrice.ShowUpDown = true;
            // 
            // itemWeight
            // 
            // 
            // 
            // 
            this.itemWeight.BackgroundStyle.Class = "DateTimeInputBackground";
            this.itemWeight.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.itemWeight.Increment = 1D;
            resources.ApplyResources(this.itemWeight, "itemWeight");
            this.itemWeight.Name = "itemWeight";
            this.itemWeight.ShowUpDown = true;
            // 
            // itemUnit
            // 
            // 
            // 
            // 
            this.itemUnit.Border.Class = "TextBoxBorder";
            resources.ApplyResources(this.itemUnit, "itemUnit");
            this.itemUnit.Name = "itemUnit";
            // 
            // UC_Items
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.itemUnit);
            this.Controls.Add(this.itemWeight);
            this.Controls.Add(this.itemPrice);
            this.Controls.Add(this.Desc);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.ID);
            this.Name = "UC_Items";
            this.Load += new System.EventHandler(this.UC_Catogry_Load);
            ((System.ComponentModel.ISupportInitialize)(this.itemPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemWeight)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public DevComponents.DotNetBar.Controls.TextBoxX Desc;
        private DevComponents.DotNetBar.ButtonX btn1;
        public DevComponents.DotNetBar.Controls.TextBoxX ID;
        public DevComponents.Editors.DoubleInput itemPrice;
        public DevComponents.Editors.DoubleInput itemWeight;
        public DevComponents.DotNetBar.Controls.TextBoxX itemUnit;
    }
}
