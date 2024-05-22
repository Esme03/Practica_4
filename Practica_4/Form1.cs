using System;
using System.Windows.Forms;

namespace Practica_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime fechaNacimiento = Fechadenacimiento.Value;
            int años = System.DateTime.Now.Year - fechaNacimiento.Year;

            if 
                (System.DateTime.Now.Subtract(fechaNacimiento.AddYears(años)).TotalDays < 0)
                lblEdad.Text = Convert.ToString(años = 1);
            
            else
            {
                lblEdad.Text = Convert.ToString(años);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            lblEdad.Text = "";
        }

    }
}
