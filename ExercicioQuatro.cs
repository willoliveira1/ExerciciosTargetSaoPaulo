using System;
using System.Collections.Generic;

namespace ExercicioQuatro
{
    public class Program
    {
        static void Main(string[] args)
        {
            var faturamentoDosEstados = new Dictionary<string, double>()
            {
                {"SP", 67836.43 },
                {"RJ", 36678.66},
                {"MG", 29229.88},
                {"ES", 27165.48},
                {"Outros", 19849.53 }
            };

            double faturamentoTotal = 0;

            foreach (var estado in faturamentoDosEstados)
            {
                faturamentoTotal += estado.Value;
            }

            var percentualPorEstado = new Dictionary<string, double>();

            foreach (var estado in faturamentoDosEstados)
            {
                percentualPorEstado.Add(estado.Key, (estado.Value / faturamentoTotal * 100));
            }

            foreach (var estado in percentualPorEstado)
            {
                Console.WriteLine($"{estado.Key}: {estado.Value.ToString("F2")} %");
            }
        }
    }
}
