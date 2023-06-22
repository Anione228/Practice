using Prcatice.DTO;
using Prcatice.Helpers;
using Prcatice.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prcatice.Forms
{
    public partial class FaQ : Form
    {
        public FaQ()
        {
            InitializeComponent();
        }

        private void FaQ_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(26, 24, 58);
            var themes = new Themes();
            var themeDTO = new FaQThemeDTO
            {
                FaQLabel = labelFaQ
            };
            if (FormDataValues.radioButtonLight)
            {
                themes.ChangeLightTheme(themeDTO);
                this.BackColor = Color.White;
            }
            else themes.ChangeDarkTheme(themeDTO);
        }
    }
}
