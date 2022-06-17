using System;
using System.Collections.Generic;
using System.Text;

namespace WebPaymentBusinessLogic.Services.Requests
{
    public class CreditCardRequest
    {

        public string FullName { get; set; }
        public int CreditCardNumber { get; set; }
        public DateTime ExpirationDate { get; set; }
        public int SecurityCode { get; set; }
    }
}
