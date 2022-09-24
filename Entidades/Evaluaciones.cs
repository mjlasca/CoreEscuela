using System;

namespace CoreEscuela.Entidades
{
    public class Evaluaciones
    {
        public string UniqueId {get; private set;} = Guid.NewGuid().ToString();
        public string Nombre { get; set; }
        public Alumno Alumno {get;set;}
        public Asignatura Asignatura {get; set;}
        public float Nota {get; set;}

                
    }
}