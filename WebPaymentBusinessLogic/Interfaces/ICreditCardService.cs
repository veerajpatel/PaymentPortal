using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WebPaymentBusinessLogic.Services.Requests;

namespace WebPaymentBusinessLogic.Interfaces
{
    public interface ICreditCardService
    {
        public Task<bool> PostMonthlyPaymentViaCreditCard(CreditCardRequest creditCardrequest);
    }
}
