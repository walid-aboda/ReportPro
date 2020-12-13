namespace Report_Pro.PL
{
    partial class frm_SearchAcc
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.radioTransaction = new System.Windows.Forms.RadioButton();
            this.radioParent = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtsearchID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearchName = new System.Windows.Forms.TextBox();
            this.DGV1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.txtsearchID);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtSearchName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(576, 73);
            this.panel1.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.radioTransaction);
            this.panel3.Controls.Add(this.radioParent);
            this.panel3.Location = new System.Drawing.Point(7, 7);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(125, 56);
            this.panel3.TabIndex = 26;
            // 
            // radioTransaction
            // 
            this.radioTransaction.AutoSize = true;
            this.radioTransaction.Checked = true;
            this.radioTransaction.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.radioTransaction.Location = new System.Drawing.Point(5, 31);
            this.radioTransaction.Name = "radioTransaction";
            this.radioTransaction.Size = new System.Drawing.Size(105, 17);
            this.radioTransaction.TabIndex = 24;
            this.radioTransaction.TabStop = true;
            this.radioTransaction.Text = "الحسابات الفرعية";
            this.radioTransaction.UseVisualStyleBackColor = true;
            this.radioTransaction.CheckedChanged += new System.EventHandler(this.radioTransaction_CheckedChanged);
            // 
            // radioParent
            // 
            this.radioParent.AutoSize = true;
            this.radioParent.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.radioParent.Location = new System.Drawing.Point(15, 7);
            this.radioParent.Name = "radioParent";
            this.radioParent.Size = new System.Drawing.Size(95, 17);
            this.radioParent.TabIndex = 23;
            this.radioParent.Text = "جميع الحسابات";
            this.radioParent.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(486, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "رقم الحساب";
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Location = new System.Drawing.Point(158, 10);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(69, 35);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "بحث";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtsearchID
            // 
            this.txtsearchID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtsearchID.Location = new System.Drawing.Point(325, 10);
            this.txtsearchID.Name = "txtsearchID";
            this.txtsearchID.Size = new System.Drawing.Size(155, 20);
            this.txtsearchID.TabIndex = 7;
            this.txtsearchID.TextChanged += new System.EventHandler(this.txtsearchID_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(481, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "اسم الحساب";
            // 
            // txtSearchName
            // 
            this.txtSearchName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearchName.Location = new System.Drawing.Point(233, 32);
            this.txtSearchName.Name = "txtSearchName";
            this.txtSearchName.Size = new System.Drawing.Size(247, 20);
            this.txtSearchName.TabIndex = 4;
            this.txtSearchName.TextChanged += new System.EventHandler(this.txtSearchName_TextChanged);
            // 
            // DGV1
            // 
            this.DGV1.AllowUserToAddRows = false;
            this.DGV1.AllowUserToDeleteRows = false;
            this.DGV1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.DGV1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV1.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.DGV1.Location = new System.Drawing.Point(0, 73);
            this.DGV1.Name = "DGV1";
            this.DGV1.ReadOnly = true;
            this.DGV1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV1.Size = new System.Drawing.Size(576, 315);
            this.DGV1.TabIndex = 5;
            this.DGV1.DoubleClick += new System.EventHandler(this.DGV1_DoubleClick);
            // 
            // frm_SearchAcc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 388);
            this.Controls.Add(this.DGV1);
            this.Controls.Add(this.panel1);
            this.Name = "frm_SearchAcc";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "ص";
            this.Load += new System.EventHandler(this.frm_SearchAcc_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.RadioButton radioTransaction;
        public System.Windows.Forms.RadioButton radioParent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtsearchID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearchName;
        public System.Windows.Forms.DataGridView DGV1;
    }
}