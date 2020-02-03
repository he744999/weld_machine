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
    public partial class XtraForm1 : DevExpress.XtraEditors.XtraForm
    {
        public XtraForm1()
        {
            InitializeComponent();
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
    }
}