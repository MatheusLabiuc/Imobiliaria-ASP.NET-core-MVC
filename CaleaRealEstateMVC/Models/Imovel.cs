using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CaleaRealEstateMVC.Models
{
    public class Imovel
    {
        [Key]
        public int Id { get; set; }
        
        public string Descricao { get; set; }

        public string ImagemURL { get; set; }

        public double Valor { get; set; }

        public DateTime DataCadastro { get; set; }

        public bool Ativo { get; set; }

        //relationships

        public int EnderecoId { get; set; }

        [ForeignKey("EnderecoId")]

        public Endereco Endereco { get; set; }

        public int VendedorId { get; set; }


        [ForeignKey("VendedorId")]

        public Vendedor Vendedor { get; set; }
    }
}
