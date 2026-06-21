using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Text;

namespace ExercicioDeFixacao_Interface.Entities
{
    internal class Contract
    {
        public int Number { get; set; }
        public DateTime Date { get; set; }
        public double TotalValue { get; set; }

        //deveria receber uma lista de parcelas, de acordo com o diagrama um contrato recebe várias parcelas
        //public Installment Installment { get; set; }

        public List<Installment> Installments { get; set; } = new List<Installment>();

        public Contract() { }

        //o contrato não nasce com uma parcela
        //public Contract(int number, DateTime date, double totalValue, Installment installment)
        //{
        //    Number = number;
        //    Date = date;
        //    TotalValue = totalValue;
        //}

        public Contract(int number, DateTime date, double totalValue)
        {
            Number = number;
            Date = date;
            TotalValue = totalValue;
        }
    }
}
