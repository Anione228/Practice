using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Prcatice.Properties;

namespace Prcatice
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
          
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(26, 24, 58);
           
            panelUnit.Controls.Add(radioButtonKm);
            panelUnit.Controls.Add(radioButtonFt);
            panelTheme.Controls.Add(radioButtonDark);
            panelTheme.Controls.Add(radioButtonLight);
           
        }

       

        private void radioButtonEn_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonDark_CheckedChanged(object sender, EventArgs e)
        {
            //Цвета Текста
            label1.ForeColor = Color.White;
            //label2.ForeColor = Color.White;
            label3.ForeColor = Color.White;
            label4.ForeColor = Color.White;
           // radioButtonEn.ForeColor = Color.White;
           // radioButtonRu.ForeColor = Color.White;
            radioButtonLight.ForeColor = Color.White;
            radioButtonDark.ForeColor = Color.White;
            radioButtonKm.ForeColor = Color.White;
            radioButtonFt.ForeColor = Color.White;
            //Цвета фона
            this.BackColor = Color.FromArgb(26, 24, 58);

        }

        private void radioButtonLight_CheckedChanged(object sender, EventArgs e)
        {
            //Цвета Текста
            label1.ForeColor = Color.Black;
           // label2.ForeColor = Color.Black;
            label3.ForeColor = Color.Black;
            label4.ForeColor = Color.Black;
           // radioButtonEn.ForeColor = Color.Black;
           // radioButtonRu.ForeColor = Color.Black;
            radioButtonLight.ForeColor = Color.Black;
            radioButtonDark.ForeColor = Color.Black;
            radioButtonKm.ForeColor = Color.Black;
            radioButtonFt.ForeColor = Color.Black;
            //Цвета фона
            this.BackColor = Color.White;
        }

       
        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.Unit = radioButtonLight.Checked;
            Properties.Settings.Default.Theme = radioButtonKm.Checked;
            Properties.Settings.Default.Save();
        }
    }
}
