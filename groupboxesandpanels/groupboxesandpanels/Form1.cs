using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace groupboxesandpanels
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            messageLabel.Text = "Hi pressed";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            messageLabel.Text = "Far Leftist pressed";
        }

        private void messageLabel_Click(object sender, EventArgs e)
        {
            
        }

        private void bye_button_Click(object sender, EventArgs e)
        {
            messageLabel.Text = "Bye pressed";
        }

        private void rightButton_Click(object sender, EventArgs e)
        {
            messageLabel.Text = "Far Rightwing pressed";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            messageLabel.Text = " ";
        }
    }
}
