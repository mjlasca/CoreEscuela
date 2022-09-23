using System.Collections.Generic;

namespace CoreEscuela.Entidades
{
    public class Escuela
    {
        string nombre;

        public string UniqueId {get; private set;} = Guid.NewGuid().ToString();
        public string Nombre {
            get{return nombre ; }
            set{ nombre = value ;}
        }

        public List<Curso> Cursos {get; set;}

    //hola mundo

        public int anoCreacion { get; set; }
        public string pais { get; set; }
        public int ciudad { get; set; }
        public TiposEscuela TipoEscuela {get; set;}


        public Escuela (string nombre, string pais = "",  string ciudad = "" ) 
        { 
            (Nombre) = (nombre);
            this.pais = pais;
        }

        public override string ToString(){
            return $"PAIS  {this.pais} Nombre "+ this.nombre +" TIPO "+ this.TipoEscuela;
        }


    }
}