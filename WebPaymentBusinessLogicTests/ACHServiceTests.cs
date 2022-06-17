using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebPaymentBusinessLogic.Interfaces;
using WebPaymentBusinessLogic.Services;

namespace WebPaymentBusinessLogicTests
{
    [TestClass]
    public class ACHServiceTests
    {
        #region MEMBERS AND VARIABLES
        private IACHService _ACHService;
        #endregion

        #region TEST INITIATION
        [TestInitialize]
        public void Setup()
        {
            _ACHService = new ACHService();
        }
        #endregion

        [TestMethod]
        public void PostMonthlyPaymentViaACH_returnsNotNull()
        {
            var result = _ACHService.PostMonthlyPaymentViaACH().Result;

            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void PostMonthlyPaymentViaACH_returnTrue()
        {
            var result = _ACHService.PostMonthlyPaymentViaACH().Result;

            Assert.AreEqual(result, true);
        }
    }
}
