using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing; using System.Linq;

using System.Text;
using System.Windows.Forms;

namespace Report_Pro.PL
{
   
    public partial class frm_check_item_Price : Form
    {
        DAL.DataAccesslayer1 dal = new DAL.DataAccesslayer1();
        DataTable dt_;
        DataTable dt_1 =  new DataTable();
        DataTable dt = new DataTable();
        DataTable dt_LP ;
        string db1 = Properties.Settings.Default.Database_1;
        public frm_check_item_Price()
        {
            InitializeComponent();
            creatDattable();
            creatDattable_LP();
            DGV_b.EnableHeadersVisualStyles = false;
            dgv_LP.EnableHeadersVisualStyles = false;
            resizeDG();
            resizeDG_LP();

        }

        void resizeDG()
        {
            DGV_b.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DGV_b.Columns[1].Width = 70;
        }

        void resizeDG_LP()
        {
            dgv_LP.Columns[0].Width = 50;
            dgv_LP.Columns[1].Width = 80;
            dgv_LP.Columns[2].Width = 80;
            dgv_LP.Columns[3].Width = 100;
            dgv_LP.Columns[4].Width = 100;
            dgv_LP.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
           
        }

        void creatDattable()
        {
            dt.Columns.Add("الفرع");
            dt.Columns.Add(" الرصيد");
            DGV_b.DataSource = dt;
            resizeDG();
          
        }

        void creatDattable_LP()
        {
            dt_1.Columns.Add("الرقم");
            dt_1.Columns.Add(" التاريخ");
            dt_1.Columns.Add(" الكمية");
            dt_1.Columns.Add(" سعر الحبة");
            dt_1.Columns.Add(" سعر الطن");
            dt_1.Columns.Add(" المورد");
            dgv_LP.DataSource = dt_1;
            resizeDG_LP();

        }


        void total_()
        {
           txtBalance.Text =
                (from DataGridViewRow row in DGV_b.Rows
                 where row.Cells[0].FormattedValue.ToString() != string.Empty
                 // select Convert.ToDouble(row.Cells[0].FormattedValue)).Sum().ToString();
                 select (row.Cells[1].FormattedValue).ToString().ToDecimal()).Sum().ToString();
           
        }
 
        private void labelX2_Click(object sender, EventArgs e)
        {

        }

        private void unit_price_KeyUp(object sender, KeyEventArgs e)
        {
            ton_price.Value = unit_price.Value / txtWeight.Value*1000;

            if (unit_price.Value > txtCost_1.Value)
            {
                piBox1.Image = global::Report_Pro.Properties.Resources.Ok_icon1;
            }
            else
            {
                piBox1.Image = global::Report_Pro.Properties.Resources.Cross_icon;

            }

        }

        private void ton_price_KeyUp(object sender, KeyEventArgs e)
        {
            unit_price.Value = ton_price.Value * txtWeight.Value / 1000;
            if (unit_price.Value > txtCost_1.Value)
            {
                piBox1.Image = global::Report_Pro.Properties.Resources.Ok_icon1;
            }
            else
            {
                piBox1.Image = global::Report_Pro.Properties.Resources.Cross_icon;

            }
        }

      

        private void mRrate_KeyUp_1(object sender, KeyEventArgs e)
        {
            txtCost_1.Value = txtCost.Value* (1 + mRrate.Value / 100);
            txtTonCost_1.Value = txtTonCost.Value* (1 + mRrate.Value / 100);
            if (unit_price.Value > txtCost_1.Value)
            {
                piBox1.Image = global::Report_Pro.Properties.Resources.Ok_icon1;
            }
            else
            {
                piBox1.Image = global::Report_Pro.Properties.Resources.Cross_icon;

            }
        }

        private void Uc_Items_Load(object sender, EventArgs e)
        {
           
                dt_ = dal.getDataTabl_1("SELECT *  FROM wh_main_master where item_no = '"+Uc_Items.ID.Text+"'");
                if (dt_.Rows.Count > 0)
                {
                    txtCost.Value = Convert.ToDouble(dt_.Rows[0][7].ToString());
                    txtLong.Value = Convert.ToDouble(dt_.Rows[0][19].ToString());
                    txtWeight.Value = Convert.ToDouble(dt_.Rows[0][20].ToString());
                    txtThickness.Value = Convert.ToDouble(dt_.Rows[0][21].ToString());
                    txtWeight.Value = Convert.ToDouble(dt_.Rows[0][22].ToString());
                    txtTonCost.Value = Convert.ToDouble(dt_.Rows[0][7].ToString()) / txtWeight.Value * 1000;
                    txtCost_1.Value = txtCost.Value * (1 + mRrate.Value / 100);
                    txtTonCost_1.Value = txtTonCost.Value * (1 + mRrate.Value / 100);
                    unit_price.Value = 0;
                    ton_price.Value = 0;

                }
                else
                {
                    txtCost.Value = 0;
                    txtLong.Value = 0;
                    txtWeight.Value = 0;
                    txtThickness.Value = 0;
                    txtWeight.Value = 0;
                    unit_price.Value = 0;
                    ton_price.Value = 0;
                    txtTonCost.Value = 0;


                }
                get_balance();
            get_last_Purch(Uc_Items.ID.Text);
          

        }

