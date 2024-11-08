using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Autentificacion.Pages.Student
{
    [Authorize]
    public class StudentModel : PageModel
    {
        public void OnGet()
        {
        }
    }
}
