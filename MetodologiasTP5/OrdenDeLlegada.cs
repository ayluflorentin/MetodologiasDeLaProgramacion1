using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodologiasTP5
{
    public class OrdenLlegada : OrdenAula2
    {
        private Aula aula;
        public OrdenLlegada(Aula aula)
        {
            this.aula = aula;
        }

        // Implemento interfaz
        public void ejecutar(Comparable comp)
        {
            this.aula.nuevoAlumno((IAlumno)comp);
        }

    }
}
