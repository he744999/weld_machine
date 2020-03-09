using System;
using System.Windows.Forms;

namespace DXApplication1
{
    public partial class Form1Input1 : Form
    {
        public delegate void SendCoilsErrorDelegate(string data);
        public event SendCoilsErrorDelegate InInputFormEvent;
    
        public Form1Input1()
        {
            InitializeComponent();
        }

        private void Input_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            InInputFormEvent("INIT");
        }

        public void test(string data)
        {
            Console.WriteLine(data + " from input class");
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            InInputFormEvent("START");
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            InInputFormEvent("CHECK");
        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {
            InInputFormEvent("OK");
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            InInputFormEvent("RESTART");
        }

        private void simpleButton11_Click(object sender, EventArgs e)
        {
            InInputFormEvent("m3INIT");
        }

        private void simpleButton10_Click(object sender, EventArgs e)
        {
            InInputFormEvent("m3START");
        }

        private void simpleButton9_Click(object sender, EventArgs e)
        {
            InInputFormEvent("m3NEXT");
        }

        private void simpleButton8_Click(object sender, EventArgs e)
        {
            InInputFormEvent("m3OK");
        }

        private void simpleButton7_Click(object sender, EventArgs e)
        {
            InInputFormEvent("m3RESTART");
        }

        private void simpleButton12_Click(object sender, EventArgs e)
        {
            InInputFormEvent("M3DOT");
        }
    }
}
