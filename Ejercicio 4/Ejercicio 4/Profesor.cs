using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4
{
    internal class Profesor:Personas
    {
        string tipodocente { get; set; }

        List<Profesor> Profesores = new List<Profesor>();
    }
}
