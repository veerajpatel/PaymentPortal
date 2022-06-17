using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WebPaymentBusinessLogic.Interfaces;

namespace WebPaymentBusinessLogic.Services
{
    public class PayPalService : IPayPalService
    {
        #region MEMBERS AND VARIABLES
        #endregion

        #region CONSTRUCTORS
        public PayPalService()
        {

        }
        #endregion

        #region PUBLIC METHODS
        public Task<bool> PostMonthlyPaymentViaPayPal()
        {
            try
            {
                /* Business logic */
                return Task.FromResult(true);
            }
            catch
            {
                /* Error Handling*/
                throw;
            }

        }
        #endregion

        #region PRIVATE METHODS
        #endregion
    }
}
