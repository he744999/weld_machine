using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;


namespace DXApplication4
{
    public partial class ViewData : DevExpress.XtraEditors.XtraForm
    {
        Model model = new Model();
        public ViewData()
        {
            InitializeComponent();
            // simpleButton1.DataBindings.Add("Text", model, "ts");

            timerViewData.Start();
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
        }

        private void XtraForm1_Load(object sender, EventArgs e)
        {
        }

        public void showFrom(bool data_)
        {
            this.Visible = data_;
        }

        private void XtraForm1_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            simpleButton1.Text = Model.DOS[0][0].ToString();
            simpleButton2.Text = Model.DOS[0][1].ToString();
            simpleButton3.Text = Model.DOS[0][2].ToString();
            simpleButton4.Text = Model.DOS[0][3].ToString();

            simpleButton5.Text = Model.DOS[1][0].ToString();
            simpleButton6.Text = Model.DOS[1][1].ToString();
            simpleButton7.Text = Model.DOS[1][2].ToString();
            simpleButton8.Text = Model.DOS[1][3].ToString();

            simpleButton9.Text  = Model.DIS[0][0].ToString();
            simpleButton10.Text = Model.DIS[0][1].ToString();
            simpleButton11.Text = Model.DIS[0][2].ToString();
            simpleButton12.Text = Model.DIS[0][3].ToString();


            simpleButton13.Text = Model.DIS[1][0].ToString();
            simpleButton14.Text = Model.DIS[1][1].ToString();
            simpleButton15.Text = Model.DIS[1][2].ToString();
            simpleButton16.Text = Model.DIS[1][3].ToString();


            simpleButton17.Text = Model.AIS[0][0].ToString();
            simpleButton18.Text = Model.AIS[0][1].ToString();
            simpleButton19.Text = Model.AIS[0][2].ToString();
            simpleButton20.Text = Model.AIS[0][3].ToString();
            simpleButton21.Text = Model.AIS[0][4].ToString();
            simpleButton22.Text = Model.AIS[0][5].ToString();
            simpleButton23.Text = Model.AIS[0][6].ToString();
            simpleButton24.Text = Model.AIS[0][7].ToString();

        }

        private void simpleButton9_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton9_MouseDown(object sender, MouseEventArgs e)
        {
            Model.DIS[0][0] = Model.DIS[0][0] == true ? false : true;
        }

        private void simpleButton10_Click(object sender, EventArgs e)
        {
            Model.DIS[0][1] = Model.DIS[0][1] == true ? false : true;
        }

        private void simpleButton11_Click(object sender, EventArgs e)
        {
            Model.DIS[0][2] = Model.DIS[0][2] == true ? false : true;
        }
    }
}