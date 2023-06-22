using Prcatice.DTO;
using Prcatice.Helpers;
using Prcatice.UI;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace HomePage
{
   
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(26, 24, 58);

            var themes = new Themes();
            var themeDTO = new HomeThemeDTO
            {
                helloText = labelHome,
                nameText = labelName,
            };
            if (FormDataValues.radioButtonLight)
            {
                themes.ChangeLightTheme(themeDTO);
                this.BackColor = Color.White;
            }
            else themes.ChangeDarkTheme(themeDTO);
        }

		private void labelHome_Click(object sender, EventArgs e)
		{

		}
	}
}
