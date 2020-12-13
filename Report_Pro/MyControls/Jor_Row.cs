using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing; using System.Linq;
using System.Data;

using System.Text;

using System.Windows.Forms;

namespace Report_Pro.MyControls
{
    public partial class Jor_Row : UserControl
    {
        DAL.DataAccesslayer1 dal = new DAL.DataAccesslayer1();
        public Jor_Row()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
            OnClick(e);
        }

        private void txtDebit_ValueChanged(object sender, EventArgs e)
        {
            OnLoad(e);
        }

        private void txtDebit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txtDebit.Value > 0)
            {
                txtAccNo.Focus();
            }
        }

        private void txtAccNo_TextChanged(object sender, EventArgs e)
        {
            get_desc();
        }

        private void get_desc()
        {
            try
            {
                DataTable dt_ = dal.getDataTabl_1("select PAYER_NAME from payer2 where ACC_NO= '" + txtAccNo.t.Text + "' and  BRANCH_code like '" + branchID.Text + "'+'%' and t_final like '1' ");
                if (dt_.Rows.Count > 0)
                {
                    txtAccDesc.Text = dt_.Rows[0][0].ToString();
                }
                else
                {

                    txtAccDesc.Text="";

                }
            }
            catch { }
        }

        private void txtAccNo_KeyDown(object sender, KeyEventArgs e)
        {
            if(txtAccNo.t.Text!= string.Empty && e.KeyCode==Keys.Enter)
            {
                txtCatID.t.Focus();
            }
        }

        private void txtAccDesc_Click(object sender, EventArgs e)
        {

        }

        private void Jor_Row_Load(object sender, EventArgs e)
        {

        }
    }

}
