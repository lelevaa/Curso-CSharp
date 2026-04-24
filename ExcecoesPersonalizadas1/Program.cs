using System;
using ExcecoesPersonalizadas1.Entities;
namespace MeuProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Room number: ");
            int number = int.Parse(Console.ReadLine());

            Console.Write("Check-in date (dd/MM/yyyy): ");
            DateTime dataEntrada = DateTime.Parse(Console.ReadLine());

            Console.Write("Check-out date (dd/MM/yyyy): ");
            DateTime dataSaida = DateTime.Parse(Console.ReadLine());

            Reservation reserva = new Reservation(number, dataEntrada, dataSaida);

            Console.WriteLine();
            Console.WriteLine("Reservation: " + reserva);
            Console.WriteLine("Enter data to update the reservation:");

        }
    }
}