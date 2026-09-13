using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Escenario3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            
            try
            {
                string nombre = txtNombre.Text;
                string cedula = txtCed.Text;
                string telefono = txtTel.Text;
                Verificaciones.VerificarCamposVacios(nombre, cedula, telefono);
                Verificaciones.SoloLetras(nombre);
                Verificaciones.SoloNumeros(cedula, telefono);

                MessageBox.Show("Agregado con exito");
                DGV.Rows.Add(nombre, cedula, telefono);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: "+ ex.Message);
            }


        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
