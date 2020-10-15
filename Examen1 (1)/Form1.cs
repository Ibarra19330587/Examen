using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int incrementar = int.Parse(textBox1.Text);
            incrementar++;
            textBox1.Text = incrementar.ToString();
                if (incrementar >=25)
                {
                    MessageBox.Show("ya llego al maximo numero de datos a generar");
                }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int incrementar = int.Parse(textBox1.Text);
            incrementar--;
            textBox1.Text = incrementar.ToString();
            if (incrementar <= 0)
            {
                MessageBox.Show("no se puede borrar mas, ya llego al tope");
            }
        }
    }
}
