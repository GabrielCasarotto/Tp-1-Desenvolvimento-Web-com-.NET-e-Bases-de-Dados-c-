using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;

namespace Tp_1_C__ASP_NET.Pages
{
    public class EventItem
    {
        public string Titulo { get; set; } = string.Empty;
        public DateTime Data { get; set; }
        public string Local { get; set; } = string.Empty;
    }

    public static class EventNotifier
    {
        public static Action<EventItem> OnEventCreated = (evt) =>
        {
            Console.WriteLine($"-> Título: {evt.Titulo}");
            Console.WriteLine($"-> Data: {evt.Data:dd/MM/yyyy}");
            Console.WriteLine($"-> Local: {evt.Local}\n");
        };
    }

    public class Ex12Model : PageModel
    {
        [BindProperty]
        public EventItem Evento { get; set; } = new EventItem();

        public bool EventoCriado { get; set; } = false;

        public void OnGet(){}

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid) {return Page();}

            EventNotifier.OnEventCreated?.Invoke(Evento);

            EventoCriado = true;
            return Page();
        }
    }
}