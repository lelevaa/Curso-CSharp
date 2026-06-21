using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioDeFixacao_Interface.Entities
{
    internal class Installment
    {
        public DateTime DueDate { get; set; }
        public double Amount { get; set; }
        public Installment() { }

        public Installment(DateTime dueDate, double amount) {
            DueDate = dueDate;
            Amount = amount;
        }
    }
}
