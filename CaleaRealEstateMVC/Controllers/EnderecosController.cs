using CaleaRealEstateMVC.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CaleaRealEstateMVC.Controllers
{
    public class EnderecosController : Controller
    {
        private readonly AppDbContext _context;

        public EnderecosController(AppDbContext context)
        {
            _context = context;
        }
        public async Task <IActionResult> Index()
        {
            var enderecoImovel = await _context.Enderecos.ToListAsync();   
            return View(enderecoImovel);
        }
    }
}
