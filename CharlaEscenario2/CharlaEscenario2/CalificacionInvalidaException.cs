using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharlaEscenario2
{
    public class CalificacionInvalidaException : Exception
    {
        public CalificacionInvalidaException()
            : base("La calificación debe estar entre 0 y 100.")
        {
        }
    }
}
