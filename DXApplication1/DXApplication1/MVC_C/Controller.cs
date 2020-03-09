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

        string guid;
        public void ControllerInit()
        {
            guid = System.Guid.NewGuid().ToString();
            Console.WriteLine($"This Computer Guid is {guid}");
            cfg.Guid = guid;

            modelTemp.KValue1 = cfg.K1;
            modelTemp.OValue1 = cfg.Ovalue1;

            modelTemp.KValue2 = cfg.K2;
            modelTemp.OValue2 = cfg.Ovalue2;

            if (cfg.IsAutoConnectMdb == 1)
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

            if (cfg.IsAutoConnectStepper == 1)
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


            timerInput.Start();
            timer_UI_loop.Start();
            timerDataUpdate.Start();

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
                    modelTemp.WeightDoor2 = false;
                    modelTemp.BigDoor2 = true;
                    modelTemp.SmallDoor2 = true;
                    break;
                case "OnEntryReady":
                    textEdit_targ2.Text = textEdit_target2.Text;
                    break;
                case "OnEntrySlowT":
                    modelTemp.WeightDoor2 = false;
                    modelTemp.BigDoor2 = true;
                    modelTemp.SmallDoor2 = false;
                    break;
                case "OnEntrySlowK":
                    modelTemp.WeightDoor2 = false;
                    modelTemp.BigDoor2 = true;
                    modelTemp.SmallDoor2 = true;
                    break;
                case "OnEntryOkk":
                    modelTemp.WeightDoor2 = false;
                    modelTemp.BigDoor2 = false;
                    modelTemp.SmallDoor2 = false;
                    break;
            }
        }

        string commands;
        string[] cmds;
        string name;
        string value;
        private void modelTemp2Controller(object sender, EventArgs e)
        {
            commands = sender as string;
            cmds = commands.Split('-');
            name  = cmds[0];
            value = cmds[1];
            switch(name)
            {
                case "LightSwitch":
                    MVC_C2_1._machine.Fire(Machine2.Trigger.TURN);
                    switch(value)
                    {
                        case "False":
                            Console.WriteLine("false");
                            break;
                        case "True":
                            Console.WriteLine("true");
                            break;
                    }
                    break;
                case "WriteSwitch":
                    switch (value)
                    {
                        case "False":
                            Console.WriteLine("false");
                            break;
                        case "True":
                            MVC_C2_1._machine.Fire(Machine2.Trigger.W);
                            Console.WriteLine("true");
                            break;
                    }
                    break;
                case "ReadSwitch":
                    switch (value)
                    {
                        case "False":
                            Console.WriteLine("false");
                            break;
                        case "True":
                            MVC_C2_1._machine.Fire(Machine2.Trigger.R);
                            Console.WriteLine("true");
                            break;
                    }
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
            MVC_C3_1.TargetValue = int.Parse(textEdit_target1.Text);

            MVC_C3_2.TargetValue = int.Parse(textEdit_target2.Text);
        }

        public void input1_TOController(string s)
        {
            // Console.WriteLine(s + "-----machine3all");
            switch (s)
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

                case "m3RESTART":
                    MVC_C_0.Restart();
                    break;
                case "m3NEXT":
                    MVC_C_0.Next();
                    break;
                case "m3INIT":
                    MVC_C_0.MachineInit(2);
                    break;
                case "m3START":
                    MVC_C_0.Init();
                    break;
                case "M3DOT":
                    Console.WriteLine(MVC_C3_1.ToDOTGraph());
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
                case "OnEntryReady":
                    textEdit_targ1.Text = textEdit_target1.Text;
                    break;
                case "OnEntryFaster":
                    modelTemp.WeightDoor1 = false;
                    modelTemp.BigDoor1 = true;
                    modelTemp.SmallDoor1 = true;
                    break;
                case "OnEntrySlowT":
                    modelTemp.WeightDoor1 = false;
                    modelTemp.BigDoor1 = true;
                    modelTemp.SmallDoor1 = false;
                    break;
                case "OnEntrySlowK":
                    modelTemp.WeightDoor1 = false;
                    modelTemp.BigDoor1 = true;
                    modelTemp.SmallDoor1 = true;
                    break;
                case "OnEntryOkk":
                    modelTemp.WeightDoor1 = false;
                    modelTemp.BigDoor1 = false;
                    modelTemp.SmallDoor1 = false;
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
                    modelTemp.Light = true;
                    break;
                case "OnExitOn":
                    modelTemp.Light = false;
                    break;

                case "OnExitwrite":
                    modelTemp.WriteAction = false;
                    break;
                case "OnEntrywrite":
                    modelTemp.WriteAction = true;
                    break;

                case "OnEntryread":
                    modelTemp.ReadAction = true;
                    break;
                case "OnExitread":
                    modelTemp.ReadAction = false;
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
            MVC_C3_1.CurrentValue = modelTemp.currentWeight1;

            MVC_C3_2.CurrentValue = modelTemp.currentWeight2;
        }

        private void timerInput_Tick(object sender, EventArgs e)
        {
            /*
            turn_sig.CheckState = model.LightSwitch == true ? CheckState.Checked : CheckState.Unchecked;
            w_sig.CheckState = model.WriteSwitch == true ? CheckState.Checked : CheckState.Unchecked;
            r_sig.CheckState = model.ReadSwitch == true ? CheckState.Checked : CheckState.Unchecked;
            h_sig.CheckState = model.LimitSwitch == true ? CheckState.Checked : CheckState.Unchecked;
            */
        }
        /// <summary>
        /// timer tick事件更新UI
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer_UI_loop_Tick(object sender, EventArgs e)
        {
            // MVC_C0 当前状态
            simpleButton_m3State.Text = MVC_C_0.GetStates();

            labelControl34.Text = MVC_C4_1._state.ToString();
            simpleButton10.Text = MVC_C3ALL._state.ToString();
            // Light 状态机 
            labelControl35.Text = MVC_C2_1._state.ToString();

            // ------------------------------------------------------------------------------
            // 一号配料机更新

            // 称示数
            simpleButton_Cheng1.Text = modelTemp.currentWeight1.ToString();

            // machine3 当前状态
            simpleButton_m3cang1.Text = MVC_C3_1._state.ToString();

            // 称门, 在easy状态下，仓称门可自由开关
            if (MVC_C3_1._state != Machine3.States.Idle)
            {
                // 称门
                if (modelTemp.WeightDoor1)
                {
                    if (!toggleSwitch_Cheng1Door.IsOn)
                    {
                        toggleSwitch_Cheng1Door.Toggle();
                    }
                }
                else
                {
                    if (toggleSwitch_Cheng1Door.IsOn)
                    {
                        toggleSwitch_Cheng1Door.Toggle();
                    }
                }
                // 仓小门
                if (modelTemp.SmallDoor1)
                {
                    if (!toggleSwitch_Cang1SmallDoor.IsOn)
                    {
                        toggleSwitch_Cang1SmallDoor.Toggle();
                    }
                }
                else
                {
                    if (toggleSwitch_Cang1SmallDoor.IsOn)
                    {
                        toggleSwitch_Cang1SmallDoor.Toggle();
                    }
                }
                // 仓大门
                if (modelTemp.BigDoor1)
                {
                    if (!toggleSwitch_Cang1BigDoor.IsOn)
                    {
                        toggleSwitch_Cang1BigDoor.Toggle();
                    }
                }
                else
                {
                    if (toggleSwitch_Cang1BigDoor.IsOn)
                    {
                        toggleSwitch_Cang1BigDoor.Toggle();
                    }
                }
            }

            // ------------------------------------------------------------------------------
            // 二号配料机更新

            // 称示数
            simpleButton_Cheng2.Text = modelTemp.currentWeight2.ToString();

            // machine3 当前状态
            simpleButton_m3cang2.Text = MVC_C3_2._state.ToString();

            // 称门, 在easy状态下，仓称门可自由开关
            if (MVC_C3_2._state != Machine3.States.Idle)
            {
                // 称门
                if (modelTemp.WeightDoor2)
                {
                    if (!toggleSwitch_Cheng2Door.IsOn)
                    {
                        toggleSwitch_Cheng2Door.Toggle();
                    }
                }
                else
                {
                    if (toggleSwitch_Cheng2Door.IsOn)
                    {
                        toggleSwitch_Cheng2Door.Toggle();
                    }
                }
                // 仓小门
                if (modelTemp.SmallDoor2)
                {
                    if (!toggleSwitch_Cang2SmallDoor.IsOn)
                    {
                        toggleSwitch_Cang2SmallDoor.Toggle();
                    }
                }
                else
                {
                    if (toggleSwitch_Cang2SmallDoor.IsOn)
                    {
                        toggleSwitch_Cang2SmallDoor.Toggle();
                    }
                }
                // 仓大门
                if (modelTemp.BigDoor2)
                {
                    if (!toggleSwitch_Cang2BigDoor.IsOn)
                    {
                        toggleSwitch_Cang2BigDoor.Toggle();
                    }
                }
                else
                {
                    if (toggleSwitch_Cang2BigDoor.IsOn)
                    {
                        toggleSwitch_Cang2BigDoor.Toggle();
                    }
                }
            }
        }


    }
}

