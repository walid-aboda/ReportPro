using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing; using System.Linq;

using System.Text;
using System.Windows.Forms;

namespace Report_Pro.PL
{
    public partial class frm_search_items : Form

    {
        DAL.DataAccesslayer1 dal = new DAL.DataAccesslayer1();
        public int clos_;
        public frm_search_items()
        {
            InitializeComponent();

            //search_product();
            
        }

        private void frm_search_items_Load(object sender, EventArgs e)
        {

        }

        private void search_product()
        {
            dGV_pro_list.DataSource = dal.getDataTabl("srch_product_", txtSrch.Text, txtsrch_1.Text, txtserch_2.Text, txtSrch_3.Text,txtserch_4.Text, (radiobalance.Checked ? "1" : "2"),dal.db1);
            resizeDG();
        }
        void resizeDG()
        {
            this.dGV_pro_list.Columns[0].Width = 100;
            this.dGV_pro_list.Columns[1].Width = 300;
            this.dGV_pro_list.Columns[2].Width = 300;
            this.dGV_pro_list.Columns[3].Width = 90;
            this.dGV_pro_list.Columns[4].Width = 90;
        }

        private void dGV_pro_list_DoubleClick(object sender, EventArgs e)
        {
            clos_ = 1;
            this.Close();
        }

        private void dGV_pro_list_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                this.Close();
            }
        }

        private void dGV_pro_list_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.Handled = true;
            }
        }

        private void btnSrch_Click(object sender, EventArgs e)
        {
            search_product();
        }

        private void txtSrch_3_KeyUp(object sender, KeyEventArgs e)
        {
            search_product();
        }

       

        private void txtSrch_3_TextChanged(object sender, EventArgs e)
        {
            search_product();

        }

        private void txtsrch_1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter && txtsrch_1.Text.Trim()!="")
            {
                txtserch_2.Focus();
            }
        }

        private void txtserch_2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter && txtserch_2.Text.Trim() != "")
            {
                txtSrch_3.Focus();
            }
        }

        private void txtSrch_3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter && txtSrch_3.Text.Trim() != "")
            {
                txtserch_4.Focus();
            }
        }

        private void txtserch_4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter && txtserch_4.Text.Trim() != "")
            {
                txtsrch_1.Focus();
            }

        }

        private void txtserch_4_TextChanged(object sender, EventArgs e)
        {
           search_product();
        }

        private void btnSrch_Click_1(object sender, EventArgs e)
        {
            search_product();
        }

        
      

        private void txtsrch_1_TextChanged(object sender, EventArgs e)
        {
            search_product();
        }

        private void txtSrch_TextChanged(object sender, EventArgs e)
        {
            search_product();
        }

        private void txtserch_2_TextChanged(object sender, EventArgs e)
        {
            search_product();
        }
    }
}
