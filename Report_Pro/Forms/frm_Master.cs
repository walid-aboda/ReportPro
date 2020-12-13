using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Report_Pro.Forms
{
    public partial class frm_Master : XtraForm
    {
        bool IsNew;
        public static string ErrorText
        {
            get
            {

                return "هذا الحقل مطلوب";
            }
        }
        public frm_Master()
        {
            InitializeComponent();
           
        }

        private void frm_Master_Load(object sender, EventArgs e)
        {
        
        }
        public virtual void Save()
        {
            XtraMessageBox.Show("تم الحفظ بنجاح");
            RefreshData();
            IsNew = false;
        }
        public virtual void New()
        {
            GetData();
        }
        public virtual void Delete()
        {

        }

        public virtual void Search()
        {

        }
        public virtual void Print()
        {

        }

        public virtual void GetData()
        {

        }

        public virtual void SetData()
        {

        }

        public virtual void RefreshData()
        {

        }


        private void btn_Save_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Save();
        }

        private void btn_New_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            New();

        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Delete();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Print();
        }


        private void frm_Master_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                Save();
            }
            if (e.KeyCode == Keys.F2)
            {
                New();
            }
            if (e.KeyCode == Keys.F3)
            {
                Delete();
            }
            if (e.KeyCode == Keys.F4)
            {
                Print();
            }
        }

        private void btn_Search_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Search();
        }

    }
}
