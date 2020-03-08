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
        private string id;

        public string Id { get => id; set => id = value; }

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
            switch (Id)
            {
                case "1":
                    Cfg.TOpen1 = int.Parse(textEdit_TOpen.Text);
                    Cfg.TClose1 = int.Parse(textEdit_TClose.Text);
                    Cfg.K1 = float.Parse(textEdit_K.Text);
                    Cfg.Ovalue1 = int.Parse(textEdit_OValue.Text);
                    break;
                case "2":
                    Cfg.TOpen2 = int.Parse(textEdit_TOpen.Text);
                    Cfg.TClose2 = int.Parse(textEdit_TClose.Text);
                    Cfg.K2 = float.Parse(textEdit_K.Text);
                    Cfg.Ovalue2 = int.Parse(textEdit_OValue.Text);
                    break;
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            timer_UI.Start();
            InitUi();
        }
        private void InitUi()
        {
            switch (Id)
            {
                case "1":
                    textEdit_RawValue.Text = modeltemp.RawValue1.ToString();
                    textEdit_K.Text = modeltemp.KValue1.ToString();
                    textEdit_OValue.Text = modeltemp.OValue1.ToString();
                    textEdit_TOpen.Text = Cfg.TOpen1.ToString();
                    textEdit_TClose.Text = Cfg.TClose1.ToString();
                    break;
                case "2":
                    textEdit_RawValue.Text = modeltemp.RawValue2.ToString();
                    textEdit_K.Text = modeltemp.KValue2.ToString();
                    textEdit_OValue.Text = modeltemp.OValue2.ToString();
                    textEdit_TOpen.Text = Cfg.TOpen2.ToString();
                    textEdit_TClose.Text = Cfg.TClose2.ToString();
                    break;
            }
        }
  
        Random ran = new Random();

        private void simpleButton_xiaocheng_Click(object sender, EventArgs e)
        {
            switch (Id)
            {
                case "1":
                    float delta = modeltemp.RawValue1 - modeltemp.OValue1;
                    float target = float.Parse(textEdit_targetWeight.Text);
                    modeltemp.KValue1 = target / delta;
                    break;
                case "2":
                    float delta2 = modeltemp.RawValue2 - modeltemp.OValue2;
                    float target2 = float.Parse(textEdit_targetWeight.Text);
                    modeltemp.KValue2 = target2 / delta2;
                    break;
            }
        }

 
        private void simpleButton_add100_Click(object sender, EventArgs e)
        {
            modeltemp.RawValue1 += ran.Next(1, 100);
        }

        private void simpleButton_add50_Click(object sender, EventArgs e)
        {
            modeltemp.RawValue1 += ran.Next(1, 50);
        }

        private void simpleButton_add10_Click(object sender, EventArgs e)
        {
            modeltemp.RawValue1 += ran.Next(1, 10);
        }

        private void simpleButton_add1_Click(object sender, EventArgs e)
        {
            modeltemp.RawValue1 += 1;
        }

        private void simpleButton_to0_Click(object sender, EventArgs e)
        {
            modeltemp.RawValue1 = 0;
        }

        private void simpleButton_sub1_Click(object sender, EventArgs e)
        {
            modeltemp.RawValue1 -= 1;
        }

        private void simpleButton_sub10_Click(object sender, EventArgs e)
        {
            modeltemp.RawValue1 = ran.Next(1, 10);
        }

        private void simpleButton_sub50_Click(object sender, EventArgs e)
        {
            modeltemp.RawValue1 -= ran.Next(1, 50);
        }

        private void simpleButton_sub100_Click(object sender, EventArgs e)
        {
            modeltemp.RawValue1 -= ran.Next(1, 100);
        }

        private void timer_UI_Tick(object sender, EventArgs e)
        {
            switch (Id)
            {
                case "1":
                    textEdit_RawValue.Text = modeltemp.RawValue1.ToString();
                    textEdit_K.Text = modeltemp.KValue1.ToString();
                    textEdit_OValue.Text = modeltemp.OValue1.ToString();
                    break;
                case "2":
                    textEdit_RawValue.Text = modeltemp.RawValue2.ToString();
                    textEdit_K.Text = modeltemp.KValue2.ToString();
                    textEdit_OValue.Text = modeltemp.OValue2.ToString();
                    break;
            }
        }


        private void simpleButton_zero_Click(object sender, EventArgs e)
        {
            switch (Id)
            {
                case "1":
                    modeltemp.OValue1 = modeltemp.RawValue1;
                    break;
                case "2":
                    modeltemp.OValue2 = modeltemp.RawValue2;
                    break;
            }
        }
    }
}
