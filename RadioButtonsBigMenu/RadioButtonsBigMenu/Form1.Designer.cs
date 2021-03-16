
namespace RadioButtonsBigMenu
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioRC = new System.Windows.Forms.RadioButton();
            this.radioYN = new System.Windows.Forms.RadioButton();
            this.radioYNC = new System.Windows.Forms.RadioButton();
            this.radioARI = new System.Windows.Forms.RadioButton();
            this.radioOKCANCEL = new System.Windows.Forms.RadioButton();
            this.radioOK = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Warning = new System.Windows.Forms.RadioButton();
            this.radioStop = new System.Windows.Forms.RadioButton();
            this.radioQuestion = new System.Windows.Forms.RadioButton();
            this.radioInformation = new System.Windows.Forms.RadioButton();
            this.radioHand = new System.Windows.Forms.RadioButton();
            this.radioExclamation = new System.Windows.Forms.RadioButton();
            this.radioError = new System.Windows.Forms.RadioButton();
            this.radioAsterisk = new System.Windows.Forms.RadioButton();
            this.displayButton = new System.Windows.Forms.Button();
            this.textAction = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioRC);
            this.groupBox1.Controls.Add(this.radioYN);
            this.groupBox1.Controls.Add(this.radioYNC);
            this.groupBox1.Controls.Add(this.radioARI);
            this.groupBox1.Controls.Add(this.radioOKCANCEL);
            this.groupBox1.Controls.Add(this.radioOK);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(131, 175);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Button Type";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // radioRC
            // 
            this.radioRC.AutoSize = true;
            this.radioRC.Location = new System.Drawing.Point(7, 148);
            this.radioRC.Name = "radioRC";
            this.radioRC.Size = new System.Drawing.Size(88, 19);
            this.radioRC.TabIndex = 5;
            this.radioRC.TabStop = true;
            this.radioRC.Text = "RetryCancel";
            this.radioRC.UseVisualStyleBackColor = true;
            this.radioRC.CheckedChanged += new System.EventHandler(this.radioRC_CheckedChanged);
            // 
            // radioYN
            // 
            this.radioYN.AutoSize = true;
            this.radioYN.Location = new System.Drawing.Point(7, 123);
            this.radioYN.Name = "radioYN";
            this.radioYN.Size = new System.Drawing.Size(58, 19);
            this.radioYN.TabIndex = 4;
            this.radioYN.TabStop = true;
            this.radioYN.Text = "YesNo";
            this.radioYN.UseVisualStyleBackColor = true;
            this.radioYN.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
            // 
            // radioYNC
            // 
            this.radioYNC.AutoSize = true;
            this.radioYNC.Location = new System.Drawing.Point(7, 98);
            this.radioYNC.Name = "radioYNC";
            this.radioYNC.Size = new System.Drawing.Size(94, 19);
            this.radioYNC.TabIndex = 3;
            this.radioYNC.TabStop = true;
            this.radioYNC.Text = "YesNoCancel";
            this.radioYNC.UseVisualStyleBackColor = true;
            this.radioYNC.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // radioARI
            // 
            this.radioARI.AutoSize = true;
            this.radioARI.Location = new System.Drawing.Point(7, 73);
            this.radioARI.Name = "radioARI";
            this.radioARI.Size = new System.Drawing.Size(116, 19);
            this.radioARI.TabIndex = 2;
            this.radioARI.TabStop = true;
            this.radioARI.Text = "AbortRetryIgnore";
            this.radioARI.UseVisualStyleBackColor = true;
            this.radioARI.CheckedChanged += new System.EventHandler(this.radioARI_CheckedChanged);
            // 
            // radioOKCANCEL
            // 
            this.radioOKCANCEL.AutoSize = true;
            this.radioOKCANCEL.Location = new System.Drawing.Point(7, 48);
            this.radioOKCANCEL.Name = "radioOKCANCEL";
            this.radioOKCANCEL.Size = new System.Drawing.Size(76, 19);
            this.radioOKCANCEL.TabIndex = 1;
            this.radioOKCANCEL.TabStop = true;
            this.radioOKCANCEL.Text = "OKCancel";
            this.radioOKCANCEL.UseVisualStyleBackColor = true;
            this.radioOKCANCEL.CheckedChanged += new System.EventHandler(this.radioOKCANCEL_CheckedChanged);
            // 
            // radioOK
            // 
            this.radioOK.AutoSize = true;
            this.radioOK.Location = new System.Drawing.Point(7, 23);
            this.radioOK.Name = "radioOK";
            this.radioOK.Size = new System.Drawing.Size(41, 19);
            this.radioOK.TabIndex = 0;
            this.radioOK.TabStop = true;
            this.radioOK.Text = "OK";
            this.radioOK.UseVisualStyleBackColor = true;
            this.radioOK.CheckedChanged += new System.EventHandler(this.radioOK_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Warning);
            this.groupBox2.Controls.Add(this.radioStop);
            this.groupBox2.Controls.Add(this.radioQuestion);
            this.groupBox2.Controls.Add(this.radioInformation);
            this.groupBox2.Controls.Add(this.radioHand);
            this.groupBox2.Controls.Add(this.radioExclamation);
            this.groupBox2.Controls.Add(this.radioError);
            this.groupBox2.Controls.Add(this.radioAsterisk);
            this.groupBox2.Location = new System.Drawing.Point(149, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(124, 233);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Icon";
            // 
            // Warning
            // 
            this.Warning.AutoSize = true;
            this.Warning.Location = new System.Drawing.Point(6, 198);
            this.Warning.Name = "Warning";
            this.Warning.Size = new System.Drawing.Size(70, 19);
            this.Warning.TabIndex = 12;
            this.Warning.TabStop = true;
            this.Warning.Text = "Warning";
            this.Warning.UseVisualStyleBackColor = true;
            this.Warning.CheckedChanged += new System.EventHandler(this.Warning_CheckedChanged);
            // 
            // radioStop
            // 
            this.radioStop.AutoSize = true;
            this.radioStop.Location = new System.Drawing.Point(6, 173);
            this.radioStop.Name = "radioStop";
            this.radioStop.Size = new System.Drawing.Size(49, 19);
            this.radioStop.TabIndex = 11;
            this.radioStop.TabStop = true;
            this.radioStop.Text = "Stop";
            this.radioStop.UseVisualStyleBackColor = true;
            this.radioStop.CheckedChanged += new System.EventHandler(this.radioStop_CheckedChanged);
            // 
            // radioQuestion
            // 
            this.radioQuestion.AutoSize = true;
            this.radioQuestion.Location = new System.Drawing.Point(6, 148);
            this.radioQuestion.Name = "radioQuestion";
            this.radioQuestion.Size = new System.Drawing.Size(73, 19);
            this.radioQuestion.TabIndex = 10;
            this.radioQuestion.TabStop = true;
            this.radioQuestion.Text = "Question";
            this.radioQuestion.UseVisualStyleBackColor = true;
            this.radioQuestion.CheckedChanged += new System.EventHandler(this.radioQuestion_CheckedChanged);
            // 
            // radioInformation
            // 
            this.radioInformation.AutoSize = true;
            this.radioInformation.Location = new System.Drawing.Point(6, 123);
            this.radioInformation.Name = "radioInformation";
            this.radioInformation.Size = new System.Drawing.Size(88, 19);
            this.radioInformation.TabIndex = 9;
            this.radioInformation.TabStop = true;
            this.radioInformation.Text = "Information";
            this.radioInformation.UseVisualStyleBackColor = true;
            this.radioInformation.CheckedChanged += new System.EventHandler(this.radioInformation_CheckedChanged);
            // 
            // radioHand
            // 
            this.radioHand.AutoSize = true;
            this.radioHand.Location = new System.Drawing.Point(6, 98);
            this.radioHand.Name = "radioHand";
            this.radioHand.Size = new System.Drawing.Size(54, 19);
            this.radioHand.TabIndex = 8;
            this.radioHand.TabStop = true;
            this.radioHand.Text = "Hand";
            this.radioHand.UseVisualStyleBackColor = true;
            this.radioHand.CheckedChanged += new System.EventHandler(this.radioHand_CheckedChanged);
            // 
            // radioExclamation
            // 
            this.radioExclamation.AutoSize = true;
            this.radioExclamation.Location = new System.Drawing.Point(6, 73);
            this.radioExclamation.Name = "radioExclamation";
            this.radioExclamation.Size = new System.Drawing.Size(90, 19);
            this.radioExclamation.TabIndex = 7;
            this.radioExclamation.TabStop = true;
            this.radioExclamation.Text = "Exclamation";
            this.radioExclamation.UseVisualStyleBackColor = true;
            this.radioExclamation.CheckedChanged += new System.EventHandler(this.radioExclamation_CheckedChanged);
            // 
            // radioError
            // 
            this.radioError.AutoSize = true;
            this.radioError.Location = new System.Drawing.Point(6, 48);
            this.radioError.Name = "radioError";
            this.radioError.Size = new System.Drawing.Size(50, 19);
            this.radioError.TabIndex = 6;
            this.radioError.TabStop = true;
            this.radioError.Text = "Error";
            this.radioError.UseVisualStyleBackColor = true;
            this.radioError.CheckedChanged += new System.EventHandler(this.radioError_CheckedChanged);
            // 
            // radioAsterisk
            // 
            this.radioAsterisk.AutoSize = true;
            this.radioAsterisk.Location = new System.Drawing.Point(6, 23);
            this.radioAsterisk.Name = "radioAsterisk";
            this.radioAsterisk.Size = new System.Drawing.Size(66, 19);
            this.radioAsterisk.TabIndex = 5;
            this.radioAsterisk.TabStop = true;
            this.radioAsterisk.Text = "Asterisk";
            this.radioAsterisk.UseVisualStyleBackColor = true;
            this.radioAsterisk.CheckedChanged += new System.EventHandler(this.radioAsterisk_CheckedChanged);
            // 
            // displayButton
            // 
            this.displayButton.Location = new System.Drawing.Point(12, 193);
            this.displayButton.Name = "displayButton";
            this.displayButton.Size = new System.Drawing.Size(131, 52);
            this.displayButton.TabIndex = 2;
            this.displayButton.Text = "Display";
            this.displayButton.UseVisualStyleBackColor = true;
            this.displayButton.Click += new System.EventHandler(this.displayButton_Click);
            // 
            // textAction
            // 
            this.textAction.Location = new System.Drawing.Point(12, 251);
            this.textAction.Name = "textAction";
            this.textAction.ReadOnly = true;
            this.textAction.Size = new System.Drawing.Size(261, 23);
            this.textAction.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 290);
            this.Controls.Add(this.textAction);
            this.Controls.Add(this.displayButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Radio Buttons";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button displayButton;
        private System.Windows.Forms.TextBox textAction;
        private System.Windows.Forms.RadioButton radioRC;
        private System.Windows.Forms.RadioButton radioYN;
        private System.Windows.Forms.RadioButton radioYNC;
        private System.Windows.Forms.RadioButton radioARI;
        private System.Windows.Forms.RadioButton radioOKCANCEL;
        private System.Windows.Forms.RadioButton radioOK;
        private System.Windows.Forms.RadioButton Warning;
        private System.Windows.Forms.RadioButton radioStop;
        private System.Windows.Forms.RadioButton radioQuestion;
        private System.Windows.Forms.RadioButton radioInformation;
        private System.Windows.Forms.RadioButton radioHand;
        private System.Windows.Forms.RadioButton radioExclamation;
        private System.Windows.Forms.RadioButton radioError;
        private System.Windows.Forms.RadioButton radioAsterisk;
    }
}

