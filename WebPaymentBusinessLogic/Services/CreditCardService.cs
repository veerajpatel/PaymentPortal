using System.Threading.Tasks;
using WebPaymentBusinessLogic.Interfaces;
using WebPaymentBusinessLogic.Services.Requests;

namespace WebPaymentBusinessLogic.Services
{
    public class CreditCardService :ICreditCardService
    {
        #region MEMBERS AND VARIABLES
        
        #endregion

        #region CONSTRUCTORS
        public CreditCardService()
        { 
        
        }
        #endregion

        #region PUBLIC METHODS
        public Task<bool> PostMonthlyPaymentViaCreditCard(CreditCardRequest creditCardrequest)
        {
            try
            { /* Business logic */
               
                if (!string.IsNullOrEmpty(creditCardrequest.FullName) && 
                    creditCardrequest.CreditCardNumber >= 0 && 
                    creditCardrequest.ExpirationDate != null && 
                    creditCardrequest.SecurityCode > 0)

                        { return Task.FromResult(true); }
                else
                        { return Task.FromResult(false); }
              
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
