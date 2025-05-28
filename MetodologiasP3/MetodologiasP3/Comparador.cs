using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodologiasP3
{
    public interface IComparador
    {
        bool SosIgual(Comparable a, Comparable b);
        bool SosMayor(Comparable a, Comparable b);
        bool SosMenor(Comparable a, Comparable b);
    }
}
