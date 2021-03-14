using System;

namespace Cebolinha
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello W!");


            string frase, cebolinha;

            Console.WriteLine("Digite uma frase:");
            frase = Console.ReadLine();
            cebolinha = frase.Replace("r", "l").Replace("R", "L");
            Console.WriteLine($"Texto Cebolinha: {cebolinha}");
        }
    }
}