        private void get_balance()
        {

            DataTable dt_b = dal.getDataTabl_1(@"select * from ( SELECT  D.Branch_code,A.branch_name,sum(D.QTY_BALANCE) as balance
            FROM VIEW_balance As D inner join wh_BRANCHES As A on A.Branch_code = D.Branch_code
            where D.item_no = '"+Uc_Items.ID.Text+"' group by D.Branch_code, A.branch_name) as t where t.balance <> 0");

            dt.Clear();
            int i = 0;
            DataRow row = null;
            foreach (DataRow r in dt_b.Rows)
            {

                row = dt.NewRow();
                row[0] = dt_b.Rows[i][1].ToString();
                row[1] = Convert.ToDecimal(dt_b.Rows[i][2]).ToString("n" + 2);
                // row[9] = Convert.ToDecimal(dt_.Rows[i][70]).ToString("n" + dal.digits_);


                //row[8] = dt_.Rows[i][7];
                //row[9] = dt_.Rows[i][2];


                dt.Rows.Add(row);
                i = i + 1;
            }

            DGV_b.DataSource = dt;
            total_();


        }
        private void get_last_Purch(string item_no)
        {
            DataTable dt_LP = dal.getDataTabl_1(@"select top 1 A.ser_no,A.G_DATE,A.QTY_ADD,A.Local_Price,P.PAYER_NAME from wh_material_transaction as A
            inner join wh_inv_data as B on A.SER_NO=B.Ser_no and A.TRANSACTION_CODE=B.TRANSACTION_CODE and a.Branch_code=b.Branch_code and a.Cyear=b.Cyear
            inner join payer2 as P on p.ACC_NO=b.Acc_no and b.Acc_Branch_code=p.BRANCH_code
            where item_no='" + item_no + "' and (A.TRANSACTION_CODE='Xpc' or A.TRANSACTION_CODE='XpE') order by G_DATE desc");

            dt_1.Clear();
            int i = 0;
            DataRow row = null;
            foreach (DataRow r in dt_LP.Rows)
            {

                row = dt_1.NewRow();
                row[0] = dt_LP.Rows[i][0].ToString();
                row[1] =  DateTime.Parse(dt_LP.Rows[i][1].ToString()).ToShortDateString(); ;
                row[2] = Convert.ToDecimal(dt_LP.Rows[i][2]).ToString("n0");
                row[3] = Convert.ToDecimal(dt_LP.Rows[i][3]).ToString("n3");
                if (txtWeight.Value > 0)
                {
                    row[4] = Math.Round(dt_LP.Rows[i][3].ToString().ToDecimal() / txtWeight.Text.ToDecimal() * 1000, 0);
                }
                else
                {
                    row[4] = 0;
                }
                row[5] = dt_LP.Rows[i][4].ToString();
                // row[9] = Convert.ToDecimal(dt_.Rows[i][70]).ToString("n" + dal.digits_);


                //row[8] = dt_.Rows[i][7];
                //row[9] = dt_.Rows[i][2];


                dt_1.Rows.Add(row);
                i = i + 1;
            }

            dgv_LP.DataSource = dt_1;

        }


        private void Uc_Items_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {

                    dt_ = dal.getDataTabl_1("SELECT *  FROM wh_main_master where item_no = '"+ Uc_Items.ID.Text + "'");
                    if (dt_.Rows.Count > 0)
                    {
                        txtCost.Value = Convert.ToDouble(dt_.Rows[0][7].ToString());
                        txtLong.Value = Convert.ToDouble(dt_.Rows[0][19].ToString());
                        txtWeight.Value = Convert.ToDouble(dt_.Rows[0][20].ToString());
                        txtThickness.Value = Convert.ToDouble(dt_.Rows[0][21].ToString());
                        txtWeight.Value = Convert.ToDouble(dt_.Rows[0][22].ToString());
                        txtTonCost.Value = Convert.ToDouble(dt_.Rows[0][7].ToString()) / txtWeight.Value * 1000;
                        txtCost_1.Value = txtCost.Value * (1 + mRrate.Value / 100);
                        txtTonCost_1.Value = txtTonCost.Value * (1 + mRrate.Value / 100);
                        unit_price.Value = 0;
                        ton_price.Value = 0;
                        get_balance();
                    }
                    else
                    {
                        txtCost.Value = 0;
                        txtLong.Value = 0;
                        txtWeight.Value = 0;
                        txtThickness.Value = 0;
                        txtWeight.Value = 0;
                        unit_price.Value = 0;
                        ton_price.Value = 0;
                        txtTonCost.Value = 0;
                        PL.frm_search_items frm = new PL.frm_search_items();
                        frm.ShowDialog();
                        Uc_Items.ID.Text = frm.dGV_pro_list.CurrentRow.Cells[0].Value.ToString();
                        get_balance();
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Uc_Items_Click(object sender, EventArgs e)
        {
            try
            {
                PL.frm_search_items frm = new PL.frm_search_items();
                frm.ShowDialog();
                Uc_Items.ID.Text = frm.dGV_pro_list.CurrentRow.Cells[0].Value.ToString();
                get_balance();
            }
            catch { }
        }

        private void labelX16_Click(object sender, EventArgs e)
        {

        }

        private void labelX17_Click(object sender, EventArgs e)
        {

        }

        private void frm_check_item_Price_Load(object sender, EventArgs e)
        {

        }

        private void txtTonCost_1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
