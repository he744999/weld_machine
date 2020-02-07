using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DXApplication4
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        Model MVC_M = new Model();
        Machine2 MVC_C2 = new Machine2("light");
        Cfg cfg = new Cfg();

        XtraForm1 Model_View_form = new XtraForm1();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Model.SendMessageEvent += SerialUpdate;
            for (int i = 0; i < MVC_M.ports.Length; i++ )
            {
                comboBox1.Items.Add(MVC_M.ports[i]);
                if (i == MVC_M.ports.Length - 1)
                {
                    comboBox1.Text = MVC_M.ports[0];
                    simpleButton3.Enabled = false;
                }
            }
            Model.SendMessageEvent += SerialUpdate;
            checkEdit1.CheckState = (cfg.ttt == 1)?CheckState.Checked:CheckState.Unchecked;

            // 
            timerUI.Start();
            Machine2.OutputEvent += m2func;
        }

        private void m2func(string data)
        {
            Console.WriteLine(data);
        }

        private void SerialUpdate(bool data)
        {
            simpleButton2.BeginInvoke((Action)(() => {simpleButton2.Text = data.ToString();}));
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Test1");
        }



        private void buttonEdit2_CheckedChanged(object sender, EventArgs e)
        {
            // Model View窗口采用Visiable控制其可见性
            Model_View_form.showFrom(buttonEdit2.CheckState == CheckState.Checked);
        }







        private void simpleButton3_Click(object sender, EventArgs e)
        {
            MVC_M.MbsInit(comboBox1.Text);
            simpleButton3.Enabled = true;
            simpleButton333.Enabled = false;
        }

        private void toggleSwitch1_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch1.IsOn)
            {
                MVC_M.UpdatePorts();
                string info = MVC_M.GetPort();
                comboBox1.Text = info;
            }
            else
            {
                MVC_M.Close_Serial();
            }
        }

 

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            cfg.test();
        }

        private void checkEdit1_CheckedChanged(object sender, EventArgs e)
        {
            cfg.ChangeEvent(checkEdit1.CheckState == CheckState.Checked);
        }



        private void timerUI_Tick(object sender, EventArgs e)
        {
            labelControl5.BeginInvoke(new Action(() => { labelControl5.Text = MVC_C2._state.ToString(); }));
        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {
            MVC_C2._machine.Fire(Machine2.Trigger.turn);
        }




        private void simpleButton6_Click_1(object sender, EventArgs e)
        {
            MVC_C2._machine.Fire(Machine2.Trigger.turn);
        }

        private void simpleButton8_Click_1(object sender, EventArgs e)
        {
            MVC_C2._machine.Fire(Machine2.Trigger.R);

        }

        private void simpleButton7_Click_1(object sender, EventArgs e)
        {
            MVC_C2._machine.Fire(Machine2.Trigger.W);

        }

        private void timerUI_Tick_1(object sender, EventArgs e)
        {
            labelControl5.BeginInvoke(new Action(() => { labelControl5.Text = MVC_C2._state.ToString(); }));
        }

        private void xtraTabPage1_Paint_1(object sender, PaintEventArgs e)
        {

        }





    }
}
