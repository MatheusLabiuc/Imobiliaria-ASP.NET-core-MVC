using CaleaRealEstateMVC.Data;
using CaleaRealEstateMVC.Models;
using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CaleaRealEstateMVC.Controllers
{
    public class ImoveisController : Controller
    {
        private readonly AppDbContext _context;

        public ImoveisController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var allImoveis = await _context.Imoveis.Include(v => v.Vendedor).ToListAsync();
            ViewBag.Imoveis = allImoveis;
            return View(allImoveis);
        }
    }
    }

