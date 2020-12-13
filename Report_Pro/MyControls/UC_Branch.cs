using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing; using System.Linq;
using System.Data;

using System.Text;
using System.Windows.Forms;

namespace Report_Pro.MyControls
{
    public partial class UC_Branch : UserControl
    {
        DAL.DataAccesslayer1 dal = new DAL.DataAccesslayer1();
        public UC_Branch()
        {
            InitializeComponent();
        }

        private void UC_Branch_Load(object sender, EventArgs e)
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
                DataTable dt_ = dal.getDataTabl_1(@"select branch_name,WH_E_NAME,ACC_BRANCH from wh_BRANCHES  where T_final like '" + txtTfinal.Text+"%' and Branch_code='" + ID.Text + "' ");
                if (dt_.Rows.Count > 0)
                {
                    if (Properties.Settings.Default.lungh == "0")
                    {
                        Desc.Text = dt_.Rows[0]["branch_name"].ToString();
                    }
                    else
                    {
                        Desc.Text = dt_.Rows[0]["WH_E_NAME"].ToString();
                    }
                    txtAccBranch.Text= dt_.Rows[0]["ACC_BRANCH"].ToString();
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
            try
            {
                dgv1.Visible = true;
                this.Height = 150;
                this.BringToFront();
                if (Properties.Settings.Default.lungh == "0")
                {
                    dgv1.DataSource = dal.getDataTabl_1(@"select Branch_code,branch_name from  wh_BRANCHES where t_final like '"+txtTfinal.Text+"%' and branch_name like '%" + Desc.Text + "'+'%'  ");
                }
                else
                {
                    dgv1.DataSource = dal.getDataTabl_1(@"select Branch_code,WH_E_NAME from wh_BRANCHES where t_final like '" + txtTfinal.Text + "%' and WH_E_NAME like '%" + Desc.Text + "'+'%'  ");
                }
                    dgv1.Columns[0].Width = 72;
            }
            catch { }

        }

        private void Desc_KeyUp(object sender, KeyEventArgs e)
        {
           
            search_();
            //OnLoad(e);
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
            //Desc.Text = dgv1.Rows[ii].Cells[1].Value.ToString();
            get_desc();

            dgv1.Visible = false;
            this.Height = 23;
            this.SendToBack();

        }

        private void dgv1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgv1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ID_TextChanged(object sender, EventArgs e)
        {
            get_desc();
            OnLoad(e);

        }

        private void Desc_TextChanged(object sender, EventArgs e)
        {

        }

        private void UC_Branch_Leave(object sender, EventArgs e)
        {
            dgv1.Visible = false;
            this.Height = 23;
            this.SendToBack();
        }

        private void ID_Leave(object sender, EventArgs e)
        {
            try
            {
                DataTable dt_ = dal.getDataTabl_1(@"select branch_name,WH_E_NAME,ACC_BRANCH from wh_BRANCHES  where T_final like '" + txtTfinal.Text + "%' and Branch_code='" + ID.Text + "' ");
                if (dt_.Rows.Count > 0)
                {
                    if (Properties.Settings.Default.lungh == "0")
                    {
                        Desc.Text = dt_.Rows[0]["branch_name"].ToString();
                    }
                    else
                    {
                        Desc.Text = dt_.Rows[0]["WH_E_NAME"].ToString();
                    }
                    txtAccBranch.Text = dt_.Rows[0]["ACC_BRANCH"].ToString();
                }
                else
                {
                    ID.Clear();
                    Desc.Clear();

                }
            }

            catch { }


        }
    }
}
