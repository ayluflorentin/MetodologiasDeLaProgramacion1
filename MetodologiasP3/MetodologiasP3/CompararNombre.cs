﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodologiasP3
{
    public class CompararPorNombre : IComparador
    {
        public bool SosIgual(Comparable a, Comparable b)
        {
            Alumno alumno1 = (Alumno)a;
            Alumno alumno2 = (Alumno)b;
            return alumno1.getNombre() == alumno2.getNombre();
        }

        public bool SosMayor(Comparable a, Comparable b)
        {
            Alumno alumno1 = (Alumno)a;
            Alumno alumno2 = (Alumno)b;
            return string.Compare(alumno1.getNombre(), alumno2.getNombre()) > 0;
        }

        public bool SosMenor(Comparable a, Comparable b)
        {
            Alumno alumno1 = (Alumno)a;
            Alumno alumno2 = (Alumno)b;
            return string.Compare(alumno1.getNombre(), alumno2.getNombre()) < 0;
        }
    }
}
