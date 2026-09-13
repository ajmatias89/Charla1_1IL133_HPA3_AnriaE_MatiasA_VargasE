using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace CharlaEscenario2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtCedula_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCedula_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void txtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) &&
            e.KeyChar != (char)Keys.Back &&
            e.KeyChar != 'E' &&
            e.KeyChar != 'P' &&
            e.KeyChar != 'N' &&
            e.KeyChar != '-')
            {
                e.Handled = true;
            }
        }

        private void txtCalificacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) &&
             e.KeyChar != '.' &&
             e.KeyChar != ',' &&
             e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                errorProvider1.Clear();
                // Bloque de validaciones de llenado de datos
                if (string.IsNullOrEmpty(txtNombre.Text))
                {
                    errorProvider1.SetError(txtNombre, "El nombre no puede estar vacio.");
                    return;
                }
                if (string.IsNullOrEmpty(txtApellido.Text))
                {
                    errorProvider1.SetError(txtApellido, "El Apellido no puede estar vacio.");
                    return;
                }
                if (string.IsNullOrEmpty(txtCedula.Text))
                {
                    errorProvider1.SetError(txtCedula, "La cedula no puede estar vacia.");
                    return;
                }
                if (string.IsNullOrEmpty(txtCalificacion.Text))
                {
                    errorProvider1.SetError(txtCalificacion, "Debe ingresar la calificacion para continuar");
                    return;
                }
                //Fin de validaciones de llenado de datos

                //Inicio de validaciones de formato y rango de datos ingresados

                double calificacion = Convert.ToDouble(txtCalificacion.Text.Replace(',', '.'));
                if (calificacion < 0 || calificacion > 100)
                {
                    throw new CalificacionInvalidaException();
                }
                //Confirmacion final de Success
                MessageBox.Show("Se he registrado exitosamente la nota del estudiante."
                    + "\n Estudiante: " + txtNombre.Text + " " + txtApellido.Text
                    + "\n Cédula: "+txtCedula.Text
                    + "\n Calificación: "+calificacion,
                    "Registro exitoso",MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                    );
            }catch(CalificacionInvalidaException ex)
            {
                errorProvider1.SetError(txtCalificacion,ex.Message);
               MessageBox.Show(ex.Message, "Calificacion invalida",MessageBoxButtons.OK,MessageBoxIcon.Warning );
            }
            catch (FormatException)
            {
                MessageBox.Show(
           "Uno de los datos ingresados tiene un formato incorrecto.",
           "Error de formato",
           MessageBoxButtons.OK,
           MessageBoxIcon.Error
            );
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error inesperado: \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                txtNombre.Focus();
            }
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cerrando el proograma", "Cerrando", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            this.Close();
        }
    }
}
