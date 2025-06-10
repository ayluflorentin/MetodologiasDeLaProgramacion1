using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodologiasTP5
{
    public class FabricaDeNumeros : FabricaDeComparables
    {
        public override Comparable crearAleatorio()
        {
            return new Numero(gen.numeroAleatorio(1000));
        }

        public override Comparable crearPorTeclado()
        {
            return new Numero(LectorDeDatos.numeroPorTeclado());
        }
    }
}
