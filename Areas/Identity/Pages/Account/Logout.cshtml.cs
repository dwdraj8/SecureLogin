using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SecureLoginApp.Pages
{
    public class LogoutModel : PageModel
    {
        public LogoutModel(ILogger<LogoutModel> logger)
        {
        }

        public async Task<IActionResult> OnPost(string returnUrl = null)
        {
            var a = HttpContext.User.Identity.IsAuthenticated;

            await HttpContext.SignOutAsync();
            Response.Cookies.Delete(".AspNetCore.Identity.Application");
            Response.Cookies.Delete(".AspNetCore.Antiforgery.vxVaZKpoh0M");

            // Additional cleanup logic, if needed

            return RedirectToPage("/Index");
        }
    }
}