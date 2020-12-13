namespace Report_Pro.MyControls
{
    partial class jorDebit
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.txtDebitTotal = new DevComponents.Editors.DoubleInput();
            this.jorHead1 = new Report_Pro.MyControls.JorHead();
            this.jor_Row1 = new Report_Pro.MyControls.Jor_Row();
            this.jor_Row2 = new Report_Pro.MyControls.Jor_Row();
            this.jor_Row3 = new Report_Pro.MyControls.Jor_Row();
            this.jor_Row4 = new Report_Pro.MyControls.Jor_Row();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDebitTotal)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.Control;
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Controls.Add(this.jor_Row1);
            this.flowLayoutPanel1.Controls.Add(this.jor_Row2);
            this.flowLayoutPanel1.Controls.Add(this.jor_Row3);
            this.flowLayoutPanel1.Controls.Add(this.jor_Row4);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 50);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1807, 273);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // labelX2
            // 
            this.labelX2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelX2.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX2.Location = new System.Drawing.Point(1372, 326);
            this.labelX2.Margin = new System.Windows.Forms.Padding(0);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(188, 34);
            this.labelX2.TabIndex = 2;
            this.labelX2.Text = "اجمالي المدين";
            this.labelX2.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // txtDebitTotal
            // 
            // 
            // 
            // 
            this.txtDebitTotal.BackgroundStyle.Class = "DateTimeInputBackground";
            this.txtDebitTotal.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.txtDebitTotal.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDebitTotal.Increment = 1D;
            this.txtDebitTotal.Location = new System.Drawing.Point(1565, 329);
            this.txtDebitTotal.Name = "txtDebitTotal";
            this.txtDebitTotal.Size = new System.Drawing.Size(188, 29);
            this.txtDebitTotal.TabIndex = 3;
            // 
            // jorHead1
            // 
            this.jorHead1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.jorHead1.Location = new System.Drawing.Point(5, 12);
            this.jorHead1.Margin = new System.Windows.Forms.Padding(0);
            this.jorHead1.Name = "jorHead1";
            this.jorHead1.Size = new System.Drawing.Size(1704, 35);
            this.jorHead1.TabIndex = 1;
            // 
            // jor_Row1
            // 
            this.jor_Row1.BackColor = System.Drawing.SystemColors.Control;
            this.jor_Row1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.jor_Row1.Location = new System.Drawing.Point(0, 0);
            this.jor_Row1.Margin = new System.Windows.Forms.Padding(0);
            this.jor_Row1.Name = "jor_Row1";
            this.jor_Row1.Padding = new System.Windows.Forms.Padding(3);
            this.jor_Row1.Size = new System.Drawing.Size(1786, 80);
            this.jor_Row1.TabIndex = 0;
            // 
            // jor_Row2
            // 
            this.jor_Row2.BackColor = System.Drawing.SystemColors.Control;
            this.jor_Row2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.jor_Row2.Location = new System.Drawing.Point(0, 80);
            this.jor_Row2.Margin = new System.Windows.Forms.Padding(0);
            this.jor_Row2.Name = "jor_Row2";
            this.jor_Row2.Padding = new System.Windows.Forms.Padding(3);
            this.jor_Row2.Size = new System.Drawing.Size(1786, 80);
            this.jor_Row2.TabIndex = 1;
            // 
            // jor_Row3
            // 
            this.jor_Row3.BackColor = System.Drawing.SystemColors.Control;
            this.jor_Row3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.jor_Row3.Location = new System.Drawing.Point(0, 160);
            this.jor_Row3.Margin = new System.Windows.Forms.Padding(0);
            this.jor_Row3.Name = "jor_Row3";
            this.jor_Row3.Padding = new System.Windows.Forms.Padding(3);
            this.jor_Row3.Size = new System.Drawing.Size(1786, 80);
            this.jor_Row3.TabIndex = 2;
            // 
            // jor_Row4
            // 
            this.jor_Row4.BackColor = System.Drawing.SystemColors.Control;
            this.jor_Row4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.jor_Row4.Location = new System.Drawing.Point(0, 240);
            this.jor_Row4.Margin = new System.Windows.Forms.Padding(0);
            this.jor_Row4.Name = "jor_Row4";
            this.jor_Row4.Padding = new System.Windows.Forms.Padding(3);
            this.jor_Row4.Size = new System.Drawing.Size(1786, 80);
            this.jor_Row4.TabIndex = 3;
            // 
            // jorDebit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtDebitTotal);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.jorHead1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Name = "jorDebit";
            this.Size = new System.Drawing.Size(1825, 384);
            this.Load += new System.EventHandler(this.UserControl2_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtDebitTotal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private JorHead jorHead1;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.Editors.DoubleInput txtDebitTotal;
        private Jor_Row jor_Row1;
        private Jor_Row jor_Row2;
        private Jor_Row jor_Row3;
        private Jor_Row jor_Row4;
    }
}
