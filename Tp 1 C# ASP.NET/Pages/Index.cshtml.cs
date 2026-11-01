using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

namespace Tp_1_C__ASP_NET.Pages
{
    public class ProdutoModel
    {
        public string Nome { get; set; }
        public decimal Preco { get; set; }

        public ProdutoModel(string nome, decimal preco)
        {
            Nome = nome;
            Preco = preco;
        }
    }

    public class IndexModel : PageModel
    {
        public List<ProdutoModel> Produtos { get; set; } = new List<ProdutoModel>();

        public void OnGet()
        {
            Produtos.Add(new ProdutoModel("Pc ganer Acer", 3500.00m));
            Produtos.Add(new ProdutoModel("Mouse Logitech", 136.10m));
            Produtos.Add(new ProdutoModel("Teclado", 299.99m));
        }
    }
}