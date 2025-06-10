using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodologiasTP5
{
    public class OrdenAulaLlena : OrdenAula1
    {
        private Aula aula;
        public OrdenAulaLlena(Aula aula)
        {
            this.aula = aula;
        }

        // interfaz
        public void ejecutar()
        {
            this.aula.claseLista();
        }

    }
}
