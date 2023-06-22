using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using distance;
using FontAwesome.Sharp;
using HomePage;
//Добавть выделение подпунктов!!!!!!!!
namespace Prcatice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            HomeForm Home = new HomeForm();
            Distance Distan = new Distance();
            Form2 Opti = new Form2();
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
            Distance Distan = new Distance();
            Form2 Opti = new Form2();
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
    }
}
