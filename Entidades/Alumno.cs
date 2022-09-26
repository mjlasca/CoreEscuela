using System;

namespace CoreEscuela.Entidades
{
    public class Alumno
    {
        public string UniqueId {get; private set;} = Guid.NewGuid().ToString();
        public string Nombre { get; set; }
        public List<Evaluacion> Evaluaciones {get ; set;}
    }
}