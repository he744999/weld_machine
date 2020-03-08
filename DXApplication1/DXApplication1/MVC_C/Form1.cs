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
using NLog;

namespace DXApplication1
{
    public partial class Form1 : DevExpress.XtraBars.TabForm
    {
        /// <summary>
        /// MVC C控制器：副部分，负责用户动作交互之内的控制, 即自动生成方法部分
        /// </summary>
        ModelTemp modelTemp= new ModelTemp();


        Serial ser = new Serial();

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
            Serial.Model2ControllerMessageHanlder += model1TOController;

            MVC_C3_1.SendMessageEvent += machine3_1TOController;
            MVC_C3_2.SendMessageEvent += machine3_2TOController;
            MVC_C3ALL.SendMessageEvent += machine3ALL_1TOController;
            MVC_C4_1.SendMessageEvent += Machine4TOController;
            modelTemp.SendInputEvent += modelTemp2Controller;

            this.Controller2InputHandler1 += intput.test;

            intput.InInputFormEvent += input1_TOController;

        }



        private void Machine4TOController(string data)
        {
            switch (data)
            {
                case "OnEntryOkk":
                    Reset();
                    Console.WriteLine("Okkkkk");
                    break;
                case "OnEntryFast":
                    ser.StepperCmd("G90X100");
                    break;
                case "OnExitFast":
                    break;
                case "OnEntryBack":
                    Reset();
                    ser.StepperCmd("G91X-10");
                    ser.StepperCmd("G91X10");
                    break;
                case "OnExitSlowFast":
                    ser.StepperCmd("!");
                    ser.StepperCmd(ctrlX);
                    break;
            }
        }
        public void Reset()
        {
            ser.StepperCmd("!"); 
            Task.Delay(1000).Wait();
            ser.StepperCmd(ctrlX); 
            Task.Delay(3000).Wait();
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
            UpdateSerialComboBox(ser.ports);
            ControllerInit();
            f2 = new Form2(cfg, modelTemp);
        }
        private void UpdateSerialComboBox(string[] ports)
        {
            comboBox1.Items.Clear();
            comboBox2.Items.Clear();
            if(ports.Length !=0)
            {
                // modbus串口选择下拉框
                comboBox1.Items.AddRange(ports);
                comboBox1.Text = ser.ports[0];

                // 步进电机串口选择下拉框 
                comboBox2.Items.AddRange(ports);
                comboBox2.Text = ser.ports[0];
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
     

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            MVC_VM.Close();
            ser.Close();

            cfg.K1 = modelTemp.KValue1;
            cfg.Ovalue1 = modelTemp.OValue1;

            cfg.K2 = modelTemp.KValue2;
            cfg.Ovalue2 = modelTemp.OValue2;
        }


        private void checkEdit1_CheckedChanged(object sender, EventArgs e)
        {
            cfg.IsAutoConnectStepper = checkEdit1.CheckState == CheckState.Checked ? 1:0 ;

            // cfg.ChangeEvent(checkEdit1.CheckState == CheckState.Checked);
        }

        private void toggleSwitch5_Toggled(object sender, EventArgs e)
        {
            if(toggleSwitch5.IsOn)
            {
                if(comboBox1.Text != "no port")
                {
                    if(ser.MbsInit(comboBox1.Text))
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
                Serial.isCommunicatingMdb = false;

            }
        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {
            ser.UpdatePorts();
            UpdateSerialComboBox(ser.ports);
        }

        private void simpleButton9_Click(object sender, EventArgs e)
        {
            float delta = modelTemp.RawValue1 - modelTemp.OValue1;
            modelTemp.KValue1 = delta/ modelTemp.OValue1;
        }

        private void simpleButton8_Click(object sender, EventArgs e)
        {
            modelTemp.OValue1 = modelTemp.RawValue1;
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


        private void simpleButton27_Click(object sender, EventArgs e)
        {
            modelTemp.OValue2 = modelTemp.RawValue2;
        }

        private void simpleButton26_Click(object sender, EventArgs e)
        {
            float delta = modelTemp.RawValue2 - modelTemp.OValue2;
            modelTemp.KValue2 = delta / modelTemp.OValue2;
        }

 
        private void toggleSwitch9_Toggled(object sender, EventArgs e)
        {
            intput.Visible = !intput.Visible;
        }


        Logger logF = LogManager.GetLogger("fileLogger");
        Logger logC = LogManager.GetLogger("fileConsole");

        private void simpleButton25_Click_1(object sender, EventArgs e)
        {
            logF.Info("111111111111111");
            logC.Info("1111111111");
        }


  
        private void simpleButton37_Click(object sender, EventArgs e)
        {
            ser.StepperCmd("!");
        }

        private void simpleButton36_Click(object sender, EventArgs e)
        {
            ser.StepperCmd("~");
        }
        private void simpleButton38_Click(object sender, EventArgs e)
        {
            ser.StepperCmd("?");
        }

        private void simpleButton40_Click(object sender, EventArgs e)
        {
            ser.StepperCmd(textBox1.Text);
        }

        string ctrlX = ((char)24).ToString();
        private void simpleButton39_Click(object sender, EventArgs e)
        {
            ser.StepperCmd(ctrlX);
        }


        private void toggleSwitch10_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch10.IsOn)
            {
                if (comboBox2.Text != "no port")
                {
                    if (ser.StepperInit(comboBox2.Text))
                    {
                        Console.WriteLine("stepper serial init sucess...");
                    }
                    else
                    {
                        Console.WriteLine("stepper serial init faild...");
                        toggleSwitch10.Toggle();
                    }
                }
                else
                {
                    toggleSwitch10.Toggle();
                }
            }
            else
            {
                Serial.isCommunicatingMdb = false;

            }
        }


        private void simpleButton17_Click_1(object sender, EventArgs e)
        {
            MVC_C4_1._machine.Fire(Machine4.Trigger.START);
        }

        private void simpleButton34_Click(object sender, EventArgs e)
        {
            MVC_C4_1._machine.Fire(Machine4.Trigger.TOGGLE);
        }

        private void simpleButton35_Click(object sender, EventArgs e)
        {
            MVC_C4_1._machine.Fire(Machine4.Trigger.REREADY);
        }

        private void simpleButton42_Click(object sender, EventArgs e)
        {

            Console.WriteLine(modelTemp.KValue1);
            Console.WriteLine(modelTemp.KValue2);
            Console.WriteLine(modelTemp.OValue1);
            Console.WriteLine(modelTemp.OValue2);
        }


        private void simpleButton24_DoubleClick(object sender, EventArgs e)
        {
          
        }

        private void simpleButton24_Click(object sender, EventArgs e)
        {

        }
        Form2 f2;
        private void simpleButton5_DoubleClick(object sender, EventArgs e)
        {
            f2.ShowDialog();
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {

        }

        private void toggleSwitch1_Toggled_1(object sender, EventArgs e)
        {
            MVC_VM.Visible = !MVC_VM.Visible;
        }
    }
}

