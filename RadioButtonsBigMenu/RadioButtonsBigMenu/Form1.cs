using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RadioButtonsBigMenu
{
    public partial class Form1 : Form
    {
        private MessageBoxIcon iconType;
        private MessageBoxButtons buttonType;
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            buttonType = MessageBoxButtons.YesNoCancel;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            buttonType = MessageBoxButtons.YesNo;
        }

        private void radioOK_CheckedChanged(object sender, EventArgs e)
        {
            buttonType = MessageBoxButtons.OK;
        }

        private void radioOKCANCEL_CheckedChanged(object sender, EventArgs e)
        {
            buttonType = MessageBoxButtons.OKCancel;
        }

        private void radioARI_CheckedChanged(object sender, EventArgs e)
        {
            buttonType = MessageBoxButtons.AbortRetryIgnore;
        }

        private void radioRC_CheckedChanged(object sender, EventArgs e)
        {
            buttonType = MessageBoxButtons.RetryCancel;
        }

        private void radioAsterisk_CheckedChanged(object sender, EventArgs e)
        {
            iconType = MessageBoxIcon.Asterisk;
        }

        private void radioError_CheckedChanged(object sender, EventArgs e)
        {
            iconType = MessageBoxIcon.Error;
        }

        private void radioExclamation_CheckedChanged(object sender, EventArgs e)
        {
            iconType = MessageBoxIcon.Exclamation;
        }

        private void radioHand_CheckedChanged(object sender, EventArgs e)
        {
            iconType = MessageBoxIcon.Hand;
        }

        private void radioInformation_CheckedChanged(object sender, EventArgs e)
        {
            iconType = MessageBoxIcon.Information;
        }

        private void radioQuestion_CheckedChanged(object sender, EventArgs e)
        {
            iconType = MessageBoxIcon.Question;
        }

        private void radioStop_CheckedChanged(object sender, EventArgs e)
        {
            iconType = MessageBoxIcon.Stop;
        }

        private void Warning_CheckedChanged(object sender, EventArgs e)
        {
            iconType = MessageBoxIcon.Warning;
        }

        private void displayButton_Click(object sender, EventArgs e)
        {
            DialogResult result =  MessageBox.Show("This is random message", "RandomMessageDeliverinator", buttonType, iconType);
            
            switch (result)
            {
                case DialogResult.OK:
                    textAction.Text = "OK was pressed";
                    break;
                case DialogResult.Cancel:
                    textAction.Text = "Cancel was pressed";
                    break;
                case DialogResult.Abort:
                    textAction.Text = "Abort was pressed";
                    break;
                case DialogResult.Retry:
                    textAction.Text = "Retry was pressed";
                    break;
                case DialogResult.Ignore:
                    textAction.Text = "Ignore was pressed";
                    break;
                case DialogResult.Yes:
                    textAction.Text = "Yes was pressed";
                    break;
                case DialogResult.No:
                    textAction.Text = "No was pressed";
                    break;
            }
        }
    }
}
