using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodologiasTP5
{
    public class OrdendeInicio : OrdenAula1
    {
        private Aula aula;

        public OrdendeInicio(Aula aula)
        {
            this.aula = aula;
        }

        // Implemento interfaz
        public void ejecutar()
        {
            this.aula.comenzar();
        }
    }
}
