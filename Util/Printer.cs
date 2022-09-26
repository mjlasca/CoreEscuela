using System;

namespace CoreEscuela.Util
{
    public static class Printer
    {
        public static void DibujarLinea(int Tam = 10){
            Console.WriteLine("".PadLeft(Tam,'='));
        }
        public static void WriteTitle(string title){
            DibujarLinea(title.Length * 2);
            string espAux = "";
            for (int i = 1; i < (title.Length / 2) - 1; i++)
            {
                espAux += " ";
            }
            Console.WriteLine($"{espAux}| {title} |");
            DibujarLinea(title.Length * 2);
        }
    }
}