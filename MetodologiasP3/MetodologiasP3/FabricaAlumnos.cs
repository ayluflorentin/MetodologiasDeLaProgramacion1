﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodologiasP3
{
    public class FabricaDeAlumnos : FabricaDeComparables
    {


        // Implemento metodos abstractos
        public override Comparable crearAleatorio()
        {
            return new Alumno(
                gen.stringAleatorio(),
                new Numero(gen.numeroAleatorio(10000000)),
                new Numero(gen.numeroAleatorio(10000)),
                new Numero((int)gen.doubleAleatorio(10))
            );
        }


        public override Comparable crearPorTeclado()
        {
            return new Alumno(
                LectorDeDatos.stringPorTeclado(),
                new Numero(LectorDeDatos.numeroPorTeclado()),
                new Numero(LectorDeDatos.numeroPorTeclado()),
                new Numero((int)LectorDeDatos.doublePorTeclado())
            );
        }


    }
}
