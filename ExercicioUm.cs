using System;

namespace ExercicioUm
{
    public class Program
    {
        static void Main(string[] args)
        {
            int indice = 13;
            int soma = 0;
            int k = 0;

            while (k < indice)
            {
                k++;
                soma += k;
            }

            Console.WriteLine(soma);
        }
    }
}
