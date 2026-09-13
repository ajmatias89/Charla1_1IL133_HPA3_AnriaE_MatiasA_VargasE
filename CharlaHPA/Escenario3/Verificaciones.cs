using System;
using System.Text.RegularExpressions;

namespace Escenario3
{
    public static class Verificaciones
    {
        public static void VerificarCamposVacios(string nombre, string cedula, string telefono)
        {
            if( string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(cedula) ||
                   string.IsNullOrWhiteSpace(telefono))
            {
                throw new ArgumentException("Por favor, complete todos los campos.");
            }
        }

        public static void SoloNumeros(string cedula, string telefono)
        {
            string patronC = @"^[0-9-]+$";

            if(!Regex.IsMatch(cedula, patronC))
            {
                throw new ArgumentException("El campo cedula solo puede contener números.");
            }

            if(!Regex.IsMatch(telefono, patronC))
            {
                throw new ArgumentException("El campo telefono solo puede contener números.");
            }
        }

        public static void SoloLetras(string Nombre)
        {
            string patronL = @"^[a-zA-Z\s]+$";

            if (!Regex.IsMatch(Nombre, patronL))
            {
                throw new ArgumentException("El campo nombre solo puede contener letras.");
            }
        }
    }
}
