using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodologiasP2
{
    public class CompararPorPromedio : IComparador
    {
        public bool SosIgual(Comparable a, Comparable b)
        {
            Alumno alumno1 = (Alumno)a;
            Alumno alumno2 = (Alumno)b;
            return alumno1.getPromedio().sosIgual(alumno2.getPromedio());
        }

        public bool SosMayor(Comparable a, Comparable b)
        {
            Alumno alumno1 = (Alumno)a;
            Alumno alumno2 = (Alumno)b;
            return alumno1.getPromedio().sosMayor(alumno2.getPromedio());
        }

        public bool SosMenor(Comparable a, Comparable b)
        {
            Alumno alumno1 = (Alumno)a;
            Alumno alumno2 = (Alumno)b;
            return alumno1.getPromedio().sosMenor(alumno2.getPromedio());
        }
    }
}
