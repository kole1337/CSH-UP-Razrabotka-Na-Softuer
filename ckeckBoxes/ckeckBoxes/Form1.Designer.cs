
namespace ckeckBoxes
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
            this.italicBox = new System.Windows.Forms.RadioButton();
            this.boldBox = new System.Windows.Forms.RadioButton();
            this.outputLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // italicBox
            // 
            this.italicBox.AutoSize = true;
            this.italicBox.Location = new System.Drawing.Point(31, 86);
            this.italicBox.Name = "italicBox";
            this.italicBox.Size = new System.Drawing.Size(50, 19);
            this.italicBox.TabIndex = 1;
            this.italicBox.TabStop = true;
            this.italicBox.Text = "Italic";
            this.italicBox.UseVisualStyleBackColor = true;
            this.italicBox.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // boldBox
            // 
            this.boldBox.AutoSize = true;
            this.boldBox.Location = new System.Drawing.Point(190, 86);
            this.boldBox.Name = "boldBox";
            this.boldBox.Size = new System.Drawing.Size(49, 19);
            this.boldBox.TabIndex = 2;
            this.boldBox.TabStop = true;
            this.boldBox.Text = "Bold";
            this.boldBox.UseVisualStyleBackColor = true;
            this.boldBox.CheckedChanged += new System.EventHandler(this.boldBox_CheckedChanged);
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.Location = new System.Drawing.Point(58, 26);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(157, 15);
            this.outputLabel.TabIndex = 3;
            this.outputLabel.Text = "Watch how the text changes";
            this.outputLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 136);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.boldBox);
            this.Controls.Add(this.italicBox);
            this.Name = "Form1";
            this.Text = "CheckBoxes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton italicBox;
        private System.Windows.Forms.RadioButton boldBox;
        private System.Windows.Forms.Label outputLabel;
    }
}

