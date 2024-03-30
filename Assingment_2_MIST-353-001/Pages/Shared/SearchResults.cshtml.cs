using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Assingment_2_MIST_353_001.Pages.Shared
{
    public class SearchResultsModel : PageModel
    {
        public void OnGet()
        {
        }
        public string JsonData { get; set; }
    }
}
