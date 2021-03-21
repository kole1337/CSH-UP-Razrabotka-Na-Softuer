﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Painter
{
    public partial class Form1 : Form
    {
        bool shouldPaint = false;
        public Form1()
        {
            InitializeComponent();
        }

 
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            shouldPaint = true;
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            shouldPaint = false;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (shouldPaint)
            {
                using (Graphics graphics = CreateGraphics() )
                {
                    graphics.FillEllipse(
                        new SolidBrush(Color.Red), e.X, e.Y, 4, 4);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}