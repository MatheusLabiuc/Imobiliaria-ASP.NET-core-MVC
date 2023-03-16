using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CaleaRealEstateMVC.Models
{
    public class ImovelEndereco
    {
        [Key]
        public int Id { get; set; }

        public string Logradouro { get; set; }

        public string Numero { get; set; }

        public string Complemento { get; set; }

        public string Cep { get; set; }

        public string Bairro { get; set; }

        public string Cidade { get; set; }

        public string Estado { get; set; }

        //relationship

        public Imovel Imovel { get; set; }
    }
}
