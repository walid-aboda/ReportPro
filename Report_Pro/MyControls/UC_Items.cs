using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing; using System.Linq;
using System.Data;

using System.Text;
using System.Windows.Forms;

namespace Report_Pro.MyControls
{
    public partial class UC_Items : UserControl
    {
        DAL.DataAccesslayer1 dal = new DAL.DataAccesslayer1();
        public UC_Items()
        {
            InitializeComponent();
        }

        private void UC_Catogry_Load(object sender, EventArgs e)
        {

        }

        private void ID_KeyUp(object sender, KeyEventArgs e)
        {
            get_desc();
        }

        private void get_desc()
        {
            try
            {
                DataTable dt_ = dal.getDataTabl_1("SELECT item_no,descr,Descr_eng,isnull(Weight,0) as Weight,Unit,isnull(sale_price,0) as sale_price FROM wh_main_master where item_no = '" + ID.Text + "' or factory_no= '" + ID.Text + "' ");
                if (ID.Text!="" && dt_.Rows.Count > 0)
                {
                    ID.Text= dt_.Rows[0]["item_no"].ToString();
                    itemWeight.Value = Convert.ToDouble(dt_.Rows[0]["Weight"].ToString());
                    itemPrice.Value = Convert.ToDouble(dt_.Rows[0]["sale_price"].ToString());
                    itemUnit.Text = dt_.Rows[0]["Unit"].ToString();
                    if (Properties.Settings.Default.lungh == "0")
                    {
                        Desc.Text = dt_.Rows[0]["descr"].ToString();
                    }
                    else
                    {
                        Desc.Text = dt_.Rows[0]["Descr_eng"].ToString();
                    }
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
            OnClick(e);

        }

       
       

      

       
      

        private void ID_TextChanged(object sender, EventArgs e)
        {
            get_desc();
            OnLoad(e);

        }

     

       

        private void ID_KeyDown(object sender, KeyEventArgs e)
        {
            OnKeyDown(e);
        }

        private void Desc_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
