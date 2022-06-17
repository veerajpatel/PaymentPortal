
using System.Threading.Tasks;

namespace WebPaymentBusinessLogic.Interfaces
{
    public interface IVenmoService
    {
        public Task<bool> PostMonthlyPaymentViaVenmo();
    }
}
