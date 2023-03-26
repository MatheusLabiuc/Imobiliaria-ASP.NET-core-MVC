using CaleaRealEstateMVC.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CaleaRealEstateMVC.Controllers
{
    public class VendedoresController : Controller
    {
        private readonly AppDbContext _context;

        public VendedoresController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var allProducers = await _context.Vendedores.Include(i => i.Imoveis).ToListAsync();
            return View(allProducers);
        }
    }
}
