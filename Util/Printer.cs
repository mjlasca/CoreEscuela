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
            Console.WriteLine($"| {title} |");
            DibujarLinea(title.Length * 2);
        }
    }
}