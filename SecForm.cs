using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class SecForm : Form
    {
        public SecForm()
        {
            InitializeComponent();
        }

        private void BtnShowpart1_Click(object sender, EventArgs e)
        {
            Form _e = new Form1();
            _e.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (Form frm = new Form1())
            {
                frm.ShowDialog();
            }

        }

        private void BtnMsgBoxForm_Click(object sender, EventArgs e)
        {
            Form frm_1 = new FrmMessageBox();
            frm_1.ShowDialog();
        }
    }
}
