using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodologiasP3
{
    public class IteradorDeLista : Iterador
    {
        private List<Comparable> lista;
        private int indice;

        public IteradorDeLista(List<Comparable> lista)
        {
            this.lista = lista;
            this.indice = 0;
        }

        public void primero()
        {
            indice = 0;
        }

        public void siguiente()
        {
            indice++;
        }

        public bool fin()
        {
            return indice >= lista.Count;
        }

        public Comparable actual()
        {
            return lista[indice];
        }
    }
}
