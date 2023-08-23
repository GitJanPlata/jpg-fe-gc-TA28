using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    public interface Entregable
    {
        void entregar();
        void devolver();
        bool isEntregado();
        int compareTo(Object a);
    }
}
