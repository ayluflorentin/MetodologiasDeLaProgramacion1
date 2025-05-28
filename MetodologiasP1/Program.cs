using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodologiasP1
{
    class Program
    {
        // creo un random para usar luego
        private static Random random = new Random();

        public static void Main(string[] args)
        {
            Pila pila = new Pila();
            Cola cola = new Cola();
            ColeccionMultiple multiple = new ColeccionMultiple(pila, cola);

            //llenar(pila);
            //llenar(cola);

            llenarAlumnos(pila);
            llenarAlumnos(cola);

            //Console.WriteLine("Informe Pila: ");
            //informar(pila);
            //Console.WriteLine("Informe Cola: ");
            //informar(cola);
            //Console.WriteLine("Informe Colección múltiple: ");

            informarAlumnos(multiple);

            Console.ReadKey();
        }

        // Funciones
        public static void llenar(Coleccionable coleccionable)
        {
            for (int i = 0; i < 20; i++)
            {
                Comparable comparable = new Numero(random.Next(1, 51)); // Aleatorio del 1 al 50
                coleccionable.agregar(comparable);
            }
        }

        public static void informar(Coleccionable coleccionable)
        {
            Console.WriteLine("Cantidad: " + coleccionable.cuantos().ToString());
            Console.WriteLine("Mínimo: " + coleccionable.minimo().ToString());
            Console.WriteLine("Máximo: " + coleccionable.maximo().ToString());
            Console.Write("Ingresar número: ");

            try
            {

                int valorBuscado = int.Parse(Console.ReadLine());
                Numero comparableBuscado = new Numero(valorBuscado);

                if (coleccionable.contiene(comparableBuscado))
                {
                    Console.WriteLine("El elemento está en la colección");
                }
                else
                {
                    Console.WriteLine("El elemento leído no está en la colección");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("El valor ingresado no es un número válido.");
            }
        }


        public static void llenarAlumnos(Coleccionable coleccionable)
        {
            for (int i = 0; i < 20; i++)
            {
                string nombre = generarNombre(); // Funcion para generar nombres aleatorios.
                Numero dni = new Numero(random.Next(10000000, 99999999));
                Numero legajo = new Numero(random.Next(10000, 99999));
                Numero promedio = new Numero(random.Next(1, 11));

                Comparable alumno = new Alumno(nombre, dni, legajo, promedio);
                coleccionable.agregar(alumno);
            }
        }

        public static String generarNombre()
        {
            string[] nombres = { "Aylén", "Juan Cruz", "Ana", "Maitena", "Agustina", "Felipe", "Leon", "Ignacio", "Loana", "Dante" };
            string[] apellidos = { "Florentin", "Hurtado", "Farran", "Bustos", "Villagra", "Pinolli", "Gigliotti", "Morel", "Medina", "Mendoza" };

            return nombres[random.Next(0, nombres.Length)] + " " + apellidos[random.Next(0, apellidos.Length)];
        }
        public static void informarAlumnos(Coleccionable coleccionable)
        {
            Console.WriteLine("Cantidad: " + coleccionable.cuantos().ToString());
            Console.WriteLine("Mínimo: " + coleccionable.minimo().ToString());
            Console.WriteLine("Máximo: " + coleccionable.maximo().ToString());

            Console.Write("Ingrese legajo a buscar: ");
            try
            {
                int legajoBuscado = int.Parse(Console.ReadLine());
                Alumno alumnoBuscado = new Alumno("Generico", new Numero(0), new Numero(legajoBuscado), new Numero(0));

                if (coleccionable.contiene(alumnoBuscado))
                {
                    Console.WriteLine("El alumno está en la colección");
                }
                else
                {
                    Console.WriteLine("El alumno no está en la colección");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("El valor ingresado no es un número válido.");
            }
        }
    }
}
