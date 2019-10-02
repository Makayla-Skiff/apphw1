using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace apphw1.Pages
{
    public class IndexModel : PageModel
    {
        public string[] MovieNames { get; set; }
        public string [] moviename1 { get; set; }
        public string [] movienames2 { get; set; }
        public void OnGet()
        {
            MovieNames = new string[] { "Brides Made","Me Before You","It"};
            moviename1 = new string[] { "Hangover", "After","47 Meters Down" };
            movienames2 = new string[] { "Little Man", "The Notebook", "BriteBurn" };
        }
    }
}
