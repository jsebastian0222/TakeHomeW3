using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TakeHomeW3
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        Form2 form2 = new Form2();

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                buttonSubmit.Enabled = true;
            }
            else
            {
                buttonSubmit.Enabled = false;
            }
        }

        
        public string GetName
        {
            get { return textBoxName.Text; }
            set { textBoxName.Text = value; }
        }
        public string GetArtist
        {
            get { return textBoxArtist.Text; }
            set { textBoxArtist.Text = value; }
        }


        private void buttonNextForm_Click(object sender, EventArgs e)
        {
            form2.Show();
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text is null && textBoxArtist.Text is null)
            {
                MessageBox.Show("enter correct input");
            }
            else
            {
                string nama = textBoxName.Text;
                string Artist = textBoxArtist.Text;
                string text = $"Hi, My name is {nama} and my favorite artist is {Artist}";
                form2.textlabel = text;
            }
        }
    }
}
