using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using EasyModbus;
using System.IO.Ports;


namespace DXApplication1
{
    class Serial
    {
        // 串口对象和信息
        SerialPort StepperSerial = new SerialPort();
        private static ModbusClient mdb;
        public string[] ports;

        // 线程输入出
        private Thread thdMdb = null;
        public static bool isRunningMdb = false;
        public static bool isCommunicatingMdb = false;

        // 线程输入出
        // private Thread thdStepper = null;
        public static bool isRunningStepper = false;
        public static bool isCommunicatingStepper = false;

        // 线程技术称值类
        private Thread thd2 = null;

        // 委托事件
        public delegate string MessageDelegate1(object sender, string data);
        public static event MessageDelegate1 Model2ControllerMessageHanlder;

        public Serial()
        {

            thdMdb = new Thread(new ThreadStart(SerialRunning));
            thdMdb.IsBackground = true;
            thd2 = new Thread(new ThreadStart(thdTest));
            thd2.IsBackground = true;
            thdMdb.Name = "SerialCommunicating";
            thd2.Name = "thdTest";

            UpdatePorts();
            mdb = new ModbusClient();
            isRunningMdb = true;

            StepperSerial = new SerialPort();
            StepperSerial.DataReceived += StepperSerial_DataReceived;
            isRunningStepper = true;

            thd2.Start();
        }

        string str = "";

        private void StepperSerial_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            int count = StepperSerial.BytesToRead;
            // byte[] readbuffer = new byte[count];
            if (count > 0)
            {
                // Application.DoEvents();
                str = StepperSerial.ReadTo("\n");
                str += "\n";
            }

            // textBox1.BeginInvoke(new Action(() => textBox1.Text += str));
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
                    // simpleButton9.BeginInvoke(new Action(() => simpleButton9.Text = xPos));
                    // simpleButton11.BeginInvoke(new Action(() => simpleButton11.Text = yPos));
                    // simpleButton12.BeginInvoke(new Action(() => simpleButton12.Text = zPos));
                }
                if (i.StartsWith("FS"))
                {
                    Console.WriteLine(i);
                }
            }
        }

        public bool MbsInit(string port)
        {
            mdb.SerialPort = port;
            mdb.Baudrate = 9600;
            mdb.StopBits = System.IO.Ports.StopBits.One;
            mdb.Parity = System.IO.Ports.Parity.None;
            mdb.ConnectionTimeout = 200;
            try
            {
                mdb.Connect();
                isCommunicatingMdb = true;
                if (thdMdb.ThreadState == (System.Threading.ThreadState.Unstarted | System.Threading.ThreadState.Background))
                {
                    thdMdb.Start();
                    isRunningMdb = true;
                }

            }
            catch
            {
                isCommunicatingMdb = false;
            }
            return isCommunicatingMdb;
        }


        public bool StepperInit(string port)
        {
            StepperSerial.PortName = port;
            StepperSerial.StopBits = StopBits.One;
            StepperSerial.BaudRate = 115200;
            StepperSerial.Parity = System.IO.Ports.Parity.None;
            StepperSerial.ReadTimeout = 200;
            StepperSerial.WriteTimeout = 200;
            try
            {
                StepperSerial.Open();
                isCommunicatingStepper = true;
            }
            catch
            {
                isCommunicatingStepper = false;
            }
            return isCommunicatingStepper;
        }

        public void Close()
        {
            isCommunicatingMdb = false;
            isRunningMdb = false;
            if (mdb.Connected) { mdb.Disconnect(); }

            isCommunicatingStepper = false;
            isRunningStepper = false;
            if (StepperSerial.IsOpen) { StepperSerial.Close(); }
        }

        public void SerialRunning()
        {
            Thread.Sleep(2000);
            string Message = "";
            while (isRunningMdb)
            {
                if (isCommunicatingMdb)
                {
                    //----------------------------------------------------------------------------
                    mdb.UnitIdentifier = 202;
                    Model.DIS[1] = mdb.ReadDiscreteInputs(0x64, 4);
                    mdb.WriteSingleCoil(0, Model.DOS[0][0]);
                    mdb.WriteSingleCoil(1, Model.DOS[0][1]);
                    mdb.WriteSingleCoil(2, Model.DOS[0][2]);
                    mdb.WriteSingleCoil(3, Model.DOS[0][3]);
                    //mdb.WriteMultipleCoils(0, DOS[1]);
                    Model.DOS_COILS[1] = mdb.ReadCoils(0, 4);
                    //----------------------------------------------------------------------------

                    //----------------------------------------------------------------------------
                    // 模块1-  DI和DO 及读取线圈状态
                    /*
                    mdb.UnitIdentifier = 120;
                    DIS[0] = mdb.ReadDiscreteInputs(0x64, 4);00 03 40 00 00 01 90 1b
                    mdb.WriteMultipleCoils(0, DOS[0]);
                    DOS_COILS[0] = mdb.ReadCoils(0, 4);
                    //----------------------------------------------------------------------------



                    //----------------------------------------------------------------------------
                    // 模块2-  DI和DO 及读取线圈状态
                    mdb.UnitIdentifier = 121;
                    DIS[1] = mdb.ReadDiscreteInputs(0x64, 4);
                    mdb.WriteMultipleCoils(0, DOS[1]);
                    DOS_COILS[1] = mdb.ReadCoils(0, 4);
                    //----------------------------------------------------------------------------




                    //----------------------------------------------------------------------------
                    // 模块3-  AI
                    mdb.UnitIdentifier = 100;
                    //AIS[0] = mdb.ReadInputRegisters(256, 8);
                    //----------------------------------------------------------------------------




                    //----------------------------------------------------------------------------
                    // 检查 输出继电器线圈状态是否和输出数组一致，否 ，发送CoilsError事件
                    for (int i = 0; i < DOS.Length; i++)
                    {
                        if (DOS[0][i] != DOS_COILS[0][i])
                        {
                            mdb.UnitIdentifier = 120;
                            mdb.WriteSingleCoil(i, DOS_COILS[0][i]);
                        }
                        if (DOS[1][i] != DOS_COILS[1][i])
                        {
                            mdb.UnitIdentifier = 121;
                            mdb.WriteSingleCoil(i, DOS_COILS[0][i] );
                        }
                    }
                    */


                    Message = Model2ControllerMessageHanlder("communica", "Communicating");
                }
                else
                {
                    Message = Model2ControllerMessageHanlder("no communica", "No communication");
                    Thread.Sleep(500);
                }
            }
        }
        public void thdTest()
        {
            while (true)
            {
                // Console.WriteLine("thdTest");
                //currentWeight1 = Convert.ToInt32((RawValue1 - OValue1) * KValue1);
                //currentWeight2 = Convert.ToInt32((RawValue2 - OValue2) * KValue2);
                Thread.Sleep(100);
            }

        }
        public bool StepperCmd(string cmd)
        {
            bool status = false;
            try
            {
                if(StepperSerial.IsOpen)
                {
                    StepperSerial.WriteLine(cmd);
                    status = true;
                }

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);

            }

            return status;
        }
        public void UpdatePorts()
        {
            ports = SerialPort.GetPortNames();
            if (ports.Length == 0)
            {
                ports = new string[] { "no port" };
            }
        }
    }
}
