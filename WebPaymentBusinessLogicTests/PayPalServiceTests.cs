using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebPaymentBusinessLogic.Interfaces;
using WebPaymentBusinessLogic.Services;

namespace WebPaymentBusinessLogicTests
{ [TestClass]
    public class PayPalServiceTests
    {
        #region MEMBERS AND VARIABLES
        private IPayPalService _PayPalService;
        #endregion

        #region TEST INITIATION
        [TestInitialize]
        public void Setup()
        {
            _PayPalService = new PayPalService();
        }
        #endregion

        [TestMethod]
        public void PostMonthlyPaymentViaPayPal_returnsNotNull()
        {
            var result = _PayPalService.PostMonthlyPaymentViaPayPal().Result;

            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void PostMonthlyPaymentViaPayPal_returnTrue()
        {
            var result = _PayPalService.PostMonthlyPaymentViaPayPal().Result;

            Assert.AreEqual(result, true);
        }
    }
}
