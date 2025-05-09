using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Q8.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;

    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    public List<Produtos> Produtos { get; set; }
    public void OnGet()
    {
        Produtos = new List<Produtos>
        {
            new Produtos
            {
                Nome = "Produto 1",
                Preco = 10.0
            },
              new Produtos
            {
                Nome = "Produto 2",
                Preco = 40.0
            },
                new Produtos
            {
                Nome = "Produto 3",
                Preco = 20.0
            },
        };

    }
}
public class Produtos
{
    public string Nome { get; set; }
    public double Preco { get; set; }
}
