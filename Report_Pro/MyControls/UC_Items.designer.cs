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
            this.ID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ID_KeyDown);
            this.ID.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ID_KeyUp);
            this.ID.TextChanged += new System.EventHandler(this.ID_TextChanged);
            // 
            // UC_Items
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.Desc);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.ID);
            this.Name = "UC_Items";
            this.Load += new System.EventHandler(this.UC_Catogry_Load);
            this.ResumeLayout(false);

        }

        #endregion
        public DevComponents.DotNetBar.Controls.TextBoxX Desc;
        private DevComponents.DotNetBar.ButtonX btn1;
        public DevComponents.DotNetBar.Controls.TextBoxX ID;
    }
}
