using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebPaymentBusinessLogic.Interfaces;
using WebPaymentBusinessLogic.Services;
using WebPaymentBusinessLogic.Services.Requests;
using System;

namespace WebPaymentBusinessLogicTests
{
    [TestClass]
    public class CreditcardServiceTests
    {
        #region MEMBERS AND VARIABLES
        private ICreditCardService _CreditCardService;
        #endregion

        #region TEST INITIATION
        [TestInitialize]
        public void Setup()
        {
            _CreditCardService = new CreditCardService();
        }
        #endregion

        [TestMethod]
        public void PostMonthlyPaymentViaCreditCard_returnsNotNull()
        {
            CreditCardRequest creditCardRequest = new CreditCardRequest
            {
                SecurityCode = 0,
                CreditCardNumber = 1234,
                ExpirationDate = DateTime.Today,
                FullName = "John Smith"
            };
            
            var result = _CreditCardService.PostMonthlyPaymentViaCreditCard(creditCardRequest).Result;

            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void PostMonthlyPaymentViaCreditCard_returnTrue()
        {
            CreditCardRequest creditCardRequest = new CreditCardRequest
            {
                SecurityCode = 123,
                CreditCardNumber = 1234,
                ExpirationDate = DateTime.Today,
                FullName = "John Smith"
            };
            var result = _CreditCardService.PostMonthlyPaymentViaCreditCard(creditCardRequest).Result;

            Assert.AreEqual(result,true);
        }

        [TestMethod]
        public void PostMonthlyPaymentViaCreditCard_returnfalse()
        {
            CreditCardRequest creditCardRequest = new CreditCardRequest
            {
                SecurityCode = 123,
                CreditCardNumber = -1,
                ExpirationDate = DateTime.Today,
                FullName = "John Smith"
            };
            var result = _CreditCardService.PostMonthlyPaymentViaCreditCard(creditCardRequest).Result;

            Assert.AreEqual(result, false);
        }

    }
}
