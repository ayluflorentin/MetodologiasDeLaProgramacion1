using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodologiasTP4
{
    public interface IComparador
    {
        bool sosIgual(IAlumno A, IAlumno B);
        bool sosMenor(IAlumno A, IAlumno B);
        bool sosMayor(IAlumno A, IAlumno B);
    }

}
