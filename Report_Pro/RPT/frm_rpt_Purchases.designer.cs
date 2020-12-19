namespace Report_Pro.RPT
{
    partial class frm_rpt_Purchases
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_rpt_Purchases));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnOption = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cmb_DimCategory = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.payment_type = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.category = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dTP2 = new System.Windows.Forms.DateTimePicker();
            this.dTP1 = new System.Windows.Forms.DateTimePicker();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.Lc_Acc = new Report_Pro.MyControls.UC_Acc();
            this.label10 = new System.Windows.Forms.Label();
            this.Uc_Group = new Report_Pro.MyControls.Uc_Group();
            this.label9 = new System.Windows.Forms.Label();
            this.Uc_Acc = new Report_Pro.MyControls.UC_Acc();
            this.label7 = new System.Windows.Forms.Label();
            this.UC_Branch = new Report_Pro.MyControls.UC_Branch();
            this.thick_2 = new System.Windows.Forms.NumericUpDown();
            this.thick_1 = new System.Windows.Forms.NumericUpDown();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_purchase_byACC = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.thick_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thick_1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnOption);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnOption
            // 
            this.btnOption.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnOption.FlatAppearance.BorderSize = 0;
            this.btnOption.ForeColor = System.Drawing.SystemColors.Window;
            resources.ApplyResources(this.btnOption, "btnOption");
            this.btnOption.Name = "btnOption";
            this.btnOption.UseVisualStyleBackColor = false;
            this.btnOption.Click += new System.EventHandler(this.btnOption_Click);
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label5.Name = "label5";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // cmb_DimCategory
            // 
            resources.ApplyResources(this.cmb_DimCategory, "cmb_DimCategory");
            this.cmb_DimCategory.FormattingEnabled = true;
            this.cmb_DimCategory.Items.AddRange(new object[] {
            resources.GetString("cmb_DimCategory.Items"),
            resources.GetString("cmb_DimCategory.Items1"),
            resources.GetString("cmb_DimCategory.Items2")});
            this.cmb_DimCategory.Name = "cmb_DimCategory";
            this.cmb_DimCategory.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label8.Name = "label8";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // payment_type
            // 
            resources.ApplyResources(this.payment_type, "payment_type");
            this.payment_type.FormattingEnabled = true;
            this.payment_type.Items.AddRange(new object[] {
            resources.GetString("payment_type.Items"),
            resources.GetString("payment_type.Items1"),
            resources.GetString("payment_type.Items2")});
            this.payment_type.Name = "payment_type";
            this.payment_type.SelectedIndexChanged += new System.EventHandler(this.payment_type_SelectedIndexChanged);
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label6.Name = "label6";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label4.Name = "label4";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label3.Name = "label3";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // category
            // 
            resources.ApplyResources(this.category, "category");
            this.category.FormattingEnabled = true;
            this.category.Name = "category";
            this.category.SelectedIndexChanged += new System.EventHandler(this.category_SelectedIndexChanged);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label2.Name = "label2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Name = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dTP2
            // 
            resources.ApplyResources(this.dTP2, "dTP2");
            this.dTP2.Name = "dTP2";
            // 
            // dTP1
            // 
            resources.ApplyResources(this.dTP1, "dTP1");
            this.dTP1.Name = "dTP1";
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            resources.ApplyResources(this.crystalReportViewer1, "crystalReportViewer1");
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            // 
            // button6
            // 
            resources.ApplyResources(this.button6, "button6");
            this.button6.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.ForeColor = System.Drawing.SystemColors.Window;
            this.button6.Name = "button6";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            resources.ApplyResources(this.button7, "button7");
            this.button7.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.ForeColor = System.Drawing.SystemColors.Window;
            this.button7.Name = "button7";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            resources.ApplyResources(this.button8, "button8");
            this.button8.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.ForeColor = System.Drawing.SystemColors.Window;
            this.button8.Name = "button8";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            resources.ApplyResources(this.button9, "button9");
            this.button9.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.ForeColor = System.Drawing.SystemColors.Window;
            this.button9.Name = "button9";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            resources.ApplyResources(this.button10, "button10");
            this.button10.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button10.FlatAppearance.BorderSize = 0;
            this.button10.ForeColor = System.Drawing.SystemColors.Window;
            this.button10.Name = "button10";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.Lc_Acc);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.Uc_Group);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.Uc_Acc);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.UC_Branch);
            this.groupBox1.Controls.Add(this.thick_2);
            this.groupBox1.Controls.Add(this.thick_1);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dTP1);
            this.groupBox1.Controls.Add(this.category);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dTP2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.payment_type);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.cmb_DimCategory);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label11.Name = "label11";
            // 
            // Lc_Acc
            // 
            resources.ApplyResources(this.Lc_Acc, "Lc_Acc");
            this.Lc_Acc.BackColor = System.Drawing.Color.Transparent;
            this.Lc_Acc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Lc_Acc.Name = "Lc_Acc";
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label10.Name = "label10";
            // 
            // Uc_Group
            // 
            resources.ApplyResources(this.Uc_Group, "Uc_Group");
            this.Uc_Group.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Uc_Group.Name = "Uc_Group";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label9.Name = "label9";
            // 
            // Uc_Acc
            // 
            resources.ApplyResources(this.Uc_Acc, "Uc_Acc");
            this.Uc_Acc.BackColor = System.Drawing.Color.Transparent;
            this.Uc_Acc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Uc_Acc.Name = "Uc_Acc";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label7.Name = "label7";
            // 
            // UC_Branch
            // 
            resources.ApplyResources(this.UC_Branch, "UC_Branch");
            this.UC_Branch.BackColor = System.Drawing.Color.Transparent;
            this.UC_Branch.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.UC_Branch.Cursor = System.Windows.Forms.Cursors.Default;
            this.UC_Branch.Name = "UC_Branch";
            // 
            // thick_2
            // 
            resources.ApplyResources(this.thick_2, "thick_2");
            this.thick_2.DecimalPlaces = 2;
            this.thick_2.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.thick_2.Name = "thick_2";
            // 
            // thick_1
            // 
            resources.ApplyResources(this.thick_1, "thick_1");
            this.thick_1.DecimalPlaces = 2;
            this.thick_1.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.thick_1.Name = "thick_1";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.btn_purchase_byACC);
            this.groupBox3.Controls.Add(this.button14);
            this.groupBox3.Controls.Add(this.button6);
            this.groupBox3.Controls.Add(this.button7);
            this.groupBox3.Controls.Add(this.button10);
            this.groupBox3.Controls.Add(this.button8);
            this.groupBox3.Controls.Add(this.button9);
            this.groupBox3.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // btn_purchase_byACC
            // 
            resources.ApplyResources(this.btn_purchase_byACC, "btn_purchase_byACC");
            this.btn_purchase_byACC.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_purchase_byACC.FlatAppearance.BorderSize = 0;
            this.btn_purchase_byACC.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_purchase_byACC.Name = "btn_purchase_byACC";
            this.btn_purchase_byACC.UseVisualStyleBackColor = false;
            this.btn_purchase_byACC.Click += new System.EventHandler(this.button16_Click);
            // 
            // button14
            // 
            resources.ApplyResources(this.button14, "button14");
            this.button14.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button14.FlatAppearance.BorderSize = 0;
            this.button14.ForeColor = System.Drawing.SystemColors.Window;
            this.button14.Name = "button14";
            this.button14.UseVisualStyleBackColor = false;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.ForeColor = System.Drawing.SystemColors.Window;
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // frm_rpt_Purchases
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.panel1);
            this.Name = "frm_rpt_Purchases";
            this.Load += new System.EventHandler(this.frm_rpt_Purchases_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.thick_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thick_1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dTP2;
        private System.Windows.Forms.DateTimePicker dTP1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox category;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox payment_type;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmb_DimCategory;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.NumericUpDown thick_2;
        private System.Windows.Forms.NumericUpDown thick_1;
        private System.Windows.Forms.Button btnOption;
        private System.Windows.Forms.Label label7;
        private MyControls.UC_Branch UC_Branch;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Label label9;
        private MyControls.UC_Acc Uc_Acc;
        private System.Windows.Forms.Button btn_purchase_byACC;
        private System.Windows.Forms.Label label10;
        private MyControls.Uc_Group Uc_Group;
        private System.Windows.Forms.Label label11;
        private MyControls.UC_Acc Lc_Acc;
        private System.Windows.Forms.Button button1;
    }
}