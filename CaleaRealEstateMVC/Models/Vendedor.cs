﻿using System.ComponentModel.DataAnnotations.Schema;

namespace CaleaRealEstateMVC.Models
{
    public class Vendedor
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Documento { get; set; }

        public string Telefone { get; set; } 

        //relationships
        public List<Imovel> Imoveis { get; set;}
    }
}
