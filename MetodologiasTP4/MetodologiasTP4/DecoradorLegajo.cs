using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodologiasTP4
{
    public class DecoradorLegajo : AlumnoDecorator
    {
        public DecoradorLegajo(IAlumno alumno) : base(alumno)
        {
        }

        public override string mostrarCalificacion()
        {
            string legajo = " (" + this.alumnoAdicional.getLegajo().ToString() + ")";
            string resultadoBase = base.mostrarCalificacion();

            int espacioIndex = resultadoBase.IndexOf(',');
            string resultadoConLegajo = resultadoBase.Insert(espacioIndex, legajo);

            return resultadoConLegajo;
        }

    }
}
