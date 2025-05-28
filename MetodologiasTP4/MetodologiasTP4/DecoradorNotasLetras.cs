using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodologiasTP4
{
    public class DecoradorNotaLetras : AlumnoDecorator
    {
        public DecoradorNotaLetras(IAlumno alumno) : base(alumno)
        {
        }

        public override string mostrarCalificacion()
        {
            string[] notas = { "CERO", "UNO", "DOS", "TRES", "CUATRO", "CINCO", "SEIS", "SIETE", "OCHO", "NUEVE", "DIEZ" };
            string nota = notas[alumnoAdicional.getCalificacion()];

            return base.mostrarCalificacion() + " (" + nota + ")";
        }

    }
}
