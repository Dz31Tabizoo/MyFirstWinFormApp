using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace WindowsFormsApp1
{
    public partial class FrmMessageBox : Form
    {
        public FrmMessageBox()
        {
            InitializeComponent();
        }

        private void ShowMessage_Click(object sender, EventArgs e)
        {
            // better to define a varible (Res) to get result and than use If statment to do some think

            DialogResult Res = MessageBox.Show("Hi this is a message", "Caption is a Title", 
                MessageBoxButtons.YesNoCancel,MessageBoxIcon.Information
                ,MessageBoxDefaultButton.Button2);


            if (Res == DialogResult.Yes)
            {
                MessageBox.Show("Yes BOX", "Yes");
            }
            else if(Res == DialogResult.No)
            {
                MessageBox.Show("No BOX", "No");
            }
            else
            {
                MessageBox.Show("Cansle", "X");
                this.Close();
            }


        }
    }
}
