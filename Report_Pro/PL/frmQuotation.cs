using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing; using System.Linq;
//using System.linq;

using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Collections.Specialized;
using CrystalDecisions.CrystalReports.Engine;
using Outlook = Microsoft.Office.Interop.Outlook;
using System.Data.SqlClient;

namespace Report_Pro.PL
{

    public partial class frmQuotation : Form
    {
        SqlConnection con = new SqlConnection(@"server=" + Properties.Settings.Default.Server + " ;database= " + Properties.Settings.Default.Database_1 + " ;integrated security=false; user id = " + Properties.Settings.Default.Id + "; password = " + Properties.Settings.Default.Password + "");
        string btntype = "0";
        string frmType = "ADD";
        DataTable dt_Q;
         Int32 m;
        string btn_name;
        DAL.DataAccesslayer1 dal = new DAL.DataAccesslayer1();
        DataTable dt = new DataTable();


        public frmQuotation()
        {

            InitializeComponent();


            comboBox1.DataSource = Enumerable.Range(1983, DateTime.Now.Year - 1983 + 1).ToList();
            comboBox1.SelectedItem = DateTime.Now.Year;

            Validty_Date.Value = txt_InvDate.Value.AddDays(ValidtyDays.Value);
            txtStore_ID.Text = Properties.Settings.Default.BranchId;
            txtBranchID.Text = Properties.Settings.Default.BranchAccID;
            AccType.Text = Properties.Settings.Default.TRANS_TO_ACC;
            txt_InvSM.Text = Program.salesman;
            userID.Text = Program.userID;
            Uc_cost.ID.Text = Program.userCostCode;

            PaymentType.DataSource = dal.getDataTabl_1("select * from wh_Payment_type");
            PaymentType.ValueMember = "Payment_type";
            PaymentType.DisplayMember = "Payment_name";
            PaymentType.SelectedIndex = -1;

            txt_Bank.DataSource = dal.getDataTabl_1("select * from BanksTbl");
            txt_Bank.ValueMember = "BID";
            txt_Bank.DisplayMember = "BNameA";
            txt_Bank.SelectedIndex = -1;

            PaymentTearms.DataSource = dal.getDataTabl_1("select * from Sal_Pyment_type");
            PaymentTearms.ValueMember = "Payment_type";
            PaymentTearms.DisplayMember = "Payment_name";
            PaymentTearms.SelectedIndex = -1;

            DelevryTearms.DataSource = dal.getDataTabl_1("select * from sales_delevry");
            DelevryTearms.ValueMember = "D_CODE";
            DelevryTearms.DisplayMember = "D_Name";
            DelevryTearms.SelectedIndex = -1;

            get_data();
            //Vat_acc_Desc.Text = Dt_3.Rows[0][1].ToString();
            creatDattable();
           resizeDG ();

            getSer();

        }


        private void get_data()
        {
            DataTable Dt_3 = dal.getDataTabl_1(@"SELECT B.K_M_ACC_NO_SALES , PAYER_NAME FROM wh_BRANCHES AS B right join payer2 AS P on B.K_M_ACC_NO_SALES=P.ACC_NO and B.ACC_BRANCH=P.BRANCH_code where p.BRANCH_code='" + txtStore_ID.Text + "'");
            VAT_Acc.Text = Dt_3.Rows[0][0].ToString();
            year_.Text = txt_InvDate.Value.ToString("yy");
        }


