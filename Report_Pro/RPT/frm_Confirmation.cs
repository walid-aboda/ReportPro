

using CrystalDecisions.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing; using System.Linq;
using System.IO;

using System.Text;
using System.Windows.Forms;



namespace Report_Pro.RPT
{
    public partial class frm_Confirmation : Form
    {
        List<CurrencyInfo> currencies = new List<CurrencyInfo>();
        int currencyNo=2;
        DAL.DataAccesslayer1 dal = new DAL.DataAccesslayer1();
        public frm_Confirmation()
        {
            InitializeComponent();
        }

        private void groupPanel1_Click(object sender, EventArgs e)
        {
          
    

        }

        private void RB3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RB4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RB1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonX4_Click(object sender, EventArgs e)
        {

        }

        private void buttonX7_Click(object sender, EventArgs e)
        {
            string bal = "1";
            if (RB1.Checked == true)
            { bal = "1"; }
            if (RB2.Checked == true)
            { bal = "2"; }
            if (RB3.Checked == true)
            { bal = "3"; }



            this.Cursor = Cursors.WaitCursor;
            DataTable dt = new DataTable();
            dt = dal.getDataTabl("GetAcc_", UC_Branch.ID.Text, UC_Acc.ID.Text, "", "", "", dal.db1);
            if (dt.Rows.Count <= 0 )
            {
                MessageBox.Show("لم يتم اختيار حساب", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (dal.getDataTabl("GetAcc_", UC_Branch.ID.Text, UC_Acc.ID.Text, "", "", "1", dal.db1).Rows.Count <= 0)
            {

                DataTable dt_ch = new DataTable();
                groupPanel1.Visible = false;

                if (RB1.Checked)
                {
                    dt_ch = dal.getDataTabl_1(@"select * from (select p.acc_no,PAYER_NAME,payer_l_name,A.Ending_balance ,ROW_NUMBER() OVER(PARTITION BY p.Acc_no ORDER BY p.acc_no) AS DuplicateCount from payer2 As P
                    inner join (select  acc_no
                    , SUM(CASE WHEN cast(g_date as date) >= '" + ToDate.MinDate.ToString("yyyy-MM-dd") + "' and cast(g_date as date) <= '" + ToDate.Value.ToString("yyyy-MM-dd") +
                    "' THEN meno - loh ELSE 0 END) AS Ending_balance" +
                    " from daily_transaction  group by ACC_NO ) As A " +
                    " on P.ACC_NO=A.ACC_NO " +
                    " where p.ACC_NO like '" + UC_Acc.ID.Text + "%' ) As X where X.DuplicateCount=1 ");
                }
                else if (RB2.Checked)
                {
                    dt_ch = dal.getDataTabl_1(@"select * from (select p.acc_no,PAYER_NAME,payer_l_name,A.Ending_balance ,ROW_NUMBER() OVER(PARTITION BY p.Acc_no ORDER BY p.acc_no) AS DuplicateCount from payer2 As P
                    inner join (select  acc_no
                    , SUM(CASE WHEN cast(g_date as date) >= '" + ToDate.MinDate.ToString("yyyy-MM-dd") + "' and cast(g_date as date) <= '" + ToDate.Value.ToString("yyyy-MM-dd") +
                    "' THEN meno - loh ELSE 0 END) AS Ending_balance" +
                    " from daily_transaction  group by ACC_NO ) As A " +
                    " on P.ACC_NO=A.ACC_NO " +
                    " where p.ACC_NO like '" + UC_Acc.ID.Text + "%' and A.Ending_balance<>0) As X where X.DuplicateCount=1");
                }
                else if (RB3.Checked)
                {
                    dt_ch = dal.getDataTabl_1(@"select * from (select p.acc_no,PAYER_NAME,payer_l_name,A.Ending_balance ,ROW_NUMBER() OVER(PARTITION BY p.Acc_no ORDER BY p.acc_no) AS DuplicateCount from payer2 As P
                    inner join (select  acc_no
                    , SUM(CASE WHEN cast(g_date as date) >= '" + ToDate.MinDate.ToString("yyyy-MM-dd") + "' and cast(g_date as date) <= '" + ToDate.Value.ToString("yyyy-MM-dd") +
                                       "' THEN meno - loh ELSE 0 END) AS Ending_balance" +
                                       " from daily_transaction  group by ACC_NO ) As A " +
                                       " on P.ACC_NO=A.ACC_NO " +
                                       " where p.ACC_NO like '" + UC_Acc.ID.Text + "%' and A.Ending_balance=0) As X where X.DuplicateCount=1 ");

                }

                foreach (DataRow dr in dt_ch.Rows)
                {

                    RPT.rpt_BH_Confirmation rpt = new RPT.rpt_BH_Confirmation();
                    DataSet1 ds = new DataSet1();
                    DataTable dt1 = new DataTable();



                    //dt1 = dal.getDataTabl_1(@"select p.ACC_NO,p.PAYER_NAME,p.payer_l_name, SUM(CASE WHEN cast(A.g_date as date) <= '" + ToDate.Value.ToString("yyyy-MM-dd") + "' THEN meno - loh ELSE 0 END) AS Ending_balance from " + dal.db1 + ".dbo.daily_transaction as A inner join " + dal.db1 + ".dbo.payer2 as P on a.ACC_NO = p.ACC_NO and where A.ACC_NO = '" + dr[0].ToString() + "' group by p.ACC_NO, p.PAYER_NAME, p.payer_l_name");
                    dt1 = dal.getDataTabl_1(@"
                        select X.Acc_no,p2.PAYER_NAME,p2.payer_l_name,X.Ending_balance from 
                        (select p.ACC_NO, SUM(CASE WHEN cast(A.g_date as date) <= '" + ToDate.Value.ToString("yyyy-MM-dd") + "' THEN meno - loh ELSE 0 END) AS Ending_balance from daily_transaction as A inner join payer2 as P on a.ACC_NO = p.ACC_NO and a.BRANCH_code = p.BRANCH_code where A.ACC_NO ='" + dr[0].ToString() +
                        "' group by p.ACC_NO) as X inner join (select acc_no,PAYER_NAME,payer_l_name ,ROW_NUMBER() OVER(PARTITION BY Acc_no ORDER BY acc_no) AS DuplicateCount from payer2 ) as p2 on x.ACC_NO=p2.acc_no where p2.DuplicateCount=1");

                    rpt.DataDefinition.FormulaFields["OB_studs"].Text = "";

                    ds.Tables.Add(dt1);

                    ds.WriteXmlSchema("schema1.xml");

                    rpt.SetDataSource(ds);
                    crystalReportViewer1.ReportSource = rpt;
                    this.Cursor = Cursors.Default;
                    rpt.DataDefinition.FormulaFields["To_Date"].Text = "'" + ToDate.Value.ToString("dd/MM/yyyy") + "'";
                    rpt.DataDefinition.FormulaFields["Acc_name"].Text = " '" + UC_Acc.Desc.Text + "'";
                    rpt.DataDefinition.FormulaFields["Currency_"].Text = "'" + Properties.Settings.Default.Currency + "'";

                   
                    ToWord toWord = new ToWord(Math.Abs(Math.Round(dt1.Rows[0][3].ToString().ToDecimal(), dal.digits_)), currencies[currencyNo]);

                    rpt.DataDefinition.FormulaFields["noToText"].Text = "'" + toWord.ConvertToEnglish().ToString() + "'";

                    rpt.PrintOptions.PrinterName = Properties.Settings.Default.Report_P;
                    rpt.PrintToPrinter(1,false,0,15);


                    rpt.Close();
                    rpt.Dispose();
                }

            }

            else
            {
                RPT.rpt_BH_Confirmation rpt = new RPT.rpt_BH_Confirmation();
                DataSet1 ds = new DataSet1();
                DataTable dt1 = new DataTable();



                //dt1 = dal.getDataTabl_1(@"select p.ACC_NO,p.PAYER_NAME,p.payer_l_name, SUM(CASE WHEN cast(A.g_date as date) <= '" + ToDate.Value.ToString("yyyy-MM-dd") + "' THEN meno - loh ELSE 0 END) AS Ending_balance from " + dal.db1 + ".dbo.daily_transaction as A inner join " + dal.db1 + ".dbo.payer2 as P on a.ACC_NO = p.ACC_NO and a.BRANCH_code = p.BRANCH_code where A.ACC_NO = '" + UC_Acc.ID.Text + "' group by p.ACC_NO, p.PAYER_NAME, p.payer_l_name");
                dt1 = dal.getDataTabl_1(@"
                        select X.Acc_no,p2.PAYER_NAME,p2.payer_l_name,X.Ending_balance from 
                        (select p.ACC_NO, SUM(CASE WHEN cast(A.g_date as date) <= '" + ToDate.Value.ToString("yyyy-MM-dd") + "' THEN meno - loh ELSE 0 END) AS Ending_balance from daily_transaction as A inner join payer2 as P on a.ACC_NO = p.ACC_NO and a.BRANCH_code = p.BRANCH_code where A.ACC_NO ='" +UC_Acc.ID.Text +
                       "' group by p.ACC_NO) as X inner join (select acc_no,PAYER_NAME,payer_l_name ,ROW_NUMBER() OVER(PARTITION BY Acc_no ORDER BY acc_no) AS DuplicateCount from payer2 ) as p2 on x.ACC_NO=p2.acc_no where p2.DuplicateCount=1");


                rpt.DataDefinition.FormulaFields["OB_studs"].Text = "";

                ds.Tables.Add(dt1);

                ds.WriteXmlSchema("schema1.xml");

                rpt.SetDataSource(ds);
                crystalReportViewer1.ReportSource = rpt;
                this.Cursor = Cursors.Default;
                rpt.DataDefinition.FormulaFields["To_Date"].Text = "'" + ToDate.Value.ToString("dd/MM/yyyy") + "'";
                rpt.DataDefinition.FormulaFields["Acc_name"].Text = " '" + UC_Acc.Desc.Text + "'";
                rpt.DataDefinition.FormulaFields["Currency_"].Text = "'" + Properties.Settings.Default.Currency + "'";

                ToWord toWord = new ToWord(Math.Abs(Math.Round(dt1.Rows[0][3].ToString().ToDecimal(), dal.digits_)), currencies[currencyNo]);
                rpt.DataDefinition.FormulaFields["noToText"].Text = "'" + toWord.ConvertToEnglish().ToString() + "'";

                groupPanel1.Visible = false;

            }



        }

        private void buttonX6_Click(object sender, EventArgs e)
        {
            groupPanel1.Visible = true;
        }

        private void buttonX3_Click(object sender, EventArgs e)
        {
          
                string bal = "1";
                if (RB1.Checked == true)
                { bal = "1"; }
                if (RB2.Checked == true)
                { bal = "2"; }
                if (RB3.Checked == true)
                { bal = "3"; }


                this.Cursor = Cursors.WaitCursor;
                DataTable dt = new DataTable();
                dt = dal.getDataTabl("GetAcc_", UC_Branch.ID.Text, UC_Acc.ID.Text, "", "", "", dal.db1);
                if (dt.Rows.Count <= 0)
                {
                    MessageBox.Show("لم يتم اختيار حساب", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


            if (dal.getDataTabl("GetAcc_", UC_Branch.ID.Text, UC_Acc.ID.Text, "", "", "1", dal.db1).Rows.Count <= 0)

            {
                
               
                DataTable dt_ch = new DataTable();
                if (RB1.Checked)
                {
                    dt_ch = dal.getDataTabl_1(@"select * from (select p.acc_no,PAYER_NAME,payer_l_name,A.Ending_balance ,ROW_NUMBER() OVER(PARTITION BY p.Acc_no ORDER BY p.acc_no) AS DuplicateCount from payer2 As P
                    inner join (select  acc_no
                    , SUM(CASE WHEN cast(g_date as date) >= '" + ToDate.MinDate.ToString("yyyy-MM-dd") + "' and cast(g_date as date) <= '" + ToDate.Value.ToString("yyyy-MM-dd") +
                    "' THEN meno - loh ELSE 0 END) AS Ending_balance" +
                    " from daily_transaction  group by ACC_NO ) As A " +
                    " on P.ACC_NO=A.ACC_NO " +
                    " where p.ACC_NO like '" + UC_Acc.ID.Text + "%' ) As X where X.DuplicateCount=1 ");
                }
                else if (RB2.Checked)
                {
                    dt_ch = dal.getDataTabl_1(@"select * from (select p.acc_no,PAYER_NAME,payer_l_name,A.Ending_balance ,ROW_NUMBER() OVER(PARTITION BY p.Acc_no ORDER BY p.acc_no) AS DuplicateCount from payer2 As P
                    inner join (select  acc_no
                    , SUM(CASE WHEN cast(g_date as date) >= '" + ToDate.MinDate.ToString("yyyy-MM-dd") + "' and cast(g_date as date) <= '" + ToDate.Value.ToString("yyyy-MM-dd") +
                    "' THEN meno - loh ELSE 0 END) AS Ending_balance" +
                    " from daily_transaction  group by ACC_NO ) As A " +
                    " on P.ACC_NO=A.ACC_NO " +
                    " where p.ACC_NO like '" + UC_Acc.ID.Text + "%' and A.Ending_balance<>0) As X where X.DuplicateCount=1");
                }
                else if (RB3.Checked)
                {
                    dt_ch = dal.getDataTabl_1(@"select * from (select p.acc_no,PAYER_NAME,payer_l_name,A.Ending_balance ,ROW_NUMBER() OVER(PARTITION BY p.Acc_no ORDER BY p.acc_no) AS DuplicateCount from payer2 As P
                    inner join (select  acc_no
                    , SUM(CASE WHEN cast(g_date as date) >= '" + ToDate.MinDate.ToString("yyyy-MM-dd") + "' and cast(g_date as date) <= '" + ToDate.Value.ToString("yyyy-MM-dd") +
                                       "' THEN meno - loh ELSE 0 END) AS Ending_balance" +
                                       " from daily_transaction  group by ACC_NO ) As A " +
                                       " on P.ACC_NO=A.ACC_NO " +
                                       " where p.ACC_NO like '" + UC_Acc.ID.Text + "%' and A.Ending_balance=0) As X where X.DuplicateCount=1 ");

                }

                foreach (DataRow dr in dt_ch.Rows)
                {

                    RPT.rpt_Confirmation rpt = new RPT.rpt_Confirmation();
                    DataTable dt1 = new DataTable();
                    DataSet1 ds = new DataSet1();


                    //dt1 = dal.getDataTabl_1(@"select p.ACC_NO,p.PAYER_NAME,p.payer_l_name, SUM(CASE WHEN cast(A.g_date as date) <= '" + ToDate.Value.ToString("yyyy-MM-dd") + "' THEN meno - loh ELSE 0 END) AS Ending_balance from " + dal.db1 + ".dbo.daily_transaction as A inner join " + dal.db1 + ".dbo.payer2 as P on a.ACC_NO = p.ACC_NO and a.BRANCH_code = p.BRANCH_code where A.ACC_NO = '" + dr[0].ToString() + "' group by p.ACC_NO, p.PAYER_NAME, p.payer_l_name");
                    dt1 = dal.getDataTabl_1(@"
                        select X.Acc_no,p2.PAYER_NAME,p2.payer_l_name,X.Ending_balance from 
                        (select p.ACC_NO, SUM(CASE WHEN cast(A.g_date as date) <= '" + ToDate.Value.ToString("yyyy-MM-dd") + "' THEN meno - loh ELSE 0 END) AS Ending_balance from daily_transaction as A inner join payer2 as P on a.ACC_NO = p.ACC_NO and a.BRANCH_code = p.BRANCH_code where A.ACC_NO ='" + dr[0].ToString() +
                       "' group by p.ACC_NO) as X inner join (select acc_no,PAYER_NAME,payer_l_name ,ROW_NUMBER() OVER(PARTITION BY Acc_no ORDER BY acc_no) AS DuplicateCount from payer2 ) as p2 on x.ACC_NO=p2.acc_no where p2.DuplicateCount=1");


                    rpt.DataDefinition.FormulaFields["OB_studs"].Text = "";

                    ds.Tables.Add(dt1);
                    ds.WriteXmlSchema("schema1.xml");
                rpt.SetDataSource(ds);
                crystalReportViewer1.ReportSource = rpt;
                this.Cursor = Cursors.Default;
                rpt.DataDefinition.FormulaFields["OB_studs"].Text = "";
                rpt.DataDefinition.FormulaFields["To_Date"].Text = "'" + ToDate.Value.ToString("dd/MM/yyyy") + "'";
                rpt.DataDefinition.FormulaFields["CoName"].Text = " '" + Properties.Settings.Default.head_txt + "'";
                rpt.DataDefinition.FormulaFields["CoName_E"].Text = " '" + Properties.Settings.Default.head_txt_EN + "'";
                rpt.DataDefinition.FormulaFields["Currency_"].Text = "'" + Properties.Settings.Default.Currency + "'";
                ToWord toWord = new ToWord(Math.Abs(Convert.ToDecimal(dt1.Rows[0][3].ToString())), currencies[currencyNo]);
                rpt.DataDefinition.FormulaFields["NuToText_A"].Text = "'" + toWord.ConvertToArabic().ToString() + "'";
                rpt.DataDefinition.FormulaFields["noToText"].Text = "'" + toWord.ConvertToEnglish().ToString() + "'";

                rpt.PrintOptions.PrinterName = Properties.Settings.Default.Report_P;
                rpt.PrintToPrinter(1, false, 0, 15);


                rpt.Close();
                rpt.Dispose();
                }
                groupPanel1.Visible = false;
            }

                else
                {
                RPT.rpt_Confirmation rpt = new RPT.rpt_Confirmation();
                DataSet1 ds = new DataSet1();
                DataTable dt1 = new DataTable();
                //dt1 = dal.getDataTabl_1(@"select p1.ACC_NO,p1.PAYER_NAME,p1.payer_l_name, SUM(CASE WHEN cast(A.g_date as date) <= '" + ToDate.Value.ToString("yyyy-MM-dd") + "' THEN meno - loh ELSE 0 END) AS Ending_balance from " + dal.db1 + 
                //".dbo.daily_transaction as A inner join (select* from (select p.ACC_NO,p.PAYER_NAME,p.payer_l_name,p.BRANCH_code , ROW_NUMBER() OVER(PARTITION BY p.Acc_no ORDER BY p.acc_no) AS DuplicateCount FROM "+ dal.db1 +
                //".dbo.payer2  As P inner join " + dal.db1 + ".dbo.BRANCHS As B on P.BRANCH_code = B.BRANCH_code where B.BRANCH_code like '"+UC_Branch.ID.Text+"%') as t1 where t1.DuplicateCount = 1) as P1 on a.ACC_NO = p1.ACC_NO  where A.ACC_NO = '" + UC_Acc.ID.Text + "' and p1.BRANCH_code like '"+UC_Branch.ID.Text+"%'  group by p1.ACC_NO, p1.PAYER_NAME, p1.payer_l_name");

                dt1 = dal.getDataTabl_1(@"
                        select X.Acc_no,p2.PAYER_NAME,p2.payer_l_name,X.Ending_balance from 
                        (select p.ACC_NO, SUM(CASE WHEN cast(A.g_date as date) <= '" + ToDate.Value.ToString("yyyy-MM-dd") + "' THEN meno - loh ELSE 0 END) AS Ending_balance from daily_transaction as A inner join payer2 as P on a.ACC_NO = p.ACC_NO and a.BRANCH_code = p.BRANCH_code where A.ACC_NO ='" + UC_Acc.ID.Text +
                       "' group by p.ACC_NO) as X inner join (select acc_no,PAYER_NAME,payer_l_name ,ROW_NUMBER() OVER(PARTITION BY Acc_no ORDER BY acc_no) AS DuplicateCount from payer2 ) as p2 on x.ACC_NO=p2.acc_no where p2.DuplicateCount=1");


                rpt.DataDefinition.FormulaFields["OB_studs"].Text = "";
                ds.Tables.Add(dt1);
                ds.WriteXmlSchema("schema1.xml");
                rpt.SetDataSource(ds);
                crystalReportViewer1.ReportSource = rpt;
                this.Cursor = Cursors.Default;
                rpt.DataDefinition.FormulaFields["To_Date"].Text = "'" + ToDate.Value.ToString("dd/MM/yyyy") + "'";
                rpt.DataDefinition.FormulaFields["CoName"].Text = " '" + Properties.Settings.Default.head_txt + "'";
                rpt.DataDefinition.FormulaFields["CoName_E"].Text = " '" + Properties.Settings.Default.head_txt_EN+ "'";
                rpt.DataDefinition.FormulaFields["Currency_"].Text = "'" + Properties.Settings.Default.Currency + "'";
                ToWord toWord = new ToWord(Math.Abs(Convert.ToDecimal(dt1.Rows[0][3].ToString())), currencies[currencyNo]);
                rpt.DataDefinition.FormulaFields["NuToText_A"].Text = "'"+toWord.ConvertToArabic().ToString()+"'";
                groupPanel1.Visible = false;

                }



            }

        private void frm_Confirmation_Load(object sender, EventArgs e)
        {
            currencies.Add(new CurrencyInfo(CurrencyInfo.Currencies.Syria));
            currencies.Add(new CurrencyInfo(CurrencyInfo.Currencies.UAE));
            currencies.Add(new CurrencyInfo(CurrencyInfo.Currencies.s));
            currencies.Add(new CurrencyInfo(CurrencyInfo.Currencies.Tunisia));
            currencies.Add(new CurrencyInfo(CurrencyInfo.Currencies.Gold));
            currencies.Add(new CurrencyInfo(CurrencyInfo.Currencies.Bahrain));
            currencies.Add(new CurrencyInfo(CurrencyInfo.Currencies.Oman));

            switch (Properties.Settings.Default.Currency)
            {
                case "s":
                    currencyNo = 2;
                    break;
                case "BH":
                    currencyNo = 5;
                    break;
                case "OM":
                    currencyNo = 6;
                    break;
                case "DR":
                    currencyNo = 1;
                    break;
            }
        }

        private void buttonX5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
           
                string bal = "1";
                if (RB1.Checked == true)
                { bal = "1"; }
                if (RB2.Checked == true)
                { bal = "2"; }
                if (RB3.Checked == true)
                { bal = "3"; }



                this.Cursor = Cursors.WaitCursor;
                DataTable dt = new DataTable();
                dt = dal.getDataTabl("GetAcc_", UC_Branch.ID.Text, UC_Acc.ID.Text, "", "", "", dal.db1);
                if (dt.Rows.Count <= 0)
                {
                    MessageBox.Show("لم يتم اختيار حساب", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


            if (dal.getDataTabl("GetAcc_", UC_Branch.ID.Text, UC_Acc.ID.Text, "", "", "1", dal.db1).Rows.Count <= 0)
            {

                DataTable dt_ch = new DataTable();


                if (RB1.Checked)
                {
                    dt_ch = dal.getDataTabl_1(@"select * from (select p.acc_no,PAYER_NAME,payer_l_name,A.Ending_balance ,ROW_NUMBER() OVER(PARTITION BY p.Acc_no ORDER BY p.acc_no) AS DuplicateCount from payer2 As P
                    inner join (select  acc_no
                    , SUM(CASE WHEN cast(g_date as date) >= '" + ToDate.MinDate.ToString("yyyy-MM-dd") + "' and cast(g_date as date) <= '" + ToDate.Value.ToString("yyyy-MM-dd") +
                    "' THEN meno - loh ELSE 0 END) AS Ending_balance" +
                    " from daily_transaction  group by ACC_NO ) As A " +
                    " on P.ACC_NO=A.ACC_NO " +
                    " where p.ACC_NO like '" + UC_Acc.ID.Text + "%' ) As X where X.DuplicateCount=1 ");
                }
                else if (RB2.Checked)
                {
                    dt_ch = dal.getDataTabl_1(@"select * from (select p.acc_no,PAYER_NAME,payer_l_name,A.Ending_balance ,ROW_NUMBER() OVER(PARTITION BY p.Acc_no ORDER BY p.acc_no) AS DuplicateCount from payer2 As P
                    inner join (select  acc_no
                    , SUM(CASE WHEN cast(g_date as date) >= '" + ToDate.MinDate.ToString("yyyy-MM-dd") + "' and cast(g_date as date) <= '" + ToDate.Value.ToString("yyyy-MM-dd") +
                    "' THEN meno - loh ELSE 0 END) AS Ending_balance" +
                    " from daily_transaction  group by ACC_NO ) As A " +
                    " on P.ACC_NO=A.ACC_NO " +
                    " where p.ACC_NO like '" + UC_Acc.ID.Text + "%' and A.Ending_balance<>0) As X where X.DuplicateCount=1");
                }
                else if (RB3.Checked)
                {
                    dt_ch = dal.getDataTabl_1(@"select * from (select p.acc_no,PAYER_NAME,payer_l_name,A.Ending_balance ,ROW_NUMBER() OVER(PARTITION BY p.Acc_no ORDER BY p.acc_no) AS DuplicateCount from payer2 As P
                    inner join (select  acc_no
                    , SUM(CASE WHEN cast(g_date as date) >= '" + ToDate.MinDate.ToString("yyyy-MM-dd") + "' and cast(g_date as date) <= '" + ToDate.Value.ToString("yyyy-MM-dd") +
                                       "' THEN meno - loh ELSE 0 END) AS Ending_balance" +
                                       " from daily_transaction  group by ACC_NO ) As A " +
                                       " on P.ACC_NO=A.ACC_NO " +
                                       " where p.ACC_NO like '" + UC_Acc.ID.Text + "%' and A.Ending_balance=0) As X where X.DuplicateCount=1 ");

                }

                FolderBrowserDialog fd1 = new FolderBrowserDialog();

                // Show the FolderBrowserDialog.
                DialogResult result = fd1.ShowDialog();
                if (result == DialogResult.OK)
                {
                    string folderName = fd1.SelectedPath;
                }
                else
                {
                    return;
                }

                   
                foreach (DataRow dr in dt_ch.Rows)
                    {

                    string fName = "";
                    if (dr[2].ToString() == "")
                    {
                        fName=dr[1].ToString();
                    }
                    else
                    {
                        fName = dr[2].ToString();
                    }
                    RPT.rpt_BH_Confirmation rpt = new rpt_BH_Confirmation();
                        DataSet1 ds = new DataSet1();
                        DataTable dt1 = new DataTable();
                        //dt1 = dal.getDataTabl_1(@"select p.ACC_NO, SUM(CASE WHEN cast(A.g_date as date) <= '" + ToDate.Value.ToString("yyyy-MM-dd") + "' THEN meno - loh ELSE 0 END) AS Ending_balance from " + dal.db1 + ".dbo.daily_transaction as A inner join " + dal.db1 + ".dbo.payer2 as P on a.ACC_NO = p.ACC_NO and a.BRANCH_code = p.BRANCH_code where A.ACC_NO = '" + dr[0].ToString() + "' group by p.ACC_NO");
                       dt1 = dal.getDataTabl_1(@"
                        select X.Acc_no,p2.PAYER_NAME,p2.payer_l_name,X.Ending_balance from 
                        (select p.ACC_NO, SUM(CASE WHEN cast(A.g_date as date) <= '" + ToDate.Value.ToString("yyyy-MM-dd") + "' THEN meno - loh ELSE 0 END) AS Ending_balance from daily_transaction as A inner join payer2 as P on a.ACC_NO = p.ACC_NO and a.BRANCH_code = p.BRANCH_code where A.ACC_NO ='" + dr[0].ToString() +
                        "' group by p.ACC_NO) as X inner join (select acc_no,PAYER_NAME,payer_l_name ,ROW_NUMBER() OVER(PARTITION BY Acc_no ORDER BY acc_no) AS DuplicateCount from payer2 ) as p2 on x.ACC_NO=p2.acc_no where p2.DuplicateCount=1");

                        rpt.DataDefinition.FormulaFields["OB_studs"].Text = "";
                        ds.Tables.Add(dt1);
                        ds.WriteXmlSchema("schema1.xml");
                        rpt.SetDataSource(ds);
                        crystalReportViewer1.ReportSource = rpt;

                    ToWord toWord = new ToWord(Math.Abs(Math.Round(dt1.Rows[0][3].ToString().ToDecimal(), dal.digits_)), currencies[currencyNo]);
                    rpt.DataDefinition.FormulaFields["noToText"].Text = "'" + toWord.ConvertToEnglish().ToString() + "'";

                    rpt.DataDefinition.FormulaFields["To_Date"].Text = "'" + ToDate.Value.ToString("dd/MM/yyyy") + "'";
                    rpt.DataDefinition.FormulaFields["Acc_Name"].Text = "'" + UC_Acc.Desc.Text + "'";
                    rpt.DataDefinition.FormulaFields["Currency_"].Text = "'" + Properties.Settings.Default.Currency + "'";
                    //rpt.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, ());
                    rpt.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, (fd1.SelectedPath + "\\" + fName + ".pdf"));
                    //rpt.PrintOptions.PrinterName = Properties.Settings.Default.Report_P;
                    //rpt.PrintToPrinter(1, false, 0, 15);

                    this.Cursor = Cursors.Default;
                     
                        groupPanel1.Visible = false;
                    rpt.Close();
                    rpt.Dispose();
                    }
                
                                }

                else
                {
                    RPT.rpt_BH_Confirmation rpt = new RPT.rpt_BH_Confirmation();
                    DataSet1 ds = new DataSet1();
                    DataTable dt1 = new DataTable();



                    //dt1 = dal.getDataTabl_1(@"select p.ACC_NO,p.PAYER_NAME,p.payer_l_name, SUM(CASE WHEN cast(A.g_date as date) <= '" + ToDate.Value.ToString("yyyy-MM-dd") + "' THEN meno - loh ELSE 0 END) AS Ending_balance from " + dal.db1 + ".dbo.daily_transaction as A inner join " + dal.db1 + ".dbo.payer2 as P on a.ACC_NO = p.ACC_NO and a.BRANCH_code = p.BRANCH_code where A.ACC_NO = '" + UC_Acc.ID.Text + "' group by p.ACC_NO, p.PAYER_NAME, p.payer_l_name");
                dt1 = dal.getDataTabl_1(@"
                        select X.Acc_no,p2.PAYER_NAME,p2.payer_l_name,X.Ending_balance from 
                        (select p.ACC_NO, SUM(CASE WHEN cast(A.g_date as date) <= '" + ToDate.Value.ToString("yyyy-MM-dd") + "' THEN meno - loh ELSE 0 END) AS Ending_balance from daily_transaction as A inner join payer2 as P on a.ACC_NO = p.ACC_NO and a.BRANCH_code = p.BRANCH_code where A.ACC_NO ='" + UC_Acc.ID.Text + 
                         "' group by p.ACC_NO) as X inner join (select acc_no,PAYER_NAME,payer_l_name ,ROW_NUMBER() OVER(PARTITION BY Acc_no ORDER BY acc_no) AS DuplicateCount from payer2 ) as p2 on x.ACC_NO=p2.acc_no where p2.DuplicateCount=1");

                rpt.DataDefinition.FormulaFields["OB_studs"].Text = "";

                    ds.Tables.Add(dt1);

                    ds.WriteXmlSchema("schema1.xml");

                    rpt.SetDataSource(ds);
                    crystalReportViewer1.ReportSource = rpt;
                    this.Cursor = Cursors.Default;
                    rpt.DataDefinition.FormulaFields["To_Date"].Text = "'" + ToDate.Value.ToString("dd/MM/yyyy") + "'";
                    rpt.DataDefinition.FormulaFields["Acc_name"].Text = " '" + UC_Acc.Desc.Text + "'";
                    rpt.DataDefinition.FormulaFields["Currency_"].Text = "'" + Properties.Settings.Default.Currency + "'";

                    groupPanel1.Visible = false;

                }



            }

        private void buttonX2_Click(object sender, EventArgs e)
        {

            string bal = "1";
            if (RB1.Checked == true)
            { bal = "1"; }
            if (RB2.Checked == true)
            { bal = "2"; }
            if (RB3.Checked == true)
            { bal = "3"; }



            this.Cursor = Cursors.WaitCursor;
            DataTable dt = new DataTable();
            dt = dal.getDataTabl("GetAcc_", UC_Branch.ID.Text, UC_Acc.ID.Text, "", "", "", dal.db1);
            if (dt.Rows.Count <= 0)
            {
                MessageBox.Show("لم يتم اختيار حساب", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            FolderBrowserDialog fd1 = new FolderBrowserDialog();

            DialogResult result = fd1.ShowDialog();
            if (result == DialogResult.OK)
            {
                string folderName = fd1.SelectedPath;
            }
            else
            {
                return;
            }

            if (dal.getDataTabl("GetAcc_", UC_Branch.ID.Text, UC_Acc.ID.Text, "", "", "1", dal.db1).Rows.Count <= 0)
            {

                DataTable dt_ch = new DataTable();


                if (RB1.Checked)
                {
                    dt_ch = dal.getDataTabl_1(@"select * from (select p.acc_no,PAYER_NAME,payer_l_name,A.Ending_balance ,ROW_NUMBER() OVER(PARTITION BY p.Acc_no ORDER BY p.acc_no) AS DuplicateCount from payer2 As P
                    inner join (select  acc_no
                    , SUM(CASE WHEN cast(g_date as date) >= '" + ToDate.MinDate.ToString("yyyy-MM-dd") + "' and cast(g_date as date) <= '" + ToDate.Value.ToString("yyyy-MM-dd") +
                    "' THEN meno - loh ELSE 0 END) AS Ending_balance" +
                    " from daily_transaction  group by ACC_NO ) As A " +
                    " on P.ACC_NO=A.ACC_NO " +
                    " where p.ACC_NO like '" + UC_Acc.ID.Text + "%' ) As X where X.DuplicateCount=1 ");
                }
                else if (RB2.Checked)
                {
                    dt_ch = dal.getDataTabl_1(@"select * from (select p.acc_no,PAYER_NAME,payer_l_name,A.Ending_balance ,ROW_NUMBER() OVER(PARTITION BY p.Acc_no ORDER BY p.acc_no) AS DuplicateCount from payer2 As P
                    inner join (select  acc_no
                    , SUM(CASE WHEN cast(g_date as date) >= '" + ToDate.MinDate.ToString("yyyy-MM-dd") + "' and cast(g_date as date) <= '" + ToDate.Value.ToString("yyyy-MM-dd") +
                    "' THEN meno - loh ELSE 0 END) AS Ending_balance" +
                    " from daily_transaction  group by ACC_NO ) As A " +
                    " on P.ACC_NO=A.ACC_NO " +
                    " where p.ACC_NO like '" + UC_Acc.ID.Text + "%' and A.Ending_balance<>0) As X where X.DuplicateCount=1");
                }
                else if (RB3.Checked)
                {
                    dt_ch = dal.getDataTabl_1(@"select * from (select p.acc_no,PAYER_NAME,payer_l_name,A.Ending_balance ,ROW_NUMBER() OVER(PARTITION BY p.Acc_no ORDER BY p.acc_no) AS DuplicateCount from payer2 As P
                    inner join (select  acc_no
                    , SUM(CASE WHEN cast(g_date as date) >= '" + ToDate.MinDate.ToString("yyyy-MM-dd") + "' and cast(g_date as date) <= '" + ToDate.Value.ToString("yyyy-MM-dd") +
                                       "' THEN meno - loh ELSE 0 END) AS Ending_balance" +
                                       " from daily_transaction  group by ACC_NO ) As A " +
                                       " on P.ACC_NO=A.ACC_NO " +
                                       " where p.ACC_NO like '" + UC_Acc.ID.Text + "%' and A.Ending_balance=0) As X where X.DuplicateCount=1 ");

                }

                


                foreach (DataRow dr in dt_ch.Rows)
                {
                    string fName = "";
                    if (dr[2].ToString() == "")
                    {
                        fName = dr[1].ToString();
                    }
                    else
                    {
                        fName = dr[2].ToString();
                    }
                    RPT.rpt_Confirmation rpt = new RPT.rpt_Confirmation();
                    DataSet1 ds = new DataSet1();
                    DataTable dt1 = new DataTable();
                    //dt1 = dal.getDataTabl_1(@"select p.ACC_NO, SUM(CASE WHEN cast(A.g_date as date) <= '" + ToDate.Value.ToString("yyyy-MM-dd") + "' THEN meno - loh ELSE 0 END) AS Ending_balance from " + dal.db1 + ".dbo.daily_transaction as A inner join " + dal.db1 + ".dbo.payer2 as P on a.ACC_NO = p.ACC_NO and a.BRANCH_code = p.BRANCH_code where A.ACC_NO = '" + dr[0].ToString() + "' group by p.ACC_NO");
                    dt1 = dal.getDataTabl_1(@"
                        select X.Acc_no,p2.PAYER_NAME,p2.payer_l_name,X.Ending_balance from 
                        (select p.ACC_NO, SUM(CASE WHEN cast(A.g_date as date) <= '" + ToDate.Value.ToString("yyyy-MM-dd") + "' THEN meno - loh ELSE 0 END) AS Ending_balance from daily_transaction as A inner join payer2 as P on a.ACC_NO = p.ACC_NO and a.BRANCH_code = p.BRANCH_code where A.ACC_NO ='" + dr[0].ToString() +
                     "' group by p.ACC_NO) as X inner join (select acc_no,PAYER_NAME,payer_l_name ,ROW_NUMBER() OVER(PARTITION BY Acc_no ORDER BY acc_no) AS DuplicateCount from payer2 ) as p2 on x.ACC_NO=p2.acc_no where p2.DuplicateCount=1");

                    rpt.DataDefinition.FormulaFields["OB_studs"].Text = "";
                    ds.Tables.Add(dt1);
                    ds.WriteXmlSchema("schema1.xml");
                    rpt.SetDataSource(ds);
                    crystalReportViewer1.ReportSource = rpt;

                    ToWord toWord = new ToWord(Math.Abs(Math.Round(dt1.Rows[0][3].ToString().ToDecimal(), dal.digits_)), currencies[currencyNo]);
                    rpt.DataDefinition.FormulaFields["noToText"].Text = "'" + toWord.ConvertToEnglish().ToString() + "'";
                    rpt.DataDefinition.FormulaFields["NuToText_A"].Text = "'" + toWord.ConvertToArabic().ToString() + "'";
                    
                    rpt.DataDefinition.FormulaFields["To_Date"].Text = "'" + ToDate.Value.ToString("dd/MM/yyyy") + "'";
                    rpt.DataDefinition.FormulaFields["Currency_"].Text = "'" + Properties.Settings.Default.Currency + "'";
                    rpt.DataDefinition.FormulaFields["CoName"].Text = "'" + Properties.Settings.Default.head_txt + "'";
                    rpt.DataDefinition.FormulaFields["CoName_E"].Text = "'" + Properties.Settings.Default.head_txt_EN + "'";

                    rpt.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, (fd1.SelectedPath + "\\" + fName + ".pdf"));
                    this.Cursor = Cursors.Default;
                 

                    groupPanel1.Visible = false;
                    rpt.Close();
                    rpt.Dispose();
                }

            }

            else
            {
                RPT.rpt_Confirmation rpt = new RPT.rpt_Confirmation();
                DataSet1 ds = new DataSet1();
                DataTable dt1 = new DataTable();



                //dt1 = dal.getDataTabl_1(@"select p.ACC_NO,p.PAYER_NAME,p.payer_l_name, SUM(CASE WHEN cast(A.g_date as date) <= '" + ToDate.Value.ToString("yyyy-MM-dd") + "' THEN meno - loh ELSE 0 END) AS Ending_balance from " + dal.db1 + ".dbo.daily_transaction as A inner join " + dal.db1 + ".dbo.payer2 as P on a.ACC_NO = p.ACC_NO and a.BRANCH_code = p.BRANCH_code where A.ACC_NO = '" + UC_Acc.ID.Text + "' group by p.ACC_NO, p.PAYER_NAME, p.payer_l_name");
                dt1 = dal.getDataTabl_1(@"
                        select X.Acc_no,p2.PAYER_NAME,p2.payer_l_name,X.Ending_balance from 
                        (select p.ACC_NO, SUM(CASE WHEN cast(A.g_date as date) <= '" + ToDate.Value.ToString("yyyy-MM-dd") + "' THEN meno - loh ELSE 0 END) AS Ending_balance from daily_transaction as A inner join payer2 as P on a.ACC_NO = p.ACC_NO and a.BRANCH_code = p.BRANCH_code where A.ACC_NO ='" + UC_Acc.ID.Text +
                         "' group by p.ACC_NO) as X inner join (select acc_no,PAYER_NAME,payer_l_name ,ROW_NUMBER() OVER(PARTITION BY Acc_no ORDER BY acc_no) AS DuplicateCount from payer2 ) as p2 on x.ACC_NO=p2.acc_no where p2.DuplicateCount=1");

                rpt.DataDefinition.FormulaFields["OB_studs"].Text = "";

                ds.Tables.Add(dt1);

                ds.WriteXmlSchema("schema1.xml");

                rpt.SetDataSource(ds);
                crystalReportViewer1.ReportSource = rpt;
                this.Cursor = Cursors.Default;

                ToWord toWord = new ToWord(Math.Abs(Math.Round(dt1.Rows[0][3].ToString().ToDecimal(), dal.digits_)), currencies[currencyNo]);
                rpt.DataDefinition.FormulaFields["noToText"].Text = "'" + toWord.ConvertToEnglish().ToString() + "'";
                rpt.DataDefinition.FormulaFields["NuToText_A"].Text = "'" + toWord.ConvertToArabic().ToString() + "'";
                rpt.DataDefinition.FormulaFields["To_Date"].Text = "'" + ToDate.Value.ToString("dd/MM/yyyy") + "'";
                rpt.DataDefinition.FormulaFields["Currency_"].Text = "'" + Properties.Settings.Default.Currency + "'";
                rpt.DataDefinition.FormulaFields["CoName"].Text = "'" + Properties.Settings.Default.head_txt + "'";
                rpt.DataDefinition.FormulaFields["CoName_E"].Text = "'" + Properties.Settings.Default.head_txt_EN + "'";

                string fName = dt1.Rows[0][0].ToString();
                rpt.ExportToDisk(ExportFormatType.PortableDocFormat, (fd1.SelectedPath + "\\" + fName + ".pdf"));

                

                groupPanel1.Visible = false;

            }



        }
    }
}
