using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Juego_Gestion
{
    public partial class Form1 : Form
    {
        int Sueldos=0;
        int productividad = 0;

        public Form1()
        {
            InitializeComponent();
            //Inicio ventIni = new Inicio();
            //ventIni.Show();
            ///this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 ventana = new Form2();
            ventana.Show();
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked==true) {
                Sueldos = Sueldos + 1000;
                productividad = productividad + 3;
            }
            else
            {
                Sueldos = Sueldos - 1000;
                productividad = productividad - 3;
            }
            textBox1.Text = Sueldos+"";
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                Sueldos = Sueldos + 1000;
                productividad = productividad + 3;
            }
            else
            {
                Sueldos = Sueldos - 1000;
                productividad = productividad - 3;
            }
            textBox1.Text = Sueldos + "";
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                Sueldos = Sueldos + 100;
                productividad = productividad + 1;
            }
            else
            {
                Sueldos = Sueldos - 100;
                productividad = productividad - 1;
            }
            textBox1.Text = Sueldos + "";
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true)
            {
                Sueldos = Sueldos + 100;
                productividad = productividad + 1;
            }
            else
            {
                Sueldos = Sueldos - 100;
                productividad = productividad - 1;
            }
            textBox1.Text = Sueldos + "";
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked == true)
            {
                Sueldos = Sueldos + 1000;
                productividad = productividad + 3;
            }
            else
            {
                Sueldos = Sueldos - 1000;
                productividad = productividad - 3;
            }
            textBox1.Text = Sueldos + "";
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked == true)
            {
                Sueldos = Sueldos + 100;
                productividad = productividad + 1;
            }
            else
            {
                Sueldos = Sueldos - 100;
                productividad = productividad - 1;
            }
            textBox1.Text = Sueldos + "";
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox7.Checked == true)
            {
                Sueldos = Sueldos + 300;
                productividad = productividad + 2;
            }
            else
            {
                Sueldos = Sueldos - 300;
                productividad = productividad - 2;
            }
            textBox1.Text = Sueldos + "";
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox8.Checked == true)
            {
                Sueldos = Sueldos + 300;
                productividad = productividad + 2;
            }
            else
            {
                Sueldos = Sueldos - 300;
                productividad = productividad - 2;
            }
            textBox1.Text = Sueldos + "";
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox9.Checked == true)
            {
                Sueldos = Sueldos + 100;
                productividad = productividad + 1;
            }
            else
            {
                Sueldos = Sueldos - 100;
                productividad = productividad - 1;
            }
            textBox1.Text = Sueldos + "";
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox10.Checked == true)
            {
                Sueldos = Sueldos + 1000;
                productividad = productividad + 3;
            }
            else
            {
                Sueldos = Sueldos - 1000;
                productividad = productividad - 3;
            }
            textBox1.Text = Sueldos + "";
        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox11.Checked == true)
            {
                Sueldos = Sueldos + 100;
                productividad = productividad + 1;
            }
            else
            {
                Sueldos = Sueldos - 100;
                productividad = productividad - 1;
            }
            textBox1.Text = Sueldos + "";
        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                Sueldos = Sueldos + 300;
                productividad = productividad + 2;
            }
            else
            {
                Sueldos = Sueldos - 300;
                productividad = productividad - 2;
            }
            textBox1.Text = Sueldos + "";
        }
    }
}
