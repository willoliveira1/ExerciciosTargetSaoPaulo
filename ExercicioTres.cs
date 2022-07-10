// Mantive as classes no mesmo arquivo para ficar mais fácil de avaliarem, mas pela convenção do C# o correto seria estarem em outro arquivo
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
                JsonSerializer serializer = new JsonSerializer();
                Faturamento fat = (Faturamento)serializer.Deserialize(file, typeof(Faturamento));
                faturamento.Add(fat);
            }

            double valorMinimo = faturamento[0].Dados[0].Valor;
            double valorMaximo = faturamento[0].Dados[0].Valor;

            foreach (var item in faturamento[0].Dados)
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

            foreach (var dia in faturamento[0].Dados)
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
        public FaturamentoJson[] Dados { get; set; }
    }

    public class FaturamentoJson
    {
        public string Data { get; set; }
        public double Valor { get; set; }
    }
}
