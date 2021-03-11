
namespace groupboxesandpanels
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
            this.groupbox1 = new System.Windows.Forms.GroupBox();
            this.bye_button = new System.Windows.Forms.Button();
            this.hi_button = new System.Windows.Forms.Button();
            this.rightButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.messageLabel = new System.Windows.Forms.Label();
            this.leftButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupbox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupbox1
            // 
            this.groupbox1.Controls.Add(this.bye_button);
            this.groupbox1.Controls.Add(this.hi_button);
            this.groupbox1.Location = new System.Drawing.Point(87, 12);
            this.groupbox1.Name = "groupbox1";
            this.groupbox1.Size = new System.Drawing.Size(207, 76);
            this.groupbox1.TabIndex = 0;
            this.groupbox1.TabStop = false;
            this.groupbox1.Text = "Main GroupBox";
            this.groupbox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // bye_button
            // 
            this.bye_button.Location = new System.Drawing.Point(132, 22);
            this.bye_button.Name = "bye_button";
            this.bye_button.Size = new System.Drawing.Size(69, 29);
            this.bye_button.TabIndex = 2;
            this.bye_button.Text = "Bye";
            this.bye_button.UseVisualStyleBackColor = true;
            this.bye_button.Click += new System.EventHandler(this.bye_button_Click);
            // 
            // hi_button
            // 
            this.hi_button.Location = new System.Drawing.Point(6, 22);
            this.hi_button.Name = "hi_button";
            this.hi_button.Size = new System.Drawing.Size(69, 29);
            this.hi_button.TabIndex = 1;
            this.hi_button.Text = "Hi";
            this.hi_button.UseVisualStyleBackColor = true;
            this.hi_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // rightButton
            // 
            this.rightButton.Location = new System.Drawing.Point(172, 15);
            this.rightButton.Name = "rightButton";
            this.rightButton.Size = new System.Drawing.Size(68, 25);
            this.rightButton.TabIndex = 0;
            this.rightButton.Text = "Far Righwing";
            this.rightButton.UseVisualStyleBackColor = true;
            this.rightButton.UseWaitCursor = true;
            this.rightButton.Click += new System.EventHandler(this.rightButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-787, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // messageLabel
            // 
            this.messageLabel.AutoSize = true;
            this.messageLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.messageLabel.Location = new System.Drawing.Point(157, 222);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(68, 30);
            this.messageLabel.TabIndex = 3;
            this.messageLabel.Text = "label2";
            this.messageLabel.Click += new System.EventHandler(this.messageLabel_Click);
            // 
            // leftButton
            // 
            this.leftButton.Location = new System.Drawing.Point(-1, 15);
            this.leftButton.Name = "leftButton";
            this.leftButton.Size = new System.Drawing.Size(68, 25);
            this.leftButton.TabIndex = 2;
            this.leftButton.Text = "Far Leftist";
            this.leftButton.UseVisualStyleBackColor = true;
            this.leftButton.UseWaitCursor = true;
            this.leftButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.leftButton);
            this.panel1.Controls.Add(this.rightButton);
            this.panel1.Location = new System.Drawing.Point(87, 117);
            this.panel1.Name = "panel1";
            this.panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panel1.Size = new System.Drawing.Size(207, 86);
            this.panel1.TabIndex = 1;
            this.panel1.UseWaitCursor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 283);
            this.Controls.Add(this.messageLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupbox1);
            this.Name = "Form1";
            this.Text = "GroupBox and Panel";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupbox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupbox1;
        private System.Windows.Forms.Button hi_button;
        private System.Windows.Forms.Button bye_button;
        private System.Windows.Forms.Button rightButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label messageLabel;
        private System.Windows.Forms.Button leftButton;
        private System.Windows.Forms.Panel panel1;
    }
}

