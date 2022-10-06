using System;
using Herança_e_Polimorfismo.Entidades;

namespace Herança_e_Polimorfismo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Empregado> lista = new List<Empregado>();

            Console.Write("Entre com o número de Empregados: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Registrando Empregado #" + i);
                Console.Write("Digite o nome: ");
                string nome1 = Console.ReadLine();
                Console.Write("Digite quantas horas de trabalho: ");
                int horas1 = int.Parse(Console.ReadLine());
                Console.Write("Digite o valor que o empregado ganha por hora: ");
                double valorporhora1 = double.Parse(Console.ReadLine());
                Console.WriteLine("O empregado é tercerizado? (digite sim ou nao) ");
                string yesorno = Console.ReadLine();

                if (yesorno == "sim")
                {
                    Console.WriteLine("Digite o custo adicional do empregado: ");
                    double custoadicional1 = double.Parse(Console.ReadLine());

                    lista.Add(new EmpregadoTercerizado(nome1, horas1, valorporhora1, custoadicional1));
                }
               else
               {
                    lista.Add(new Empregado(nome1, horas1, valorporhora1));

               }
             }

            Console.WriteLine();
            Console.WriteLine("Pagamentos: ");
            foreach (Empregado func in lista)
            {
                Console.WriteLine(func.Nome + "- $ " +func.Pagamento().ToString("F2"));
            }
        }
     }
 }
