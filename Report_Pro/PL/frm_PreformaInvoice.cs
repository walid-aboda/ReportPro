using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing; using System.Linq;
using System.Globalization;

using System.Reflection;
using System.Resources;
using System.Text;
using System.Windows.Forms;

//using Syncfusion.Pdf;
//using Syncfusion.Pdf.Graphics;
//using Syncfusion.Pdf.Parsing;
//using Syncfusion.Pdf.Security;


namespace Report_Pro.PL
{
    public partial class frm_PreformaInvoice : Form
    {
        DAL.DataAccesslayer1 dal = new DAL.DataAccesslayer1();
       
        Assembly a = Assembly.Load("Report_Pro");
        CultureInfo cul;

     
        public frm_PreformaInvoice()
        {
            

            InitializeComponent();

            if (Properties.Settings.Default.lungh == "0")
            {
                cul = new CultureInfo("ar");
            }
            else
            {
                cul = new CultureInfo("en");
            }


            Currency.DataSource = dal.getDataTabl_1("SELECT * FROM " + dal.db1 + ".dbo.Wh_Currency");

            Currency.ValueMember = "Currency_Code";
            if (Properties.Settings.Default.lungh == "ar")
            {
                Currency.DisplayMember = "Currency_Name";
            }
            else
            {
                Currency.DisplayMember = "Currency_Name";

            }
            Currency.SelectedIndex = -1;

            txtRegion.DataSource = dal.getDataTabl_1("SELECT * FROM REGIONS");

            txtRegion.ValueMember = "REGION_code";
            if (Properties.Settings.Default.lungh == "0")
            {
                txtRegion.DisplayMember = "REGION_name";
            }
            else
            {
                txtRegion.DisplayMember = "REGION_E_NAME";

            }
            txtRegion.SelectedIndex = -1;


            txtArivePort.DataSource = dal.getDataTabl_1("SELECT * FROM Cus_Ports");

            txtArivePort.ValueMember = "Port_code";
            if (Properties.Settings.Default.lungh == "0")
            {
                txtArivePort.DisplayMember = "Port_name";
            }
            else
            {
                txtArivePort.DisplayMember = "Port_E_name";

            }
            txtArivePort.SelectedIndex = -1;
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
                    else if (control is DevComponents.Editors.DateTimeAdv.DateTimeInput)
                        (control as DevComponents.Editors.DateTimeAdv.DateTimeInput).Text = "";
                    else if (control is DataGridView)
                        (control as DataGridView).DataSource = null;



                    else
                        func(control.Controls);
            };

            func(Controls);
        }








        private void LcNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && LcNo.Text != string.Empty)
            {
                txtBank.ID.Focus();
            }
        }



        private void Currency_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && Currency.Text != string.Empty)
            {
                Amount.Focus();
            }

        }



        private void AcceptDays_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && AcceptDays.Text != string.Empty)
            {
                OpenDate.Focus();

            }
        }

        private void Amount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && Amount.Text != string.Empty)
            {
                AcceptDays.Focus();

            }
        }

        private void Amount_KeyPress(object sender, KeyPressEventArgs e)
        {
            char DecimalSeparator = Convert.ToChar(System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator);
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != DecimalSeparator)
            {
                e.Handled = true;
            }
        }

        private void AcceptDays_KeyPress(object sender, KeyPressEventArgs e)
        {
            char DecimalSeparator = Convert.ToChar(System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator);
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != DecimalSeparator)
            {
                e.Handled = true;
            }
        }

        private void OpenDate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                ExpiryDate.Focus();
            }
        }

        private void ExpiryDate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                LShipDate.Focus();
            }
        }




        private void BNew_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
            BSave.Enabled = true;
            BEdit.Enabled = false;
        }

       



        private void buttonX1_Click(object sender, EventArgs e)
        {

            Frm_uploadImage frmUpload = new Frm_uploadImage();
            frmUpload.p_id = this.LcNo.Text;
            frmUpload.ShowDialog();
        }

        private void frmLcs_Load(object sender, EventArgs e)
        {
            txtSupplier.txtMainAcc.Text = "2343";
            txtSupplier.txtFinal.Text = "1";
            txtBank.txtMainAcc.Text = "122";
            txtBank.txtFinal.Text = "1";
            txtLcAcc.txtMainAcc.Text = "125";
            txtLcAcc.txtFinal.Text = "1";

            txtBranch.txtTfinal.Text = "1";


            txtUnit.DataSource = dal.getDataTabl_1("select * from " + dal.db1 + ".dbo.wh_unit");
            txtUnit.DisplayMember = "Wh_Unit";
            txtUnit.ValueMember = "Wh_Unit";
            txtUnit.SelectedIndex = -1;

        }

     
        
        

      

        private void btnPrintIssueFees_Click(object sender, EventArgs e)
        {
            DataSet ds =new DataSet();
            RPT.lcOpenDocument rpt = new RPT.lcOpenDocument();
            RPT.Form1 frm = new RPT.Form1();
            rpt.SetDataSource(ds);
            frm.crystalReportViewer1.ReportSource = rpt;
            frm.ShowDialog();
            ds.WriteXmlSchema("schema1.xml");
        }

     

    
      

     

       

        private void txtSupplier_Load(object sender, EventArgs e)
        {

            DataTable dtSupp = dal.getDataTabl_1("select adress from payer2 where acc_no='"+txtSupplier.ID.Text+"'");
            if (dtSupp.Rows.Count > 0)
            {
                txtAddress.Text = dtSupp.Rows[0]["adress"].ToString();
            }
        }

     


        private void uC_Items1_Click(object sender, EventArgs e)
        {
            try
            {
                PL.frm_search_items frm = new PL.frm_search_items();
                frm.ShowDialog();
                uC_Items1.ID.Text = frm.dGV_pro_list.CurrentRow.Cells[0].Value.ToString();
                //get_balance();
            }
            catch { }
        }

        private void buttonItem2_Click(object sender, EventArgs e)
        {
            RPT.frm_statment_Rpt frm = new RPT.frm_statment_Rpt();
            frm.UC_Acc1.ID.Text = txtLcAcc.ID.Text;
            frm.ShowDialog();
        }

        private void btnAttachment_Click(object sender, EventArgs e)
        {
            Frm_uploadImage frmUpload = new Frm_uploadImage();
            frmUpload.p_id = this.LcNo.Text;
            frmUpload.ShowDialog();
        }

     
       

        private void uC_Items1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter && uC_Items1.ID.Text != string.Empty)
            {
                txtUnit.SelectedText = uC_Items1.itemUnit.Text;
                txtUnitWeight.Text = uC_Items1.itemWeight.Text;
                txtNote.Focus();
            }
        }

        private void txtNote_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter )
            {
                txtUnit.Focus();
            }
        }

        private void txtUnit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_Qty.Focus();
            }
        }

        private void txt_Qty_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txt_Qty.Value >0)
            {
                txt_Price.Focus();
            }
        }

        private void txt_Price_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txt_Price.Value > 0)
            {
               
            }
        }
    }
}
