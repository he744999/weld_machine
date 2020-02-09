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
        /// <summary>
        /// MVC controller 只能写控制
        /// </summary>
        Model MVC_M = new Model();
        ModelTemp MVC_MT = new ModelTemp();
        Machine2 MVC_C2 = new Machine2("light");
        Cfg cfg = new Cfg();

        ViewData Model_View_form = new ViewData();

        public Form1()
        {
            InitializeComponent();
        }
        private void BindEvent()
        {
            turn_sig.Text = "turn";
            turn_sig.CheckStateChanged += InputHandler;

            r_sig.Text = "r";
            r_sig.CheckStateChanged += InputHandler;

            w_sig.Text = "w";
            w_sig.CheckStateChanged += InputHandler;
        }

        private void InputHandler(object sender, EventArgs e)
        {
            CheckBox cb = sender as CheckBox;
            string text = cb.Text;
            switch (text)
            {
                case "turn":
                    MVC_C2._machine.Fire(Machine2.Trigger.turn);
                    break;
                case "r":
                    MVC_C2._machine.Fire(Machine2.Trigger.R);
                    break;
                case "w":
                    MVC_C2._machine.Fire(Machine2.Trigger.W);
                    break;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
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
            Machine2.OutputEvent += machine2tocontroller;
            timerUI.Start();
            timerScanInput.Start();

            ViewInit();
            BindEvent();
        }


        private void machine2tocontroller(string data)
        {
            switch (data)
            { 
                case "OnEntryOn":
                    Model.DOS[0][0] = true;
                    break;
                case "OnEntryOff":
                    Model.DOS[0][0] = false;
                    break;
                case "OnEntryread":
                    Model.DOS[0][1] = true;
                    break;
                case "OnExitread":
                    Model.DOS[0][1] = false;
                    break;
                case "OnEntrywrite":
                    Model.DOS[0][2] = true;
                    break;
                case "OnExitwrite":
                    Model.DOS[0][2] = false;
                    break;
            }
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

        private void xtraTabPage5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ribbonControl1_Click(object sender, EventArgs e)
        {

        }

        private void textEdit1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.textEdit1.Focus();
                MVC_MT.data_raw = int.Parse(textEdit1.Text);
                Console.WriteLine(MVC_MT.data_raw);
            }

        }

        private void xtraTabPage1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void simpleButton4_Click_1(object sender, EventArgs e)
        {
            Test2();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            MVC_MT.close();
        }

        private void simpleButton9_Click(object sender, EventArgs e)
        {
            DevExpress.XtraEditors.SimpleButton btn = sender as DevExpress.XtraEditors.SimpleButton;
            
            Console.WriteLine(btn.Name);
            Console.WriteLine(btn.Text);
        }

        private void checkEdit1_CheckedChanged_1(object sender, EventArgs e)
        {
            cfg.ChangeEvent(checkEdit1.CheckState == CheckState.Checked);
        }

        private void xtraTabPage4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void xtraTabPage3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
