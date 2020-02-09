using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DXApplication4
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        /// <summary>
        /// MVC 只能写视角
        /// </summary>
        private void Test2()
        {
            Console.WriteLine("22222");
        }


        private void ViewInit()
        { 
            checkEdit1.CheckState = (cfg.ttt == 1)?CheckState.Checked:CheckState.Unchecked;
        }
        private void ShowInfo()
        { 
            
        }
        private void timerUI_Tick_1(object sender, EventArgs e)
        {
            labelControl5.BeginInvoke(new Action(() => { labelControl5.Text = MVC_C2._state.ToString(); }));
            labelControl9.BeginInvoke(new Action(() => { labelControl9.Text = MVC_MT.data_show.ToString(); }));
            labelControl10.BeginInvoke(new Action(() => { labelControl10.Text = MVC_MT.data_k.ToString(); }));
            labelControl12.BeginInvoke(new Action(() => { labelControl12.Text = MVC_MT.data_zero.ToString(); }));
        }

        private void timerUI_Tick(object sender, EventArgs e)
        {
            labelControl5.BeginInvoke(new Action(() => { labelControl5.Text = MVC_C2._state.ToString(); }));
        }
    }
}
