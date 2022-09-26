using CoreEscuela.Entidades;
using CoreEscuela.Util;
using static System.Console;


namespace CoreEscuela
{
    public sealed class EscuelaEngine
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
            CargarAsignaturas();
            CargarEvaluaciones();
            //ImprimirCursos(Escuela);
            Printer.WriteTitle("PRUEBAS DE POLIMORFISMO");

            var alumTest = new Alumno{Nombre = "Zara Corrales"};
            ObjetoEscuelaBase obj = alumTest;

            

        }

        private void CargarEvaluaciones()
        {
            foreach (var curso in Escuela.Cursos)
            {
                foreach (var alum in curso.Alumnos)
                {
                    List<Evaluacion> listEva = new List<Evaluacion>();
                    foreach (var asig in curso.Asignaturas)
                    {
                        Random rnd = new Random();
                        listEva.Add(new Evaluacion { Nombre = "Evalución 1" , Asignatura = asig, Nota = (float) (5 * rnd.NextDouble() ) });
                        listEva.Add(new Evaluacion { Nombre = "Evalución 2" , Asignatura = asig, Nota =  (float) (5 * rnd.NextDouble() )});
                        listEva.Add(new Evaluacion { Nombre = "Evalución 3" , Asignatura = asig, Nota =  (float) (5 * rnd.NextDouble() )});
                        listEva.Add(new Evaluacion { Nombre = "Evalución 4" , Asignatura = asig, Nota =  (float) (5 * rnd.NextDouble() )});
                        listEva.Add(new Evaluacion { Nombre = "Evalución 5" , Asignatura = asig, Nota =  (float) (5 * rnd.NextDouble() )});
                    }

                    alum.Evaluaciones = listEva;
                }
            }
        }

        private void CargarAsignaturas()
        {

            List<Asignatura> listaAsignaturas = new List<Asignatura>(){
                    new Asignatura {Nombre = "Matemáticas"},
                    new Asignatura {Nombre = "Educación Física"},
                    new Asignatura {Nombre = "Castellano"},
                    new Asignatura {Nombre = "Ciencias Naturales"}
            };

            foreach (var curso in Escuela.Cursos){
                curso.Asignaturas = listaAsignaturas;
            }

        }

        private List<Alumno> GenerarAlumnos(int cant )
        {
            string[] nombre1 = {"Alba", "Felipe", "Martha", "Farid" , "Álvaro"};
            string[] apellido1 = {"Ruiz", "Montenegro", "Pelaez", "Castaño" , "Lasluisa"};
            string[] nombre2 = {"Aurelio", "Sandra", "José", "Juliana" , "Pedro"};

            var listAlumnos = from n1 in nombre1
                              from n2 in nombre2
                              from a1 in apellido1
                              select new Alumno { Nombre = $"{n1} {n2} {a1}" };
            
            return listAlumnos.OrderBy((al) => al.UniqueId).Take(cant).ToList();

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

            Random rnd = new Random();

            foreach (var curso in Escuela.Cursos)
            {
                curso.Alumnos = GenerarAlumnos(rnd.Next(5,20));
            }
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