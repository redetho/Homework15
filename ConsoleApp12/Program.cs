using ConsoleApp12.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            // declarações e criação de lista
            double somaTotal = 0;
            List<Funcionario> list = new List<Funcionario>();

            //recebe o n* de funcionarios
            Console.WriteLine("Insira o número de funcionários:");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                //se for terceirizado, cria um na classe terceirizada.
                Console.WriteLine("Funcionário terceirizado? (s/n)");
                char tipo = char.Parse(Console.ReadLine());

                if (tipo == 's')
                {
                    Console.WriteLine("Nome do funcionário:");
                    String nome = Console.ReadLine();
                    Console.WriteLine("Horas trabalhadas: ");
                    double horas = double.Parse(Console.ReadLine());
                    Console.WriteLine("Valor por hora: ");
                    double valor = double.Parse(Console.ReadLine());
                    double bonus = 110;
                    list.Add(new Terceirizado(nome, horas, valor, bonus));
                }
                //se não for terceirizado, classe própria
                else if (tipo == 'n')
                {
                    Console.WriteLine("Nome do funcionário:");
                    String nome = Console.ReadLine();
                    Console.WriteLine("Horas trabalhadas: ");
                    double horas = double.Parse(Console.ReadLine());
                    Console.WriteLine("Valor por hora: ");
                    double valor = double.Parse(Console.ReadLine());
                    list.Add(new FuncProprio(nome, horas, valor));

                }


            }
            //mostra o salário de todo funcionário.
            Console.WriteLine("Salários:");
            foreach (Funcionario func in list)
            {
                double salario = func.Salario();
                
                Console.WriteLine(func.Nome + ": R$" + salario.ToString(CultureInfo.InvariantCulture));
                somaTotal += salario;
            }
            //mostra o preço total de todos salários.
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Preço total: R$" + somaTotal.ToString(CultureInfo.InvariantCulture));
        }
    }
}