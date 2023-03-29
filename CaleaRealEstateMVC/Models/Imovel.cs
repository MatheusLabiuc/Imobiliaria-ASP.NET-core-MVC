using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CaleaRealEstateMVC.Models
{
    public class Imovel
    {
        [Key]
        public int Id { get; set; }
        public string ImagemURL { get; set; }

        public string Logradouro { get; set; }

        public string Numero { get; set; }

        public string Complemento { get; set; }

        public string Cep { get; set; }

        public string Bairro { get; set; }

        public string Cidade { get; set; }

        public string Estado { get; set; }

        public string Descricao { get; set; }

        public double Valor { get; set; }

        public DateTime DataCadastro { get; set; }

        //relationships

        public int VendedorId { get; set; }
        public Vendedor Vendedor { get; set; }
    }
}
