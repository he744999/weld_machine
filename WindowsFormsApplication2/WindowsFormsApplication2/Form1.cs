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
        // MVC_M　封装数据，并线程化更新输入＼出数据
        Model MVC_M;

        // 状态机对象，通过事件通知控制器对象
        Machine MVC_C0;

        public Form1()
        {
            
            InitializeComponent();
            MVC_C0 = new Machine();
            MVC_C0.title = "weld";
            
            MVC_M = new Model();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Machine.SendMessageEvent += Test;
            Serial_Port_Init();
            timer_ui_update.Start();
            timerBlink.Start();
            // timer_start_serial.Start();
        }
        // 在comBox1中列出当前系统可用port号
        private void Serial_Port_Init()
        {
            foreach (string port in MVC_M.ports)
            {
                comBox_ports.Items.Add(port);
            }
            if (MVC_M.ports.Length == 0)
            {
                comBox_ports.Text = "无可用端口";
                btn_open_serial.Enabled = false;
                btn_close_serial.Enabled = false;
                
            }
            else 
            { 
                comBox_ports.Text = MVC_M.ports[0];
            }
            btn_close_serial.Enabled = false;
        }

        public bool Test(bool s)
        {
            Model.DOS[0][0] = s;
            return true;
        }

        // 关闭软件时，禁止所有输出
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("是否关闭窗体","提示", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                Model.DOS[0] = new bool[] { false, false, false, false };
                Model.DOS[1] = new bool[] { false, false, false, false };
                this.MVC_M.CloseOutput(MVC_M.state);
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }

        }
        // 手动启动串口
        private void button2_Click(object sender, EventArgs e)
        {
            // timer_start_serial.Stop();
            string port = comBox_ports.Text;
            if (this.MVC_M.MbsInit(port))
            {
                btn_open_serial.Enabled = false;
                btn_close_serial.Enabled = true;
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
            MVC_C0._machine.Fire(Machine.Trigger.TIMEOUT);
            timerBlink.Stop();

        }
        // 自动串口启动定时器相应函数， 串口启动button不可用
        private void timer_start_serial_Tick(object sender, EventArgs e)
        {
            timer_start_serial.Stop();
            string port = "COM" +  comBox_ports.Text.ToString();
            if (this.MVC_M.MbsInit(port))
            {
                btn_open_serial.Enabled = false;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Show();
            frm2.MdiParent = this;

        }

        private void btn_close_serial_Click(object sender, EventArgs e)
        {
            this.MVC_M.Close_Serial();
            btn_close_serial.Enabled = false;
            btn_open_serial.Enabled = false;
        }

    }
}
