using System;
using System.Drawing;
using System.Windows.Forms;
using distance;
using HomePage;
using Prcatice.DTO;
using Prcatice.Forms;
using Prcatice.Helpers;
using Prcatice.UI;
//Добавть выделение подпунктов!!!!!!!!

namespace Prcatice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        public void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void HomeButton1_Click(object sender, EventArgs e)
        {
            HomeForm Home = new HomeForm();
            Home.TopLevel = false;
            Home.FormBorderStyle = FormBorderStyle.None;
            Home.Dock = DockStyle.Fill;
            panel1.Controls.Add(Home);
            Home.BringToFront();
            Home.Show();
           
            }

            public void Form1_Load(object sender, EventArgs e)
        {
            HomeForm Home = new HomeForm();
            Home.TopLevel = false;
            Home.FormBorderStyle = FormBorderStyle.None;
            Home.Dock = DockStyle.Fill;
            panel1.Controls.Add(Home);
            Home.BringToFront();
            Home.Show();
            panelMenu.BackColor = Color.FromArgb(31, 30, 68);

            
        }

        public void PlayButton_Click(object sender, EventArgs e)
        {
            Distance Distan = new Distance();
            Distan.TopLevel = false;
            Distan.FormBorderStyle = FormBorderStyle.None;
            Distan.Dock = DockStyle.Fill;
            panel1.Controls.Add(Distan);
            Distan.BringToFront();
            Distan.Show();
        }

        public void InfoButton_Click(object sender, EventArgs e)
        {
            FaQ Info = new FaQ();
            Info.TopLevel = false;
            Info.FormBorderStyle = FormBorderStyle.None;
            Info.Dock = DockStyle.Fill;
            panel1.Controls.Add(Info);
            Info.BringToFront();
            Info.Show();
        }

        public void OptionButton_Click(object sender, EventArgs e)
        {
            Form2 Opti = new Form2();
            Opti.TopLevel = false;
            Opti.FormBorderStyle = FormBorderStyle.None;
            Opti.Dock = DockStyle.Fill;
            panel1.Controls.Add(Opti);
            Opti.BringToFront();
            Opti.Show();
        }

        private void panelMenu_MouseMove(object sender, MouseEventArgs e) // тут колхоз получился потому что я пробовал через ссылку 
        {                                                                 //и через условия chekedchanged форма не менялась так что пока так
            
            var themes = new Themes();
            var themeDTO = new MainThemeDTO
            {
                MainPanel = panelMenu,
                playB = PlayButton,
                faqB = InfoButton,
                opB = OptionButton,
                exitB = ExitButton,
            };
            if (FormDataValues.radioButtonLight)
            {
                themes.ChangeLightTheme(themeDTO);
                panelMenu.BackColor = Color.DarkGray;
            }
            else
            {
                themes.ChangeDarkTheme(themeDTO);
                panelMenu.BackColor = Color.FromArgb(31, 30, 68);
            }
        }
    }
}
//Form1 main = new Form1();
//var themes = new Themes();
//var themeDTO = new MainThemeDTO
//{
//    MainPanel = main.panelMenu,
//    playB = main.PlayButton,
//    faqB = main.InfoButton,
//    opB = main.OptionButton,
//    exitB = main.ExitButton,
//};
//if (FormDataValues.radioButtonLight)
//{
//    themes.ChangeLightTheme(themeDTO);
//    main.panelMenu.BackColor = Color.DarkGray;
//}
//else
//{
//    themes.ChangeDarkTheme(themeDTO);
//    main.panelMenu.BackColor = Color.FromArgb(31, 30, 68);
//}