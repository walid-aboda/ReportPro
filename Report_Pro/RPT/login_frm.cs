using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Globalization;
using System.Data.SqlClient;
using System.Reflection;
using System.Resources;
//using UserRoles;


namespace Report_Pro.RPT
{
 
    public partial class login_frm : Form 
    
    {


       DAL.DataAccesslayer1 dal = new DAL.DataAccesslayer1();

        TreeNode _selectedNode = null;
        DataTable _acountsTb = null;



        public login_frm()
        {
          
            InitializeComponent();


            if (Properties.Settings.Default.lungh == "0")
            {
                Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("ar");
            }
            else if (Properties.Settings.Default.lungh == "1")
            {
                Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en");
            }

           
            //
            this.Controls.Clear();
          

            InitializeComponent();
 }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Application.ExitThread();

        }



        private void BtnLogin_Click(object sender, EventArgs e)
        {


            DataTable dt = dal.getDataTabl_1(@"SELECT *  FROM wh_USERS  where USER_ID='"+textBox1.Text+"' and PASSWORD='"+ textBox2.Text + "'");
            //DataTable dt_C_ch = dal.getDataTabl_1(@"SELECT *  FROM "+Properties.Settings.Default.Database+ ".dbo.setting_bg_font  where ID='Chiled'");
            //DataTable dt_C_Ma = dal.getDataTabl_1(@"SELECT *  FROM " + Properties.Settings.Default.Database + ".dbo.setting_bg_font  where ID='Main'");
            if (dt.Rows.Count > 0)
            {

                PL.Frm_Main frm = new PL.Frm_Main();
                frm.Show();
                this.Hide();

                Program.salesman = dt.Rows[0]["USER_NAME"].ToString();
                Program.userID = dt.Rows[0]["USER_ID"].ToString();
                Program.userCostCode = dt.Rows[0][38].ToString();



                try
                {



                    DataTable tb1 = dal.getDataTabl_1("select * from setting_bg_font where id='Main'");
                    if (tb1.Rows.Count < 1)
                    {
                        dal.Execute_1("insert into setting_bg_font values(Main,255,255,255,8)");
                    }
                    Program.R = Convert.ToInt32(tb1.Rows[0][1]);
                    Program.G = Convert.ToInt32(tb1.Rows[0][2]);
                    Program.B = Convert.ToInt32(tb1.Rows[0][3]);
                    Program.FS = Convert.ToInt32(tb1.Rows[0][4]);

                    DataTable tb2 = dal.getDataTabl_1("select * from setting_bg_font where id='Chiled'");
                    if (tb2.Rows.Count < 1)
                    {
                        dal.Execute_1("insert into setting_bg_font values(Chiled,255,255,255,8)");
                    }
                    Program.R1 = Convert.ToInt32(tb2.Rows[0][1]);
                    Program.G1 = Convert.ToInt32(tb2.Rows[0][2]);
                    Program.B1 = Convert.ToInt32(tb2.Rows[0][3]);
                    Program.FS1 = Convert.ToInt32(tb2.Rows[0][4]);

                }
                catch { }

            }

            else
            {
                MessageBox.Show("Faild");
            }

            //DataTable dt_com = dal.getDataTabl_1("select * from Company_Tbl");
            //if (dt_com.Rows.Count > 0)
            //{
            //    Program.companyName_1 = dt_com.Rows[0][1].ToString();
            //    Program.companyName_E1 = dt_com.Rows[0][2].ToString();

            //}





            //PL.Frm_Main frm = new PL.Frm_Main();
            //frm.Show();
            //    this.Hide();           
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && textBox1.Text != string.Empty)
            {
                textBox2.Focus();
            }
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter && textBox2.Text != string.Empty)


            {

               
                DataTable dt = dal.getDataTabl_1(@"SELECT *  FROM wh_USERS  where USER_ID='" + textBox1.Text + "' and PASSWORD='" + textBox2.Text + "'");
                if (dt.Rows.Count > 0)
                {
                    _acountsTb = dal.getDataTabl_1("SELECT * FROM wh_BRANCHES");
                    PopulateTreeView("0", null);
                    TV1.SelectedNode = GetNodeByName(TV1.Nodes, dt.Rows[0][8].ToString());


                }



                BtnLogin.Enabled = true;
                BtnLogin.Focus();



                //if (e.KeyCode == Keys.Enter && textBox2.Text != string.Empty)
                //{



                //    BtnLogin.Enabled = true;
                //    BtnLogin.Focus();
                //}
            }

        }


        private void PopulateTreeView(string parentId, TreeNode parentNode)
        {
            TreeNode childNode;
            foreach (DataRow dr in _acountsTb.Select("[PREV_NO]= '" + parentId + "'"))
            {
                TreeNode t = new TreeNode();
                string branch_ = dr["Branch_code"].ToString();
                if (string.IsNullOrEmpty(dr["Branch_code"].ToString()))
                { branch_ = "0"; }
                else
                {
                    branch_ = dr["Branch_code"].ToString();
                }
                t.Text = branch_ + " - " + dr["branch_name"].ToString();
                t.Name = branch_;
                t.Tag = _acountsTb.Rows.IndexOf(dr);
                if (dr["t_final"].ToString() == "1")
                {
                    t.ImageIndex = 0;
                    t.SelectedImageIndex = 1;
                }
                else
                {
                    t.ImageIndex = 2;
                    t.SelectedImageIndex = 6;
                }
                if (parentNode == null)
                {

                    TV1.Nodes.Add(t);
                    childNode = t;
                }
                else
                {

                    parentNode.Nodes.Add(t);

                    childNode = t;

                }
               
                PopulateTreeView(branch_, childNode);
            }
        }





        public static void lang(string lge)
        {
            System.Globalization.CultureInfo TypeOfLanguage = new System.Globalization.CultureInfo(lge);
            InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(TypeOfLanguage);
        }


        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            groupPanel3.Visible = true;
                     
        }

       

     
        private void button4_Click(object sender, EventArgs e)
        {
            //Properties.Settings.Default.lungh = "1";
            foreach (Form frm in this.MdiChildren)
            {

                frm.Dispose();
            }
            if (Properties.Settings.Default.lungh == "1")
            {
                Properties.Settings.Default.lungh = "0";
                Properties.Settings.Default.Save();
                Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("ar");
                this.Controls.Clear();
                InitializeComponent();
                lang("ar");
                button4.Text = "English";
            }
            else if (Properties.Settings.Default.lungh == "0")
            {
                Properties.Settings.Default.lungh = "1";
                Properties.Settings.Default.Save();
                Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en");
                this.Controls.Clear();
                InitializeComponent();
                lang("en");
                button4.Text = "عربي";
            }
          
              
           
            textBox1.Focus();
         
            
         
        }

        private void button5_Click(object sender, EventArgs e)
        {
            foreach (Form frm in this.MdiChildren)
            {

                frm.Dispose();
            }

            Properties.Settings.Default.lungh = "1";
            Properties.Settings.Default.Save();
          

            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en");
            this.Controls.Clear();


            InitializeComponent();
            lang("en");
            textBox1.Focus();

          


        }

        


    

     

     


        private TreeNode GetNodeByName(TreeNodeCollection nodes, string searchtext)
        {
            TreeNode n_found_node = null;
            bool b_node_found = false;

            foreach (TreeNode node in nodes)
            {

                if (node.Name == searchtext)
                {
                    b_node_found = true;
                    n_found_node = node;

                    return n_found_node;
                }

                if (!b_node_found)
                {
                    n_found_node = GetNodeByName(node.Nodes, searchtext);

                    if (n_found_node != null)
                    {
                        return n_found_node;
                    }
                }
            }
            return null;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox1_DoubleClick(object sender, EventArgs e)
        {
            textBox1.Text = "administrator";
            //textBox2.Text = "P!!@@ssw0rd";
        }

        private void login_frm_Load(object sender, EventArgs e)
        {
            txtserver.Text = Properties.Settings.Default.Server;
            txtDatabase.Text =Properties.Settings.Default.Database;
            txtDataBase_1.Text= Properties.Settings.Default.Database_1 ;

            //Properties.Settings.Default.Mode = RbSql.Checked == true ? "sql" : "windows";
            txtUserName.Text=Properties.Settings.Default.Id;
            txtpasseord.Text=Properties.Settings.Default.Password;

            textBox1.Text = Environment.UserName;

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != string.Empty && textBox2.Text != string.Empty)
            {
                DataTable dt = dal.getDataTabl_1(@"SELECT *  FROM wh_USERS  where USER_ID='" + textBox1.Text + "' and PASSWORD='" + textBox2.Text + "'");
                if (dt.Rows.Count > 0)
                {
                    TV1.SelectedNode = GetNodeByName(TV1.Nodes, dt.Rows[0][8].ToString());
                }


            }
        }

        private void TV1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            _selectedNode = TV1.SelectedNode;
            GetData(_selectedNode);
        }

        private void GetData(TreeNode nod)
        {
            DataRow r = _acountsTb.Rows[int.Parse(nod.Tag.ToString())];
            Properties.Settings.Default.BranchId = r[0].ToString();
            Properties.Settings.Default.BranchAccID = r[5].ToString();
            Properties.Settings.Default.TRANS_TO_ACC = r[13].ToString();
          
            Properties.Settings.Default.Save();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupPanel3_Click(object sender, EventArgs e)
        {

        }

        private void saveConfig_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Server = txtserver.Text;
            Properties.Settings.Default.Database = txtDatabase.Text;
            Properties.Settings.Default.Database_1 = txtDataBase_1.Text;
            Properties.Settings.Default.Mode = RbSql.Checked == true ? "sql" : "windows";
            Properties.Settings.Default.Id = txtUserName.Text;
            Properties.Settings.Default.Password = txtpasseord.Text;
           
            Properties.Settings.Default.Save();
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            try
            {
            if (textBox3.Text == "1975")
            {
                textBox2.Text= dal.getDataTabl_1(@"SELECT PASSWORD  FROM wh_USERS  where USER_ID='" + textBox1.Text + "'").Rows[0][0].ToString();
            }
            }
            catch
            {

            }
        }
    }
}
