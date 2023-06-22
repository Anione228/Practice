using System;
using System.Drawing;
using System.Windows.Forms;
using distance;
using HomePage;
//Добавть выделение подпунктов!!!!!!!!

namespace Prcatice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void HomeButton1_Click(object sender, EventArgs e)
        {
            HomeForm Home = new HomeForm();
            Home.TopLevel = false;
            Home.FormBorderStyle = FormBorderStyle.None;
            Home.Dock = DockStyle.Fill;
            panel1.Controls.Add(Home);
            Home.BringToFront();
            Home.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
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

        private void PlayButton_Click(object sender, EventArgs e)
        {
            Distance Distan = new Distance();
            Distan.TopLevel = false;
            Distan.FormBorderStyle = FormBorderStyle.None;
            Distan.Dock = DockStyle.Fill;
            panel1.Controls.Add(Distan);
            Distan.BringToFront();
            Distan.Show();
        }

        private void InfoButton_Click(object sender, EventArgs e)
        {
            
        }

        private void OptionButton_Click(object sender, EventArgs e)
        {
            Form2 Opti = new Form2();
            Opti.TopLevel = false;
            Opti.FormBorderStyle = FormBorderStyle.None;
            Opti.Dock = DockStyle.Fill;
            panel1.Controls.Add(Opti);
            Opti.BringToFront();
            Opti.Show();
        }
    }
}
