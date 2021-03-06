﻿using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace DXApplication1
{
    public partial class ModelView : DevExpress.XtraEditors.XtraForm
    {
        public ModelView()
        {
            InitializeComponent();
        }

        private void ModelView_Load(object sender, EventArgs e)
        {
            timer_Model_view.Start();
            this.ControlBox = false;
        }

        private void ModelView_FormClosing(object sender, FormClosingEventArgs e)
        {
            Console.WriteLine("------------");
        }

        private void timer_Model_view_Tick(object sender, EventArgs e)
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

        private void simpleButton_Click(object sender, EventArgs e)
        {
            SimpleButton sb = sender as SimpleButton;
            string name = sb.Name;
            switch(name)
            {
                case "simpleButton9":
                    Model.DIS[0][0] = !Model.DIS[0][0];
                    break;
                case "simpleButton10":
                    Model.DIS[0][1] = !Model.DIS[0][1];
                    break;
                case "simpleButton11":
                    Model.DIS[0][2] = !Model.DIS[0][2];
                    break;
            }
        }


        Random ran = new Random();
        private void simpleButton25_Click(object sender, EventArgs e)
        {
            Model.AIS[0][0] += ran.Next(1, 100);
        }

        private void simpleButton26_Click(object sender, EventArgs e)
        {
            Model.AIS[0][0] += ran.Next(1, 10);
        }

        private void simpleButton27_Click(object sender, EventArgs e)
        {
            Model.AIS[0][0] += 1;
        }

        private void simpleButton28_Click(object sender, EventArgs e)
        {
            Model.AIS[0][0] -= 1;
        }

        private void simpleButton29_Click(object sender, EventArgs e)
        {
            Model.AIS[0][0] -= ran.Next(1, 10);
        }

        private void simpleButton30_Click(object sender, EventArgs e)
        {
            Model.AIS[0][0] -= ran.Next(1, 100);
        }

        private void simpleButton31_Click(object sender, EventArgs e)
        {
            Model.AIS[0][0] = 0;
        }
    }
}