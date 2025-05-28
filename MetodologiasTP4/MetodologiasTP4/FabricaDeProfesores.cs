using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodologiasTP4
{
    public class FabricaDeProfesores : FabricaDeComparables
    {
        public override Comparable crearAleatorio()
        {
            return new Profesor(
                gen.stringAleatorio(),
                new Numero(gen.numeroAleatorio(10000000)),
                gen.numeroAleatorio(35)
            );
        }

        public override Comparable crearPorTeclado()
        {
            return new Profesor(
                LectorDeDatos.stringPorTeclado(),
                new Numero(LectorDeDatos.numeroPorTeclado()),
                LectorDeDatos.numeroPorTeclado()
            );
        }
    }
}
