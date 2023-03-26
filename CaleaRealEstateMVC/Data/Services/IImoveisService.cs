using CaleaRealEstateMVC.Models;

namespace CaleaRealEstateMVC.Data.Services
{
    public interface IImoveisService
    {
        Task<List<Imovel>> GetAllAsync();

    }
}
