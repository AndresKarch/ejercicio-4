using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4
{
    public class Personas
    {
        public int codigo { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public int DNI { get; set; }
        public string localidaddeorigen { get; set; }
        public DateTime fechanacimiento { get; set; }
        public DateTime fechaingreso { get; set; }

        public List<Personas> personas = new List<Personas>();
        public virtual void cargarpersonas(int Codigo, string Nombre, string Apellido, int DNI, string LocalidadDeOrigen, DateTime FechaNacimiento, DateTime FechaIngreso, int AñoCursado)
        {
            Personas persona = new Personas();
            persona.codigo = Codigo;
            persona.nombre = Nombre;
            persona.apellido = Apellido;
            persona.localidaddeorigen = LocalidadDeOrigen;
            persona.fechanacimiento = FechaNacimiento;
            persona.fechaingreso = FechaIngreso;
            personas.Add(persona);
        }
        //Ejercicio 1:
        public List<string> NombreApellidoPersonas()
        {
            int i = 0;
            List<string> Datos = new List<string>();
            foreach (Personas persona in personas)
            {
                Datos[i]=$"{persona.nombre}-{persona.apellido}-{persona.fechaingreso}";
            }
            return Datos;
        }
    }
}
