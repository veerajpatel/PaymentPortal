using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace WebPaymentBusinessLogic.Interfaces
{
    public interface IPayPalService
    {
        public Task<bool> PostMonthlyPaymentViaPayPal();
    }
}
