using Prcatice;
using Prcatice.Helpers;
using System;
using System.Windows.Forms;

namespace distance
{
    public partial class Distance : Form
    {
        public Distance()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        { int R = 6371;
            //double m = 0,621371;

            double T1S, T2S, T1D, T2D, Result;
            T1S = Convert.ToDouble(textBox1.Text);
            T2S = Convert.ToDouble(textBox4.Text);
            T1D = Convert.ToDouble(textBox2.Text);
            T2D = Convert.ToDouble(textBox3.Text);

            if (T1S > 180 || T2S > 180 || T1D > 180 || T2D > 180)
                MessageBox.Show("Err");
            else //переводим в радианы
                T1S = (T1S * Math.PI) / 180.0;
            T2S = (T2S * Math.PI) / 180.0;
            T1D = (T1D * Math.PI) / 180.0;
            T2D = (T2D * Math.PI) / 180.0;

            if (radioButton2.Checked)
                T1S = T1S * (-1.0);
            if (radioButton6.Checked)
                T1D = T1D * (-1.0);
            if (radioButton4.Checked)
                T2S = T2S * (-1.0);
            if (radioButton8.Checked)
                T2D = T2D * (-1.0);



            Result = (Math.Sin(T1S) * Math.Sin(T2S)) + (Math.Cos(T1S) * Math.Cos(T2S) * Math.Cos(T1D - T2D));

            Result = Math.Cos(Result);
            // Form2 op = new Form2();
            if (FormDataValues.radioButtonKm == true)
                label5.Text = ($"Расстояние между городами - {Result * R:f} км");
            else
            if (FormDataValues.radioButtonFt == true)
                label5.Text = ($"Расстояние между городами - {Result * R * 0.621371:f} миль");
            else
                label5.Text = ("Choose Unit in Options");
           

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Controls.Add(radioButton2);

            groupBox2.Controls.Add(radioButton5);
            groupBox2.Controls.Add(radioButton6);
            //группа 3
            groupBox3.Controls.Add(radioButton3);
            groupBox3.Controls.Add(radioButton4);
            //groupBox3.Controls.Add(textBox4);
            //groupBox3.Controls.Add(label3);

            groupBox4.Controls.Add(radioButton7);
            groupBox4.Controls.Add(radioButton8);
            //this.BackColor = Color.FromArgb(26, 24, 58);
            radioButton1.Checked = true;
            radioButton3.Checked = true;
            radioButton5.Checked = true;
            radioButton7.Checked = true;
            

        }

    }
}
