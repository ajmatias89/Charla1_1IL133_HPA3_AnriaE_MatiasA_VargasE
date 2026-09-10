using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Escenario1
{
    public partial class frmEscenario1 : Form
    {
        public frmEscenario1()
        {
            InitializeComponent();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                int edad = int.Parse(txtEdad.Text);
                lblResultado.Text = "Su edad es: " + edad.ToString();
            }
            catch(FormatException)
            {
                MessageBox.Show("Por favor, solamente ingrese números enteros en el campo de edad");
            }
            catch(OverflowException)
            {
                MessageBox.Show("El número ingresado para la edad es demasiado grande");
            }
        }
    }
}
