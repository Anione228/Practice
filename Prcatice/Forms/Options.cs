﻿using HomePage;
using Prcatice.DTO;
using Prcatice.Helpers;
using Prcatice.UI;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Prcatice
{
    public partial class Form2 : Form
    {
        private OptionsThemeDTO optionsThemeDTO;
        public Form2()
        {
            InitializeComponent();
          
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            optionsThemeDTO = new OptionsThemeDTO
            {
                optionLabel = label1,
                themeLabel = label3,
                unitLadel = label4,
                radioButtonLight = radioButtonLight,
                radioButtonDark = radioButtonDark,
                radioButtonKm = radioButtonKm,
                radioButtonFt = radioButtonFt
            };

            this.BackColor = Color.FromArgb(26, 24, 58);
           
            panelUnit.Controls.Add(radioButtonKm);
            panelUnit.Controls.Add(radioButtonFt);
            panelUnit.Controls.Add(label4);
            panelTheme.Controls.Add(radioButtonDark);
            panelTheme.Controls.Add(radioButtonLight);
            panelTheme.Controls.Add(label3);

            if (FormDataValues.radioButtonDark)
            {
                radioButtonDark_CheckedChanged(this, e);
                radioButtonDark.Checked = true;
                radioButtonLight.Checked = false;
            }
            if (FormDataValues.radioButtonLight)
            {
                radioButtonLight_CheckedChanged(this, e);
                radioButtonDark.Checked = false;
                radioButtonLight.Checked = true;
            }
            if (FormDataValues.radioButtonKm)
            {
                radioButtonKm_CheckedChanged(this, e);
                radioButtonKm.Checked = true;
                radioButtonFt.Checked = false;
            }
            if (FormDataValues.radioButtonFt)
            {
                radioButtonFt_CheckedChanged(this, e);
                radioButtonFt.Checked = true;
                radioButtonKm.Checked = false;
            }
        }

        private void radioButtonEn_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonDark_CheckedChanged(object sender, EventArgs e)
        {
            HomeForm homeP = new HomeForm();
            var themes = new Themes();
            themes.ChangeDarkTheme(optionsThemeDTO);
            homeP.BackColor = Color.FromArgb(26, 24, 58);
            this.BackColor = Color.FromArgb(26, 24, 58);
            FormDataValues.radioButtonDark = radioButtonDark.Checked;
            
        }

        private void radioButtonLight_CheckedChanged(object sender, EventArgs e)
        {
            HomeForm homeP = new HomeForm();
            var themes = new Themes();
            themes.ChangeLightTheme(optionsThemeDTO);
            this.BackColor = Color.White;
            homeP.BackColor = Color.White;
            FormDataValues.radioButtonLight = radioButtonLight.Checked;
            
        }

       
        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }

		private void radioButtonKm_CheckedChanged(object sender, EventArgs e)
		{
            FormDataValues.radioButtonKm = radioButtonKm.Checked;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButtonFt_CheckedChanged(object sender, EventArgs e)
        {
            FormDataValues.radioButtonFt = radioButtonFt.Checked;
        }

        
    }
}
