using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExcepcionesPrueba
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            int a, b, r;

            try
            {
                a = int.Parse(txtUno.Text);
                b = int.Parse(txtDos.Text);
                r = a / b;
                lblResultado.Text = r.ToString();
            }
            catch(FormatException ex)
            {
                MessageBox.Show("Ojo. Solo números.");
            }
            catch(DivideByZeroException ex)
            {
                MessageBox.Show("No se puede dividir por cero pipi");
            }
        }
    }
}
