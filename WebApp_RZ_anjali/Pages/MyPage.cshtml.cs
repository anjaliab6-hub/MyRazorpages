using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApp_RZ_anjali.Pages
{
    public class MyPageModel : PageModel
    {

        // [ViewData]     // for set data it as viewdata for trasfer the data from this to cshtml as annotation format
        public int Haii { get; set; }

        public void OnGet()
        {
            ViewData["Message"] = "Hello from MyPageModel!";

            ViewData["Items"] = new List<string>
        {
            "Anu",
            "Ram",
            "Raj"
        };

            Haii = 42;
        }
        
    }
}


