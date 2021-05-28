using System;
using System.Collections.Generic;
using Contribuinte.Entities;
using System.Globalization;

namespace Contribuinte
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite quantidade de contribuintes ");
            int n = int.Parse(Console.ReadLine());

            List<Pessoa> list = new List<Pessoa>();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Dados do #{i} contribuinte: ");
                Console.Write("Jurida ou Fisica (j/f)?");
                char tipo = char.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Renda Anual: ");
                double renda = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (tipo == 'j')
                {
                    Console.Write("Quantidade de Funcionários? ");
                    int qtfun = int.Parse(Console.ReadLine());
                    list.Add(new PessoaJuridica(qtfun, nome, renda));
                }
                if (tipo == 'f')
                {
                    Console.Write("Gasto Plano de Saúde? ");
                    double gastosaude = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new PessoaFisica(gastosaude, nome, renda));
                }
            }
            double sum = 0.0;
            Console.WriteLine();
            Console.WriteLine("Impostos pagos:");
            foreach (Pessoa pessoa in list)
            {
                double imposto = pessoa.CalculaImposto();
                Console.WriteLine(pessoa.Nome + ": $ " + imposto.ToString("F2", CultureInfo.InvariantCulture));
                sum += imposto;
            }

            Console.WriteLine();
            Console.Write("Total de Impostos: $ " +sum.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
