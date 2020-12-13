// Decompiled with JetBrains decompiler
// Type: Report_Pro.PL.frmDelivryNote
// Assembly: Report_Pro, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 39327453-3C78-42DC-8027-AE7037A66322
// Assembly location: C:\Users\Walid\Desktop\Report_Pro.exe

using Report_Pro.MyControls;
using System;
using System.ComponentModel;
using System.Drawing; using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.Layout;

namespace Report_Pro.PL
{
  public partial class frmDelivryNote : Form
  {
    

        public frmDelivryNote()
        { 
            InitializeComponent(); 
        
        }


    private void delivryRow1_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode != Keys.Return)
        return;
      delivryRow delivryRow = new delivryRow();
      this.flowLayoutPanel1.Controls.Add((Control) new delivryRow());
    }

    private void frmDelivryNote_Load(object sender, EventArgs e) { this.flowLayoutPanel1.Controls.Add((Control)this.r); }

    private void flowLayoutPanel1_ControlAdded(object sender, ControlEventArgs e)
    {
    }

    private void frmDelivryNote_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode != Keys.Return)
        ;
      foreach (Control control in (ArrangedElementCollection) this.flowLayoutPanel1.Controls)
      {
        if (this.flowLayoutPanel1.Controls.GetChildIndex(control) == this.flowLayoutPanel1.Controls.Count - 1)
          this.flowLayoutPanel1.Controls.Add((Control) new delivryRow());
      }
    }

    private void flowLayoutPanel1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
    {
    }

    private void flowLayoutPanel1_PreviewKeyDown_1(object sender, PreviewKeyDownEventArgs e)
    {
    }

   
  
    }
}
