﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TEST
{
    public partial class temp : Form
    {
        public temp()
        {
            InitializeComponent();
        }

        private void temp_Load(object sender, EventArgs e)
        {
            UserControl1 userControl1 = new UserControl1();
            
            this.Controls.Add(userControl1);
        }
    }
}
