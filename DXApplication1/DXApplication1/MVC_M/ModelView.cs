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

namespace DXApplication1
{
    public partial class ModelView : DevExpress.XtraEditors.XtraForm
    {
        Model model = new Model();
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
                    model.LightSwitch= !model.LightSwitch;
                    break;
                case "simpleButton10":
                    model.ReadSwitch= !model.ReadSwitch;
                    break;
                case "simpleButton11":
                    model.WriteSwitch= !model.WriteSwitch;
                    break;
            }
        }
    }
}