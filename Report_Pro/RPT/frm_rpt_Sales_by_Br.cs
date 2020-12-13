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
    public partial class frm_rpt_Sales_by_Br : Form
    {
        string db1 = Properties.Settings.Default.Database_1;
        DAL.DataAccesslayer1 dal = new DAL.DataAccesslayer1();
        string sp;

        string pay_code = "";

        public frm_rpt_Sales_by_Br()
        {
            InitializeComponent();
            category.DataSource = dal.getDataTabl("Get_category_", db1);
            category.DisplayMember = "Category_name";
            category.ValueMember = "Category_code";
            category.SelectedIndex = -1;

            cmb_DimCategory.DataSource = dal.getDataTabl_1(@"select * FROM " + Properties.Settings.Default.Database_1 + ".dbo.Wh_Unit_dim");
            cmb_DimCategory.DisplayMember = "Wh_Unit_dim";
            cmb_DimCategory.ValueMember = "Wh_Unit_dim";
            cmb_DimCategory.SelectedIndex = -1;

        }
        private void btn_Report_Click(object sender, EventArgs e)
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

              
                RPT.CrystalReport3 rpt = new RPT.CrystalReport3();

                rpt.SetDataSource(dal.getDataTabl("sales_by_branch_", dTP1.Value.Date, dTP2.Value.Date, pay_code, Convert.ToString(category.SelectedValue), T1, T2, Convert.ToString(cmb_DimCategory.SelectedValue), "xs", UC_Branch.ID.Text, Uc_Acc.ID.Text, db1, Uc_Group.ID.Text,""));
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

        private void frm_rpt_Sales_by_Br_Load(object sender, EventArgs e)
        {

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

                string str_t = "1";
            string car_studes = "";
            if (radioBtn1.Checked)
            {
                str_t = "1";
                car_studes = radioBtn1.Text;
            }
            else if (radioBtn2.Checked)
            {
                str_t = "2";
                car_studes = radioBtn2.Text;
            }
            else if (radioBtn3.Checked)
            {
                str_t = "3";
                car_studes = radioBtn3.Text;
            }



                string X = "1";
                string h_txt = "Monthly Sales By Branch";
                if (rBtnAll.Checked)
                {   
                    X = "1";
                    h_txt = "Monthly Sales By Branch";
                }
                if (rBtnS.Checked)
                {
                    X = "2";
                    h_txt = "Monthly Sales By Branch - Sister Companies";
                }
                if (rBtnWithoutS.Checked)
                {
                    X = "3";
                    h_txt = "Monthly Sales By Branch - With Out Sister Companies";
                }

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


                rpt.SetDataSource(dal.getDataTabl("sales_by_Group_", dTP1.Value.Date, dTP2.Value.Date, pay_code, Convert.ToString(category.SelectedValue), T1, T2, Convert.ToString(cmb_DimCategory.SelectedValue), "xs", db1, Uc_Acc.ID.Text, UC_Branch.ID.Text, Uc_Group.ID.Text,X,str_t));


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

                rpt.SetDataSource(dal.getDataTabl("sales_by_branch_", dTP1.Value.Date, dTP2.Value.Date, pay_code, Convert.ToString(category.SelectedValue), T1, T2, Convert.ToString(cmb_DimCategory.SelectedValue), "xs", UC_Branch.ID.Text, Uc_Acc.ID.Text, db1, Uc_Group.ID.Text,""));
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

                rpt.SetDataSource(dal.getDataTabl("sales_by_Group_Paytype_", dTP1.Value.Date, dTP2.Value.Date, pay_code, Convert.ToString(category.SelectedValue), T1, T2, Convert.ToString(cmb_DimCategory.SelectedValue), "xs", UC_Branch.ID.Text, Uc_Acc.ID.Text, db1));
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

            rpt.SetDataSource(dal.getDataTabl(@"sales_by_item_", dTP1.Value.Date, dTP2.Value.Date, pay_code, Convert.ToString(category.SelectedValue), T1, T2, Convert.ToString(cmb_DimCategory.SelectedValue), "xs", UC_Branch.ID.Text, Uc_Acc.ID.Text, db1, Uc_Group.ID.Text));
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


                dt1 = (dal.getDataTabl("sales_ByGroup__", dTP1.Value.Date, dTP2.Value.Date, pay_code, Convert.ToString(category.SelectedValue), T1, T2, Convert.ToString(cmb_DimCategory.SelectedValue), UC_Branch.ID.Text, Uc_Acc.ID.Text, db1));
                dt2 = (dal.getDataTabl("Get_customers_payments", dTP1.Value.Date, dTP2.Value.Date, db1));
                dt3 = (dal.getDataTabl("Sales_total", dTP1.Value.Date, dTP2.Value.Date, db1));

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



                RPT.CrystalReport3 rpt = new RPT.CrystalReport3();

                rpt.SetDataSource(dal.getDataTabl("sales_by_branch_", dTP1.Value.Date, dTP2.Value.Date, pay_code, Convert.ToString(category.SelectedValue), T1, T2, Convert.ToString(cmb_DimCategory.SelectedValue), "xp", UC_Branch.ID.Text, Uc_Acc.ID.Text, db1));
                crystalReportViewer1.ReportSource = rpt;
                rpt.DataDefinition.FormulaFields["From_date"].Text = "'" + dTP1.Value.ToString("yyyy/MM/dd") + "'";
                rpt.DataDefinition.FormulaFields["To_Date"].Text = "'" + dTP2.Value.ToString("yyyy/MM/dd") + "'";
                rpt.DataDefinition.FormulaFields["From_thick"].Text = "'" + thick_1.Text + "'";
                rpt.DataDefinition.FormulaFields["To_thick"].Text = "'" + thick_2.Text + "'";
                rpt.DataDefinition.FormulaFields["Catogery"].Text = "'" + category.Text + "'";
                rpt.DataDefinition.FormulaFields["Dim_category"].Text = "'" + cmb_DimCategory.Text + "'";
                rpt.DataDefinition.FormulaFields["payment_"].Text = "'" + payment_type.Text + "'";
                rpt.DataDefinition.FormulaFields["Type_"].Text = "'تقرير المشتريات موزع بالفروع'";
            }
            catch
            { }


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

                rpt.SetDataSource(dal.getDataTabl("sales_by_Group_", dTP1.Value.Date, dTP2.Value.Date, pay_code, Convert.ToString(category.SelectedValue), T1, T2, Convert.ToString(cmb_DimCategory.SelectedValue), "xp", db1, Uc_Acc.ID.Text, UC_Branch.ID.Text));


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

                rpt.SetDataSource(dal.getDataTabl("sales_by_branch_", dTP1.Value.Date, dTP2.Value.Date, pay_code, Convert.ToString(category.SelectedValue), T1, T2, Convert.ToString(cmb_DimCategory.SelectedValue), "xp", UC_Branch.ID.Text, Uc_Acc.ID.Text, db1));
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

                rpt.SetDataSource(dal.getDataTabl("sales_by_Group_Paytype_", dTP1.Value.Date, dTP2.Value.Date, pay_code, Convert.ToString(category.SelectedValue), T1, T2, Convert.ToString(cmb_DimCategory.SelectedValue), "xp", UC_Branch.ID.Text, Uc_Acc.ID.Text, db1));

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

            rpt.SetDataSource(dal.getDataTabl(@"sales_by_item_", dTP1.Value.Date, dTP2.Value.Date, pay_code, Convert.ToString(category.SelectedValue), T1, T2, Convert.ToString(cmb_DimCategory.SelectedValue), "xp", UC_Branch.ID.Text, Uc_Acc.ID.Text, db1));
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


                string R, F, C, P, S, Z;
                if (chR.Checked == true) { R = "R"; } else { R = "X"; }
                if (chF.Checked == true) { F = "F"; } else { F = "X"; }
                if (chC.Checked == true) { C = "C"; } else { C = "X"; }
                if (chS.Checked == true) { S = "S"; } else { S = "X"; }
                if (chP.Checked == true) { P = "P"; } else { P = "X"; }
                if (chZ.Checked == true) { Z = "Z"; } else { Z = "X"; }

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


                rpt.SetDataSource(dal.getDataTabl("Out_from_production_", dTP1.Value.Date, dTP2.Value.Date, pay_code, Convert.ToString(category.SelectedValue), T1, T2, Convert.ToString(cmb_DimCategory.SelectedValue), "xtp", db1));


                crystalReportViewer1.ReportSource = rpt;
                rpt.DataDefinition.FormulaFields["From_date"].Text = "'" + dTP1.Value.ToString("yyyy/MM/dd") + "'";
                rpt.DataDefinition.FormulaFields["To_Date"].Text = "'" + dTP2.Value.ToString("yyyy/MM/dd") + "'";
                rpt.DataDefinition.FormulaFields["From_thick"].Text = "'" + thick_1.Text + "'";
                rpt.DataDefinition.FormulaFields["To_thick"].Text = "'" + thick_2.Text + "'";
                rpt.DataDefinition.FormulaFields["Catogery"].Text = "'" + category.Text + "'";
                rpt.DataDefinition.FormulaFields["Dim_category"].Text = "'" + cmb_DimCategory.Text + "'";
                rpt.DataDefinition.FormulaFields["payment_"].Text = "'" + payment_type.Text + "'";
                rpt.DataDefinition.FormulaFields["Type_"].Text = "' تقرير الانتاج - موزع بالمجموعات'";
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



                dt1 = (dal.getDataTabl("Monthly_Sales_", dTP1.Value.Date, dTP2.Value.Date, UC_Branch.ID.Text, "xs", db1));

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



                dt1 = (dal.getDataTabl("sales_by_Acc_", dTP1.Value.Date, dTP2.Value.Date, pay_code, Convert.ToString(category.SelectedValue), T1, T2, Convert.ToString(cmb_DimCategory.SelectedValue), "xp", UC_Branch.ID.Text, Uc_Acc.ID.Text, db1));

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
                rpt.DataDefinition.FormulaFields["Type_"].Text = "'تقرير المبيعات موزع بالفروع'";

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



                dt1 = (dal.getDataTabl("sales_by_Acc_", dTP1.Value.Date, dTP2.Value.Date, pay_code, Convert.ToString(category.SelectedValue), T1, T2, Convert.ToString(cmb_DimCategory.SelectedValue), "xs", UC_Branch.ID.Text, Uc_Acc.ID.Text, db1, Uc_Group.ID.Text));

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

        private void button6_Click_1(object sender, EventArgs e)
        {
            string R, F, C, P, S, Z;
            if (chR.Checked == true) { R = "R"; } else { R = "X"; }
            if (chF.Checked == true) { F = "F"; } else { F = "X"; }
            if (chC.Checked == true) { C = "C"; } else { C = "X"; }
            if (chS.Checked == true) { S = "S"; } else { S = "X"; }
            if (chP.Checked == true) { P = "P"; } else { P = "X"; }
            if (chZ.Checked == true) { Z = "Z"; } else { Z = "X"; }

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


                RPT.Productin rpt = new RPT.Productin();

                DataSet1 ds = new DataSet1();
                DataTable dt1 = new DataTable();
                dt1 = dal.getDataTabl_1(@"SELECT C.ser_no,C.G_date,A.item_no,A.descr,C.Branch_code,H.Branch_Name,C.Machin_No,Prod_code
                ,ROUND(sum(D.[QTY_ADD]),0 )as Qty_
                ,ROUND(sum((D.[QTY_ADD])*A.Weight),3 )as Weight_
                ,ROUND(sum((D.QTY_ADD)*D.Local_Price)-sum(((D.QTY_ADD)*D.Local_Price*D.total_disc)/100),3) as value_
	            FROM	wh_material_transaction As D
                inner join wh_main_master As A on A.item_no=D.ITEM_NO
                inner join WH_INV_TYPE As B on D.TRANSACTION_CODE=b.INV_CODE
                inner join wh_inv_data As C on  C.Ser_no = D.SER_NO AND C.Branch_code =D.Branch_code AND 
                C.Transaction_code = D.TRANSACTION_CODE AND C.Cyear = D.Cyear
                inner join wh_BRANCHES As H on H.Branch_code=d.Branch_code
                inner join Fac_Machine As M on M.Machine_no=C.Machin_No 
                where C.transaction_code='xtp' and IN_OUT_TYPE='O' and D.ITEM_NO like'" + Items.ID.Text + "%' and  A.Category in('" + R + "','" + F + "','" + C + "','" + P + "','" + S + "','" + Z + "') and Cast(C.G_date as date) between '" + dTP1.Value.ToString("yyyy/MM/dd") + "' and '" + dTP2.Value.ToString("yyyy/MM/dd") +
                "' group by C.ser_no,C.G_date,A.item_no,A.descr,C.Branch_code,H.Branch_Name,Machin_No,Prod_code ");

                ds.Tables.Add(dt1);
                ds.WriteXmlSchema("schema_rpt.xml");
                rpt.SetDataSource(ds);
                crystalReportViewer1.ReportSource = rpt;

                //crystalReportViewer1.ReportSource = rpt;
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

        private void button7_Click_1(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                string R, F, C, P, S, Z;
                if (chR.Checked == true) { R = "R"; } else { R = "X"; }
                if (chF.Checked == true) { F = "F"; } else { F = "X"; }
                if (chC.Checked == true) { C = "C"; } else { C = "X"; }
                if (chS.Checked == true) { S = "S"; } else { S = "X"; }
                if (chP.Checked == true) { P = "P"; } else { P = "X"; }
                if (chZ.Checked == true) { Z = "Z"; } else { Z = "X"; }
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


                RPT.Productin_by_Item rpt = new RPT.Productin_by_Item();

                DataSet1 ds = new DataSet1();
                DataTable dt1 = new DataTable();
                dt1 = dal.getDataTabl_1(@"SELECT A.item_no,A.descr
                ,ROUND(sum(D.[QTY_ADD]),0 )as Qty_
                ,ROUND(sum((D.[QTY_ADD])*A.Weight),3 )as Weight_
                ,ROUND(sum((D.QTY_ADD)*D.Local_Price)-sum(((D.QTY_ADD)*D.Local_Price*D.total_disc)/100),3) as value_
	            FROM	wh_material_transaction As D
                inner join wh_main_master As A on A.item_no=D.ITEM_NO
                inner join WH_INV_TYPE As B on D.TRANSACTION_CODE=b.INV_CODE
                inner join wh_inv_data As C on  C.Ser_no = D.SER_NO AND C.Branch_code =D.Branch_code AND 
                C.Transaction_code = D.TRANSACTION_CODE AND C.Cyear = D.Cyear
                inner join wh_BRANCHES As H on H.Branch_code=d.Branch_code
                inner join Fac_Machine As M on M.Machine_no=C.Machin_No 
                where C.transaction_code='xtp' and IN_OUT_TYPE='O' and D.ITEM_NO like'" + Items.ID.Text + "%' and A.Category in('" + R + "','" + F + "','" + C + "','" + P + "','" + S + "','" + Z + "') and Cast(C.G_date as date) between '" + dTP1.Value.ToString("yyyy/MM/dd") + "' and '" + dTP2.Value.ToString("yyyy/MM/dd") +
                "' group by A.item_no,A.descr");

                ds.Tables.Add(dt1);
                ds.WriteXmlSchema("schema_rpt.xml");
                rpt.SetDataSource(ds);
                crystalReportViewer1.ReportSource = rpt;

                //crystalReportViewer1.ReportSource = rpt;
                rpt.DataDefinition.FormulaFields["From_date"].Text = "'" + dTP1.Value.ToString("yyyy/MM/dd") + "'";
                rpt.DataDefinition.FormulaFields["To_Date"].Text = "'" + dTP2.Value.ToString("yyyy/MM/dd") + "'";
                rpt.DataDefinition.FormulaFields["From_thick"].Text = "'" + thick_1.Text + "'";
                rpt.DataDefinition.FormulaFields["To_thick"].Text = "'" + thick_2.Text + "'";
                rpt.DataDefinition.FormulaFields["Catogery"].Text = "'" + category.Text + "'";
                rpt.DataDefinition.FormulaFields["Dim_category"].Text = "'" + cmb_DimCategory.Text + "'";
                rpt.DataDefinition.FormulaFields["payment_"].Text = "'" + payment_type.Text + "'";
                rpt.DataDefinition.FormulaFields["Type_"].Text = "'تقرير الانتاج - موزع بالاصناف'";
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Cursor.Current = Cursors.Default;
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            string R, F, C, P, S, Z;
            if (chR.Checked == true) { R = "R"; } else { R = "X"; }
            if (chF.Checked == true) { F = "F"; } else { F = "X"; }
            if (chC.Checked == true) { C = "C"; } else { C = "X"; }
            if (chS.Checked == true) { S = "S"; } else { S = "X"; }
            if (chP.Checked == true) { P = "P"; } else { P = "X"; }
            if (chZ.Checked == true) { Z = "Z"; } else { Z = "X"; }

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

                
                DateTime psDate = dTP1.Value.AddYears(-1);
                DateTime peDate = dTP2.Value.AddYears(-1);
                RPT.Productin_by_Machin rpt = new RPT.Productin_by_Machin();

                DataSet1 ds = new DataSet1();
                DataTable dt1 = new DataTable();
                dt1 = dal.getDataTabl_1(@"SELECT C.Branch_code,H.Branch_Name,C.Machin_No,Machine_Name
        ,SUM(CASE WHEN  Cast(C.G_date as date) between '" + dTP1.Value.ToString("yyyy/MM/dd") + "' and '" + dTP2.Value.ToString("yyyy/MM/dd") +
        "' THEN D.QTY_ADD ELSE 0 END) AS 'Qty2019'" +
        ",SUM(CASE WHEN  Cast(C.G_date as date) between '" + psDate.ToString("yyyy/MM/dd") + "' and '" + peDate.ToString("yyyy/MM/dd") +
        "'  THEN D.QTY_ADD ELSE 0 END) AS 'Qty2018'" +
       ", SUM(CASE WHEN  Cast(C.G_date as date) between '" + dTP1.Value.ToString("yyyy/MM/dd") + "' and '" + dTP2.Value.ToString("yyyy/MM/dd") +
        "' THEN D.QTY_ADD*A.unitlenth/1000 ELSE 0 END) AS 'lenth2019'" +
        ",SUM(CASE WHEN  Cast(C.G_date as date) between '" + psDate.ToString("yyyy/MM/dd") + "' and '" + peDate.ToString("yyyy/MM/dd") +
        "'  THEN D.QTY_ADD*A.unitlenth/1000 ELSE 0 END) AS 'lenth2018'" +


        ",SUM(CASE WHEN  Cast(C.G_date as date) between '" + dTP1.Value.ToString("yyyy/MM/dd") + "' and '" + dTP2.Value.ToString("yyyy/MM/dd") +
        "' THEN D.QTY_ADD*A.Weight ELSE 0 END) AS 'Weight2019'" +
        ",SUM(CASE WHEN  Cast(C.G_date as date) between '" + psDate.ToString("yyyy/MM/dd") + "' and '" + peDate.ToString("yyyy/MM/dd") +
        "' THEN D.QTY_ADD*A.Weight ELSE 0 END) AS 'Weight2018'" +
		      
        ",SUM(CASE WHEN  Cast(C.G_date as date) between '" + dTP1.Value.ToString("yyyy/MM/dd") + "' and '" + dTP2.Value.ToString("yyyy/MM/dd") +
        "' THEN (D.QTY_ADD*D.Local_Price)-((D.QTY_ADD*D.Local_Price*D.total_disc)/100) ELSE 0 END) AS 'Value2019'" +
        ", SUM(CASE WHEN  Cast(C.G_date as date) between '" + psDate.ToString("yyyy/MM/dd") + "' and '" + peDate.ToString("yyyy/MM/dd") +
        "'  THEN (D.QTY_ADD*D.Local_Price)-((D.QTY_ADD*D.Local_Price*D.total_disc)/100)  ELSE 0 END) AS 'Value2018'" +
       
        "FROM	wh_material_transaction As D " +
        "inner join wh_main_master As A on A.item_no=D.ITEM_NO " +
        "inner join WH_INV_TYPE As B on D.TRANSACTION_CODE=b.INV_CODE " +
        "inner join wh_inv_data As C on  C.Ser_no = D.SER_NO AND C.Branch_code =D.Branch_code AND " +
        "C.Transaction_code = D.TRANSACTION_CODE AND C.Cyear = D.Cyear " +
        "inner join wh_BRANCHES As H on H.Branch_code=d.Branch_code " +
        "inner join Fac_Machine As M on M.Machine_no=C.Machin_No " +
        "where C.transaction_code='xtp' and IN_OUT_TYPE='O' and D.ITEM_NO like'" + Items.ID.Text +
        "%'  and group_code like '"+Uc_Group.ID.Text+"%' and A.Category in('" + R + "','" + F + "','" + C + "','" + P + "','" + S + "','" + Z + "') " +
        "group by C.Branch_code,H.Branch_Name,C.Machin_No,Machine_Name ");

                ds.Tables.Add(dt1);
                ds.WriteXmlSchema("schema_rpt.xml");
                rpt.SetDataSource(ds);
                crystalReportViewer1.ReportSource = rpt;

                //crystalReportViewer1.ReportSource = rpt;
                rpt.DataDefinition.FormulaFields["From_date"].Text = "'" + dTP1.Value.ToString("yyyy/MM/dd") + "'";
                rpt.DataDefinition.FormulaFields["To_Date"].Text = "'" + dTP2.Value.ToString("yyyy/MM/dd") + "'";
                rpt.DataDefinition.FormulaFields["From_thick"].Text = "'" + thick_1.Text + "'";
                rpt.DataDefinition.FormulaFields["To_thick"].Text = "'" + thick_2.Text + "'";
                rpt.DataDefinition.FormulaFields["Catogery"].Text = "'" + category.Text + "'";
                rpt.DataDefinition.FormulaFields["Dim_category"].Text = "'" + cmb_DimCategory.Text + "'";
                rpt.DataDefinition.FormulaFields["payment_"].Text = "'" + payment_type.Text + "'";
                rpt.DataDefinition.FormulaFields["Type_"].Text = "' تقرير الانتاج - موزع بخطوط الانتاج'";

            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Cursor.Current = Cursors.Default;

        }

        private void btnMonthelySales_Click(object sender, EventArgs e)
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


                RPT.rpt_M_BranchSales rpt = new RPT.rpt_M_BranchSales();

                DataSet1 ds = new DataSet1();
                DataTable dt1 = new DataTable();



                dt1 = (dal.getDataTabl_1(@"SELECT H.branch_code,H.branch_name
                ,Abs(Round(SUM(CASE WHEN   FORMAT(C.g_date, 'MM-yyyy')='01-'+FORMAT(C.g_date, 'yyyy') and D.Transaction_code like'XS%'  THEN ((D.QTY_TAKE-D.QTY_ADD) * D.Local_Price) - ((D.QTY_TAKE-D.QTY_ADD) * D.Local_Price * D.total_disc) / 100  ELSE 0 END),0)) AS '01' 
                ,Abs(Round(SUM(CASE WHEN   FORMAT(C.g_date, 'MM-yyyy')='02-'+FORMAT(C.g_date, 'yyyy')  and D.Transaction_code like'XS%'  THEN ((D.QTY_TAKE-D.QTY_ADD) * D.Local_Price) - ((D.QTY_TAKE-D.QTY_ADD) * D.Local_Price * D.total_disc) / 100  ELSE 0 END),0)) AS '02'
                ,Abs(Round(SUM(CASE WHEN   FORMAT(C.g_date, 'MM-yyyy')='03-'+FORMAT(C.g_date, 'yyyy')  and D.Transaction_code like'XS%'  THEN ((D.QTY_TAKE-D.QTY_ADD) * D.Local_Price) - ((D.QTY_TAKE-D.QTY_ADD) * D.Local_Price * D.total_disc) / 100  ELSE 0 END),0)) AS '03'
                ,Abs(Round(SUM(CASE WHEN   FORMAT(C.g_date, 'MM-yyyy')='04-'+FORMAT(C.g_date, 'yyyy')  and D.Transaction_code like'XS%'  THEN ((D.QTY_TAKE-D.QTY_ADD) * D.Local_Price) - ((D.QTY_TAKE-D.QTY_ADD) * D.Local_Price * D.total_disc) / 100  ELSE 0 END),0)) AS '04'
                ,Abs(Round(SUM(CASE WHEN   FORMAT(C.g_date, 'MM-yyyy')='05-'+FORMAT(C.g_date, 'yyyy')  and D.Transaction_code like'XS%'  THEN ((D.QTY_TAKE-D.QTY_ADD) * D.Local_Price) - ((D.QTY_TAKE-D.QTY_ADD) * D.Local_Price * D.total_disc) / 100  ELSE 0 END),0)) AS '05'
                ,Abs(Round(SUM(CASE WHEN   FORMAT(C.g_date, 'MM-yyyy')='06-'+FORMAT(C.g_date, 'yyyy')  and D.Transaction_code like'XS%'  THEN ((D.QTY_TAKE-D.QTY_ADD) * D.Local_Price) - ((D.QTY_TAKE-D.QTY_ADD) * D.Local_Price * D.total_disc) / 100  ELSE 0 END),0)) AS '06'
                ,Abs(Round(SUM(CASE WHEN   FORMAT(C.g_date, 'MM-yyyy')='07-'+FORMAT(C.g_date, 'yyyy')  and D.Transaction_code like'XS%'  THEN ((D.QTY_TAKE-D.QTY_ADD) * D.Local_Price) - ((D.QTY_TAKE-D.QTY_ADD) * D.Local_Price * D.total_disc) / 100  ELSE 0 END),0)) AS '07'
                ,Abs(Round(SUM(CASE WHEN   FORMAT(C.g_date, 'MM-yyyy')='08-'+FORMAT(C.g_date, 'yyyy')  and D.Transaction_code like'XS%'  THEN ((D.QTY_TAKE-D.QTY_ADD) * D.Local_Price) - ((D.QTY_TAKE-D.QTY_ADD) * D.Local_Price * D.total_disc) / 100  ELSE 0 END),0)) AS '08'
                ,Abs(Round(SUM(CASE WHEN   FORMAT(C.g_date, 'MM-yyyy')='09-'+FORMAT(C.g_date, 'yyyy')  and D.Transaction_code like'XS%'  THEN ((D.QTY_TAKE-D.QTY_ADD) * D.Local_Price) - ((D.QTY_TAKE-D.QTY_ADD) * D.Local_Price * D.total_disc) / 100  ELSE 0 END),0)) AS '09'
                ,Abs(Round(SUM(CASE WHEN   FORMAT(C.g_date, 'MM-yyyy')='10-'+FORMAT(C.g_date, 'yyyy')  and D.Transaction_code like'XS%'  THEN ((D.QTY_TAKE-D.QTY_ADD) * D.Local_Price) - ((D.QTY_TAKE-D.QTY_ADD) * D.Local_Price * D.total_disc) / 100  ELSE 0 END),0)) AS '10'
                ,Abs(Round(SUM(CASE WHEN   FORMAT(C.g_date, 'MM-yyyy')='11-'+FORMAT(C.g_date, 'yyyy')  and D.Transaction_code like'XS%'  THEN ((D.QTY_TAKE-D.QTY_ADD) * D.Local_Price) - ((D.QTY_TAKE-D.QTY_ADD) * D.Local_Price * D.total_disc) / 100  ELSE 0 END),0)) AS '11'
                ,Abs(Round(SUM(CASE WHEN   FORMAT(C.g_date, 'MM-yyyy')='12-'+FORMAT(C.g_date, 'yyyy')  and D.Transaction_code like'XS%'  THEN ((D.QTY_TAKE-D.QTY_ADD) * D.Local_Price) - ((D.QTY_TAKE-D.QTY_ADD) * D.Local_Price * D.total_disc) / 100  ELSE 0 END),0)) AS '12'

                FROM  wh_material_transaction As D
                inner join wh_main_master As A on A.item_no=D.ITEM_NO
                inner join wh_inv_data As C on  C.Ser_no = D.SER_NO AND C.Branch_code =D.Branch_code 
                AND  C.Transaction_code = D.TRANSACTION_CODE AND C.Cyear = D.Cyear
                inner join wh_BRANCHES As H on H.Branch_code=d.Branch_code					  
                where cast(D.G_date as date) between '"+dTP1.Value.ToString("yyyy/MM/dd")+ "' and '" + dTP2.Value.ToString("yyyy/MM/dd") +
                "'  and A.Company_code='A'   And H.branch_code like '"+UC_Branch.ID.Text+"%' and c.acc_no like '123998%'  GROUP BY H.branch_code,H.branch_name order by H.branch_code"));

                ds.Tables.Add(dt1);


                ds.WriteXmlSchema("schema_rpt.xml");
                rpt.SetDataSource(ds);
                crystalReportViewer1.ReportSource = rpt;

                rpt.DataDefinition.FormulaFields["FromDate"].Text = "'" + dTP1.Value.ToString("yyyy/MM/dd") + "'";
                rpt.DataDefinition.FormulaFields["ToDate"].Text = "'" + dTP2.Value.ToString("yyyy/MM/dd") + "'";
                rpt.DataDefinition.FormulaFields["Rep_Head"].Text = "'Monthly Sales By Branch'";
                rpt.DataDefinition.FormulaFields["company_name"].Text = "'" + Properties.Settings.Default.head_txt_EN + "'";
                rpt.DataDefinition.FormulaFields["Branch_Name"].Text = "'" + Properties.Settings.Default.Branch_txt_EN + "'";
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Cursor.Current = Cursors.Default;

        }

        private void Items_Load(object sender, EventArgs e)
        {

        }

        private void Items_Click(object sender, EventArgs e)
        {
            try
            {
                PL.frm_search_items frm = new PL.frm_search_items();
                frm.ShowDialog();
                Items.ID.Text = frm.dGV_pro_list.CurrentRow.Cells[0].Value.ToString();
                //get_balance();
            }
            catch { }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}

