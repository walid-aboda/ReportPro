namespace Report_Pro.RPT
{
    partial class frm_local_sales
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.UC_PayType = new Report_Pro.MyControls.UC_PayType();
            this.UC_Acc = new Report_Pro.MyControls.UC_Acc();
            this.UC_Branch = new Report_Pro.MyControls.UC_Branch();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.btn_Report = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dTP2 = new System.Windows.Forms.DateTimePicker();
            this.dTP1 = new System.Windows.Forms.DateTimePicker();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.UC_PayType);
            this.panel1.Controls.Add(this.UC_Acc);
            this.panel1.Controls.Add(this.UC_Branch);
            this.panel1.Controls.Add(this.labelX6);
            this.panel1.Controls.Add(this.labelX5);
            this.panel1.Controls.Add(this.labelX4);
            this.panel1.Controls.Add(this.btn_Report);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dTP2);
            this.panel1.Controls.Add(this.dTP1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1438, 142);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // UC_PayType
            // 
            this.UC_PayType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.UC_PayType.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.UC_PayType.Location = new System.Drawing.Point(854, 95);
            this.UC_PayType.Margin = new System.Windows.Forms.Padding(0);
            this.UC_PayType.Name = "UC_PayType";
            this.UC_PayType.Size = new System.Drawing.Size(463, 32);
            this.UC_PayType.TabIndex = 311;
            // 
            // UC_Acc
            // 
            this.UC_Acc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.UC_Acc.BackColor = System.Drawing.Color.Transparent;
            this.UC_Acc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.UC_Acc.Location = new System.Drawing.Point(850, 57);
            this.UC_Acc.Margin = new System.Windows.Forms.Padding(0);
            this.UC_Acc.Name = "UC_Acc";
            this.UC_Acc.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.UC_Acc.Size = new System.Drawing.Size(463, 35);
            this.UC_Acc.TabIndex = 310;
            // 
            // UC_Branch
            // 
            this.UC_Branch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.UC_Branch.BackColor = System.Drawing.Color.Transparent;
            this.UC_Branch.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.UC_Branch.Cursor = System.Windows.Forms.Cursors.Default;
            this.UC_Branch.Location = new System.Drawing.Point(850, 16);
            this.UC_Branch.Margin = new System.Windows.Forms.Padding(0);
            this.UC_Branch.Name = "UC_Branch";
            this.UC_Branch.Size = new System.Drawing.Size(463, 33);
            this.UC_Branch.TabIndex = 309;
            // 
            // labelX6
            // 
            this.labelX6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelX6.AutoSize = true;
            this.labelX6.BackColor = System.Drawing.Color.Transparent;
            this.labelX6.Location = new System.Drawing.Point(1323, 95);
            this.labelX6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(87, 24);
            this.labelX6.TabIndex = 308;
            this.labelX6.Text = "طريقة الدفع";
            // 
            // labelX5
            // 
            this.labelX5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelX5.AutoSize = true;
            this.labelX5.BackColor = System.Drawing.Color.Transparent;
            this.labelX5.Location = new System.Drawing.Point(1323, 50);
            this.labelX5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(63, 24);
            this.labelX5.TabIndex = 307;
            this.labelX5.Text = "الحساب";
            // 
            // labelX4
            // 
            this.labelX4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelX4.AutoSize = true;
            this.labelX4.BackColor = System.Drawing.Color.Transparent;
            this.labelX4.Location = new System.Drawing.Point(1323, 16);
            this.labelX4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(42, 24);
            this.labelX4.TabIndex = 306;
            this.labelX4.Text = "الفرع";
            // 
            // btn_Report
            // 
            this.btn_Report.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Report.Location = new System.Drawing.Point(410, 31);
            this.btn_Report.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Report.Name = "btn_Report";
            this.btn_Report.Size = new System.Drawing.Size(135, 53);
            this.btn_Report.TabIndex = 6;
            this.btn_Report.Text = "التقرير";
            this.btn_Report.UseVisualStyleBackColor = true;
            this.btn_Report.Click += new System.EventHandler(this.btn_Report_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(735, 70);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "الي تاريخ";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(735, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "من تاريخ";
            // 
            // dTP2
            // 
            this.dTP2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dTP2.Location = new System.Drawing.Point(570, 64);
            this.dTP2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dTP2.Name = "dTP2";
            this.dTP2.Size = new System.Drawing.Size(154, 27);
            this.dTP2.TabIndex = 1;
            // 
            // dTP1
            // 
            this.dTP1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dTP1.Location = new System.Drawing.Point(570, 31);
            this.dTP1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dTP1.Name = "dTP1";
            this.dTP1.Size = new System.Drawing.Size(154, 27);
            this.dTP1.TabIndex = 0;
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 142);
            this.crystalReportViewer1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.SelectionFormula = "";
            this.crystalReportViewer1.Size = new System.Drawing.Size(1438, 535);
            this.crystalReportViewer1.TabIndex = 5;
            this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            this.crystalReportViewer1.ToolPanelWidth = 300;
            this.crystalReportViewer1.ViewTimeSelectionFormula = "";
            // 
            // frm_local_sales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1438, 677);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frm_local_sales";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "المبيعات المحلية 5%";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Report;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dTP2;
        private System.Windows.Forms.DateTimePicker dTP1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private MyControls.UC_PayType UC_PayType;
        private MyControls.UC_Acc UC_Acc;
        private MyControls.UC_Branch UC_Branch;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.LabelX labelX4;
    }
}