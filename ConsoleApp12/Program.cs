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
            double sum = 0;
            List<Funcionario> list = new List<Funcionario>();

            Console.WriteLine("Insira o número de funcionários:");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
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

            Console.WriteLine("Salários:");
            foreach (Funcionario func in list)
            {
                double salario = func.Salario();
                Console.WriteLine(func.Nome + ": $ " + salario.ToString("F2", CultureInfo.InvariantCulture));
                sum += salario;
            }

            Console.WriteLine();
            Console.WriteLine("TOTAL TAXES: $ " + sum.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}