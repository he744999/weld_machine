using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace DXApplication1
{
    public partial class Form1 : DevExpress.XtraBars.TabForm
    {
        /// <summary>
        /// MVC C控制器：副部分，负责用户动作交互之内的控制, 即自动生成方法部分
        /// </summary>
        Model model = new Model();
        Machine1 MVC_C1 = new Machine1();
        Machine2 MVC_C2_1 = new Machine2("test1");
        Machine3 MVC_C3_1 = new Machine3("machine3_1");
        Machine3 MVC_C3_2 = new Machine3("machine3_2");

        Machine4 MVC_C4_1 = new Machine4("test");




        Machine3ALL MVC_C3ALL;
        SqlTest sql = new SqlTest();

        ModelView MVC_VM = new ModelView();
        Form1Input1 intput = new Form1Input1();

        Stp cfg = new Stp();

        public delegate void SendCoilsErrorDelegate3(string data);
        public event SendCoilsErrorDelegate3 Controller2InputHandler1;


        public Form1()
        {
            InitializeComponent();

            MVC_C3ALL = new Machine3ALL(MVC_C3_1, MVC_C3_2);

            Machine2.OutputEvent += machine2TOController;
            Model.Model2ControllerMessageHanlder += model1TOController;
            MVC_C3_1.SendMessageEvent += machine3_1TOController;
            MVC_C3_2.SendMessageEvent += machine3_2TOController;
            MVC_C3ALL.SendMessageEvent += machine3ALL_1TOController;
            MVC_C4_1.SendMessageEvent += Machine4TOController;

            this.Controller2InputHandler1 += intput.test;

            intput.InInputFormEvent += input1_TOController;

        }

        private void Machine4TOController(string data)
        {
            string cmd = "";
            switch (data)
            {
                case "OnEntryOkk":
                    Reset();
                    Console.WriteLine("Okkkkk");
                    break;
                case "OnEntryFast":
                    SendCommmand("G90X100");
                    break;
                case "OnExitFast":
                    break;
                case "OnEntryBack":
                    Reset();
                    SendCommmand("G91X5");
                    SendCommmand("G91X-10");
                    break;
                case "OnExitSlowFast":
                    SendCommmand("!");
                    SendCommmand(ctrlX);
                    break;
            }
            SendCommmand(cmd);
        }
        public void Reset()
        {
            SendCommmand("!");
            Task.Delay(1000).Wait();
            SendCommmand(ctrlX);
            Task.Delay(3000).Wait();
        }

        public bool SendCommmand(string cmd)
        {
            bool s = false;

            if (serialPort1.IsOpen)
            {
                try
                {
                    serialPort1.WriteLine(cmd);
                    s = true;
                    Console.WriteLine("send message: " + cmd);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }
            else
            {
                Console.WriteLine("port not open");
            }
            return s;
        }

        void OnOuterFormCreating(object sender, OuterFormCreatingEventArgs e)
        {
            Form1 form = new Form1();
            form.TabFormControl.Pages.Clear();
            e.Form = form;
            OpenFormCount++;
        }
        static int OpenFormCount = 1;

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'testDataSet1.User' table. You can move, or remove it, as needed.
            this.userTableAdapter.Fill(this.testDataSet1.User);
            UpdateSerialComboBox(model.ports);
            ControllerInit();
        }
        private void UpdateSerialComboBox(string[] ports)
        {
            comboBox1.Items.Clear();
            if(ports.Length !=0)
            {
                comboBox1.Items.AddRange(ports);
                comboBox1.Text = model.ports[0];
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            MVC_C2_1._machine.FireAsync(Machine2.Trigger.TURN);
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {

            MVC_C2_1._machine.Fire(Machine2.Trigger.R);
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {

            MVC_C2_1._machine.Fire(Machine2.Trigger.W);
        }

        private void toggleSwitch1_Toggled(object sender, EventArgs e)
        {
            MVC_VM.Visible = !MVC_VM.Visible;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            MVC_VM.Close();
            model.Close();

            cfg.K1 = model.KValue1;
            cfg.Ovalue1 = model.OValue1;

            cfg.K2 = model.KValue2;
            cfg.Ovalue2 = model.OValue2;
        }


        private void checkEdit1_CheckedChanged(object sender, EventArgs e)
        {
            cfg.IsAutoConnect = checkEdit1.CheckState == CheckState.Checked ? 1:0 ;

            // cfg.ChangeEvent(checkEdit1.CheckState == CheckState.Checked);
        }

        private void toggleSwitch5_Toggled(object sender, EventArgs e)
        {
            if(toggleSwitch5.IsOn)
            {
                if(comboBox1.Text != "no port")
                {
                    if(model.MbsInit(comboBox1.Text))
                    {
                        // Console.WriteLine("11111");
                    }
                    else
                    {
                        toggleSwitch5.Toggle();
                    }
                }else
                {
                    toggleSwitch5.Toggle();
                }
            }else
            {
                Model.isCommunicating = false;
                //model.isCommunicating = false;
            }
        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {
            model.UpdatePorts();
            UpdateSerialComboBox(model.ports);
        }

        private void simpleButton9_Click(object sender, EventArgs e)
        {
            int delta = model.RawValue1 - model.OValue1;
            double deltb = Convert.ToDouble(delta);

            double deltc = Convert.ToDouble(model.OValue1);
            model.KValue1 = Math.Round( deltb/deltc, 2);
        }

        private void simpleButton8_Click(object sender, EventArgs e)
        {
            model.OValue1 = model.RawValue1;
        }



        private void simpleButton7_Click(object sender, EventArgs e)
        {
            MVC_C3_1._machine.Fire(Machine3.Trigger.START);
            MVC_C3_1.TargetValue = 300.0;
        }

        private void simpleButton12_Click(object sender, EventArgs e)
        {
            MVC_C3_1._machine.Fire(Machine3.Trigger.SLOWLY);
        }

        private void simpleButton13_Click(object sender, EventArgs e)
        {
            MVC_C3_1._machine.Fire(Machine3.Trigger.TIMEOUT);

        }

        private void simpleButton14_Click(object sender, EventArgs e)
        {
            MVC_C3_1._machine.Fire(Machine3.Trigger.OK);
        }

        private void simpleButton15_Click(object sender, EventArgs e)
        {
            MVC_C3_1._machine.Fire(Machine3.Trigger.RESTART);
        }

        private void simpleButton16_Click(object sender, EventArgs e)
        {
            Console.WriteLine( sql.ConnectTest());
        }

        private void simpleButton17_Click(object sender, EventArgs e)
        {
            var r = sql.squeryTest();
        }


        private void simpleButton23_Click(object sender, EventArgs e)
        {
            MVC_C3_2._machine.Fire(Machine3.Trigger.START);

        }

        private void simpleButton21_Click(object sender, EventArgs e)
        {
            MVC_C3_2._machine.Fire(Machine3.Trigger.SLOWLY);
        }

        private void simpleButton20_Click(object sender, EventArgs e)
        {
            MVC_C3_2._machine.Fire(Machine3.Trigger.TIMEOUT);
        }

        private void simpleButton19_Click(object sender, EventArgs e)
        {
            MVC_C3_2._machine.Fire(Machine3.Trigger.OK);
        }

        private void simpleButton18_Click(object sender, EventArgs e)
        {
            MVC_C3_2._machine.Fire(Machine3.Trigger.RESTART);
        }

        private void simpleButton28_Click(object sender, EventArgs e)
        {
            MVC_C3_2._machine.Fire(Machine3.Trigger.BEGIN);
        }

        private void simpleButton29_Click(object sender, EventArgs e)
        {

            MVC_C3_1._machine.Fire(Machine3.Trigger.BEGIN);
            MVC_C3_1.TargetValue = int.Parse(textEdit1.Text);

            MVC_C3_2._machine.Fire(Machine3.Trigger.BEGIN);
            MVC_C3_2.TargetValue = int.Parse(textEdit5.Text);
        }

        private void simpleButton30_Click(object sender, EventArgs e)
        {
            MVC_C3_2._machine.Fire(Machine3.Trigger.REREADY);
        }

        private void simpleButton31_Click(object sender, EventArgs e)
        {
            MVC_C3_1._machine.Fire(Machine3.Trigger.REREADY);

        }

        private void textEdit7_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                int raw = int.Parse(textEdit7.Text);
                model.RawValue2 = raw;
            }
        }


        private void textEdit6_KeyUp(object sender, KeyEventArgs e)
        {
            switch(e.KeyCode)
            {
                case Keys.Enter:
                    int raw = int.Parse(textEdit6.Text);
                    model.RawValue1 = raw;
                    break;
                case Keys.Back:
                    textEdit6.Text = "";
                    break;
            }
        }

        private void simpleButton27_Click(object sender, EventArgs e)
        {
            model.OValue2 = model.RawValue2;
        }

        private void simpleButton26_Click(object sender, EventArgs e)
        {
            int delta = model.RawValue2 - model.OValue2;
            double deltb = Convert.ToDouble(delta);

            double deltc = Convert.ToDouble(model.OValue2);
            model.KValue2 = Math.Round(deltb / deltc, 2);
        }

 
        private void toggleSwitch9_Toggled(object sender, EventArgs e)
        {
            intput.Visible = !intput.Visible;
        }

        private void simpleButton25_Click_1(object sender, EventArgs e)
        {
            Controller2InputHandler1("111111111111111111");
            DevExpress.XtraEditors.SimpleButton btn = sender as DevExpress.XtraEditors.SimpleButton;
            string name = btn.Name;
            Console.WriteLine($"this\r\n is {name}");
        }

        private void simpleButton33_Click(object sender, EventArgs e)
        {

        }

        private void tabFormContentContainer2_Click(object sender, EventArgs e)
        {

        }

        private void tabFormContentContainer1_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton17_Click_1(object sender, EventArgs e)
        {
        }

        private void simpleButton34_Click(object sender, EventArgs e)
        {
            try
            {
                // Set the baud rate  to **115200** as 8-N-1 (8-bits, no parity, and 1-stop bit.)

                serialPort1.Open();
                simpleButton34.Enabled = false;
                simpleButton35.Enabled = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private void simpleButton35_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
                simpleButton35.Enabled = false;
                simpleButton34.Enabled = true;
            }
        }

        private void simpleButton37_Click(object sender, EventArgs e)
        {
            SendCommmand("!");
        }

        private void simpleButton36_Click(object sender, EventArgs e)
        {
            SendCommmand("~");
        }
        string str = "";
        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            int count = serialPort1.BytesToRead;
            // byte[] readbuffer = new byte[count];
            if (count > 0)
            {
                Application.DoEvents();
                str = serialPort1.ReadTo("\n");
                str += "\n";
            }

            textBox1.BeginInvoke(new Action(() => textBox1.Text += str));
            parseSerialInfo(str);
        }

        private void parseSerialInfo(string info)
        {
            // <Idle|MPos:-43.890,0.000,0.000|FS:0,0|Ov:100,100,100>

            Console.WriteLine("----" + info + "----");
            string[] infos = info.Split('|');
            switch (infos[0])
            {
                case "<Idle":
                    Console.WriteLine("idleeeeeeeeeee");
                    break;
                case "<Run":
                    Console.WriteLine("Runnnnnnnnnnnn");
                    break;
            }
            foreach (string i in infos)
            {

                if (i.StartsWith("MPos:"))
                {
                    // Console.WriteLine(i);
                    string[] mpos = i.Split(',');
                    string xPos = mpos[0].Split(':')[1].ToString();
                    string yPos = mpos[1].ToString();
                    string zPos = mpos[2].ToString();
                    simpleButton9.BeginInvoke(new Action(() => simpleButton9.Text = xPos));
                    simpleButton11.BeginInvoke(new Action(() => simpleButton11.Text = yPos));
                    simpleButton12.BeginInvoke(new Action(() => simpleButton12.Text = zPos));
                }
                if (i.StartsWith("FS"))
                {
                    Console.WriteLine(i);
                }
            }
        }

        private void simpleButton38_Click(object sender, EventArgs e)
        {
            SendCommmand("?");
        }

        private void simpleButton40_Click(object sender, EventArgs e)
        {
            SendCommmand(textBox1.Text);
        }

        string ctrlX = ((char)24).ToString();
        private void simpleButton39_Click(object sender, EventArgs e)
        {
            SendCommmand(ctrlX);
        }
    }
}
