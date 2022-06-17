using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace WebPaymentPortal.Pages.Shared
{
    public class loginModel : PageModel
    {
        #region PROPERTY
        
        [BindProperty]
        [Required, MinLength(6)]
        public string UserName { get; set; }
       
        [BindProperty]
        [Required, MinLength(6)]
        public string Password { get; set; }
        #endregion

        #region PUBLIC METHODS
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            /* assuming all users are valid with 6 char user/pass" */
            return RedirectToPage("./Invoice");
        }
        #endregion
    }
}
