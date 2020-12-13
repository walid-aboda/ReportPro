using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing; using System.Linq;
using System.Data;

using System.Text;

using System.Windows.Forms;

namespace Report_Pro.MyControls
{
    public partial class jorDebit : UserControl
    {
        public jorDebit()
        {
            InitializeComponent();
        }
 
                private void UserControl2_Load(object sender, EventArgs e)
        {
           // populatList();
            foreach (Jor_Row ctl in flowLayoutPanel1.Controls)
            {
                ctl.ser_.Text = (flowLayoutPanel1.Controls.GetChildIndex(ctl) + 1).ToString();
                ctl.branchID.Text = Properties.Settings.Default.BranchAccID;
             }
            AddTextChangedHandler(this);

        }

        

       
       

       

     
     
        private void c_Load(object sender, EventArgs e)
        {
            gettotDb();
        }
        private void c_click(object sender, EventArgs e)
        {

            //var add = new Jor_Row();
            //flowLayoutPanel1.Controls.Add(add);
            //foreach (Jor_Row ctl in flowLayoutPanel1.Controls)
            //{
            //    ctl.ser_.Text = (flowLayoutPanel1.Controls.GetChildIndex(ctl) + 1).ToString();
            //}

            
            //gettotDb();
        }

        private void gettotDb()
        {
            double totDb = 0;
            foreach (Jor_Row c in flowLayoutPanel1.Controls)
            {

                totDb += c.txtDebit.Value;
                txtDebitTotal.Value = totDb;

            }
        }

        private void AddTextChangedHandler(Control parent)
        {
           
            foreach (Jor_Row c in flowLayoutPanel1.Controls)
            {
               
                    c.txtDebit.ValueChanged += new EventHandler(c_Load);
                c.Click+= new EventHandler(c_click);
            }
        }

      
    }
}
