using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing; using System.Linq;
using System.Data;

using System.Text;
using System.Windows.Forms;

namespace Report_Pro.MyControls
{
    public partial class UC_Acc : UserControl
    {
        DAL.DataAccesslayer1 dal = new DAL.DataAccesslayer1();
        public UC_Acc()
        {
            InitializeComponent();
        }

       

        private void ID_TextChanged(object sender, EventArgs e)
        {
           
        
        }

        private void ID_KeyUp(object sender, KeyEventArgs e)
        {
            get_desc();
            OnKeyUp(e);
            

        }

        private void get_desc()
        {
            try
            {
                DataTable dt_ = dal.getDataTabl_1("select PAYER_NAME from payer2 where ACC_NO= '" + ID.Text + "'  and acc_no like '"+txtMainAcc.Text +"%' and BRANCH_code like '" + branchID.Text + "'+'%' and t_final like '"+txtFinal.Text+"%' ");
                if (dt_.Rows.Count > 0)
                {
                    Desc.Text = dt_.Rows[0][0].ToString();
                }
                else
                {

                    Desc.Clear();

                }
            }
            catch { }
        }
        
        private void btn1_Click(object sender, EventArgs e)
        {
            search_();

        }

        private void search_()
        {
            //try
            //{
                dgv1.Visible = true;
                this.Height = 150;
                this.BringToFront();
                dgv1.DataSource = dal.getDataTabl_1("select ACC_NO,PAYER_NAME from payer2 where (PAYER_NAME like '%" + Desc.Text + "%' or payer_l_name like '%" + Desc.Text + "%'  )and Acc_No like '" + txtMainAcc.Text+"%' and BRANCH_code like '" + branchID.Text + "'+'%'  and t_final like '" + txtFinal.Text + "%' ORDER BY acc_no ");
                dgv1.Columns[0].Width = 72;
            //}
            //catch { }

        }

        private void Desc_KeyUp(object sender, KeyEventArgs e)
        {
            search_();
        }

        private void ID_Enter(object sender, EventArgs e)
        {
            dgv1.Visible = false;
            this.Height = 23;
            this.SendToBack();
        }



        private void dgv1_DoubleClick(object sender, EventArgs e)
        {

            int ii = dgv1.CurrentCell.RowIndex;

            ID.Text = dgv1.Rows[ii].Cells[0].Value.ToString();
            Desc.Text = dgv1.Rows[ii].Cells[1].Value.ToString();

            dgv1.Visible = false;
            this.Height = 23;
            this.SendToBack();

        }

        private void dgv1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ID_TextChanged_1(object sender, EventArgs e)
        {
            get_desc();
            OnLoad(e);
            
        }

        private void UC_Acc_Leave(object sender, EventArgs e)
        {
            dgv1.Visible = false;
            this.Height = 23;
            this.SendToBack();

        }

        private void ID_Leave(object sender, EventArgs e)
        {
            try
            {
                DataTable dt_ = dal.getDataTabl_1("select PAYER_NAME from payer2 where ACC_NO= '" + ID.Text + "'  and acc_no like '" + txtMainAcc.Text + "%' and BRANCH_code like '" + branchID.Text + "'+'%' and t_final like '" + txtFinal.Text + "%' ");
                if (dt_.Rows.Count > 0)
                {
                    Desc.Text = dt_.Rows[0][0].ToString();
                }
                else
                {
                    ID.Clear();
                    Desc.Clear();

                }
            }
            catch { }
        }

        private void ID_KeyDown(object sender, KeyEventArgs e)
        {
            OnKeyDown(e);
        }
    }
}

