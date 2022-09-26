using System;

namespace CoreEscuela.Entidades
{
    public class Evaluacion
    {
        public string UniqueId {get; private set;} = Guid.NewGuid().ToString();
        public string Nombre { get; set; }
        public Asignatura Asignatura {get; set;}
        public float Nota {get; set;}

        public Evaluacion() => UniqueId = Guid.NewGuid().ToString();

                
    }
}