        private void حذفالسطرالحاليToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                dGV_Item.Rows.RemoveAt(dGV_Item.CurrentRow.Index);
            }
            catch
            {
                return;
            }
        }











        private void txtDiscount_KeyUp(object sender, KeyEventArgs e)
        {
            total_inv();
        }



        private void Payment_Type_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

      



        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void BNew_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
            btntype = "0";
            get_data();
            getSer();
            Uc_cost.ID.Text = Program.userCostCode;
            tabControlPanel1.Enabled = true;
            tabControlPanel2.Enabled = true;
            groupPanel7.Enabled = true;

            //txt_CustID.Clear();
            //txt_CustNm.Clear();
            //txt_custTel.Clear();
            //txt_CustEmail.Clear();
            //txt_InvNot.Clear();
            //AccSer_No.Clear();
            dt.Clear();
            dGV_Item.DataSource = null;
            dGV_Item.Refresh();
            dGV_Item.Rows.Clear();


            BSave.Enabled = true;
            txt_InvNot.Focus();

        }

        private void getSer()
        {
            string get_ser = @"select isnull(max(CO)+1,1) from wh_Serial where Branch_code='" + Properties.Settings.Default.BranchId
                     + "' and Cyear= '"+txt_InvDate.Value.ToString("yy")+"'";
            this.txt_InvNu.Text = dal.getDataTabl_1(get_ser).Rows[0][0].ToString();//.PadLeft(4, '0');
        }

        private void BSave_Click(object sender, EventArgs e)
        {
            

            try
            {

                if (dGV_Item.Rows.Count < 1)
                {
                    MessageBox.Show("فضلا.. تاكد من اختيار الاصناف", "تنبية !!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                if (PaymentType.SelectedIndex < 0)
                {
                    MessageBox.Show("فضلا.. تاكد من نوع الفاتورة", "تنبية !!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (Convert.ToDecimal(txtNetTotal.Text) <= 0)
                {
                    MessageBox.Show("لايمكن حفظ فاتورة بقيمة اقل من او يساوي صفر", "خطأ !!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }



                if (Convert.ToString(PaymentType.SelectedValue) == "11")
                {

                    if (cashCustomer.ID.Text.Replace(" ", string.Empty) == "")
                    {
                        MessageBox.Show("تأكد من اسم العميل النقدي", "خطأ !!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }


                }
                getSer();
               
                add_wh_Po_Cot_inv_data();
            
            }



            catch (System.Exception ex)
            {
               
                MessageBox.Show(ex.Message);
                return;

            }

        }



        private void add_wh_Po_Cot_inv_data()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            SqlTransaction trans;
            trans = con.BeginTransaction();
            cmd.Connection = con;
            cmd.Transaction = trans;
            try {
                cmd.CommandText = @"INSERT INTO wh_Po_Cot_inv_data (Ser_no, Branch_code, Transaction_code, Cyear,Sanad_no, G_date, ACC_TYPE,
            Acc_no, Acc_Branch_code, Payment_Type, Sales_man_Id, User_id, Cash_costomer_name,
            Costomer_adress, Costomer_Phone, Costmer_fax, Ref, E_mail, TermsOfPayment, Validity, DelevryE, PERM_SER,
            K_M_ACC_NO, K_M_Credit_TAX, COSTMER_K_M_NO, KM_CODE_ACC, MAIN_KM_CODE, Costomer_Notes, OPEN_VAT, VAT_RATIO)
            values('" + txt_InvNu.Text + "', '" + txtStore_ID.Text + "', '" + Doc_Type.Text + "', '" + txt_InvDate.Value.ToString("yy") +
                "', '" + 0 + "," + txt_InvDate.Value.ToString("yyyy-MM-dd HH: mm:ss") + "', '" + AccType.Text + "', '" + Uc_Acc.ID.Text + "', '" + txtBranchID.Text + "', '" + Convert.ToString(PaymentType.SelectedValue) +
                "', '" + Uc_cost.ID.Text + "',  '" + userID.Text + "', '" + cashCustomer.ID.Text +
                "', '" + txt_address.Text + "', '" + txt_custTel.Text + "', '" + txt_custFax.Text + "', '" + CustomerRef.Text + "', '" + txt_CustEmail.Text +
                "', '" + Convert.ToString(PaymentTearms.SelectedValue) + "', '" + ValidtyDays.Text + "', '" + Convert.ToString(DelevryTearms.SelectedValue) +
                "', '" + Convert.ToString(txt_Bank.SelectedValue) + "', '" + VAT_Acc.Text +
                "', '" + Net_Vat.Text + "', '" + Cust_Vat_No.Text + "', '" + txtKmCode.Text + "', '" + Vat_Class.Text + "', '" + txt_attn.Text + "', '" + 0 +
                "', '" + Cust_Vat_Rate.Text + "')";
                cmd.ExecuteNonQuery();
                for (int i = 0; i <= dGV_Item.Rows.Count - 1; i++)
                {
                    cmd.CommandText = @" INSERT INTO wh_Po_Cot_MATERIAL_TRANSACTION   (SER_NO, Branch_code, TRANSACTION_CODE, Cyear, ITEM_NO, QTY_TAKE,
                G_DATE, Unit, Local_Price, USER_ID, main_counter, balance, Backege, Pice_Total_Cost, DETAILS,
                TAX_OUT, K_M_TYPE_ITEMS)
                values ('" + txt_InvNu.Text + "', '" + txtStore_ID.Text + "', '" + Doc_Type.Text + "', '" + txt_InvDate.Value.ToString("yy") + "', '" + dGV_Item.Rows[i].Cells[0].Value +
                        "', '" + dGV_Item.Rows[i].Cells[5].Value + "', '" + txt_InvDate.Value.ToString("yyyy-MM-dd HH:mm:ss") +
                        "', '" + dGV_Item.Rows[i].Cells[3].Value + "', '" + dGV_Item.Rows[i].Cells[6].Value + "', '" + userID.Text +
                        "', '" + dGV_Item.Rows[i].Index + "', '" + dGV_Item.Rows[i].Cells[5].Value + "', '" + 1 + "', '" + dGV_Item.Rows[i].Cells[13].Value +
                        "', '" + dGV_Item.Rows[i].Cells[2].Value + "', '" + dGV_Item.Rows[i].Cells[10].Value + "', '" + dGV_Item.Rows[i].Cells[14].Value + "') ";
                    cmd.ExecuteNonQuery();
                }


                cmd.CommandText = @"Update wh_Serial set CO='" + txt_InvNu.Text + "'  where Branch_code='" + txtStore_ID.Text
                     + "' and Cyear= '" + txt_InvDate.Value.ToString("yy") + "' ";
                cmd.ExecuteNonQuery();
                MessageBox.Show("تم الحفظ بنجاح", "الحفظ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                trans.Commit();
               
            }
            catch (Exception ex) {
                trans.Rollback();
                MessageBox.Show(ex.Message);         
            }
            finally
            {
                con.Close();
            }
           
        }


        private void Update_wh_Po_Cot_inv_data()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            SqlTransaction trans;
            trans = con.BeginTransaction();
            cmd.Connection = con;
            cmd.Transaction = trans;
            try
            {
                //حذف الفاتورة القديمة
                cmd.CommandText = "delete from wh_Po_Cot_MATERIAL_TRANSACTION where SER_NO = '" + txt_InvNu.Text + "' and Branch_code = '" + txtStore_ID.Text +
                "' and TRANSACTION_CODE = '" + Doc_Type.Text + "' and Cyear = '" + txt_InvDate.Value.ToString("yy") + "'";
                cmd.ExecuteNonQuery();

                cmd.CommandText = "delete from wh_Po_Cot_inv_data where SER_NO = '" + txt_InvNu.Text + "' and Branch_code = '" + txtStore_ID.Text +
                "' and TRANSACTION_CODE = '" + Doc_Type.Text + "' and Cyear = '" + txt_InvDate.Value.ToString("yy") + "'";
                cmd.ExecuteNonQuery();
                //اضافة الفاتورة بعد التعديل
                cmd.CommandText = @"INSERT INTO wh_Po_Cot_inv_data (Ser_no, Branch_code, Transaction_code, Cyear,Sanad_no, G_date, ACC_TYPE,
                Acc_no, Acc_Branch_code, Payment_Type, Sales_man_Id, User_id, Cash_costomer_name,
                Costomer_adress, Costomer_Phone, Costmer_fax, Ref, E_mail, TermsOfPayment, Validity, DelevryE, PERM_SER,
                K_M_ACC_NO, K_M_Credit_TAX, COSTMER_K_M_NO, KM_CODE_ACC, MAIN_KM_CODE, Costomer_Notes, OPEN_VAT, VAT_RATIO)
                values('" + txt_InvNu.Text + "', '" + txtStore_ID.Text + "', '" + Doc_Type.Text + "', '" + txt_InvDate.Value.ToString("yy") +
                "', '" + 0 + "," + txt_InvDate.Value.ToString("yyyy-MM-dd HH: mm:ss") + "', '" + AccType.Text + "', '" + Uc_Acc.ID.Text + "', '" + txtBranchID.Text + "', '" + Convert.ToString(PaymentType.SelectedValue) +
                "', '" + Uc_cost.ID.Text + "',  '" + userID.Text + "', '" + cashCustomer.ID.Text +
                "', '" + txt_address.Text + "', '" + txt_custTel.Text + "', '" + txt_custFax.Text + "', '" + CustomerRef.Text + "', '" + txt_CustEmail.Text +
                "', '" + Convert.ToString(PaymentTearms.SelectedValue) + "', '" + ValidtyDays.Text + "', '" + Convert.ToString(DelevryTearms.SelectedValue) +
                "', '" + Convert.ToString(txt_Bank.SelectedValue) + "', '" + VAT_Acc.Text +
                "', '" + Net_Vat.Text + "', '" + Cust_Vat_No.Text + "', '" + txtKmCode.Text + "', '" + Vat_Class.Text + "', '" + txt_attn.Text + "', '" + 0 +
                "', '" + Cust_Vat_Rate.Text + "')";
                cmd.ExecuteNonQuery();

                for (int i = 0; i <= dGV_Item.Rows.Count - 1; i++)
                {
                cmd.CommandText = @" INSERT INTO wh_Po_Cot_MATERIAL_TRANSACTION   (SER_NO, Branch_code, TRANSACTION_CODE, Cyear, ITEM_NO, QTY_TAKE,
                G_DATE, Unit, Local_Price, USER_ID, main_counter, balance, Backege, Pice_Total_Cost, DETAILS,
                TAX_OUT, K_M_TYPE_ITEMS)
                values ('" + txt_InvNu.Text + "', '" + txtStore_ID.Text + "', '" + Doc_Type.Text + "', '" + txt_InvDate.Value.ToString("yy") + "', '" + dGV_Item.Rows[i].Cells[0].Value +
                "', '" + dGV_Item.Rows[i].Cells[5].Value + "', '" + txt_InvDate.Value.ToString("yyyy-MM-dd HH:mm:ss") +
                "', '" + dGV_Item.Rows[i].Cells[3].Value + "', '" + dGV_Item.Rows[i].Cells[6].Value + "', '" + userID.Text +
                "', '" + dGV_Item.Rows[i].Index + "', '" + dGV_Item.Rows[i].Cells[5].Value + "', '" + 1 + "', '" + dGV_Item.Rows[i].Cells[13].Value +
                "', '" + dGV_Item.Rows[i].Cells[2].Value + "', '" + dGV_Item.Rows[i].Cells[10].Value + "', '" + dGV_Item.Rows[i].Cells[14].Value + "') ";
                cmd.ExecuteNonQuery();
            }

                MessageBox.Show("تم التعديل بنجاح", "تعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);

                trans.Commit();

            }
            catch (Exception ex)
            {
                trans.Rollback();
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }



        private void buttonItem1_Click(object sender, EventArgs e)
        {
            string printModel = Properties.Settings.Default.inv_print;
            if (printModel == "1")
            {
                RPT.rpt_SalesQuotation rpt = new RPT.rpt_SalesQuotation();
                RPT.Form1 frm = new RPT.Form1();
                DataSet ds = new DataSet();
                getQuotation(txt_InvNu.Text, txtStore_ID.Text, Doc_Type.Text, txt_InvDate.Value.ToString("yy"));
                ds.Tables.Add(dt_Q);
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

            else

            {
                RPT.rpt_SalesQuotation rpt = new RPT.rpt_SalesQuotation();
                RPT.Form1 frm = new RPT.Form1();
                DataSet ds = new DataSet();
                getQuotation(txt_InvNu.Text, txtStore_ID.Text, Doc_Type.Text, txt_InvDate.Value.ToString("yy"));
                ds.Tables.Add(dt_Q);
                ds.WriteXmlSchema("schema_rpt.xml");
                rpt.SetDataSource(ds);
                rpt.DataDefinition.FormulaFields["decimal_"].Text = "'" + Properties.Settings.Default.digitNo_ + "'";
                rpt.DataDefinition.FormulaFields["Currency_"].Text = "'" + Properties.Settings.Default.Currency + "'";
                frm.crystalReportViewer1.ReportSource = rpt;
                frm.WindowState = FormWindowState.Maximized;
                frm.ShowDialog();
                ////reportInv.PrintOptions.PrinterName = Properties.Settings.Default.Invoice_P;
                ////reportInv.PrintToPrinter(1, false, 0, 15);
                //frm.crystalReportViewer1.ReportSource = rpt;
                //frm.WindowState = FormWindowState.Maximized;
                //frm.ShowDialog();
            }
        }


        private void BtnCalc_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc");
        }





        private void BExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }











        private void TxtDisc_KeyDown(object sender, KeyEventArgs e)
        {

        }



        void clculat_amount()
        {
            try
            {
                Txtvalue.Text = (Convert.ToDecimal(TxtQty.Text) * Convert.ToDecimal(TxtPrice.Text)).ToString("N" + dal.digits_);
            VatValue.Text = (Convert.ToDecimal(Txtvalue.Text) * Convert.ToDecimal(VatRate.Text)).ToString("N" + dal.digits_);
            totWeight.Text = (Convert.ToDecimal(TxtQty.Text) * Convert.ToDecimal(txtUnitWeight.Text)).ToString("N3");

            }
            catch
            {
                return;
            }
        }

        void addrow_new()
        {
            DataRow r = dt.NewRow();
            r[0] = TxtId.Text;
            r[1] = TxtDesc.Text;
            r[2] = txtNote.Text;
            r[3] = txtUnit.Text;
            r[4] = txtUnitWeight.Text;
            r[5] = TxtQty.Text;
            r[6] = Convert.ToDecimal(TxtPrice.Text).ToString("N" + dal.digits_);
            r[7] = Price_ton.Text;
            r[8] = Txtvalue.Text;
            r[9] = VatRate.Text;
            r[10] = VatValue.Text;
            r[11] = totWeight.Text;
            r[12] = txtBalance.Text;
            r[13] = txtCost.Text;
            r[14] = KM_TYPE_ITEMS.Text;


            dt.Rows.Add(r);
            dGV_Item.DataSource = dt;
            clear_texts();
            btn_braws.Focus();
            total_inv();
            resizeDG();
        }

        void editrow()
        {
            dGV_Item.Rows[m].Cells[0].Value = TxtId.Text;
            dGV_Item.Rows[m].Cells[1].Value = TxtDesc.Text;
            dGV_Item.Rows[m].Cells[2].Value = txtNote.Text;
            dGV_Item.Rows[m].Cells[3].Value = txtUnit.Text;
            dGV_Item.Rows[m].Cells[4].Value = txtUnitWeight.Text;
            dGV_Item.Rows[m].Cells[5].Value = TxtQty.Text;
            dGV_Item.Rows[m].Cells[6].Value = TxtPrice.Text.ToDecimal().ToString("N" + dal.digits_);
            dGV_Item.Rows[m].Cells[7].Value = Price_ton.Text;
            dGV_Item.Rows[m].Cells[8].Value = Txtvalue.Text;
            dGV_Item.Rows[m].Cells[9].Value = VatRate.Text;
            dGV_Item.Rows[m].Cells[10].Value = VatValue.Text;
            dGV_Item.Rows[m].Cells[11].Value = totWeight.Text;
            dGV_Item.Rows[m].Cells[12].Value = txtBalance.Text;
            dGV_Item.Rows[m].Cells[13].Value = txtCost.Text;
            dGV_Item.Rows[m].Cells[14].Value = KM_TYPE_ITEMS.Text;

            total_inv();
            clear_texts();
            btn_braws.Focus();
            resizeDG();

        }



        private void total_inv()
        {

            totalQty.Text =
               (from DataGridViewRow row in dGV_Item.Rows
                where row.Cells[5].FormattedValue.ToString() != string.Empty
                select Convert.ToDouble(row.Cells[5].FormattedValue)).Sum().ToString("n0");

            txtNetTotal.Text =
              (from DataGridViewRow row in dGV_Item.Rows
               where row.Cells[8].FormattedValue.ToString() != string.Empty
               select Convert.ToDouble(row.Cells[8].FormattedValue)).Sum().ToString("n"+dal.digits_);

          
            totalWeight.Text =
                (from DataGridViewRow row in dGV_Item.Rows
                 where row.Cells[11].FormattedValue.ToString() != string.Empty
                 select Convert.ToDouble(row.Cells[11].FormattedValue)).Sum().ToString("n" + dal.digits_);
          


           
            for (int i = 0; i <= dGV_Item.Rows.Count - 1; i++)
            {
                if (dGV_Item.Rows[i].Cells[0].Value != null && dGV_Item.Rows[i].Cells[5].Value.ToString().ToDecimal() > 0
                   && dGV_Item.Rows[i].Cells[5].Value.ToString().ToDecimal() > 0)
                {
                    if (dGV_Item.Rows[i].Cells[9].Value.ToString().ToDecimal() > Cust_Vat_Rate.Text.ToDecimal())
                    {
                        dGV_Item.Rows[i].Cells[10].Value = Math.Round((dGV_Item.Rows[i].Cells[8].Value.ToString().ToDecimal() * Cust_Vat_Rate.Text.ToDecimal()), 3);
                    }
                    else
                    {
                        dGV_Item.Rows[i].Cells[10].Value = Math.Round((dGV_Item.Rows[i].Cells[8].Value.ToString().ToDecimal() * dGV_Item.Rows[i].Cells[9].Value.ToString().ToDecimal()), 3);
                    }
                }
            }
            Net_Vat.Text =
                (from DataGridViewRow row in dGV_Item.Rows
                 where row.Cells[10].FormattedValue.ToString() != string.Empty
                 select Convert.ToDouble(row.Cells[10].FormattedValue)).Sum().ToString("N" + dal.digits_);

            NetValue.Text = (txtNetTotal.Text.ToDecimal() + Net_Vat.Text.ToDecimal()).ToString("N" + dal.digits_);

          
        }


        void clear_texts()
        {
            TxtId.Clear();
            TxtDesc.Clear();
            txtNote.Clear();
            txtUnit.Clear();
            TxtQty.Value = 0;
            TxtPrice.Value = 0;
            Price_ton.Value = 0;
            Txtvalue.Clear();
            VatRate.Clear();
            VatValue.Clear();
            txtBalance.Clear();
            txtCost.Clear();

        }

        void resizeDG()
        {

            this.dGV_Item.Columns[0].Width = this.TxtId.Width;
            this.dGV_Item.Columns[1].Width = this.TxtDesc.Width;
            this.dGV_Item.Columns[2].Width = this.txtNote.Width;
            this.dGV_Item.Columns[3].Width = this.txtUnit.Width;
            this.dGV_Item.Columns[4].Width = this.txtUnitWeight.Width;
            this.dGV_Item.Columns[5].Width = this.TxtQty.Width;
            this.dGV_Item.Columns[6].Width = this.TxtPrice.Width;
            this.dGV_Item.Columns[7].Width = this.Price_ton.Width;
            this.dGV_Item.Columns[8].Width = this.Txtvalue.Width;
            this.dGV_Item.Columns[9].Width = this.VatRate.Width;
            this.dGV_Item.Columns[10].Width = this.VatValue.Width;
            this.dGV_Item.Columns[11].Width = this.totWeight.Width;
            this.dGV_Item.Columns[12].Width = this.txtBalance.Width;
            this.dGV_Item.Columns[13].Width = this.txtCost.Width;
            this.dGV_Item.Columns[14].Visible = false;


        }

        void creatDattable()
        {
            dt.Columns.Add("رقم الصنف");
            dt.Columns.Add(" اسم الصنف");
            dt.Columns.Add(" الوصف");
            dt.Columns.Add("الوحدة");
            dt.Columns.Add("وزن الوحدة");
            dt.Columns.Add(" الكمية");
            dt.Columns.Add("السعر");
            dt.Columns.Add("سعر الطن");
            dt.Columns.Add("الصافي");
            dt.Columns.Add("نسبة الضريبة");
            dt.Columns.Add("مبلغ الضريبة");
            dt.Columns.Add("اجمالي الوزن");
            dt.Columns.Add("الرصيد");
            dt.Columns.Add("التكلفة");
            dt.Columns.Add("كود الضريبة");

            dGV_Item.DataSource = dt;
        }

        private void TxtQty_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && TxtQty.Value > 0)
            {

                TxtPrice.Focus();
            }
        }

        private void TxtQty_KeyUp(object sender, KeyEventArgs e)
        {
            clculat_amount();

        }

      

        private void TxtPrice_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtUnitWeight.Text.ToDecimal() > 0)
            {
                Price_ton.Text = ((TxtPrice.Text.ToDecimal() / txtUnitWeight.Text.ToDecimal()) * 1000).ToString("n0");
            }
            clculat_amount();
            
        }

        private void TxtDisc_KeyUp(object sender, KeyEventArgs e)
        {
           
            clculat_amount();
            
        }

        private void TxtPrice_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && TxtPrice.Text != string.Empty)
            {
               Price_ton.Focus();
            }

            if (e.KeyCode == Keys.F1)
            {
                //PL.list_H_price item_h_price = new PL.list_H_price();
                //item_h_price.dataGridView1.DataSource = dal.getDataTabl("item_H_prices_sales", TxtId.Text, txt_CustID.Text);
                //item_h_price.ShowDialog();


            }

            if (e.KeyCode == Keys.F2)
            {
               

                //PL.list_H_price item_h_price = new PL.list_H_price();
                //item_h_price.dataGridView1.DataSource = dal.getDataTabl("item_H_prices_sales", TxtId.Text,"%");
                //item_h_price.ShowDialog();



            }

        }

        private void TxtId_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter && TxtId.Text != "")
            {

                get_ItemData(TxtId.Text);

            }
        
    }

        private void get_ItemData(string item_No)
        {
            DataTable dt = dal.getDataTabl_1(@"SELECT item_no,factory_no,descr,Descr_eng,Weight,unit,
                BALANCE,local_cost,K.KM_RATIO,K.KM_Code
                FROM wh_main_master as A 
                inner join wh_Groups As B on A.group_code = B.group_code 
                left join KM_MATERIAL_CODE As K on  ISNULL(NULLIF(a.KM_CODE, ''), 1) = K.KM_CODE
                 where item_no = '" + item_No + "' or factory_no = '" + item_No + "'");
            if (dt.Rows.Count > 0)
            {
                TxtId.Text = dt.Rows[0][0].ToString();
                if (Properties.Settings.Default.lungh == "0")
                {
                    TxtDesc.Text = dt.Rows[0][2].ToString();
                }
                else
                {
                    TxtDesc.Text = dt.Rows[0][3].ToString();
                }
                txtUnitWeight.Text = dt.Rows[0][4].ToString().ToDecimal().ToString("N3");
                txtUnit.Text = dt.Rows[0][5].ToString();
                txtBalance.Text = dt.Rows[0][6].ToString().ToDecimal().ToString("N1");
                txtCost.Text = dt.Rows[0][7].ToString().ToDecimal().ToString("N3");
                VatRate.Text = dt.Rows[0][8].ToString().ToDecimal().ToString("N2");
                KM_TYPE_ITEMS.Text = dt.Rows[0][9].ToString();

                txtNote.Focus();


            }
            else
            {
                btn_braws.PerformClick();
            }
        }



        private void btn_braws_Click(object sender, EventArgs e)
        {
            try
            {
            clear_texts();
           
            PL.frm_search_items frm = new PL.frm_search_items();
            frm.ShowDialog();
                get_ItemData(frm.dGV_pro_list.CurrentRow.Cells[0].Value.ToString());
            }
            catch
            {
                return;
            }

        }

        private void dGV_Item_DoubleClick(object sender, EventArgs e)
        {

            btntype = "1";
            m = dGV_Item.CurrentRow.Index;
            try
            {
                TxtId.Text = dGV_Item.CurrentRow.Cells[0].Value.ToString();
                TxtDesc.Text = dGV_Item.CurrentRow.Cells[1].Value.ToString();
                txtNote.Text = dGV_Item.CurrentRow.Cells[2].Value.ToString();
                txtUnit.Text = dGV_Item.CurrentRow.Cells[3].Value.ToString();
                txtUnitWeight.Text = dGV_Item.CurrentRow.Cells[4].Value.ToString();
                TxtQty.Text = dGV_Item.CurrentRow.Cells[5].Value.ToString();
                TxtPrice.Text = dGV_Item.CurrentRow.Cells[6].Value.ToString();
                Price_ton.Text = dGV_Item.CurrentRow.Cells[7].Value.ToString();
                Txtvalue.Text = dGV_Item.CurrentRow.Cells[8].Value.ToString();
                VatRate.Text = dGV_Item.CurrentRow.Cells[9].Value.ToString();
                VatValue.Text = dGV_Item.CurrentRow.Cells[10].Value.ToString();
                totWeight.Text = dGV_Item.CurrentRow.Cells[11].Value.ToString();
                txtBalance.Text = dGV_Item.CurrentRow.Cells[12].Value.ToString();
                txtCost.Text = dGV_Item.CurrentRow.Cells[13].Value.ToString();
                KM_TYPE_ITEMS.Text = dGV_Item.CurrentRow.Cells[14].Value.ToString();

                TxtId.Focus();
            }
            catch
            {
                return;
            }
        }


        private void txtNote_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                TxtQty.Focus();
            }
        }

      
        private void ClearTextBoxes()
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Clear();
                    else if (control is ComboBox)
                        (control as ComboBox).SelectedIndex = -1;
                    else if (control is DateTimePicker)
                        (control as DateTimePicker).Value = DateTime.Now;
                    else if (control is DevComponents.Editors.DoubleInput)
                        (control as DevComponents.Editors.DoubleInput).Value = 0;

                    else
                        func(control.Controls);
            };

            func(Controls);
            // txtCoId.Text = Properties.Settings.Default.CoId;
            //BranchId.Text = Properties.Settings.Default.BranchId;
        }

      
        private void Btn_DelRow_Click(object sender, EventArgs e)
        {
            if (this.dGV_Item.SelectedRows.Count > 0)
            {
                dGV_Item.Rows.RemoveAt(this.dGV_Item.SelectedRows[0].Index);
                total_inv();
                foreach (DataGridViewRow row in this.dGV_Item.Rows)
                {
                    row.HeaderCell.Value = string.Format("{0}", row.Index + 1);
                }
            }
        }

        private void labelX6_Click(object sender, EventArgs e)
        {

        }

        private void txt_InvDate_ValueChanged(object sender, EventArgs e)
        {
             year_.Text = txt_InvDate.Value.ToString("yy");
        }

        private void txt_subTOt_TextChanged(object sender, EventArgs e)
        {

        }

        private void Uc_Acc_Load(object sender, EventArgs e)
        {

            DataTable dt_M = dal.getDataTabl_1(@"select Costmers_acc_no,Suppliers_acc_no,Cash_acc_no FROM wh_BRANCHES where BRANCH_code like '" + txtStore_ID.Text+ "%'");
            if (dt_M.Rows.Count > 0)
            {
                string Acc_main = dt_M.Rows[0][0].ToString();
                string Acc_cash = dt_M.Rows[0][2].ToString();
                DataTable dt_cust = dal.getDataTabl_1(@"select P.*,A.MAIN_KM_CODE,a.MAIN_KM_DESC,b.KM_RATIO,b.KM_CODE FROM payer2 As P left join KM_MAIN_ACC_CODE as A on  ISNULL(NULLIF(P.KM_CODE_Sales, ''), 11) = A.MAIN_KM_CODE
                left join  KM_ACC_CODE as b on b.KM_CODE = a.KM_CODE where P.BRANCH_code like '" + txtStore_ID.Text + "%' and P.ACC_NO = '" + Uc_Acc.ID.Text + "' and(P.ACC_NO like '" + Acc_main + "%' or P.ACC_NO like '" + Acc_cash + "%') and P.t_final ='1'");
                Uc_Acc.branchID.Text = Properties.Settings.Default.BranchId;
                if (dt_cust.Rows.Count > 0)
                {
                    if (Uc_Acc.ID.Text == Acc_cash)
                    {
                        cashCustomer.Enabled = true;
                        PaymentType.SelectedValue = "11";
                        PaymentType.Enabled = false;
                    }
                    else
                    {
                        cashCustomer.Enabled = false;
                        PaymentType.SelectedValue = "2";
                        PaymentType.Enabled = true;

                        txt_custTel.Text = dt_cust.Rows[0][14].ToString();
                        txt_address.Text = dt_cust.Rows[0][11].ToString();
                        txt_custFax.Text = dt_cust.Rows[0][16].ToString();
                        txt_CustEmail.Text = dt_cust.Rows[0][15].ToString();
                        txt_BoBox.Text = dt_cust.Rows[0][12].ToString();
                        txt_area_code.Text = dt_cust.Rows[0][19].ToString();
                        Cust_Vat_No.Text = dt_cust.Rows[0][60].ToString();
                        txt_attn.Text = dt_cust.Rows[0][22].ToString();
                        Vat_Class.Text = dt_cust.Rows[0][68].ToString();
                        Vat_Class_Desc.Text = dt_cust.Rows[0][69].ToString();
                        if (dt_cust.Rows[0][70].ToString() == string.Empty)
                        { Cust_Vat_Rate.Text = "0.05"; }
                        else
                        {
                            Cust_Vat_Rate.Text = dt_cust.Rows[0][70].ToString().ToDecimal().ToString("N2");
                        }
                        txtKmCode.Text = dt_cust.Rows[0][71].ToString();
                    }
                }
                else
                {
                    cashCustomer.Enabled = false;
                    txt_custTel.Clear();
                    txt_address.Clear();
                    txt_custFax.Clear();
                    txt_CustEmail.Clear();
                    txt_BoBox.Clear();
                    txt_area_code.Clear();
                    Cust_Vat_No.Clear();
                    txt_attn.Clear();
                    Vat_Class.Clear();
                    Vat_Class_Desc.Clear();
                    Cust_Vat_Rate.Clear();


                }
                total_inv();
            }
        }

        private void tabControl1_Click(object sender, EventArgs e)
        {

        }

        private void labelX47_Click(object sender, EventArgs e)
        {

        }

        private void Price_ton_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                clculat_amount();

                if (btntype == "0")
                {

                    if (TxtPrice.Value <= 0)
                    {
                        MessageBox.Show("تأكد من السعر", "تنبية !!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                    for (int i = 0; i <= dGV_Item.Rows.Count - 1; i++)
                    {
                        if (dGV_Item.Rows[i].Cells[0].Value.ToString() == TxtId.Text)
                        {
                            MessageBox.Show("هذا الصنف مضاف من قبل", "تنبية !!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return;
                        }
                    }

                    addrow_new();
                    btntype = "0";


                }
                else if (btntype == "1")
                {
                    editrow();
                    btntype = "0";

                }

            }
        }

        private void Price_ton_ValueChanged(object sender, EventArgs e)
        {
            }

        private void Price_ton_KeyUp(object sender, KeyEventArgs e)
        {
          
       
        }

        private void TxtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void Price_ton_KeyPress(object sender, KeyPressEventArgs e)
        {

            clculat_amount();
            TxtPrice.Text = ((Price_ton.Text.ToDecimal() * txtUnitWeight.Text.ToDecimal()) / 1000).ToString("n3");
        }

        private void TxtTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmInvoice_Load(object sender, EventArgs e)
        {

        }

        private void btnAddPayment_Click(object sender, EventArgs e)
        {
            PL.frmAddPaymentTearms frm = new frmAddPaymentTearms();
            frm.ShowDialog();
        }

        private void btnAddDelevery_Click(object sender, EventArgs e)
        {
            PL.frmAddSalesDelevry frm = new frmAddSalesDelevry();
            frm.ShowDialog();
        }

        private void txtStore_ID_Click(object sender, EventArgs e)
        {

        }

        private void tabControlPanel1_Click(object sender, EventArgs e)
        {

        }

        private void ValidtyDays_ValueChanged(object sender, EventArgs e)
        {
            Validty_Date.Value = txt_InvDate.Value.AddDays(ValidtyDays.Value);
        }

        private void labelX24_Click(object sender, EventArgs e)
        {

        }

        private void txt_InvSM_Click(object sender, EventArgs e)
        {

        }

        private void userID_Click(object sender, EventArgs e)
        {

        }

        private void labelX5_Click(object sender, EventArgs e)
        {

        }

        private void groupPanel6_Click(object sender, EventArgs e)
        {

        }

        private void BSearch_Click(object sender, EventArgs e)
        {
            groupPanel1.Visible = true;
            groupPanel1.BringToFront();
            txtSearch.Focus();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            
            frmType = "EDIT";
            getQuotation(txtSearch.Text, txtStore_ID.Text, Doc_Type.Text,comboBox1.Text.Substring(comboBox1.Text.Length-2));
            // DataTable dt_Q = dal.getDataTabl("Get_Po_Cot", txtSearch.Text, txtStore_ID.Text, Doc_Type.Text, txt_InvDate.Value.ToString("yy"),0,"");
            if (dt_Q.Rows.Count > 0)
            {
                txt_InvNu.Text = dt_Q.Rows[0][0].ToString();
                txt_InvDate.Text = dt_Q.Rows[0][6].ToString();
                Uc_Acc.ID.Text = dt_Q.Rows[0][8].ToString();
                PaymentType.SelectedValue = dt_Q.Rows[0][11].ToString();
                Uc_cost.ID.Text = dt_Q.Rows[0][12].ToString();
                txt_address.Text = dt_Q.Rows[0][24].ToString();
                txt_custTel.Text = dt_Q.Rows[0][25].ToString();
                txt_custFax.Text = dt_Q.Rows[0][26].ToString();
                CustomerRef.Text = dt_Q.Rows[0][27].ToString();
                txt_CustEmail.Text = dt_Q.Rows[0][30].ToString();
                PaymentTearms.SelectedValue = dt_Q.Rows[0][32].ToString();
                ValidtyDays.Value = Convert.ToInt32(dt_Q.Rows[0][33].ToString());
                DelevryTearms.SelectedValue = dt_Q.Rows[0][35].ToString();
                if (dt_Q.Rows[0][37] != DBNull.Value)
                {
                    txt_Bank.SelectedValue = Convert.ToInt32(dt_Q.Rows[0][37]);
                }
                else
                { txt_Bank.SelectedValue = 0; }
                VAT_Acc.Text = dt_Q.Rows[0][54].ToString();
                Net_Vat.Text = dt_Q.Rows[0][55].ToString();
                Cust_Vat_No.Text = dt_Q.Rows[0][57].ToString();
                txtKmCode.Text = dt_Q.Rows[0][59].ToString();
                Vat_Class.Text = dt_Q.Rows[0][60].ToString();
                txt_attn.Text = dt_Q.Rows[0][62].ToString();
                if (dt_Q.Rows[0][64].ToString() == string.Empty)
                { Cust_Vat_Rate.Text = "0.05"; }
                else
                {
                    Cust_Vat_Rate.Text = dt_Q.Rows[0][64].ToString().ToDecimal().ToString("N2");
                }
                Validty_Date.Value = txt_InvDate.Value.AddDays(ValidtyDays.Value);




                dt.Clear();
                int i = 0;
                DataRow row = null;
                foreach (DataRow r in dt_Q.Rows)
                {

                    row = dt.NewRow();
                    row[0] = dt_Q.Rows[i]["ITEM_NO"].ToString();
                    if (Properties.Settings.Default.lungh == "0")
                    {
                        row[1] = dt_Q.Rows[i]["descr"].ToString();
                    }
                    else
                    {
                        row[1] = dt_Q.Rows[i]["Descr_eng"].ToString();
                    }
                    row[2] = dt_Q.Rows[i]["DETAILS"].ToString();
                    row[3] = dt_Q.Rows[i]["Unit"].ToString();
                    row[4] = dt_Q.Rows[i]["Weight"].ToString();
                    row[5] = dt_Q.Rows[i]["QTY_TAKE"].ToString().ToDecimal().ToString("N2");
                    row[6] = dt_Q.Rows[i]["Local_Price"].ToString().ToDecimal().ToString("N" + dal.digits_);
                    row[7] = (dt_Q.Rows[i]["Local_Price"].ToString().ToDecimal() / dt_Q.Rows[i]["Weight"].ToString().ToDecimal() * 1000).ToString("N0");
                    row[8] = (dt_Q.Rows[i]["Local_Price"].ToString().ToDecimal() * dt_Q.Rows[i]["QTY_TAKE"].ToString().ToDecimal()).ToString("N" + dal.digits_); ;
                    row[9] = dt_Q.Rows[i]["KM_RATIO"].ToString().ToDecimal().ToString("N2");
                    row[10] = dt_Q.Rows[i]["TAX_OUT"].ToString().ToDecimal().ToString("N" + dal.digits_); ;
                    row[11] = (dt_Q.Rows[i]["QTY_TAKE"].ToString().ToDecimal() * dt_Q.Rows[i]["Weight"].ToString().ToDecimal()).ToString("n3");
                    row[12] = dt_Q.Rows[i]["BALANCE"].ToString().ToDecimal().ToString("N0");
                    row[13] = dt_Q.Rows[i]["Pice_Total_Cost"].ToString().ToDecimal().ToString("N" + dal.digits_);
                    row[14] = dt_Q.Rows[i]["K_M_TYPE_ITEMS"].ToString();
                    dt.Rows.Add(row);
                    i = i + 1;
                }
                dGV_Item.DataSource = dt;
                resizeDG();
                total_inv();
                txtSearch.Text = "";
                groupPanel1.Visible = false;
                BSave.Enabled = false;
                BEdit.Enabled = true;
            }
            else
            {
                MessageBox.Show("تاكد من الرقم", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Validty_Date_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if( e.KeyCode==Keys.Enter && txtSearch.Text != string.Empty)
            {
                btnOk.Focus();
            }
        }

        private void BtnEmail_Click(object sender, EventArgs e)
        {


            string printModel = Properties.Settings.Default.inv_print;
            if (printModel == "1")
            {
                RPT.rpt_SalesQuotation rpt = new RPT.rpt_SalesQuotation();
                DataSet ds = new DataSet();
                getQuotation(txt_InvNu.Text, txtStore_ID.Text, Doc_Type.Text, txt_InvDate.Value.ToString("yy"));
                ds.Tables.Add(dt_Q);
                ds.WriteXmlSchema("schema_rpt.xml");
                rpt.SetDataSource(ds);
                rpt.DataDefinition.FormulaFields["decimal_"].Text = "'" + Properties.Settings.Default.digitNo_ + "'";
                rpt.DataDefinition.FormulaFields["Currency_"].Text = "'" + Properties.Settings.Default.Currency + "'";

                rpt.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, (Application.StartupPath + "\\attachment.pdf"));
                Outlook.Application oApp = new Outlook.Application();
                Outlook.MailItem email = (Outlook.MailItem)(oApp.CreateItem(Outlook.OlItemType.olMailItem));



                //email.Sender = Application.Sea
                email.To = "";
                email.CC = Properties.Settings.Default.EmailCC;
                //email.Attachments.Add(Application.StartupPath + "\\attachment.pdf");
                email.Subject = "Quotation No. : " + this.txt_InvNu.Text;
                email.HTMLBody = ReadSignature();//here is where you add the signature...
                                              //so this line will read... mi.HTMLBody + ReadSignature(); Problem fixed!!
                email.Display(true);
                //email.Send();
              
            }
        }

    private void delete_wh_Po_Cot_MATERIAL_TRANSACTION()
        {
            dal.Execute_1("delete from wh_Po_Cot_MATERIAL_TRANSACTION where SER_NO = '" + txt_InvNu.Text + "' and Branch_code = '" + txtStore_ID.Text +
               "' and TRANSACTION_CODE = '" + Doc_Type.Text + "' and Cyear = '" + txt_InvDate.Value.ToString("yy") + "'");
        }

        private void BEdit_Click(object sender, EventArgs e)
        {

            try
            {

                if (dGV_Item.Rows.Count < 1)
                {
                    MessageBox.Show("فضلا.. تاكد من اختيار الاصناف", "تنبية !!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                if (PaymentType.SelectedIndex < 0)
                {
                    MessageBox.Show("فضلا.. تاكد من نوع الفاتورة", "تنبية !!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (txtNetTotal.Text.ToDecimal() <= 0)
                {
                    MessageBox.Show("لايمكن حفظ فاتورة بقيمة اقل من او يساوي صفر", "خطأ !!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }



                if (Convert.ToString(PaymentType.SelectedValue) == "11")
                {

                    if (cashCustomer.ID.Text.Replace(" ", string.Empty) == "")
                    {
                        MessageBox.Show("تأكد من اسم العميل النقدي", "خطأ !!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }


                }
                
                Update_wh_Po_Cot_inv_data();
                //delete_wh_Po_Cot_MATERIAL_TRANSACTION();
                //add_wh_Po_Cot_MATERIAL_TRANSACTION();
                //MessageBox.Show("تم التعديل بنجاح", "تعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {

            }
        }

        private void groupPanel1_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
               txtSearch.Clear();
            groupPanel1.Visible = false;
         
        }

        private void getQuotation(string ser_, string branch_, string transaction_, string cyear_)
        {
            try
            { //, ReportDB.dbo.Tafkeet('+@4+', '''+@5+''')  from wh_Po_Cot_inv_data As A
                dt_Q = dal.getDataTabl_1(@"select A.*,B.*,M.descr,M.Descr_eng,m.Weight,m.BALANCE ,K.KM_RATIO,x.PAYER_NAME,x.payer_l_name,SP.Payment_name,SP.Notes,
            DP.DeLEVRY_Name,DP.DELEVER_NAME_E,U.USER_NAME,BA.*
            from wh_Po_Cot_inv_data As A             
            Inner join wh_Po_Cot_MATERIAL_TRANSACTION As B
            on A.Ser_no = B.SER_NO and A.Branch_code = B.Branch_code AND A.Transaction_code = B.TRANSACTION_CODE AND A.Cyear = B.Cyear
            inner join wh_main_master AS M on M.item_no = B.ITEM_NO
            left join KM_MATERIAL_CODE As K on K.KM_CODE = ISNULL(NULLIF(M.KM_CODE, ''), 1)
            left join Sal_Pyment_type As SP on SP.Payment_type = A.termsOfPayment
            left join WH_PO_DELEVRY_CODE As DP on DP.DeLEVRY_CODE = A.DelevryE
            inner join wh_USERS As U on U.USER_ID = A.USER_ID
            left join BanksTbl AS BA on BA.BID = A.PERM_SER

            inner join(SELECT t1.Acc_no , t1.PREV_NO , t1.PAYER_NAME , t1.payer_l_name , t1.t_level , t1.t_final
            , t1.MAIN_NO , t1.MAIN_MEZAN , t1.BRANCH_code , t1.Acc_stoped , t1.Max_Sales_Am , t1.Credit_AGE , t1.BRANCH_name
            , t1.BRANCH_E_NAME , t1.med_MEZAN

            from
            (
            select
            p.*
            ,B.BRANCH_name
            ,B.BRANCH_E_NAME
	        ,ROW_NUMBER() OVER(PARTITION BY p.Acc_no ORDER BY p.acc_no) AS DuplicateCount
            FROM payer2 As P inner join BRANCHS As B on P.BRANCH_code = B.BRANCH_code )  as t1

            where
            DuplicateCount = 1) as X  on A.Acc_no = X.acc_no and A.Branch_code = X.Branch_code


            where A.Ser_no = '" + ser_ + "'  and A.Branch_code = '" + branch_ + "'  and A.transaction_code = '" + transaction_ + "'  and A.cyear = '" + cyear_ + "'");
            }
            catch (Exception ex){ MessageBox.Show(ex.Message); }
        }

        private void tabControlPanel2_Click(object sender, EventArgs e)
        {

        }

        private void txt_InvNu_TextChanged(object sender, EventArgs e)
        {

        }

        private void next__Click(object sender, EventArgs e)
        {

        }

        private void last__Click(object sender, EventArgs e)
        {

        }

        private void AccType_Click(object sender, EventArgs e)
        {

        }

        private void labelX1_Click(object sender, EventArgs e)
        {

        }

        private void txtNetTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void NetValue_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelX34_Click(object sender, EventArgs e)
        {

        }

        private void totalWeight_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelX32_Click(object sender, EventArgs e)
        {

        }

        private void Net_Vat_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelX22_Click(object sender, EventArgs e)
        {

        }

        private void labelX21_Click(object sender, EventArgs e)
        {

        }

        private void labelX35_Click(object sender, EventArgs e)
        {

        }

        private void BtnAttache_Click(object sender, EventArgs e)
        {
            try
            {
                Outlook.Application mailApp = new Outlook.Application();
                Outlook.NameSpace myNam = mailApp.GetNamespace("MAPI");

                myNam.Logon(null, null, true, true);


                Outlook.MAPIFolder ofold = myNam.GetDefaultFolder(Outlook.OlDefaultFolders.olFolderSentMail);
                Outlook._MailItem mi = (Outlook._MailItem)mailApp.CreateItem(Outlook.OlItemType.olMailItem);
                mi.To = "";
                mi.CC = "mohsabry81@hotmail.com";
                //mi.CC = emailcc.Text;
                //mi.CC = emailcc.Text;
                //mi.CC = emailcc.Text;
                //mi.CC = emailcc.Text;
                //mi.CC = emailcc.Text;
                //mi.CC = emailcc.Text;
                //mi.CC = emailcc.Text;
                mi.SentOnBehalfOfName = "mycompany.com";
                mi.Subject = "";
                mi.HTMLBody = ReadSignature();//here is where you add the signature...
                                              //so this line will read... mi.HTMLBody + ReadSignature(); Problem fixed!!
                mi.Display(true);
                mi.SaveSentMessageFolder = ofold;
                mi.Send();
            }
            catch { }
        }
        private string ReadSignature()

        {
            string appDataDir = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Microsoft\\Signatures";
            string signature = string.Empty;
            DirectoryInfo diInfo = new DirectoryInfo(appDataDir);
            if
            (diInfo.Exists)
            {
                FileInfo[] fiSignature = diInfo.GetFiles("*.*");

                if (fiSignature.Length > 0)
                {
                    StreamReader sr = new StreamReader(fiSignature[0].FullName, Encoding.Default);
                    signature = sr.ReadToEnd();
                    if (!string.IsNullOrEmpty(signature))
                    {
                        string fileName = fiSignature[0].Name.Replace(fiSignature[0].Extension, string.Empty);
                        signature = signature.Replace(fileName + "_files/", appDataDir + "/" + fileName + "_files/");
                    }
                }

            }
            return signature;
        }


    }
}


     