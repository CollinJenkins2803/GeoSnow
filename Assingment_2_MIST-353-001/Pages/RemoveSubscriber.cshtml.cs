using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
using System.Text;

namespace Assingment_2_MIST_353_001.Pages
{
    public class RemoveSubscriberModel : PageModel
    {
        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPostRemoveSubscriberAsync(string email)
        {
            using (var httpClient = new HttpClient())
            {
                var content = new FormUrlEncodedContent(new[]
                {
            new KeyValuePair<string, string>("email", email)
        });

                var response = await httpClient.PostAsync("https://localhost:7293/api/Newsletter/remove-subscriber", content);

                if (response.IsSuccessStatusCode)
                {
                    // Handle success
                    return RedirectToPage("RemoveSubscriber");
                }
                else
                {
                    // Handle error
                    return RedirectToPage("Error");
                }
            }
        }


    }
}
