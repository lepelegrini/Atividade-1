using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a distânia que será percorrida em KM: ");
            double n = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor do litro de combustível: ");
            double n1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite quantos KM o automóvel faz por litro: ");
            double n2 = double.Parse(Console.ReadLine());

            double resultado = (n / n2) * n1;

            Console.WriteLine("Você gastará: " + resultado);

            Console.ReadKey();
        }
    }
}
