﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hello
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent(); //INIT  
            //Release v10.87.
            //
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("HelloWorld 23334 ");//DEV2
            //hotfix ok
            //develop test
            //develop ok
            //DEV111222223333
            //444
            //5
            //6
            //RELA
            //DEV19
            //DEV19111
            //TEST18
            //test19
            //TEST9
            //TTTT00
            //1111111
            //WYM
            //5.10   5.11
        }


        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.Yellow;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
        }
    }
}
