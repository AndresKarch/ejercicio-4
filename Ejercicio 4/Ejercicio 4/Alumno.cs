using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4
{
    internal class Alumno : Personas
    {
        public int añocursado { get; set; }

        public override void cargarpersonas(int Codigo, string Nombre, string Apellido, int DNI, string LocalidadDeOrigen, DateTime FechaNacimiento, DateTime FechaIngreso, int AñoCursado)
        {
            base.cargarpersonas(Codigo, Nombre, Apellido, DNI, LocalidadDeOrigen, FechaNacimiento, FechaIngreso,AñoCursado);
            Alumno persona = new Alumno();
            persona.añocursado = AñoCursado;

        }
    }
}
