using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioDeFixacao_Interface.Services
{
    internal interface IOnlinePaymentService
    {
        double PaymentFee(double amount);

        double Interest(double amount, int months);
    }
}
