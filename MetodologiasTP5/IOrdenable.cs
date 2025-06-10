using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodologiasTP5
{
    // Ordenable = puede recibir ordenes
    public interface Ordenable
    {
        void setOrdenInicio(OrdenAula1 O);
        void setOrdenLlegada(OrdenAula2 O);
        void setOrdenAulaLlena(OrdenAula1 O);
    }
}
