using System;

namespace CoreEscuela.Entidades
{
    public class Evaluacion : ObjetoEscuelaBase
    {
        public Asignatura Asignatura {get; set;}
        public float Nota {get; set;}

    }
}