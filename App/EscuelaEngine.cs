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

        public void Inicializar()
        {

            Escuela = new Escuela("Platzi School", "Colombia");
            Escuela.TipoEscuela = TiposEscuela.PreEscolar;
            CargarCursos();
            
            foreach (var curso in Escuela.Cursos)
            {
                curso.Alumnos.AddRange(
                    CargarAlumnos()
                );
            }
            
            CargarAsignaturas();
            CargarEvaluaciones();

            ImprimirCursos(Escuela);

        }

        private void CargarEvaluaciones()
        {
            throw new NotImplementedException();
        }

        private void CargarAsignaturas()
        {
            foreach (var curso in Escuela.Cursos){
                List<Asignatura> listaAsignaturas = new List<Asignatura>(){
                    new Asignatura {Nombre = "Matemáticas"},
                    new Asignatura {Nombre = "Educación Física"},
                    new Asignatura {Nombre = "Castellano"},
                    new Asignatura {Nombre = "Ciencias Naturales"}
                };
                curso.Asignaturas.AddRange(listaAsignaturas);
            }
        }

        private IEnumerable<Alumno> CargarAlumnos()
        {
            string[] nombre1 = {"Alba", "Felipe", "Martha", "Farid" , "Álvaro"};
            string[] apellido1 = {"Ruiz", "Montenegro", "Pelaez", "Castaño" , "Lasluisa"};
            string[] nombre2 = {"Aurelio", "Sandra", "José", "Juliana" , "Pedro"};

            var listAlumnos = from n1 in nombre1
                              from n2 in nombre2
                              from a1 in apellido1
                              select new Alumno { Nombre = $"{n1} {n2} {a1}" };
            
            return listAlumnos;

        }

        private void CargarCursos()
        {
            Escuela.Cursos = new List<Curso>(){
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