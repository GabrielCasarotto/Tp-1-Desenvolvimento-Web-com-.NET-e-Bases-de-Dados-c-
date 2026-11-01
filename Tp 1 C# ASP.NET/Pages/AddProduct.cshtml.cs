using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Tp_1_C__ASP_NET.Pages
{
    public class AddProductModel : PageModel
    {
        [BindProperty]
        public string Nome { get; set; } = string.Empty;

        [BindProperty]
        public decimal Preco { get; set; }

        public bool DadosEnviados { get; set; } = false;

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            DadosEnviados = true;
            return Page();
        }
    }
}