using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using WebPaymentBusinessLogic.Interfaces;
using WebPaymentBusinessLogic.Services.Requests;


namespace WebPaymentPortal.Pages.Shared
{
    public class InvoiceModel : PageModel
    {
        #region VARIABLES AND PROPERTIES
        private readonly ICreditCardService _creditCardService;
        private readonly IPayPalService _payPalService;
   

        [BindProperty]
        [Required]
        public string FullName { get; set; }

        [BindProperty]
        [Required]
        public int CreditCardNumber { get; set; }
     
        [BindProperty]
        [Required]
        public DateTime ExpirationDate { get; set; }

        [BindProperty]
        [Required]
        public int SecurityCode { get; set; }

        public string Message { get; set; }
        public bool showCCView = false;
        public bool showPPView = false;

        #endregion

        #region PUBLIC METHODS


        public InvoiceModel(IPayPalService payPalService, ICreditCardService creditCardService)
        {
          
            _creditCardService = creditCardService;
            _payPalService = payPalService;
        }
       

        public void OnPostShowPayPalView()
        {
            showCCView = false;
            showPPView = true;
          
        }
        public void OnPostShowCCView()
        {
            showPPView = false;
            showCCView = true;
        }

        public async Task<IActionResult> OnPostPayWithCC()
        {
            
            CreditCardRequest creditCardRequest = new CreditCardRequest
            {
                SecurityCode = this.SecurityCode,
                CreditCardNumber = this.CreditCardNumber,
                ExpirationDate = this.ExpirationDate,
                FullName = this.FullName
               
            };

            if(await _creditCardService.PostMonthlyPaymentViaCreditCard(creditCardRequest))
            {
                return RedirectToPage("./ThankYou");
            }
            else
            {
                showPPView = false;
                showCCView = true;
                return Page();
             
            }
        }

        public async Task<IActionResult> OnPostPayWithPayPal()
        {
            
            if (await _payPalService.PostMonthlyPaymentViaPayPal())
            {
                return RedirectToPage("./ThankYou");
            }
            else
            {
                return RedirectToPage("./Error");
            }
        }
        #endregion
    }
}
