using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace TakeHomeW3
{
    public partial class Form2 : Form
    {
        //public string Artist;
        public Form2()
        {
            InitializeComponent();
        }

        public string textlabel
        {
            get { return label3.Text; }
            set { label3.Text = value;  }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        private void MagicButton_Click(object sender, EventArgs e)
        {
            if (checkBoxagree.Checked == true && checkBoxchoice.Checked == true && radioButtonRed.Checked == true || radioButtonGreen.Checked == true || radioButtonBlue.Checked == true || radioButtonYellow.Checked == true || radioButtonPurple.Checked == true && radioButtonPink.Checked == true || radioButtonOrange.Checked == true || radioButtonBrown.Checked == true)
            {
                Form1 form = Application.OpenForms["Form1"] as Form1;
                if (radioButtonRed.Checked)
                {
                    form.BackColor = Color.Red;
                }
                else if (radioButtonGreen.Checked)
                {
                    form.BackColor = Color.Green;
                }
                else if (radioButtonBlue.Checked)
                {
                    form.BackColor = Color.Blue;
                }
                else if (radioButtonYellow.Checked)
                {
                    form.BackColor = Color.Yellow;
                }
                else if (radioButtonPurple.Checked)
                {
                    form.BackColor = Color.Purple;
                }

                if (radioButtonPink.Checked)
                {
                    form.ForeColor = Color.Pink;
                }
                else if (radioButtonOrange.Checked)
                {
                    form.ForeColor= Color.Orange;
                }
                else if (radioButtonBrown.Checked)
                {
                    form.ForeColor = Color.Brown;
                }
            }
            else
            {
                MessageBox.Show("Error");
            }
        }
    }
}
