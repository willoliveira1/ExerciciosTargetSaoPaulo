// Mantive as classes no mesmo arquivo para ficar mais fácil de avaliarem, mas pela convenção do C# o correto seria estarem em outro arquivo
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace ExercicioTres
{
    public class Program
    {
        static void Main(string[] args)
        {
            double media=0;
            int contador=0, auxMedia=0;

            List<Faturamento> faturamento = new List<Faturamento>();

            using (StreamReader file = File.OpenText("data.json"))
            {
                string jsonString = file.ReadToEnd();
                faturamento = JsonConvert.DeserializeObject<List<Faturamento>>(jsonString);
            }

            double valorMinimo = faturamento[0].Valor;
            double valorMaximo = faturamento[0].Valor;

            foreach (var item in faturamento)
            {
                if (item.Valor < valorMinimo && item.Valor > 0)
                {
                    valorMinimo = item.Valor;
                }
                else if (item.Valor > valorMaximo)
                {
                    valorMaximo = item.Valor;
                }

                if (item.Valor > 0)
                {
                    media += item.Valor;
                    auxMedia++;
                }
            }

            media = media / auxMedia;

            foreach (var dia in faturamento)
            {
                if (dia.Valor > media)
                {
                    contador++;
                }
            }

            Console.WriteLine($"O valor de faturamento mínimo foi: R$ {valorMinimo.ToString("F2")}.");
            Console.WriteLine($"O valor de faturamento máximo foi: R$ {valorMaximo.ToString("F2")}.");
            Console.WriteLine($"O valor de faturamento médio foi : R$ {media.ToString("F2")}.");
            Console.WriteLine($"A quantidade de dias de faturamento acima da média foram: {contador} dias.");
        }
    }

    public class Faturamento
    {
        public int Dia { get; set; }
        public double Valor { get; set; }
    }
}
