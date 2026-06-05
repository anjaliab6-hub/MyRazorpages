using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApp_RZ_anjali.Pages
{
    public class AboutModel : PageModel
    {
        public string message {  get; set; }
        public string fname { get; set; }
        public string lname {  get; set; }
        public long phone {  get; set; }
        public string city { get; set; }
        public string email { get; set; }

        public void OnGet()
        {
            message = "in on get";
        }
        public void OnPost()
        {
            message = "in on post";
        }
        public void OnPostEdit()
        {
            fname = Request.Form["fname"];
            lname = Request.Form["lname"];
            phone = Convert.ToInt64(Request.Form["phone"]);
            city = Request.Form["city"];
            email = Request.Form["email"];
            message = $"in on postEdit\n{fname} {lname}\n{phone}\n{city}\n{email}";
        }
        public void OnPostDelete()
        {
            message = "in on postDelete";
        }
        public void OnPostView(int id)
        {
            message = $"in on postView {id}";
        }
        public async Task<IActionResult> onPostRegisterAsync()
        {
            message = " in on post register async";
            //return Redirect("https://www.google.com");
            Console.WriteLine(message);
            return RedirectToPage();
        }

        public async Task<IActionResult> onPostInfo()
        {
            message = "in on post info";
            Console.WriteLine(message);
            return RedirectToPage();
        }
    }
}
