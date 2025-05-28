using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodologiasTP4
{
    public class GeneradorDeDatosAleatorios
    {

        private static Random random = new Random();

        public GeneradorDeDatosAleatorios()
        {

        }


        public int numeroAleatorio(int max)
        {
            return random.Next(0, max);
        }

        public double doubleAleatorio(double max)
        {
            return Math.Round(random.NextDouble() * max, 1);
        }

        public string stringAleatorio(int cant = 5)
        {
            const string alfabeto = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            StringBuilder token = new StringBuilder();

            for (int i = 0; i < cant; i++)
            {
                int indice = random.Next(alfabeto.Length);
                token.Append(alfabeto[indice]);
            }

            return token.ToString();
        }


        // Nuevo metodo para generar nombres aleatorios (mas completo)
        public string nombreAleatorio()
        {
            string[] nombres = { "Aylén", "Juan Cruz", "Ana", "Maitena", "Agustina", "Felipe", "Leon", "Ignacio", "Loana", "Dante" };
            string[] apellidos = { "Florentin", "Hurtado", "Farran", "Bustos", "Villagra", "Pinolli", "Gigliotti", "Morel", "Medina", "Mendoza" };
            
            string nombre = nombres[numeroAleatorio(nombres.Length)];
            string apellido = apellidos[numeroAleatorio(apellidos.Length)];

            return nombre + " " + apellido;
        }

    }
}
