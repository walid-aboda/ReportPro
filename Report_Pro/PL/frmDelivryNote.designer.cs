namespace Report_Pro.PL
{
    partial class frmDelivryNote
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
            if (disposing && this.components != null)
                this.components.Dispose();
            base.Dispose(disposing);
        }


        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {

            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.delivryRow1 = new MyControls.delivryRow();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            this.flowLayoutPanel1.Controls.Add(delivryRow1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(13, 71);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(719, 333);
            this.flowLayoutPanel1.TabIndex = 0;
            this.flowLayoutPanel1.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.flowLayoutPanel1_PreviewKeyDown_1);
            this.delivryRow1.Location = new System.Drawing.Point(3, 3);
            this.delivryRow1.Name = "delivryRow1";
            this.delivryRow1.Size = new System.Drawing.Size(710, 27);
            this.delivryRow1.TabIndex = 0;
            this.delivryRow1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.delivryRow1_KeyDown);
            this.AutoScaleDimensions = new System.Drawing.SizeF(9f, 19f);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 450);
            this.Controls.Add(flowLayoutPanel1);
            this.KeyPreview = true;
            this.Name = "frmDelivryNote";
            this.Text = "frmDelivryNote";
            this.Load += new System.EventHandler(this.frmDelivryNote_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmDelivryNote_KeyDown);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private MyControls.delivryRow r = new MyControls.delivryRow();
       // private System.ComponentModel.IContainer components = (System.ComponentModel.IContainer)null;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private MyControls.delivryRow delivryRow1;
    }
}