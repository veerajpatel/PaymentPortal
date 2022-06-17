using System.Threading.Tasks;
using WebPaymentBusinessLogic.Interfaces;

namespace WebPaymentBusinessLogic.Services
{
    public class VenmoService :IVenmoService
    {
        #region MEMBERS AND VARIABLES
        #endregion

        #region CONSTRUCTORS
        public VenmoService()
        {

        }
        #endregion

        #region PUBLIC METHODS
        public Task<bool> PostMonthlyPaymentViaVenmo()
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
