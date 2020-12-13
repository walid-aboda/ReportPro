using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing; using System.Linq;
//using System.Linq;
using System.Reflection;
using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;

namespace Report_Pro.RPT
{
    public partial class frm_rpt_Purchases : Form
    {
        string db1 = Properties.Settings.Default.Database_1;
        DAL.DataAccesslayer1 dal = new DAL.DataAccesslayer1();
        string sp;
       
        string pay_code = "";

        public frm_rpt_Purchases()
        {
            InitializeComponent();
            category.DataSource = dal.getDataTabl("Get_category_",db1);
            category.DisplayMember = "Category_name";
            category.ValueMember = "Category_code";
            category.SelectedIndex = -1;

            cmb_DimCategory.DataSource = dal.getDataTabl_1(@"select * FROM "+Properties.Settings.Default.Database_1+".dbo.Wh_Unit_dim");
            cmb_DimCategory.DisplayMember = "Wh_Unit_dim";
            cmb_DimCategory.ValueMember = "Wh_Unit_dim";
            cmb_DimCategory.SelectedIndex = -1;

        }
        private void btn_Report_Click(object sender, EventArgs e)
        {
       
        try
            {
                groupBox1.Visible = false;
                double T1,T2;
                if (thick_1.Text == "")
                { T1 = 0; }
                else { T1 = Convert.ToDouble(thick_1.Text); }
                if (thick_2.Text == "" || thick_2.Value == 0)
                { T2 = 10000; }
                else { T2 = Convert.ToDouble(thick_2.Text); }

                if (payment_type.SelectedIndex == 0)
                {
                    pay_code = "";
                }
                else if (payment_type.SelectedIndex == 1)
                {
                    pay_code = "11";
                }
                else if (payment_type.SelectedIndex == 2)
                {
                    pay_code = "2";
                }
                
                

                RPT.CrystalReport3 rpt = new RPT.CrystalReport3();

                rpt.SetDataSource(dal.getDataTabl("sales_by_branch_", dTP1.Value.Date, dTP2.Value.Date, pay_code, Convert.ToString(category.SelectedValue), T1, T2, Convert.ToString(cmb_DimCategory.SelectedValue), "xs",UC_Branch.ID.Text, Uc_Acc.ID.Text, db1));
                crystalReportViewer1.ReportSource = rpt;
                rpt.DataDefinition.FormulaFields["From_date"].Text = "'" + dTP1.Value.ToString("yyyy/MM/dd") + "'";
                rpt.DataDefinition.FormulaFields["To_Date"].Text = "'" + dTP2.Value.ToString("yyyy/MM/dd") + "'";
                rpt.DataDefinition.FormulaFields["From_thick"].Text = "'" + thick_1.Text + "'";
                rpt.DataDefinition.FormulaFields["To_thick"].Text = "'" + thick_2.Text + "'";
                rpt.DataDefinition.FormulaFields["Catogery"].Text = "'" + category.Text + "'";
                rpt.DataDefinition.FormulaFields["Dim_category"].Text = "'" + cmb_DimCategory.Text + "'";
                rpt.DataDefinition.FormulaFields["payment_"].Text = "'" + payment_type.Text + "'";
                rpt.DataDefinition.FormulaFields["Type_"].Text = "'تقرير المبيعات موزع بالفروع'";

            }
            catch
            { }


        }

       

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                groupBox1.Visible = false;
                double T1, T2;
                if (thick_1.Text == "")
                { T1 = 0; }
                else { T1 = Convert.ToDouble(thick_1.Text); }
                if (thick_2.Text == "" || thick_2.Value == 0)
                { T2 = 10000; }
                else { T2 = Convert.ToDouble(thick_2.Text); }

    
                if (payment_type.SelectedIndex == 0)
                {
                    pay_code = "";
                }
                else if (payment_type.SelectedIndex == 1)
                {
                    pay_code = "11";
                }
                else if (payment_type.SelectedIndex == 2)
                {
                    pay_code = "2";
                }

                
                RPT.sales_by_group rpt = new RPT.sales_by_group();


                rpt.SetDataSource(dal.getDataTabl("sales_by_Group_", dTP1.Value.Date, dTP2.Value.Date, pay_code, Convert.ToString(category.SelectedValue), T1, T2, Convert.ToString(cmb_DimCategory.SelectedValue), "xs",db1,Uc_Acc.ID.Text,UC_Branch.ID.Text));


                crystalReportViewer1.ReportSource = rpt;
                rpt.DataDefinition.FormulaFields["From_date"].Text = "'" + dTP1.Value.ToString("yyyy/MM/dd") + "'";
                rpt.DataDefinition.FormulaFields["To_Date"].Text = "'" + dTP2.Value.ToString("yyyy/MM/dd") + "'";
                rpt.DataDefinition.FormulaFields["From_thick"].Text = "'" + thick_1.Text + "'";
                rpt.DataDefinition.FormulaFields["To_thick"].Text = "'" + thick_2.Text + "'";
                rpt.DataDefinition.FormulaFields["Catogery"].Text = "'" + category.Text + "'";
                rpt.DataDefinition.FormulaFields["Dim_category"].Text = "'" + cmb_DimCategory.Text + "'";
                rpt.DataDefinition.FormulaFields["payment_"].Text = "'" + payment_type.Text + "'";
                rpt.DataDefinition.FormulaFields["Type_"].Text = "'تقرير المبيعات موزع بالمجموعات'";
            }
           catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Cursor.Current = Cursors.Default;
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                groupBox1.Visible = false;
                double T1, T2;
                if (thick_1.Text == "")
                { T1 = 0; }
                else { T1 = Convert.ToDouble(thick_1.Text); }
                if (thick_2.Text == "" || thick_2.Value == 0)
                { T2 = 10000; }
                else { T2 = Convert.ToDouble(thick_2.Text); }

