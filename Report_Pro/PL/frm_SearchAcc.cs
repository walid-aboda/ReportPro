using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing; using System.Linq;

using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;

namespace Report_Pro.PL
{
    public partial class frm_SearchAcc : Form
    {
        DAL.DataAccesslayer1 dal = new DAL.DataAccesslayer1();
        public frm_SearchAcc()
        {
            InitializeComponent();
            DGV1.DataSource = dal.getDataTabl("SearchAcc_", "A","A2319", txtsearchID.Text, txtSearchName.Text, (radioParent.Checked ? "" : "1"));
        }

        private void frm_SearchAcc_Load(object sender, EventArgs e)
        {

        }

        private void txtsearchID_TextChanged(object sender, EventArgs e)
        {
            DGV1.DataSource = dal.getDataTabl("SearchAcc_", "A", "A2319", txtsearchID.Text, txtSearchName.Text, (radioParent.Checked ? "" : "1"));
        }

        private void txtSearchName_TextChanged(object sender, EventArgs e)
        {
            DGV1.DataSource = dal.getDataTabl("SearchAcc_", "A", "A2319", txtsearchID.Text, txtSearchName.Text, (radioParent.Checked ? "" : "1"));

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DGV1.DataSource = dal.getDataTabl("SearchAcc_", "A", "A2319", txtsearchID.Text, txtSearchName.Text, (radioParent.Checked ? "" : "1"));

        }

        private void radioTransaction_CheckedChanged(object sender, EventArgs e)
        {
            DGV1.DataSource = dal.getDataTabl("SearchAcc_", "A", "A2319", txtsearchID.Text, txtSearchName.Text, (radioParent.Checked ? "" : "1"));

        }

        private void DGV1_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
