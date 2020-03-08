using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DXApplication1
{
    public partial class Form2 : Form
    {
        /// <summary>
        /// 这是系统参数配置界面
        /// </summary>

        public Stp Cfg;
        public ModelTemp modeltemp;

        public Form2(Stp config, ModelTemp mtp)
        {
            InitializeComponent();
            this.ControlBox = false;
            Cfg = config;
            modeltemp = mtp;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            UpdateDate();
            this.Close();
        }

        private void UpdateDate()
        {
            Cfg.TOpen1  = int.Parse(textEdit1.Text); 
            Cfg.TClose1 = int.Parse(textEdit2.Text);
            Cfg.K1 = float.Parse(textEdit3.Text);
            Cfg.Ovalue1 = int.Parse(textEdit4.Text);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            timer1.Start();

        }

        private void simpleButton9_Click(object sender, EventArgs e)
        {
            float delta = modeltemp.RawValue1 - modeltemp.OValue1;
            modeltemp.KValue1 = delta / modeltemp.OValue1;
        }

        private void simpleButton8_Click(object sender, EventArgs e)
        {
            modeltemp.OValue1 = modeltemp.RawValue1;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textEdit5.Text = modeltemp.RawValue1.ToString();
            textEdit3.Text = modeltemp.KValue1.ToString();
            textEdit4.Text = modeltemp.OValue1.ToString();
            textEdit1.Text = Cfg.TOpen1.ToString();
            textEdit2.Text = Cfg.TClose1.ToString();
        }

        Random ran = new Random();


        private void simpleButton25_Click(object sender, EventArgs e)
        {
            modeltemp.RawValue1 += ran.Next(1, 100);
        }

        private void simpleButton26_Click(object sender, EventArgs e)
        {
            modeltemp.RawValue1 += ran.Next(1, 10);
        }

        private void simpleButton27_Click(object sender, EventArgs e)
        {
            modeltemp.RawValue1 += 1;
        }

        private void simpleButton31_Click(object sender, EventArgs e)
        {
            modeltemp.RawValue1 =0;
        }

        private void simpleButton28_Click(object sender, EventArgs e)
        {
            modeltemp.RawValue1 -= 1;
        }

        private void simpleButton29_Click(object sender, EventArgs e)
        {
            modeltemp.RawValue1 = ran.Next(1, 10);
        }

        private void simpleButton30_Click(object sender, EventArgs e)
        {
            modeltemp.RawValue1 -= ran.Next(1, 100);
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            modeltemp.RawValue1 += ran.Next(1, 50);
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            modeltemp.RawValue1 -= ran.Next(1, 50);
        }
    }
}
