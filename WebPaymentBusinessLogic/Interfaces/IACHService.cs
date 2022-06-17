using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace WebPaymentBusinessLogic.Interfaces
{
    public interface IACHService
    {
        public Task<bool> PostMonthlyPaymentViaACH();
    }
}
