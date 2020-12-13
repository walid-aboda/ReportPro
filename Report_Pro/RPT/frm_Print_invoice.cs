using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Report_Pro.RPT
{
    public partial class frm_Print_invoice : Form
    {
        DAL.DataAccesslayer1 dal = new DAL.DataAccesslayer1();
        DataTable dt_inv;
        public frm_Print_invoice()
        {
            InitializeComponent();
            txtYear.Value = DateTime.Today.Year;
        }

        private void frm_Print_invoice_Load(object sender, EventArgs e)
        {

        }

        private void groupPanel1_Click(object sender, EventArgs e)
        {

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            RPT.rpt_print_XPE rpt = new RPT.rpt_print_XPE();
            RPT.Form1 frm = new RPT.Form1();
            DataSet ds = new DataSet();
            get_invoice(txtSer.Text, Branch.ID.Text, Transaction.ID.Text, (txtYear.Value-2000).ToString());
            ds.Tables.Add(dt_inv);
            ds.WriteXmlSchema("schema_rpt.xml");
            rpt.SetDataSource(ds);
            rpt.DataDefinition.FormulaFields["decimal_"].Text = "'" + Properties.Settings.Default.digitNo_ + "'";
            rpt.DataDefinition.FormulaFields["Currency_"].Text = "'" + Properties.Settings.Default.Currency + "'";
            //reportInv.PrintOptions.PrinterName = Properties.Settings.Default.Invoice_P;
            //reportInv.PrintToPrinter(1, false, 0, 15);
            frm.crystalReportViewer1.ReportSource = rpt;
            frm.WindowState = FormWindowState.Maximized;
            frm.ShowDialog();
        }

        private void get_invoice(string ser_, string branch_, string transaction_, string cyear_)
        {
            dt_inv= dal.getDataTabl_1(@"select a.*,b.*,round(b.total_disc*Forign_price*QTY_ADD/100,2) as disc_ ,p.PAYER_NAME,p.payer_l_name,p2.PAYER_NAME as lc_name ,p2.payer_l_name as lc_L_Name,m.descr,m.Descr_eng,
            C.Currency_Name,ex.Main_Perform_no, ex.Perform_invoice,EX.Perform_invoice_date,br.branch_name,BR.WH_E_NAME
            from wh_inv_data As A inner join wh_material_transaction As B
            on a.Ser_no =b.SER_NO and a.Cyear=b.Cyear and a.Transaction_code=b.TRANSACTION_CODE and a.Branch_code=b.Branch_code
            inner join payer2 As P on a.Acc_no=p.ACC_NO and a.Acc_Branch_code=p.BRANCH_code
            left join (select * from payer2 )as p2 on p2.ACC_NO=a.LC_ACC_NO and a.Acc_Branch_code=p2.BRANCH_code
            inner join wh_main_master as M on M.item_no=b.ITEM_NO
            inner join Wh_Currency as C on C.Currency_Code=b.FORIN_TYPE
            inner join wh_inv_data_Ext as EX on a.Ser_no =EX.SER_NO and a.Cyear=EX.Cyear  and a.Branch_code=EX.Branch_code
            inner join wh_BRANCHES As BR on BR.Branch_code=a.Branch_code
            where a.SER_NO = '" + ser_+"' and a.Transaction_code = '"+transaction_+"' and a.Branch_code = '"+branch_+"' and a.Cyear = '"+cyear_+"'");
        }
    }
}
