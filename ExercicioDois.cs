using System;

namespace ExercicioDois
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Escolha um número: ");
            int escolha = int.Parse(Console.ReadLine());

            int x = 0;
            int y = 1;

            while (escolha > y)
            {
                x += y;
                y += x;

                if (escolha == x || escolha == y)
                {
                    Console.WriteLine($"O número escolhido ({escolha}) faz parte da sequência Fibonacci.");
                }
                else
                {
                    Console.WriteLine($"O número escolhido ({escolha}) não faz parte da sequência Fibonacci.");
                }
            }
        }
    }
}
