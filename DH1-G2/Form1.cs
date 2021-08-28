using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DH1_G2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ///
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void rbtnSubGerente_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            ////variables
            string Nombre = txtNombre.Text;
            string Apellido = txtApellido.Text;
            double sueldo = Convert.ToDouble(txtSalBruto.Text);
            double Descuento, salarioNeto;

            ///Selecciones radioButtons
            //////Seleccion Gerente
            if (rbtnGerente.Checked == true)
            {
                Descuento = sueldo * 0.25;
                salarioNeto = sueldo - Descuento;

            }
            if (rbtnSubGerente.Checked == true)
            {
                Descuento = sueldo * 0.15;
                salarioNeto = sueldo - Descuento;

            }
            if (rbtnSecretaria.Checked == true)
            {
                Descuento = sueldo * 0.05;
                salarioNeto = sueldo - Descuento;

            }
        }
    }
}
