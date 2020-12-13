using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Windows.Forms;

namespace Report_Pro.PL
{
    public partial class frmLoan : Form
    {
        CultureInfo cul;
        Assembly a = Assembly.Load("Report_Pro");

        DAL.DataAccesslayer1 dal = new DAL.DataAccesslayer1();
        public frmLoan()
        {
            InitializeComponent();
        }

        private void BSave_Click(object sender, EventArgs e)
        {
            ResourceManager rm = new ResourceManager("Report_Pro.Lang.Langres", a);

            foreach (MyControls.LoanRow r in flowLayoutPanel1.Controls)
                    {

                        if (r.PayValue.Value > 0 && dal.IsDateTime(r.startDate.Text) && dal.IsDateTime(r.maturityDate.Text))
                        {
                            DataTable dt_ = dal.getDataTabl_1(@"select * from LoansTbl where id='" + txtLoanId.Text + "' and PaymentNo='" + r.paySer.Text + "' ");
                            if (dt_.Rows.Count > 0)
                            {
                               
                                dal.Execute_1(@"UPDATE LoansTbl set LoanNo='" + txtLoanNo.Text + "',BankId='" + BName.ID.Text + "',LoanACC='" + txtLoanAcc.ID.Text +
                                    "',NumberOfPayments='" + NoOfPayments.Value + "',LoanValue='" + txtLoanValue.Value + "',PaymentNo='" + r.paySer.Value +
                                    "', PaymentValue='" + r.PayValue.Value + "',StartDate='" + r.startDate.Value.ToString("yyyy-MM-dd") +
                                    "', MaturityDate='" + r.maturityDate.Value.ToString("yyyy-MM-dd") + "', Rate='" + r.intrestRate.Value +
                                    "',LoanPurpose='"+txtLoanPurpose.SelectedIndex+"',LoanRefrance='" + txtLoanRefrance.Text +
                                    "' where  id='" + txtLoanId.Text +"' and PaymentNo='" + r.paySer.Text + "' ");
                        MessageBox.Show(rm.GetString("msgEdit", cul), rm.GetString("msgEdit_H", cul), MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                            {
                               
                                dal.Execute_1(@"INSERT INTO LoansTbl(id,LoanNo,BankId,LoanACC,NumberOfPayments,LoanValue,PaymentNo,
                            PaymentValue,StartDate,MaturityDate,Rate,LoanPurpose,LoanRefrance)
                            VALUES(  '" + txtLoanId.Text + "', '" + txtLoanNo.Text + "','" + BName.ID.Text + "','" + txtLoanAcc.ID.Text + "','" + NoOfPayments.Value +
                                    "','" + txtLoanValue.Value + "','" + r.paySer.Value + "','" + r.PayValue.Value + "','" + r.startDate.Value.ToString("yyyy-MM-dd") +
                                    "','" + r.maturityDate.Value.ToString("yyyy-MM-dd") + "','" + r.intrestRate.Value + "','"+ txtLoanPurpose.SelectedIndex+"','" + txtLoanRefrance.Text + "')");
                        MessageBox.Show(rm.GetString("msgSave", cul), "تعديل ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
                    }

                    dal.Execute_1(@"delete from LoansTbl where id='" + txtLoanId.Text + "' and PaymentNo >'" + flowLayoutPanel1.Controls.Count + "' ");


                }

        private void txtLoanNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLoanValue_TextChanged(object sender, EventArgs e)
        {

        }

        private void addRows()
        {
            //try
            //{
            if ((NoOfPayments.Value - flowLayoutPanel1.Controls.Count) > 0)
            {
                for (int i = 1; i <= (NoOfPayments.Value - flowLayoutPanel1.Controls.Count); i++)
                {
                    MyControls.LoanRow r = new MyControls.LoanRow();
                    flowLayoutPanel1.Controls.Add(r);
                    r.paySer.Text = (flowLayoutPanel1.Controls.GetChildIndex(r) + 1).ToString();
                    r.intrestRate.Value = txtIntrestRate.Value;
                }
            }
            else if ((NoOfPayments.Value - flowLayoutPanel1.Controls.Count) < 0)
            {
                for (int i = 1; i <= (flowLayoutPanel1.Controls.Count - NoOfPayments.Value); i++)

                {
                    flowLayoutPanel1.Controls.RemoveAt(flowLayoutPanel1.Controls.Count - 1);
                }
            }
            //}
            //catch { }

        }

     
        private void NoOfPayments_ValueChanged(object sender, EventArgs e)
        {
            addRows();
        }

        private void frmLoan_Load(object sender, EventArgs e)
        {
            getLoanID();
            addRows();
        }

        private void getLoanID()
        {
            txtLoanId.Text = dal.GetCell_1("select isnull(MAX(id)+1,1) from LoansTbl").ToString();

        }

        private void txtLoanId_TextChanged(object sender, EventArgs e)
        {
            showLoanData(txtLoanId.Text.ParseInt(0));
        }

        private void showLoanData(int id_)
        {

           // string InvNum = lcNo_ + "-" + invNo_;
            DataTable loanData = dal.getDataTabl_1(@"SELECT *  FROM LoansTbl where id='" + id_ + "'");
            if (loanData.Rows.Count > 0)
            {
                txtLoanId.Text = loanData.Rows[0]["Id"].ToString();
                BName.ID.Text= loanData.Rows[0]["BankId"].ToString();
                txtLoanAcc.ID.Text = loanData.Rows[0]["LoanACC"].ToString();
                NoOfPayments.Text = loanData.Rows[0]["NumberOfPayments"].ToString();
                txtLoanNo.Text = loanData.Rows[0]["LoanNo"].ToString();
                txtIntrestRate.Text = loanData.Rows[0]["Rate"].ToString();
                txtLoanValue.Text = loanData.Rows[0]["LoanValue"].ToString();
                txtLoanPurpose.SelectedIndex= loanData.Rows[0]["LoanPurpose"].ToString().ParseInt(0);
                txtLoanRefrance.Text= loanData.Rows[0]["LoanRefrance"].ToString(); 
                int i = 0;
                flowLayoutPanel1.Controls.Clear();

                foreach (DataRow r in loanData.Rows)
                {


                    MyControls.LoanRow row = new MyControls.LoanRow();
                    row.paySer.Text = loanData.Rows[i]["PaymentNo"].ToString();
                    row.PayValue.Text = loanData.Rows[i]["PaymentValue"].ToString();
                    row.startDate.Text = loanData.Rows[i]["StartDate"].ToString();
                    row.maturityDate.Text = loanData.Rows[i]["MaturityDate"].ToString();
                    row.intrestRate.Text = loanData.Rows[i]["Rate"].ToString();

                    flowLayoutPanel1.Controls.Add(row);
                    i = i + 1;
                }
            }
        }

        private void BSearch_Click(object sender, EventArgs e)
        {
            PL.frmLoanSearch frm = new PL.frmLoanSearch();
            frm.ShowDialog();
            txtLoanId.Text = frm.DGV1.CurrentRow.Cells[0].Value.ToString();

        }
    }
}
