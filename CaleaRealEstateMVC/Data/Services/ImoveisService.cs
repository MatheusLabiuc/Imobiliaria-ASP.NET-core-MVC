using CaleaRealEstateMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace CaleaRealEstateMVC.Data.Services

{
    public class ImoveisService : IImoveisService
    {

        private readonly AppDbContext _context;

        public ImoveisService(AppDbContext context)
        {
            _context = context;
        }
        public async Task<List<Imovel>> GetAllAsync()
        {
            var result = await _context.Imoveis.ToListAsync();
            return result;
        }
    }

}