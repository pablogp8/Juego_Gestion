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
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 empleados = new Form1();
            empleados.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 banco = new Form2();
            banco.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 planVn = new Form3();
            planVn.Show();
        }
    }
}
