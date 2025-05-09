using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Q12.Models;

namespace Q12.Pages
{
    public class CretaEventModel : PageModel
    {
        [BindProperty]
        public Event NovoEvento { get; set; }

        public static Action<Event> AoEventoCriado;

        public string Mensagem { get; set; }

        public void OnGet()
        {
            
        }

        public void OnPost()
        {
            if (ModelState.IsValid)
            {
                
                AoEventoCriado?.Invoke(NovoEvento);

                Mensagem = "Evento cadastrado com sucesso!";
            }
        }
    }
}
