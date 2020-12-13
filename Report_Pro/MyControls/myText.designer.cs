namespace Report_Pro.MyControls
{
    partial class myText
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
            this.t = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // t
            // 
            this.t.Dock = System.Windows.Forms.DockStyle.Fill;
            this.t.Location = new System.Drawing.Point(0, 0);
            this.t.Margin = new System.Windows.Forms.Padding(0);
            this.t.Name = "t";
            this.t.Size = new System.Drawing.Size(96, 27);
            this.t.TabIndex = 0;
            this.t.TextChanged += new System.EventHandler(this.t_TextChanged);
            this.t.KeyDown += new System.Windows.Forms.KeyEventHandler(this.t_KeyDown);
            // 
            // myText
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.t);
            this.Name = "myText";
            this.Size = new System.Drawing.Size(96, 23);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox t;
    }
}
