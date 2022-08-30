using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4
{
    internal class Inscripciones
    {
        int codigomateria { get; set; }
        int codigoprofesor { get; set; }
        int codigoalumno { get; set; }
        string tipoinscripcion { get; set; }
        DateTime fechaexmen { get; set; }
        int nota { get; set; }

        List<Inscripciones> inscripciones = new List<Inscripciones>();
        public void Cargainscripciones(int CodigoMateria, int CodigoProfesor, int CodigoAlumno, string TipoInscripcion, DateTime FechaInscripcion, int Nota)
        {
            Inscripciones inscripcion = new Inscripciones();
            inscripcion.codigomateria = CodigoMateria;
            inscripcion.codigoprofesor = CodigoProfesor;
            inscripcion.codigoalumno = CodigoAlumno;
            inscripcion.tipoinscripcion = TipoInscripcion;
            inscripcion.fechaexmen = FechaInscripcion;
            inscripcion.nota = Nota;
            inscripciones.Add(inscripcion);
        }
        public string NotaAlumno(int CodigoAlumno, int CodigoMateria)
        {
            string mensaje = "";
            DateTime Hoy = DateTime.Today;
            foreach (Inscripciones inscripcion in inscripciones)
            {
                if (inscripcion.codigoalumno == CodigoAlumno && inscripcion.codigomateria == CodigoMateria)
                {
                    if (inscripcion.fechaexmen<Hoy)
                    {
                        mensaje = (inscripcion.nota).ToString();
                    }
                    else
                    {
                        mensaje = "Examen pendiente";
                    }
                }
            }
            return mensaje;
        }
    }
}
