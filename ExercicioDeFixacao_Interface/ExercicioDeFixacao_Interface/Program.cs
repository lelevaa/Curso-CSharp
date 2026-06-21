using System;
using System.Globalization;
using ExercicioDeFixacao_Interface.Entities;
using ExercicioDeFixacao_Interface.Services;

namespace Course
{
    class Program
    {
        static void Main(string[] args) {
            Console.WriteLine("Enter contract data");

            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());

            Console.Write("Date (dd/MM/yyyy): ");
            DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);

            Console.Write("Contract value:  ");
            double contractValue = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.Write("Enter number of installments:  ");
            int installments = int.Parse(Console.ReadLine());

            //chama a 1ª entidade
            Contract contrato = new Contract(number, date, contractValue);

            //installment era só no contract service
            //Installment installment = new Installment(date, )
            ContractService contractService = new ContractService(new PaypalService());

            contractService.ProcessContract(contrato,installments);

            Console.WriteLine("Installments:");

            foreach(Installment item in contrato.Installments)
            {
                Console.WriteLine(
                    item.DueDate.ToString("dd/MM/yyyy")
                    + " - "
                    + item.Amount.ToString("F2", CultureInfo.InvariantCulture)
                );
            }
        }
    }
}