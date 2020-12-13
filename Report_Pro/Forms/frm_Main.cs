using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace Report_Pro.Forms
{
    public partial class frm_Main : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public frm_Main()
        {
            InitializeComponent();
        }

       public static void OpenFormByName(string name)
        {

            Form frm = null;


                var ins = Assembly.GetExecutingAssembly().GetTypes().FirstOrDefault(x => x.Name == name);
                    if (ins != null)
                    {
                        frm = Activator.CreateInstance(ins) as Form;
                        if (Application.OpenForms[frm.Name] != null)
                        {
                            frm = Application.OpenForms[frm.Name];
                   
                }
                else
                        {
                            //    frm.Show();
                        }

                        frm.BringToFront();

                    }
                 
            

            if (frm != null)
            {
                frm.Name = name;

                OpenForm(frm);
            }
        }


        public static void OpenForm(Form frm, bool OpenInDialog = false)
        {
           
            frm.Show();
                       
            return;
           
        }

        private void accordionControl1_ElementClick(object sender, DevExpress.XtraBars.Navigation.ElementClickEventArgs e)
        {

            var tag = e.Element.Tag as string;
            if (tag != string.Empty)
            {
                OpenFormByName(tag);
             
            }
          
        }

      
 

    }
}
