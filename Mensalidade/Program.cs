using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mensalidade
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Informe o valor da anuidade: ");
            double anuidade = double.Parse(Console.ReadLine());
            double mensalidade = anuidade / 12;

            Console.WriteLine("Informe o valor da matrícula: ");
            double matricula = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o valor do material: ");
            double material = double.Parse(Console.ReadLine());

            int cont = 1;
            while (cont <= 12)
            {
                if (cont == 1)
                    Console.WriteLine("Mensalidade " +cont + " valor: " + (mensalidade + matricula + material).ToString("C"));
                else 
                    Console.WriteLine("Mensalidade " +cont + " valor: " + (mensalidade).ToString("C"));

                cont++;
            }

            Console.ReadKey();
        }
    }
}
