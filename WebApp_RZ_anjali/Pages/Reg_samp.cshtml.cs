using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApp_RZ_anjali.Pages
{
    public class Reg_sampModel : PageModel
    {
        [BindProperty]
        public string Name { get; set; }

        [BindProperty]
        public int Age { get; set; }

        [BindProperty]
        public string Email { get; set; }

        [BindProperty]
        public long Mob { get; set; }

        public bool IsPosted { get; set; } = false;

        public void OnGet()
        {
        }

        public void OnPostEdit()
        {
            IsPosted = true;
        }
    }
}
