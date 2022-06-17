using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebPaymentBusinessLogic.Interfaces;
using WebPaymentBusinessLogic.Services;


namespace WebPaymentBusinessLogicTests
{
    [TestClass]
    public class VenmoServiceTests
    {
        #region MEMBERS AND VARIABLES
        private IVenmoService _VenmoService;
        #endregion

        #region TEST INITIATION
        [TestInitialize]
        public void Setup()
        {
            _VenmoService = new VenmoService();
        }
        #endregion

        [TestMethod]
        public void PostMonthlyPaymentViaVenmo_returnsNotNull()
        {
            var result = _VenmoService.PostMonthlyPaymentViaVenmo().Result;

            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void PostMonthlyPaymentViaVenmo_returnTrue()
        {
            var result = _VenmoService.PostMonthlyPaymentViaVenmo().Result;

            Assert.AreEqual(result, true);
        }

    }
}
