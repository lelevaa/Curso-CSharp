using ExercicioFixacao_TratamentoDeExcecoes.Entities;
using ExercicioFixacao_TratamentoDeExcecoes.Entities.Exceptions;
using System;
using System.Globalization;

namespace MeuProjeto
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Enter account data");

            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Holder: ");
            string holder = Console.ReadLine();

            Console.Write("Inicial balance: ");
            double inicialBalance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Withdraw limit: ");
            double withDraw = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Account conta = new Account(number, holder, inicialBalance, withDraw);

            Console.WriteLine();

            Console.Write("Enter amount for withdraw:");
            double amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            try
            {
                conta.WithDraw(amount);
                Console.WriteLine("New balance: " + conta.Balance.ToString("F2", CultureInfo.InvariantCulture));
            }
            catch (DomainException e)
            {
                Console.WriteLine("Withdraw error: " + e.Message);
            }

        }
    }
}