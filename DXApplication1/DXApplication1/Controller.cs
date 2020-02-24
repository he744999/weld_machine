using System;
using System.Windows.Forms;
using System.Data;

namespace DXApplication1
{
    public partial class Form1 : DevExpress.XtraBars.TabForm
    {
        /// <summary>
        /// MVC C控制器：主部分，负责用户动作交互之外的控制
        /// </summary>

        public CheckBox turn_sig = new CheckBox();
        CheckBox w_sig = new CheckBox();
        CheckBox r_sig = new CheckBox();
        CheckBox h_sig = new CheckBox();

        string guid;
        public void ControllerInit()
        {
            guid = System.Guid.NewGuid().ToString();
            Console.WriteLine($"This Computer Guid is {guid}");
            cfg.Guid = guid;

            model.KValue1 = cfg.K1;
            model.OValue1 = cfg.Ovalue1;

            model.KValue2 = cfg.K2;
            model.OValue2 = cfg.Ovalue2;

            if (cfg.IsAutoConnectMdb== 1)
            {
                checkEdit1.CheckState = CheckState.Checked;
                if (comboBox1.Text != "no port")
                {
                    if (ser.MbsInit(comboBox1.Text))
                    {
                        cfg.LastSerialPort = comboBox1.Text;
                        if (!toggleSwitch5.IsOn) { toggleSwitch5.Toggle(); }
                    }
                    else
                    {
                        if (toggleSwitch5.IsOn) { toggleSwitch5.Toggle(); }
                    }
                }
            }
            else
            {
                checkEdit1.CheckState = CheckState.Unchecked;
            }

            if (cfg.IsAutoConnectStepper== 1)
            {
                checkEdit2.CheckState = CheckState.Checked;
                if (comboBox2.Text != "no port")
                {
                    if (ser.StepperInit(comboBox2.Text))
                    {
                        cfg.LastSerialPort = comboBox2.Text;
                        if (!toggleSwitch10.IsOn) { toggleSwitch10.Toggle(); }
                    }
                    else
                    {
                        if (toggleSwitch10.IsOn) { toggleSwitch10.Toggle(); }
                    }
                }
            }
            else
            {
                checkEdit2.CheckState = CheckState.Unchecked;
            }

            turn_sig.Name = "turn_sig";
            w_sig.Name = "w_sig";
            r_sig.Name = "r_sig";
            h_sig.Name = "h_sig";


            timerInput.Start();
            timer_UI_loop.Start();
            timerDataUpdate.Start();

            turn_sig.CheckedChanged += new EventHandler(modelTOController);
            w_sig.CheckedChanged    += new EventHandler(modelTOController);
            r_sig.CheckedChanged    += new EventHandler(modelTOController);
            h_sig.CheckedChanged    += new EventHandler(modelTOController);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="data"></param>
        private void machine3_2TOController(string data)
        {
            Console.WriteLine(data + "--------machine3_2");
            switch (data)
            {
                case "OnEntryFaster":
                    model.WeightDoor2 = false;
                    model.BigDoor2 = true;
                    model.SmallDoor2 = true;
                    break;
                case "OnEntryReady":
                    model.WeightDoor2 = false;
                    model.BigDoor2 = false;
                    model.SmallDoor2 = false;
                    break;
                case "OnEntrySlowT":
                    model.WeightDoor2 = false;
                    model.BigDoor2 = true;
                    model.SmallDoor2 = false;
                    break;
                case "OnEntrySlowK":
                    model.WeightDoor2 = false;
                    model.BigDoor2 = true;
                    model.SmallDoor2 = true;
                    break;
                case "OnEntryOkk":
                    model.WeightDoor2 = false;
                    model.BigDoor2 = false;
                    model.SmallDoor2 = false;
                    break;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="data"></param>
        private void machine3ALL_1TOController(string data)
        {
            Console.WriteLine(data + "--------machine3all_1");
            MVC_C3_1.TargetValue = int.Parse(textEdit1.Text);

            MVC_C3_2.TargetValue = int.Parse(textEdit5.Text);
        }

        public void input1_TOController(string s)
        {
            Console.WriteLine(s + "-----machine3all");
            switch(s)
            {
                case "INIT":
                    MVC_C3ALL._machine.Fire(Machine3ALL.Trigger.INIT);
                    break;

                case "START":
                    MVC_C3ALL._machine.Fire(Machine3ALL.Trigger.START);
                    break;

                case "CHECK":
                    MVC_C3ALL._machine.Fire(Machine3ALL.Trigger.CHECK);
                    break;

                case "OK":
                    MVC_C3ALL._machine.Fire(Machine3ALL.Trigger.OK);
                    break;

                case "RESTART":
                    MVC_C3ALL._machine.Fire(Machine3ALL.Trigger.RESTART);
                    break;
            }
            // labelControl10.BeginInvoke(new Action(() => labelControl10.Text = s));
        }
        
        public string model1TOController(object sender, string info)
        {
            barButtonItem3.Caption = info;
            return "ok";
            // labelControl10.BeginInvoke(new Action(() => labelControl10.Text = s));
        }
        /// <summary>
        /// machine3 委托到控制器处理
        /// 注意委托线程与UI线程的不同
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void machine3_1TOController(string data)
        {
            Console.WriteLine(data);
            switch (data)
            {
                case "OnEntryFaster":
                    model.WeightDoor1 = false;
                    model.BigDoor1 = true;
                    model.SmallDoor1 = true;
                    break;
                case "OnEntryReady":
                    model.WeightDoor1 = false;
                    model.BigDoor1 = false;
                    model.SmallDoor1 = false;
                    break;
                case "OnEntrySlowT":
                    model.WeightDoor1 = false;
                    model.BigDoor1 = true;
                    model.SmallDoor1 = false;
                    break;
                case "OnEntrySlowK":
                    model.WeightDoor1 = false;
                    model.BigDoor1 = true;
                    model.SmallDoor1 = true;
                    break;
                case "OnEntryOkk":
                    model.WeightDoor1 = false;
                    model.BigDoor1 = false;
                    model.SmallDoor1 = false;
                    break;
            }
        }

        /// <summary>
        /// model 委托到控制器处理
        /// 注意委托线程与UI线程的不同
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void modelTOController(object sender, EventArgs e)
        {
            CheckBox cb = sender as CheckBox;
            string name = cb.Name;
            switch (name)
            {
                case "turn_sig":
                    MVC_C2_1._machine.Fire(Machine2.Trigger.TURN);
                    break;
                case "w_sig":
                    MVC_C2_1._machine.Fire(Machine2.Trigger.W);
                    break;
                case "r_sig":
                    MVC_C2_1._machine.Fire(Machine2.Trigger.R);
                    break;
                case "h_sig":
                    if(h_sig.CheckState == CheckState.Checked)
                    {
                        MVC_C4_1._machine.Fire(Machine4.Trigger.TOGGLE);
                        Console.WriteLine("+++++++++++++++++++++++++++++++++++++++");
                    }
                    break;
            }

        }

        /// <summary>
        /// machine2 委托到控制器处理
        /// 注意委托线程与UI线程的不同
        /// </summary>
        /// <param name="data"></param>
        private void machine2TOController(string data)
        {
            switch (data)
            {
                case "OnEntryOn":
                    model.Light = true;
                    break;
                case "OnExitOn":
                    model.Light = false;
                    break;

                case "OnExitwrite":
                    model.WriteAction = false;
                    break;
                case "OnEntrywrite":
                    model.WriteAction = true;
                    break;

                case "OnEntryread":
                    model.ReadAction = true;
                    break;
                case "OnExitread":
                    model.ReadAction = false;
                    break;


            }
            Console.WriteLine(data);
        }

        /// <summary>
        /// timer tick事件更新数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerDataUpdate_Tick(object sender, EventArgs e)
        {
            // model 当前称值 到 状态机当前值
            MVC_C3_1.CurrentValue = model.CurrentWeight1;

            MVC_C3_2.CurrentValue = model.CurrentWeight2;
        }

        private void timerInput_Tick(object sender, EventArgs e)
        {
            turn_sig.CheckState = model.LightSwitch == true ? CheckState.Checked : CheckState.Unchecked;
            w_sig.CheckState    = model.WriteSwitch == true ? CheckState.Checked : CheckState.Unchecked;
            r_sig.CheckState    = model.ReadSwitch  == true ? CheckState.Checked : CheckState.Unchecked;
            h_sig.CheckState    = model.LimitSwitch == true ? CheckState.Checked : CheckState.Unchecked;
        }
        /// <summary>
        /// timer tick事件更新UI
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer_UI_loop_Tick(object sender, EventArgs e)
        {
            labelControl34.Text = MVC_C4_1._state.ToString();
            simpleButton10.Text = MVC_C3ALL._state.ToString();
            // Light 状态机 
            simpleButton4.Text = MVC_C2_1._state.ToString();

            // ------------------------------------------------------------------------------
            // 一号配料机更新
            // 原始值显示
            textEdit2.Text = model.RawValue1.ToString();
            // k值显示
            textEdit3.Text = model.KValue1.ToString();
            // 0值显示
            textEdit4.Text = model.OValue1.ToString();

            // 称示数
            simpleButton5.Text = model.CurrentWeight1.ToString();

            // machine3 当前状态
            simpleButton11.Text = MVC_C3_1._state.ToString();

            // 称门, 在easy状态下，仓称门可自由开关
            if (MVC_C3_1._state != Machine3.States.Easy)
            {
                // 称门
                if (model.WeightDoor1)
                {
                    if (!toggleSwitch2.IsOn)
                    {
                        toggleSwitch2.Toggle();
                    }
                }
                else
                {
                    if (toggleSwitch2.IsOn)
                    {
                        toggleSwitch2.Toggle();
                    }
                }
                // 仓小门
                if (model.SmallDoor1)
                {
                    if (!toggleSwitch3.IsOn)
                    {
                        toggleSwitch3.Toggle();
                    }
                }
                else
                {
                    if (toggleSwitch3.IsOn)
                    {
                        toggleSwitch3.Toggle();
                    }
                }
                // 仓大门
                if (model.BigDoor1)
                {
                    if (!toggleSwitch4.IsOn)
                    {
                        toggleSwitch4.Toggle();
                    }
                }
                else
                {
                    if (toggleSwitch4.IsOn)
                    {
                        toggleSwitch4.Toggle();
                    }
                }
            }

            // ------------------------------------------------------------------------------
            // 二号配料机更新
            // 原始值显示
            textEdit10.Text = model.RawValue2.ToString();
            // k值显示
            textEdit9.Text = model.KValue2.ToString();
            // 0值显示
            textEdit8.Text = model.OValue2.ToString();

            // 称示数
            simpleButton24.Text = model.CurrentWeight2.ToString();

            // machine3 当前状态
            simpleButton22.Text = MVC_C3_2._state.ToString();

            // 称门, 在easy状态下，仓称门可自由开关
            if (MVC_C3_2._state != Machine3.States.Easy)
            {
                // 称门
                if (model.WeightDoor2)
                {
                    if (!toggleSwitch8.IsOn)
                    {
                        toggleSwitch8.Toggle();
                    }
                }
                else
                {
                    if (toggleSwitch8.IsOn)
                    {
                        toggleSwitch8.Toggle();
                    }
                }
                // 仓小门
                if (model.SmallDoor2)
                {
                    if (!toggleSwitch7.IsOn)
                    {
                        toggleSwitch7.Toggle();
                    }
                }
                else
                {
                    if (toggleSwitch7.IsOn)
                    {
                        toggleSwitch7.Toggle();
                    }
                }
                // 仓大门
                if (model.BigDoor2)
                {
                    if (!toggleSwitch6.IsOn)
                    {
                        toggleSwitch6.Toggle();
                    }
                }
                else
                {
                    if (toggleSwitch6.IsOn)
                    {
                        toggleSwitch6.Toggle();
                    }
                }
            }
        }

        private void timerVirtual_Tick(object sender, EventArgs e)
        {

        }
    }
}

