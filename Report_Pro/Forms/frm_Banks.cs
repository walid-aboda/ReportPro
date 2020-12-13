using DevExpress.CodeParser;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Report_Pro.Forms
{
    public partial class frm_Banks : frm_Master
    {
        DAL.BanksTbl bnk;
        DAL.DataAccesslayer1 dal = new DAL.DataAccesslayer1();

        public frm_Banks()
        {
            InitializeComponent();
            New();
        }

        public frm_Banks(int id)
        {
            InitializeComponent();
            LoadBank(id);
        }

        private void frm_Banks_Load(object sender, EventArgs e)
        {
           
                slkp_Acc.Properties.DataSource = dal.getDataTabl_1(@"select  x.ACC_NO,x.PAYER_NAME from(select p.Acc_no,P.PAYER_NAME ,ROW_NUMBER() OVER(PARTITION BY p.Acc_no ORDER BY p.acc_no) AS DuplicateCount 
                from payer2 as P where P.t_final=1 and P.ACC_NO like '1221%') as X where X.DuplicateCount=1");
                slkp_Acc.Properties.ValueMember = "ACC_NO";
                slkp_Acc.Properties.DisplayMember = "PAYER_NAME";


            slkp_LcAcc.Properties.DataSource = dal.getDataTabl_1(@"select  x.ACC_NO,x.PAYER_NAME from(select p.Acc_no,P.PAYER_NAME ,ROW_NUMBER() OVER(PARTITION BY p.Acc_no ORDER BY p.acc_no) AS DuplicateCount 
                from payer2 as P where P.t_final=0 and P.ACC_NO like '125%') as X where X.DuplicateCount=1");
            slkp_LcAcc.Properties.ValueMember = "ACC_NO";
            slkp_LcAcc.Properties.DisplayMember = "PAYER_NAME";

        }

        public override void Save()
        {
           
            if (txt_ID.Text.Trim() == string.Empty)
            {
                txt_Name.ErrorText = frm_Master.ErrorText;
                return;
            }
            if (txt_Name.Text.Trim() == string.Empty)
            {
                txt_Name.ErrorText = frm_Master.ErrorText;
                return;
            }
            var db = new DAL.dbDataContext();

           

            if (bnk.BID == 0)
            {
                
                db.BanksTbls.InsertOnSubmit(bnk);
              
            }
            else
            {
                db.BanksTbls.Attach(bnk);
              
            }


            SetData();
            db.SubmitChanges();


            base.Save();
        }


        public override void SetData()
        {
            bnk.BID = Convert.ToInt32(txt_ID.Text);
            bnk.BNameA = txt_Name.Text;
            bnk.BNameE = txt_NameE.Text;
            bnk.Acc_Details_A = txt_AccountName.Text;
            bnk.Acc_Details_E = txt_AccountNameE.Text;
            bnk.BAccNo = txt_AccountNumber.Text;
            bnk.BTel = txt_Telephone.Text;
            bnk.BFax = txt_Fax.Text;
            bnk.BEmail = txt_Email.Text;
            bnk.BAccept = spn_Acceptance.Value;
            bnk.Bfacelty =  spn_Facility.Value;
            bnk.Bmargin =spn_Margin.Value;
            bnk.BIban = txt_IBan.Text;
            bnk.Acc_No = slkp_Acc.EditValue.ToString();
            bnk.Loan_Rate = spn_IntrestRate.Value;
            bnk.BComnication = spn_Commnication.Value;
            bnk.mainLcAccNo = slkp_LcAcc.EditValue.ToString();
            base.SetData();
        }


       public override void GetData()
        {
            txt_ID.Text = bnk.BID.ToString();
            txt_Name.Text = bnk.BNameA;
            txt_NameE.Text = bnk.BNameE;
            txt_AccountName.Text = bnk.Acc_Details_A;
            txt_AccountNameE.Text = bnk.Acc_Details_E;
            txt_AccountNumber.Text = bnk.BAccNo;
            txt_Telephone.Text = bnk.BTel;
            txt_Fax.Text = bnk.BFax;
            txt_Email.Text = bnk.BEmail;
            spn_Acceptance.Text = bnk.BAccept.ToString().ToDecimal().ToString("N2");
            layoutControlItem15.Text = bnk.Bfacelty.ToString().ToDecimal().ToString("N2");
            spn_Margin.Text = bnk.Bmargin.ToString().ToDecimal().ToString("N2");
            txt_IBan.Text = bnk.BIban;
            slkp_Acc.EditValue = bnk.Acc_No;
            spn_IntrestRate.Text = bnk.Loan_Rate.ToString().ToDecimal().ToString("N2"); ;
            spn_Commnication.Text = bnk.BComnication.ToString().ToDecimal().ToString("N2");
            slkp_LcAcc.EditValue = bnk.mainLcAccNo;
            base.GetData();

        }

        public override void New()
        {
            bnk = new DAL.BanksTbl();
            base.New();
        }

        public override void Search()
        {
           frm_serchbanks frm = new frm_serchbanks();
            frm.ShowDialog();

            int id = 0;
            if (int.TryParse(frm.DGV1.CurrentRow.Cells[0].Value.ToString(), out id) && id > 0)
            {
                var db = new DAL.dbDataContext();
                bnk = db.BanksTbls.Where(b => b.BID == Convert.ToInt32(frm.DGV1.CurrentRow.Cells[0].Value)).First();
                GetData();
            }
            base.Search();
        }

        private void txt_ID_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Enter)
            //{
            //    using (var db = new DAL.dbDataContext())
            //    {
            //        bnk = db.BanksTbls.FirstOrDefault(x => x.BID == Convert.ToInt32(txt_ID.Text));
                   
            //    }
            //    GetData();
            //}
        }

        private void slkp_Acc_EditValueChanged(object sender, EventArgs e)
        {
            txt_AccID.Text = slkp_Acc.EditValue.ToString();
        }

        private void txt_AccID_KeyUp(object sender, KeyEventArgs e)
        {
            slkp_Acc.EditValue = txt_AccID.Text;
        }

        private void slkp_LcAcc_EditValueChanged(object sender, EventArgs e)
        {
            txt_LcAcc.Text = slkp_LcAcc.EditValue.ToString();
        }

        private void txt_LcAcc_KeyUp(object sender, KeyEventArgs e)
        {
            slkp_LcAcc.EditValue = txt_LcAcc.Text;
        }

        void LoadBank(int id)
        {
            using (var db = new DAL.dbDataContext())
            {
                bnk = db.BanksTbls.Single(x => x.BID == id);
            }
            GetData();
        }

        private void txt_Telephone_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}
