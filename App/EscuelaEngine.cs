using CoreEscuela.Entidades;
using CoreEscuela.Util;
using static System.Console;


namespace CoreEscuela
{
    public class EscuelaEngine
    {
        public Escuela Escuela {get;set;}  

        public EscuelaEngine()
        {
            Inicializar();
        }

        public void Inicializar(){

            Escuela = new Escuela("Platzi School" , "Colombia");
            Escuela.TipoEscuela = TiposEscuela.PreEscolar;

            Escuela.Cursos =  new List<Curso>(){
                new Curso(){
                    Nombre = "101",
                    Jornada = TiposJornada.Mañana
                },
                new Curso(){
                    Nombre = "201",
                    Jornada = TiposJornada.Tarde
                },
                new Curso(){
                    Nombre = "301",
                    Jornada = TiposJornada.Noche
                },
                new Curso(){
                    Nombre = "401",
                    Jornada = TiposJornada.Noche
                },
                new Curso(){
                    Nombre = "501",
                    Jornada = TiposJornada.Noche
                }
            };

            ImprimirCursos(Escuela);
            
        }

        private static void ImprimirCursos(Escuela escuela)
        {
            Printer.WriteTitle("Cursos de la Escuela");
            WriteLine("-------------LISTA CURSOS--------------");

            if( escuela?.Cursos != null){
                foreach (var item in escuela.Cursos)
                {
                    WriteLine($"Nombre {item.Nombre} : {item.UniqueId} ");    
                }
            }else{
                WriteLine(" NO HAY CURSOS ");
            }
            
        }

    }

}