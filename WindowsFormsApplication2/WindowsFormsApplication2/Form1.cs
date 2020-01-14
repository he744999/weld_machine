using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        Model MVC_M;
        Machine MVC_C0;

        public Form1()
        {
            
            InitializeComponent();
            MVC_C0 = new Machine("weld");
            
            MVC_M = new Model();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Text = "DDDD";
            timer_ui_update.Start();
            timerBlink.Start();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Model.DOS[0] = new bool[] {false, false, false, false };
            Model.DOS[1] = new bool[] {false, false, false, false };
            this.MVC_M.CloseOutput(MVC_M.state);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string port = "COM" +  textBox1.Text.ToString();
            if (this.MVC_M.MbsInit(port))
            {
                button2.Enabled = false;
            }
        }
        // Model -> View
        private void timer_ui_update_Tick(object sender, EventArgs e)
        {
            X0.Text = Model.DIS[0][0].ToString();
            X1.Text = Model.DIS[0][1].ToString();
            X2.Text = Model.DIS[0][2].ToString();
            X3.Text = Model.DIS[0][3].ToString();

            X10.Text = Model.DIS[1][0].ToString();
            X11.Text = Model.DIS[1][1].ToString();
            X12.Text = Model.DIS[1][2].ToString();
            X13.Text = Model.DIS[1][3].ToString();

            Y0.Text = Model.DOS[0][0].ToString();
            Y1.Text = Model.DOS[0][1].ToString();
            Y2.Text = Model.DOS[0][2].ToString();
            Y3.Text = Model.DOS[0][3].ToString();

            Y10.Text = Model.DOS[1][0].ToString();
            Y11.Text = Model.DOS[1][1].ToString();
            Y12.Text = Model.DOS[1][2].ToString();
            Y13.Text = Model.DOS[1][3].ToString();

            AX0.Text = Model.AIS[0][0].ToString();
            AX1.Text = Model.AIS[0][1].ToString();
            AX2.Text = Model.AIS[0][2].ToString();
            AX3.Text = Model.AIS[0][3].ToString();
            AX4.Text = Model.AIS[0][4].ToString();
            AX5.Text = Model.AIS[0][5].ToString();
            AX6.Text = Model.AIS[0][6].ToString();
            AX7.Text = Model.AIS[0][7].ToString();
            lab_state.Text = MVC_C0._state.ToString();

        }
        // View -> Model 
        private void Y_CheckStateChanged(object sender, EventArgs e)
        {
            string SenderName = ((CheckBox)sender).Name;
            switch (SenderName)
            {
                case "Y0":{ Model.DOS[0][0] = Y0.CheckState == CheckState.Checked ? true : false;break;}
                case "Y1":{ Model.DOS[0][1] = Y1.CheckState == CheckState.Checked ? true : false;break;}
                case "Y2":{ Model.DOS[0][2] = Y2.CheckState == CheckState.Checked ? true : false;break;}
                case "Y3":{ Model.DOS[0][3] = Y3.CheckState == CheckState.Checked ? true : false;break;}

                case "Y10":{ Model.DOS[1][0] = Y10.CheckState == CheckState.Checked ? true : false;break;}
                case "Y11":{ Model.DOS[1][1] = Y11.CheckState == CheckState.Checked ? true : false;break;}
                case "Y12":{ Model.DOS[1][2] = Y12.CheckState == CheckState.Checked ? true : false;break;}
                case "Y13":{ Model.DOS[1][3] = Y13.CheckState == CheckState.Checked ? true : false;break;}

            
            }
            Console.WriteLine(SenderName);
        }

        private void timerBlink_Tick(object sender, EventArgs e)
        {
            MVC_C0._machine.Fire(Machine.Trigger.tick);

        }

    }
}
