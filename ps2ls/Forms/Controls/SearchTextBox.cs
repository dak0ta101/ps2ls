﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace ps2ls.Forms.Controls
{
    public class SearchTextBox : TextBox
    {
        private Timer timer = new Timer();
        public event EventHandler CustomTextChanged;

        public SearchTextBox()
        {
            timer.Interval = 500;
            timer.Tick += new EventHandler(timer_Tick);
            TextChanged += new EventHandler(CustomSearchTextBox_TextChanged);
        }

        private void timer_Tick(object sender, EventArgs args)
        {
            if (Text.Length > 0)
                BackColor = Color.Yellow;
            else
                BackColor = Color.White;

            if(CustomTextChanged != null)
                CustomTextChanged(sender, args);

            timer.Stop();
        }

        private void CustomSearchTextBox_TextChanged(object sender, EventArgs args)
        {
            timer.Stop();
            timer.Start();
        }
    }
}