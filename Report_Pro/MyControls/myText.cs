using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing; using System.Linq;
using System.Data;

using System.Text;
using System.Windows.Forms;

namespace Report_Pro.MyControls
{
    public partial class myText : UserControl
    {
        public myText()
        {
            InitializeComponent();


          
        }

       
        public override Color BackColor
        {
            get
            {
                return t.BackColor;
            }
            set
            {
                t.BackColor = value;
            }
            }
        private void textBoxX1_TextChanged(object sender, EventArgs e)
        {

        }
        


        private void t_TextChanged(object sender, EventArgs e)
        {
            OnLoad(e);
        }

        private void t_KeyDown(object sender, KeyEventArgs e)
        {
            OnKeyDown(e);
        }
    }
}
