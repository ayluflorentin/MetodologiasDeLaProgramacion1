using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodologiasP3
{
    public class CompararPorDNI : IComparador
    {
        public bool SosIgual(Comparable a, Comparable b)
        {
            Alumno alumno1 = (Alumno)a;
            Alumno alumno2 = (Alumno)b;
            return alumno1.getDNI().sosIgual(alumno2.getDNI());
        }

        public bool SosMayor(Comparable a, Comparable b)
        {
            Alumno alumno1 = (Alumno)a;
            Alumno alumno2 = (Alumno)b;
            return alumno1.getDNI().sosMayor(alumno2.getDNI());
        }

        public bool SosMenor(Comparable a, Comparable b)
        {
            Alumno alumno1 = (Alumno)a;
            Alumno alumno2 = (Alumno)b;
            return alumno1.getDNI().sosMenor(alumno2.getDNI());
        }
    }

}
