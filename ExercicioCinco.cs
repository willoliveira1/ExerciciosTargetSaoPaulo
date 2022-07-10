using System;
using System.Collections.Generic;

namespace ExercicioDois
{
    public class Program
    {
        static void Main(string[] args)
        {
            string palavra = Console.ReadLine();

            char[] arrayPalavra = palavra.ToCharArray();

            List<char> palavraInvertida = new List<char>();

            for (int i = 0; i < arrayPalavra.Length; i++)
            {
                palavraInvertida.Add(arrayPalavra[(arrayPalavra.Length - i) - 1]);
            }
            
            foreach(char letra in palavraInvertida)
            {
                Console.WriteLine(letra);
            }
        }
    }
}
