﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace src.form
{
    public partial class importTB : Form
    {
        public main mainForm;
        public importTB(main main)
        {
            InitializeComponent();
            mainForm = main;
        }
    }
}
