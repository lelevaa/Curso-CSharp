using System;
using System.Collections.Generic;
using System.Text;
using ExercicioDeFixacao_Interface.Services;
namespace ExercicioDeFixacao_Interface.Services
{
    class PaypalService : IOnlinePaymentService
    {
        public double PaymentFee(double amount)
        {
            //calculo errado 2/100 = 0
            //return amount + (2 / 100);
            return amount * 0.02;
        }

        public double Interest(double amount, int months)
        {
            //calculo errado 1/100 = 0
            return amount * 0.01 * months;
        }
    }
}
