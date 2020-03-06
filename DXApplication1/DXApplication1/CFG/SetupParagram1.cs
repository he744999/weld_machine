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

        Stp cfg = new Stp();

        public Form2()
        {
            InitializeComponent();
            this.ControlBox = false;

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            UpdateDate();
            this.Close();
        }

        private void UpdateDate()
        {
            cfg.TOpen1  = int.Parse(textEdit1.Text); 
            cfg.TClose1 = int.Parse(textEdit2.Text);
            cfg.K1 = float.Parse(textEdit3.Text);
            cfg.Ovalue1 = int.Parse(textEdit4.Text);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            InitParagram();

        }

        private void InitParagram()
        {
            textEdit1.Text = cfg.TOpen1.ToString();
            textEdit2.Text = cfg.TClose1.ToString();
            textEdit3.Text = cfg.K1.ToString();
            textEdit4.Text = cfg.Ovalue1.ToString();
        }

        private void simpleButton9_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton8_Click(object sender, EventArgs e)
        {

        }
    }
}
