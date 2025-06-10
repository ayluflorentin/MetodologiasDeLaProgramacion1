using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodologiasTP5
{
    public class AlumnoMuyEstudioso : Alumno
    {

        public AlumnoMuyEstudioso(String nombre, Numero dni, Numero legajo, double promedio, int calificacion) : base(nombre, dni, legajo, promedio, calificacion)
        {
        }

        public override int responderPregunta(int pregunta)
        {
            return pregunta % 3; // Modulo
        }

    }
}
