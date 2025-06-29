﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodologiasTP5
{
    public interface IAlumno : Comparable
    {

        Numero getLegajo();

        string getNombre();

        Numero getDNI();

        double getPromedio();

        int getCalificacion();

        void setCalificacion(int calificacion);

        void setEstrategia(IComparador estrategia);

        IComparador getEstrategia();

        void prestarAtencion();

        void distraerse();

        void actualizar(Observado o);

        int responderPregunta(int pregunta);

        string mostrarCalificacion();




    }
}
