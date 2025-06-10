using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodologiasTP5
{
    public class Aula
    {
        private Teacher teacher;


        public void comenzar()
        {
            Console.WriteLine("Comienza la clase");
            this.teacher = new Teacher();
        }

        public void nuevoAlumno(IAlumno alumno)
        {
            this.teacher.goToClass(new AlumnoAdapter(alumno));
        }

        public void claseLista()
        {
            this.teacher.teachingAClass();
        }
        public Aula()
        {
        }


    }
}
