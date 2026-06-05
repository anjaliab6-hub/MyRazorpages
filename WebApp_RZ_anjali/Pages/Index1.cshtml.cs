using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;

namespace WebApp_RZ_anjali.Pages
{
    public class Index1Model : PageModel
    {
        private readonly ILogger<Index1Model> _logger;

        public string Name { get; set; }
        public int num { get; set; }

        public List<string> Hobbies { get; set; } = new List<string>
        {
            "Reading",
            "Traveling",
            "Cooking",
            "Photography"
        };


        public Index1Model(ILogger<Index1Model> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            Name = "Sandra";
            num = 5;
            //comment for avoid delay
            //Console.WriteLine("enter number : ");
            //num = Convert.ToInt32(Console.ReadLine());
        }
    }
}
