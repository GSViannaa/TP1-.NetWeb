using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Q10.Pages
{
    public class addProductModel : PageModel
    {
        [BindProperty]
        public string ProductName { get; set; }

        [BindProperty]
        public string ProductPrice { get; set; }

        public bool FomrEnviado { get; set; }
        public void OnGet()
        {
        }

        public void OnPost()
        {
            FomrEnviado = true;
        }
    }
}
