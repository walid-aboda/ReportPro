using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;


namespace Report_Pro.RPT
{
    public partial class XtraForm1 : DevExpress.XtraEditors.XtraForm
    {
        public XtraForm1()
        {
            InitializeComponent();
        }

        private void buttonEdit1_EditValueChanged(object sender, EventArgs e)
        {
            Report.XtraReport1 rpt = new Report.XtraReport1();
          
            rpt.ShowPreviewDialog();


        }
                                      
        public static void print(object ds)
        {

            Report.XtraReport1 rpt = new Report.XtraReport1();
            rpt.DataSource = ds;
           // rpt.DetailReport.DataSource = rpt.DataSource;
            rpt.ShowPreviewDialog();

        }




    }
}