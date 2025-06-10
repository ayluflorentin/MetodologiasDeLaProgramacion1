using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodologiasTP5
{
    public class DecoratorAsteriscos : AlumnoDecorator
    {
        public DecoratorAsteriscos(IAlumno alumno) : base(alumno)
        {
        }

        public override string mostrarCalificacion()
        {
            string contenidoSinFormato = base.mostrarCalificacion();
            int largoTotal = 60;
            int espaciosLibres = largoTotal - 2 - contenidoSinFormato.Length;

            int espaciosIzquierda = espaciosLibres / 2;
            int espaciosDerecha = espaciosLibres - espaciosIzquierda;

            string contenidoFormateado = "*" + new string(' ', espaciosIzquierda) + contenidoSinFormato + new string(' ', espaciosDerecha) + "*";
            string borde = new string('*', largoTotal);

            return borde + "\n" + contenidoFormateado + "\n" + borde;
        }

    }
}
