using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodologiasTP4
{
    public class DecoradorEstado : AlumnoDecorator
    {
        public DecoradorEstado(IAlumno alumno) : base(alumno)
        {
        }

        public override string mostrarCalificacion()
        {
            if (this.alumnoAdicional.getCalificacion() >= 7)
            {
                return base.mostrarCalificacion() + " (PROMOCIONADO)";
            }
            else if (this.alumnoAdicional.getCalificacion() >= 4)
            {
                return base.mostrarCalificacion() + " (APROBADO)";
            }
            else
            {
                return base.mostrarCalificacion() + " (DESAPROBADO)";
            }
        }

    }
}
