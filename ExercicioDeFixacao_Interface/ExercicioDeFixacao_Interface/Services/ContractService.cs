using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using ExercicioDeFixacao_Interface.Entities;

namespace ExercicioDeFixacao_Interface.Services
{
    class ContractService
    {
        private IOnlinePaymentService _onlinePaymentService;

        //precisava criar um construtor
        public ContractService(IOnlinePaymentService onlinePaymentService)
        {
            _onlinePaymentService = onlinePaymentService;
        }
        public void ProcessContract(Contract contract, int months )
        {
            //CORREÇÕES
            //o loop deve começar em 1, primeira parcela, mês 1
            //travei na linha de racicio

            //for(int i = 0; i < months; i++)
            //{
            //    double payment = _onlinePaymentService.PaymentFee();
            //    double installment = _onlinePaymentService.Interest(, months);
            //    Contract contrato = new Contract(contract.Number, contract.Date, totalValue, installment);
            //}

            

            double basicQuota = contract.TotalValue / months;
            for (int i = 1; i <= months; i++)
            {
                double updateQuota = basicQuota + _onlinePaymentService.Interest(basicQuota, i);

                double fullQuota = updateQuota + _onlinePaymentService.PaymentFee(updateQuota);

                DateTime dueDate = contract.Date.AddMonths(i);

                contract.Installments.Add(new Installment(dueDate, fullQuota));
            }
        }
        
    }
}