               if (payment_type.SelectedIndex == 0)
                {
                    pay_code = "";
                }
                else if (payment_type.SelectedIndex == 1)
                {
                    pay_code = "11";
                }
                else if (payment_type.SelectedIndex == 2)
                {
                    pay_code = "2";
                }


                RPT.rpt_sales_ByBranch rpt = new RPT.rpt_sales_ByBranch();

                rpt.SetDataSource(dal.getDataTabl("sales_by_branch_", dTP1.Value.Date, dTP2.Value.Date, pay_code, Convert.ToString(category.SelectedValue), T1, T2, Convert.ToString(cmb_DimCategory.SelectedValue), "xs",UC_Branch.ID.Text,Uc_Acc.ID.Text,db1));
                crystalReportViewer1.ReportSource = rpt;
                rpt.DataDefinition.FormulaFields["From_date"].Text = "'" + dTP1.Value.ToString("yyyy/MM/dd") + "'";
                rpt.DataDefinition.FormulaFields["To_Date"].Text = "'" + dTP2.Value.ToString("yyyy/MM/dd") + "'";
                rpt.DataDefinition.FormulaFields["From_thick"].Text = "'" + thick_1.Text + "'";
                rpt.DataDefinition.FormulaFields["To_thick"].Text = "'" + thick_2.Text + "'";
                rpt.DataDefinition.FormulaFields["Catogery"].Text = "'" + category.Text + "'";
                rpt.DataDefinition.FormulaFields["Dim_category"].Text = "'" + cmb_DimCategory.Text + "'";
                rpt.DataDefinition.FormulaFields["payment_"].Text = "'" + payment_type.Text + "'";
                rpt.DataDefinition.FormulaFields["Type_"].Text = "'تقرير المبيعات موزع بالفروع'";
            }
            catch
            { }
        }

        private void thick_2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            Cursor.Current = Cursors.WaitCursor;
            try
            {
                groupBox1.Visible = false;
                double T1, T2;
                if (thick_1.Text == "")
                { T1 = 0; }
                else { T1 = Convert.ToDouble(thick_1.Text); }
                if (thick_2.Text == "" || thick_2.Value == 0)
                { T2 = 10000; }
                else { T2 = Convert.ToDouble(thick_2.Text); }

         
                if (payment_type.SelectedIndex == 0)
                {
                    pay_code = "";
                }
                else if (payment_type.SelectedIndex == 1)
                {
                    pay_code = "11";
                }
                else if (payment_type.SelectedIndex == 2)
                {
                    pay_code = "2";
                }


                RPT.rpt_transaction_byGroup_payType rpt = new RPT.rpt_transaction_byGroup_payType();

                rpt.SetDataSource(dal.getDataTabl("sales_by_Group_Paytype_", dTP1.Value.Date, dTP2.Value.Date, pay_code, Convert.ToString(category.SelectedValue), T1, T2, Convert.ToString(cmb_DimCategory.SelectedValue), "xs",UC_Branch.ID.Text,Uc_Acc.ID.Text,db1));
                crystalReportViewer1.ReportSource = rpt;

                rpt.DataDefinition.FormulaFields["From_date"].Text = "'" + dTP1.Value.ToString("yyyy/MM/dd") + "'";
                rpt.DataDefinition.FormulaFields["To_Date"].Text = "'" + dTP2.Value.ToString("yyyy/MM/dd") + "'";
                rpt.DataDefinition.FormulaFields["From_thick"].Text = "'" + thick_1.Text + "'";
                rpt.DataDefinition.FormulaFields["To_thick"].Text = "'" + thick_2.Text + "'";
                rpt.DataDefinition.FormulaFields["Catogery"].Text = "'" + category.Text + "'";
                rpt.DataDefinition.FormulaFields["Dim_category"].Text = "'" + payment_type.Text + "'";
                rpt.DataDefinition.FormulaFields["Type_"].Text = "'تقرير المبيعات موزع بالمجموعات وطريقة الدفع'";
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Cursor.Current = Cursors.Default;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            double T1, T2;
            if (thick_1.Text == "")
            { T1 = 0; }
            else { T1 = Convert.ToDouble(thick_1.Text); }
            if (thick_2.Text == "" || thick_2.Value == 0)
            { T2 = 10000; }
            else { T2 = Convert.ToDouble(thick_2.Text); }

            if (payment_type.SelectedIndex == 0)
            {
                pay_code = "";
            }
            else if (payment_type.SelectedIndex == 1)
            {
                pay_code = "11";
            }
            else if (payment_type.SelectedIndex == 2)
            {
                pay_code = "2";
            }
            
            RPT.S_P_by_Items rpt = new RPT.S_P_by_Items();

            rpt.SetDataSource(dal.getDataTabl(@"sales_by_item_", dTP1.Value.Date, dTP2.Value.Date, pay_code, Convert.ToString(category.SelectedValue), T1, T2, Convert.ToString(cmb_DimCategory.SelectedValue), "xs", UC_Branch.ID.Text, Uc_Acc.ID.Text, db1));
            crystalReportViewer1.ReportSource = rpt;
          
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
                Cursor.Current = Cursors.WaitCursor;
                try
                {
                groupBox1.Visible = false;

                    double T1, T2;
                    if (thick_1.Text == "")
                    { T1 = 0; }
                    else { T1 = Convert.ToDouble(thick_1.Text); }
                if (thick_2.Text == "" || thick_2.Value == 0) 
                    { T2 = 10000; }
                    else { T2 = Convert.ToDouble(thick_2.Text); }

                    if (payment_type.SelectedIndex == 0)
                    {
                        pay_code = "";
                    }
                    else if (payment_type.SelectedIndex == 1)
                    {
                        pay_code = "11";
                    }
                    else if (payment_type.SelectedIndex == 2)
                    {
                        pay_code = "2";
                    }


                    RPT.Sales_Purchase_Groups rpt = new RPT.Sales_Purchase_Groups();

                    DataSet1 ds = new DataSet1();
                    DataTable dt1 = new DataTable();
                    DataTable dt2 = new DataTable();
                    DataTable dt3 = new DataTable();


                    dt1 = (dal.getDataTabl("sales_ByGroup__", dTP1.Value.Date, dTP2.Value.Date, pay_code, Convert.ToString(category.SelectedValue), T1, T2, Convert.ToString(cmb_DimCategory.SelectedValue),UC_Branch.ID.Text,Uc_Acc.ID.Text,db1));
                    dt2 = (dal.getDataTabl("Get_customers_payments", dTP1.Value.Date, dTP2.Value.Date,db1));
                    dt3 = (dal.getDataTabl("Sales_total", dTP1.Value.Date, dTP2.Value.Date,db1));

                    ds.Tables.Add(dt1);
                    ds.Tables.Add(dt2);
                    ds.Tables.Add(dt3);

                    ds.WriteXmlSchema("schema2.xml");
                    rpt.SetDataSource(ds);

                    crystalReportViewer1.ReportSource = rpt;
                    rpt.DataDefinition.FormulaFields["From_date"].Text = "'" + dTP1.Value.ToString("yyyy/MM/dd") + "'";
                    rpt.DataDefinition.FormulaFields["To_Date"].Text = "'" + dTP2.Value.ToString("yyyy/MM/dd") + "'";
                    rpt.DataDefinition.FormulaFields["From_thick"].Text = "'" + thick_1.Text + "'";
                    rpt.DataDefinition.FormulaFields["To_thick"].Text = "'" + thick_2.Text + "'";
                    rpt.DataDefinition.FormulaFields["Catogery"].Text = "'" + category.Text + "'";
                    rpt.DataDefinition.FormulaFields["Dim_category"].Text = "'" + payment_type.Text + "'";
                    rpt.DataDefinition.FormulaFields["Type_"].Text = "'ملخص المبيعات والمشتريات'";
                    rpt.DataDefinition.FormulaFields["company_name"].Text = "'" + Properties.Settings.Default.head_txt + "'";
                    rpt.DataDefinition.FormulaFields["branch_name"].Text = "'" + Properties.Settings.Default.Branch_txt + "'";
            }
                catch (System.Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                Cursor.Current = Cursors.Default;

            }

        private void category_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void payment_type_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void groupPanel2_Click(object sender, EventArgs e)
        {

        }

        private void groupPanel3_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
          
                //try
                //{
                groupBox1.Visible = false;
                    double T1, T2;
                    if (thick_1.Text == "")
                    { T1 = 0; }
                    else { T1 = Convert.ToDouble(thick_1.Text); }
                if (thick_2.Text == "" || thick_2.Value == 0)
                { T2 = 10000; }
                    else { T2 = Convert.ToDouble(thick_2.Text); }

                   if (payment_type.SelectedIndex == 0)
                    {
                        pay_code = "";
                    }
                    else if (payment_type.SelectedIndex == 1)
                    {
                        pay_code = "11";
                    }
                    else if (payment_type.SelectedIndex == 2)
                    {
                        pay_code = "2";
                    }



                    RPT.CrystalReport3 rpt = new RPT.CrystalReport3();

                rpt.SetDataSource(dal.getDataTabl("sales_by_branch_", dTP1.Value.Date, dTP2.Value.Date, pay_code, Convert.ToString(category.SelectedValue), T1, T2, Convert.ToString(cmb_DimCategory.SelectedValue), "xp",UC_Branch.ID.Text,Uc_Acc.ID.Text,db1,Uc_Group.ID.Text,""));
                crystalReportViewer1.ReportSource = rpt;
                rpt.DataDefinition.FormulaFields["From_date"].Text = "'" + dTP1.Value.ToString("yyyy/MM/dd") + "'";
                rpt.DataDefinition.FormulaFields["To_Date"].Text = "'" + dTP2.Value.ToString("yyyy/MM/dd") + "'";
                rpt.DataDefinition.FormulaFields["From_thick"].Text = "'" + thick_1.Text + "'";
                rpt.DataDefinition.FormulaFields["To_thick"].Text = "'" + thick_2.Text + "'";
                rpt.DataDefinition.FormulaFields["Catogery"].Text = "'" + category.Text + "'";
                rpt.DataDefinition.FormulaFields["Dim_category"].Text = "'" + cmb_DimCategory.Text + "'";
                rpt.DataDefinition.FormulaFields["payment_"].Text = "'" + payment_type.Text + "'";
                rpt.DataDefinition.FormulaFields["Type_"].Text = "'تقرير المشتريات موزع بالفروع'";
            //}
            //catch
            //    { }

                         
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                groupBox1.Visible = false;
                double T1, T2;
                if (thick_1.Text == "")
                { T1 = 0; }
                else { T1 = Convert.ToDouble(thick_1.Text); }
                if (thick_2.Text == "" || thick_2.Value == 0)
                { T2 = 10000; }
                else { T2 = Convert.ToDouble(thick_2.Text); }

                if (payment_type.SelectedIndex == 0)
                {
                    pay_code = "";
                }
                else if (payment_type.SelectedIndex == 1)
                {
                    pay_code = "11";
                }
                else if (payment_type.SelectedIndex == 2)
                {
                    pay_code = "2";
                }


                RPT.sales_by_group rpt = new RPT.sales_by_group();

                rpt.SetDataSource(dal.getDataTabl("sales_by_Group_", dTP1.Value.Date, dTP2.Value.Date, pay_code, Convert.ToString(category.SelectedValue), T1, T2, Convert.ToString(cmb_DimCategory.SelectedValue), "xp",db1,Uc_Acc.ID.Text, UC_Branch.ID.Text, Uc_Group.ID.Text,"",""));
                               

                crystalReportViewer1.ReportSource = rpt;
                rpt.DataDefinition.FormulaFields["From_date"].Text = "'" + dTP1.Value.ToString("yyyy/MM/dd") + "'";
                rpt.DataDefinition.FormulaFields["To_Date"].Text = "'" + dTP2.Value.ToString("yyyy/MM/dd") + "'";
                rpt.DataDefinition.FormulaFields["From_thick"].Text = "'" + thick_1.Text + "'";
                rpt.DataDefinition.FormulaFields["To_thick"].Text = "'" + thick_2.Text + "'";
                rpt.DataDefinition.FormulaFields["Catogery"].Text = "'" + category.Text + "'";
                rpt.DataDefinition.FormulaFields["Dim_category"].Text = "'" + cmb_DimCategory.Text + "'";
                rpt.DataDefinition.FormulaFields["payment_"].Text = "'" + payment_type.Text + "'";
                rpt.DataDefinition.FormulaFields["Type_"].Text = "'تقرير المشتريات موزع بالمجموعات'";
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Cursor.Current = Cursors.Default;

        }

        private void button10_Click(object sender, EventArgs e)
        {
            try
            {
                groupBox1.Visible = false;
                double T1, T2;
                if (thick_1.Text == "")
                { T1 = 0; }
                else { T1 = Convert.ToDouble(thick_1.Text); }
                if (thick_2.Text == "" || thick_2.Value == 0)
                { T2 = 10000; }
                else { T2 = Convert.ToDouble(thick_2.Text); }

                //if (cmb_transaction.SelectedIndex == 0)
                //{
                //    trans_code = "xs";
                //}
                //else if (cmb_transaction.SelectedIndex == 1)
                //{
                //    trans_code = "xp";
                //}

                if (payment_type.SelectedIndex == 0)
                {
                    pay_code = "";
                }
                else if (payment_type.SelectedIndex == 1)
                {
                    pay_code = "11";
                }
                else if (payment_type.SelectedIndex == 2)
                {
                    pay_code = "2";
                }


                RPT.rpt_sales_ByBranch rpt = new RPT.rpt_sales_ByBranch();

                rpt.SetDataSource(dal.getDataTabl("sales_by_branch_", dTP1.Value.Date, dTP2.Value.Date, pay_code, Convert.ToString(category.SelectedValue), T1, T2, Convert.ToString(cmb_DimCategory.SelectedValue), "xp",UC_Branch.ID.Text,Uc_Acc.ID.Text,db1, Uc_Group.ID.Text));
                crystalReportViewer1.ReportSource = rpt;
                rpt.DataDefinition.FormulaFields["From_date"].Text = "'" + dTP1.Value.ToString("yyyy/MM/dd") + "'";
                rpt.DataDefinition.FormulaFields["To_Date"].Text = "'" + dTP2.Value.ToString("yyyy/MM/dd") + "'";
                rpt.DataDefinition.FormulaFields["From_thick"].Text = "'" + thick_1.Text + "'";
                rpt.DataDefinition.FormulaFields["To_thick"].Text = "'" + thick_2.Text + "'";
                rpt.DataDefinition.FormulaFields["Catogery"].Text = "'" + category.Text + "'";
                rpt.DataDefinition.FormulaFields["Dim_category"].Text = "'" + payment_type.Text + "'";
                rpt.DataDefinition.FormulaFields["Type_"].Text = "'تقرير المشتريات موزع بالفروع'";
            }
            catch
            { }
        }

        private void button7_Click(object sender, EventArgs e)
        {

            Cursor.Current = Cursors.WaitCursor;
            try
            {
                groupBox1.Visible = false;
                double T1, T2;
                if (thick_1.Text == "")
                { T1 = 0; }
                else { T1 = Convert.ToDouble(thick_1.Text); }
                if (thick_2.Text == "" || thick_2.Value == 0)
                { T2 = 10000; }
                else { T2 = Convert.ToDouble(thick_2.Text); }

                //if (cmb_transaction.SelectedIndex == 0)
                //{
                //    trans_code = "xs";
                //}
                //else if (cmb_transaction.SelectedIndex == 1)
                //{
                //    trans_code = "xp";
                //}

                if (payment_type.SelectedIndex == 0)
                {
                    pay_code = "";
                }
                else if (payment_type.SelectedIndex == 1)
                {
                    pay_code = "11";
                }
                else if (payment_type.SelectedIndex == 2)
                {
                    pay_code = "2";
                }


                RPT.rpt_transaction_byGroup_payType rpt = new RPT.rpt_transaction_byGroup_payType();

                rpt.SetDataSource(dal.getDataTabl("sales_by_Group_Paytype_", dTP1.Value.Date, dTP2.Value.Date, pay_code, Convert.ToString(category.SelectedValue), T1, T2, Convert.ToString(cmb_DimCategory.SelectedValue), "xp",UC_Branch.ID.Text,Uc_Acc.ID.Text,db1));

                //            rpt.SetDataSource(dal.getDataTabl_1(@"SELECT v.G_ID As Group_ID,G.Group_name as Group_name,p.Payment_name
                //,ROUND(sum((D.[QTY_TAKE] - D.[QTY_ADD]) * A.Weight), 0) as Weight_
                //,ROUND(sum((D.QTY_TAKE - D.QTY_ADD) * D.Local_Price) - sum(((D.QTY_TAKE - D.QTY_ADD) * D.Local_Price * D.total_disc) / 100), 0) as value_
                //,ROUND(ROUND(sum((D.QTY_TAKE - D.QTY_ADD) * D.Local_Price) - sum(((D.QTY_TAKE - D.QTY_ADD) * D.Local_Price * D.total_disc) / 100), 0) / ISNULL(NULLIF(ROUND(sum((D.[QTY_TAKE] - D.[QTY_ADD]) * A.Weight), 0), 0), 1), 3) * 1000 AS Average_
                //FROM " + Properties.Settings.Default.Database_1 + ".dbo.wh_material_transaction As D " +
                //"inner join " + Properties.Settings.Default.Database_1 + ".dbo.wh_main_master As A on A.item_no=D.ITEM_NO " +
                //"inner join " + Properties.Settings.Default.Database_1 + ".dbo.WH_INV_TYPE As B on D.TRANSACTION_CODE=b.INV_CODE " +
                //"inner join " + Properties.Settings.Default.Database_1 + ".dbo.wh_inv_data As C on  C.Ser_no = D.SER_NO AND C.Branch_code = D.Branch_code AND " +
                //"C.Transaction_code = D.TRANSACTION_CODE AND C.Cyear = D.Cyear " +
                //"inner join View_G_ID As V on V.item_no= a.item_no " +
                //"inner join " + Properties.Settings.Default.Database_1 + ".dbo.wh_Groups As G on  v.G_ID= G.group_code " +
                //"inner join " + Properties.Settings.Default.Database_1 + ".dbo.wh_BRANCHES As H on H.Branch_code= d.Branch_code " +
                //"inner join [main_acc_wh].[dbo].wh_Payment_type As P on P.Payment_type=C.Payment_Type " +
                //"where D.TRANSACTION_CODE like '" + trans_code + "%' and cast(D.G_date as date) between '" + dTP1.Value.ToString("yyyy/MM/dd") + "' and '" + dTP2.Value.ToString("yyyy/MM/dd") + "' and C.Payment_Type like '%" + pay_code
                //+ "%'and a.Category like '%" + Convert.ToString(category.SelectedValue) + "%' and A.UnitDepth BETWEEN '" + T1 + "' AND '" + T2 + "' and A.Company_code= 'A' group by v.G_ID, G.Group_name,p.Payment_name    "));


                crystalReportViewer1.ReportSource = rpt;
                rpt.DataDefinition.FormulaFields["From_date"].Text = "'" + dTP1.Value.ToString("yyyy/MM/dd") + "'";
                rpt.DataDefinition.FormulaFields["To_Date"].Text = "'" + dTP2.Value.ToString("yyyy/MM/dd") + "'";
                rpt.DataDefinition.FormulaFields["From_thick"].Text = "'" + thick_1.Text + "'";
                rpt.DataDefinition.FormulaFields["To_thick"].Text = "'" + thick_2.Text + "'";
                rpt.DataDefinition.FormulaFields["Catogery"].Text = "'" + category.Text + "'";
                rpt.DataDefinition.FormulaFields["Dim_category"].Text = "'" + payment_type.Text + "'";
                rpt.DataDefinition.FormulaFields["Type_"].Text = "'تقرير المشتريات موزع بالمجموعات وطريقة الدفع'";
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Cursor.Current = Cursors.Default;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            double T1, T2;
            if (thick_1.Text == "")
            { T1 = 0; }
            else { T1 = Convert.ToDouble(thick_1.Text); }
            if (thick_2.Text == "" || thick_2.Value == 0)
            { T2 = 10000; }
            else { T2 = Convert.ToDouble(thick_2.Text); }

            //if (cmb_transaction.SelectedIndex == 0)
            //{
            //    trans_code = "xs";
            //}
            //else if (cmb_transaction.SelectedIndex == 1)
            //{
            //    trans_code = "xp";
            //}

            if (payment_type.SelectedIndex == 0)
            {
                pay_code = "";
            }
            else if (payment_type.SelectedIndex == 1)
            {
                pay_code = "11";
            }
            else if (payment_type.SelectedIndex == 2)
            {
                pay_code = "2";
            }
              RPT.S_P_by_Items rpt = new RPT.S_P_by_Items();

            rpt.SetDataSource(dal.getDataTabl(@"sales_by_item_", dTP1.Value.Date, dTP2.Value.Date, pay_code, Convert.ToString(category.SelectedValue), T1, T2, Convert.ToString(cmb_DimCategory.SelectedValue), "xp",UC_Branch.ID.Text,Uc_Acc.ID.Text,db1, Uc_Group.ID.Text));
            crystalReportViewer1.ReportSource = rpt;
         
        }

      

        private void groupPanel1_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                groupBox1.Visible = false;
                double T1, T2;
                if (thick_1.Text == "")
                { T1 = 0; }
                else { T1 = Convert.ToDouble(thick_1.Text); }
                if (thick_2.Text == "" || thick_2.Value == 0)
                { T2 = 10000; }
                else { T2 = Convert.ToDouble(thick_2.Text); }



                if (payment_type.SelectedIndex == 0)
                {
                    pay_code = "";
                }
                else if (payment_type.SelectedIndex == 1)
                {
                    pay_code = "11";
                }
                else if (payment_type.SelectedIndex == 2)
                {
                    pay_code = "2";
                }


                RPT.sales_by_group rpt = new RPT.sales_by_group();


                rpt.SetDataSource(dal.getDataTabl("take_to_production_", dTP1.Value.Date, dTP2.Value.Date, pay_code, Convert.ToString(category.SelectedValue), T1, T2, Convert.ToString(cmb_DimCategory.SelectedValue), "xtp", UC_Branch.ID.Text, Uc_Acc.ID.Text, db1));


                crystalReportViewer1.ReportSource = rpt;
                rpt.DataDefinition.FormulaFields["From_date"].Text = "'" + dTP1.Value.ToString("yyyy/MM/dd") + "'";
                rpt.DataDefinition.FormulaFields["To_Date"].Text = "'" + dTP2.Value.ToString("yyyy/MM/dd") + "'";
                rpt.DataDefinition.FormulaFields["From_thick"].Text = "'" + thick_1.Text + "'";
                rpt.DataDefinition.FormulaFields["To_thick"].Text = "'" + thick_2.Text + "'";
                rpt.DataDefinition.FormulaFields["Catogery"].Text = "'" + category.Text + "'";
                rpt.DataDefinition.FormulaFields["Dim_category"].Text = "'" + cmb_DimCategory.Text + "'";
                rpt.DataDefinition.FormulaFields["payment_"].Text = "'" + payment_type.Text + "'";
                rpt.DataDefinition.FormulaFields["Type_"].Text = "'تقرير المنصرف للانتاج'";
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Cursor.Current = Cursors.Default;

        }

        private void button12_Click(object sender, EventArgs e)
        {

            Cursor.Current = Cursors.WaitCursor;
            try
            {
                groupBox1.Visible = false;
                double T1, T2;
                if (thick_1.Text == "")
                { T1 = 0; }
                else { T1 = Convert.ToDouble(thick_1.Text); }
                if (thick_2.Text == "" || thick_2.Value == 0)
                { T2 = 10000; }
                else { T2 = Convert.ToDouble(thick_2.Text); }

                //if (cmb_transaction.SelectedIndex == 0)
                //{ trans_code="xs";
                //}
                //else if (cmb_transaction.SelectedIndex == 1)
                //{
                //    trans_code = "xp";
                //}

                if (payment_type.SelectedIndex == 0)
                {
                    pay_code = "";
                }
                else if (payment_type.SelectedIndex == 1)
                {
                    pay_code = "11";
                }
                else if (payment_type.SelectedIndex == 2)
                {
                    pay_code = "2";
                }


                RPT.sales_by_group rpt = new RPT.sales_by_group();


                rpt.SetDataSource(dal.getDataTabl("Out_from_production_", dTP1.Value.Date, dTP2.Value.Date, pay_code, Convert.ToString(category.SelectedValue), T1, T2, Convert.ToString(cmb_DimCategory.SelectedValue), "xtp",db1));


                crystalReportViewer1.ReportSource = rpt;
                rpt.DataDefinition.FormulaFields["From_date"].Text = "'" + dTP1.Value.ToString("yyyy/MM/dd") + "'";
                rpt.DataDefinition.FormulaFields["To_Date"].Text = "'" + dTP2.Value.ToString("yyyy/MM/dd") + "'";
                rpt.DataDefinition.FormulaFields["From_thick"].Text = "'" + thick_1.Text + "'";
                rpt.DataDefinition.FormulaFields["To_thick"].Text = "'" + thick_2.Text + "'";
                rpt.DataDefinition.FormulaFields["Catogery"].Text = "'" + category.Text + "'";
                rpt.DataDefinition.FormulaFields["Dim_category"].Text = "'" + cmb_DimCategory.Text + "'";
                rpt.DataDefinition.FormulaFields["payment_"].Text = "'" + payment_type.Text + "'";
                rpt.DataDefinition.FormulaFields["Type_"].Text = "'تقرير الانتاج'";
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Cursor.Current = Cursors.Default;
        }

        private void btnOption_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
        }

        private void button13_Click(object sender, EventArgs e)
        {

            Cursor.Current = Cursors.WaitCursor;
            try
            {
                groupBox1.Visible = false;

                double T1, T2;
                if (thick_1.Text == "")
                { T1 = 0;
                }
                else { T1 = Convert.ToDouble(thick_1.Text); }
                if (thick_2.Text == "" || thick_2.Value == 0)
                { T2 = 10000;
                }
                else { T2 = Convert.ToDouble(thick_2.Text); }

                if (payment_type.SelectedIndex == 0)
                {
                    pay_code = "";
                }
                else if (payment_type.SelectedIndex == 1)
                {
                    pay_code = "11";
                }
                else if (payment_type.SelectedIndex == 2)
                {
                    pay_code = "2";
                }


                RPT.rptMonthly_sales_pur rpt = new RPT.rptMonthly_sales_pur();

                DataSet1 ds = new DataSet1();
                DataTable dt1 = new DataTable();



                dt1 = (dal.getDataTabl("Monthly_Sales_", dTP1.Value.Date, dTP2.Value.Date, UC_Branch.ID.Text,"xs", db1));

                ds.Tables.Add(dt1);


                ds.WriteXmlSchema("schema_rpt.xml");
                rpt.SetDataSource(ds);
                crystalReportViewer1.ReportSource = rpt;

                rpt.DataDefinition.FormulaFields["FromDate"].Text = "'" + dTP1.Value.ToString("yyyy/MM/dd") + "'";
                rpt.DataDefinition.FormulaFields["ToDate"].Text = "'" + dTP2.Value.ToString("yyyy/MM/dd") + "'";
                rpt.DataDefinition.FormulaFields["Rep_Head"].Text = "'Monthly Sales Report'";
                rpt.DataDefinition.FormulaFields["Rep_Kind"].Text = "'Sales'";
                rpt.DataDefinition.FormulaFields["company_name"].Text = "'" + Properties.Settings.Default.head_txt_EN + "'";
                rpt.DataDefinition.FormulaFields["Branch_Name"].Text = "'" + Properties.Settings.Default.Branch_txt_EN + "'";
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Cursor.Current = Cursors.Default;

        }

        private void button14_Click(object sender, EventArgs e)
        {

            Cursor.Current = Cursors.WaitCursor;
            try
            {
                groupBox1.Visible = false;

                double T1, T2;
                if (thick_1.Text == "")
                {
                    T1 = 0;
                }
                else { T1 = Convert.ToDouble(thick_1.Text); }
                if (thick_2.Text == "" || thick_2.Value == 0)
                {
                    T2 = 10000;
                }
                else { T2 = Convert.ToDouble(thick_2.Text); }

                if (payment_type.SelectedIndex == 0)
                {
                    pay_code = "";
                }
                else if (payment_type.SelectedIndex == 1)
                {
                    pay_code = "11";
                }
                else if (payment_type.SelectedIndex == 2)
                {
                    pay_code = "2";
                }


                RPT.rptMonthly_sales_pur rpt = new RPT.rptMonthly_sales_pur();

                DataSet1 ds = new DataSet1();
                DataTable dt1 = new DataTable();



                dt1 = (dal.getDataTabl("Monthly_Sales_", dTP1.Value.Date, dTP2.Value.Date, UC_Branch.ID.Text, "xp", db1));

                ds.Tables.Add(dt1);


                ds.WriteXmlSchema("schema_rpt.xml");
                rpt.SetDataSource(ds);
                crystalReportViewer1.ReportSource = rpt;

                rpt.DataDefinition.FormulaFields["FromDate"].Text = "'" + dTP1.Value.ToString("yyyy/MM/dd") + "'";
                rpt.DataDefinition.FormulaFields["ToDate"].Text = "'" + dTP2.Value.ToString("yyyy/MM/dd") + "'";
                rpt.DataDefinition.FormulaFields["Rep_Head"].Text = "'Monthly Purchases Report'";
                rpt.DataDefinition.FormulaFields["Rep_Kind"].Text = "'Purchases'";
                rpt.DataDefinition.FormulaFields["company_name"].Text = "'" + Properties.Settings.Default.head_txt_EN + "'";
                rpt.DataDefinition.FormulaFields["Branch_Name"].Text = "'" + Properties.Settings.Default.Branch_txt_EN + "'";
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Cursor.Current = Cursors.Default;

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {
            try
            {
                groupBox1.Visible = false;
                double T1, T2;
                if (thick_1.Text == "")
                { T1 = 0; }
                else { T1 = Convert.ToDouble(thick_1.Text); }
                if (thick_2.Text == "" || thick_2.Value == 0)
                { T2 = 10000; }
                else { T2 = Convert.ToDouble(thick_2.Text); }

                if (payment_type.SelectedIndex == 0)
                {
                    pay_code = "";
                }
                else if (payment_type.SelectedIndex == 1)
                {
                    pay_code = "11";
                }
                else if (payment_type.SelectedIndex == 2)
                {
                    pay_code = "2";
                }



                RPT.rpt_Sales_byAcc rpt = new RPT.rpt_Sales_byAcc();

                DataSet1 ds = new DataSet1();
                DataTable dt1 = new DataTable();



                dt1 = (dal.getDataTabl("sales_by_Acc_", dTP1.Value.Date, dTP2.Value.Date, pay_code, Convert.ToString(category.SelectedValue), T1, T2, Convert.ToString(cmb_DimCategory.SelectedValue), "xp", UC_Branch.ID.Text, Uc_Acc.ID.Text, db1,Uc_Group.ID.Text));

                ds.Tables.Add(dt1);


                ds.WriteXmlSchema("schema_rpt.xml");
                rpt.SetDataSource(ds);

                //rpt.SetDataSource(dal.getDataTabl("sales_by_Acc", dTP1.Value.Date, dTP2.Value.Date, pay_code, Convert.ToString(category.SelectedValue), T1, T2, Convert.ToString(cmb_DimCategory.SelectedValue), "xs", UC_Branch.ID.Text, Uc_Acc.ID.Text, db1));
                crystalReportViewer1.ReportSource = rpt;
                rpt.DataDefinition.FormulaFields["From_date"].Text = "'" + dTP1.Value.ToString("yyyy/MM/dd") + "'";
                rpt.DataDefinition.FormulaFields["To_Date"].Text = "'" + dTP2.Value.ToString("yyyy/MM/dd") + "'";
                rpt.DataDefinition.FormulaFields["From_thick"].Text = "'" + thick_1.Text + "'";
                rpt.DataDefinition.FormulaFields["To_thick"].Text = "'" + thick_2.Text + "'";
                rpt.DataDefinition.FormulaFields["Catogery"].Text = "'" + category.Text + "'";
                rpt.DataDefinition.FormulaFields["Dim_category"].Text = "'" + cmb_DimCategory.Text + "'";
                rpt.DataDefinition.FormulaFields["payment_"].Text = "'" + payment_type.Text + "'";
                rpt.DataDefinition.FormulaFields["decimal_"].Text = "'" + Properties.Settings.Default.digitNo_+ "'";
                rpt.DataDefinition.FormulaFields["Type_"].Text = "'تقرير المشتريات موزع بالموردين'";
                
            }
            catch
            { }

        }
    

        private void button15_Click(object sender, EventArgs e)
        {
            try
            {
                groupBox1.Visible = false;
                double T1, T2;
                if (thick_1.Text == "")
                { T1 = 0; }
                else { T1 = Convert.ToDouble(thick_1.Text); }
                if (thick_2.Text == "" || thick_2.Value == 0)
                { T2 = 10000; }
                else { T2 = Convert.ToDouble(thick_2.Text); }

                if (payment_type.SelectedIndex == 0)
                {
                    pay_code = "";
                }
                else if (payment_type.SelectedIndex == 1)
                {
                    pay_code = "11";
                }
                else if (payment_type.SelectedIndex == 2)
                {
                    pay_code = "2";
                }



                RPT.rpt_Sales_byAcc rpt = new RPT.rpt_Sales_byAcc();

                DataSet1 ds = new DataSet1();
                DataTable dt1 = new DataTable();



                dt1 = (dal.getDataTabl("sales_by_Acc_", dTP1.Value.Date, dTP2.Value.Date, pay_code, Convert.ToString(category.SelectedValue), T1, T2, Convert.ToString(cmb_DimCategory.SelectedValue), "xs", UC_Branch.ID.Text, Uc_Acc.ID.Text, db1));

                ds.Tables.Add(dt1);


                ds.WriteXmlSchema("schema_rpt.xml");
                rpt.SetDataSource(ds);

                //rpt.SetDataSource(dal.getDataTabl("sales_by_Acc", dTP1.Value.Date, dTP2.Value.Date, pay_code, Convert.ToString(category.SelectedValue), T1, T2, Convert.ToString(cmb_DimCategory.SelectedValue), "xs", UC_Branch.ID.Text, Uc_Acc.ID.Text, db1));
                crystalReportViewer1.ReportSource = rpt;
                rpt.DataDefinition.FormulaFields["From_date"].Text = "'" + dTP1.Value.ToString("yyyy/MM/dd") + "'";
                rpt.DataDefinition.FormulaFields["To_Date"].Text = "'" + dTP2.Value.ToString("yyyy/MM/dd") + "'";
                rpt.DataDefinition.FormulaFields["From_thick"].Text = "'" + thick_1.Text + "'";
                rpt.DataDefinition.FormulaFields["To_thick"].Text = "'" + thick_2.Text + "'";
                rpt.DataDefinition.FormulaFields["Catogery"].Text = "'" + category.Text + "'";
                rpt.DataDefinition.FormulaFields["Dim_category"].Text = "'" + cmb_DimCategory.Text + "'";
                rpt.DataDefinition.FormulaFields["payment_"].Text = "'" + payment_type.Text + "'";
                rpt.DataDefinition.FormulaFields["Type_"].Text = "'تقرير المبيعات موزع بالعميل'";
        
            }
            catch
            { }

        }

        private void txtNU_TextChanged(object sender, EventArgs e)
        {

        }

        private void frm_rpt_Purchases_Load(object sender, EventArgs e)
        {
            //this.skinEngine1.SkinFile = "Skins/Eighteen.ssk";
       
    }
    }
}

