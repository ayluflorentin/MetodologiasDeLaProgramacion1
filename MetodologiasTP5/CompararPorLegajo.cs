using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodologiasTP5
{
    public class CompararPorLegajo : IComparador
    {
        public bool sosIgual(IAlumno alumnoA, IAlumno alumnoB)
        {
            return alumnoA.getLegajo().sosIgual(alumnoB.getLegajo());
        }

        public bool sosMenor(IAlumno alumnoA, IAlumno alumnoB)
        {
            return alumnoA.getLegajo().sosMayor(alumnoB.getLegajo());
        }

        public bool sosMayor(IAlumno alumnoA, IAlumno alumnoB)
        {
            return alumnoA.getLegajo().sosMayor(alumnoB.getLegajo());
        }

    }
}
