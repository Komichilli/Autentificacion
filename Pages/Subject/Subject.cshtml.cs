using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Autentificacion.Pages.Subject
{
    [Authorize]
    public class SubjectModel : PageModel
    {
        public void OnGet()
        {
        }
    }
}
