using ExercicioFixacacao_MetodoAbstrato.Entities;
using System;
using System.Globalization;

namespace MeuProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            List<TaxPayer> list = new List<TaxPayer>();

            Console.Write("Enter the number of tax payers: ");
            int qtd = int.Parse(Console.ReadLine());

            for(int i = 1; i<= qtd; i++)
            {
                Console.WriteLine($"Taxpayer#{i} data:");

                Console.Write("Individual orcompany(i/c)? ");
                char choice = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Anual income: ");
                double anualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (choice == 'I' || choice == 'i')
                {
                    Console.Write("Health expenditures: ");
                    double healthExpenditures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    list.Add(new Individual(healthExpenditures, name, anualIncome));
                }
                else
                {
                    Console.Write("Number of employees: ");
                    int numberofEmployees = int.Parse(Console.ReadLine());

                    list.Add(new Company(numberofEmployees, name, anualIncome));
                }
            }

            Console.WriteLine();
            Console.WriteLine("TAXES PAID:");
            double somaDaTaxa = 0.0;
            foreach (TaxPayer pessoa in list)
            {
                double adcionarTaxa = pessoa.Tax();
                Console.WriteLine( pessoa.Name + ": $ " + pessoa.Tax().ToString("F2", CultureInfo.InvariantCulture));
                somaDaTaxa += adcionarTaxa;
            }

            Console.WriteLine("TOTAL TAXES: $ " + somaDaTaxa.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}