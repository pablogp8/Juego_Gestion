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
    public partial class Form2 : Form
    {
        int Monto = 0;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Monto = Monto + 100;
            textBox1.Text = Monto + "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Monto = Monto - 100;
            textBox1.Text = Monto + "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Monto = Monto + 500;
            textBox1.Text = Monto + "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Monto = Monto - 500;
            textBox1.Text = Monto + "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Monto = Monto + 1000;
            textBox1.Text = Monto + "";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Monto = Monto - 1000;
            textBox1.Text = Monto + "";
        }
    }
}
