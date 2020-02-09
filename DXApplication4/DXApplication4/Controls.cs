using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace DXApplication4
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {

        CheckBox turn_sig = new CheckBox();
        CheckBox r_sig    = new CheckBox();
        CheckBox w_sig = new CheckBox();
        public void test()
        {

        }

        private void timerScanInput_Tick(object sender, EventArgs e)
        {
            turn_sig.CheckState = Model.DIS[0][0] == true ? CheckState.Checked : CheckState.Unchecked;
            r_sig.CheckState = Model.DIS[0][1] == true ? CheckState.Checked : CheckState.Unchecked;
            w_sig.CheckState = Model.DIS[0][2] == true ? CheckState.Checked : CheckState.Unchecked;
        }
    }
}
