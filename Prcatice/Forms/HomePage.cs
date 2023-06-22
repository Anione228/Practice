﻿using Prcatice.DTO;
using Prcatice.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomePage
{
   
    public partial class HomeForm : Form
    {
        private HomeThemeDTO themehDTO;
        public HomeForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(26, 24, 58);
            themehDTO = new HomeThemeDTO
            {
                Hello = labelHome,
                Name = labelName,
            };

         
        }
    }
}
