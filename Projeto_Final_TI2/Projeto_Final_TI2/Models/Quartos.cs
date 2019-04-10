using System;
using System.Collections.Generic;
using System.Web;

namespace Projeto_Final_TI2.Models
{
    public class Quartos
    {
        //id do quarto
        public int IdQuarto { get; set; }
        //preço do quarto
        public decimal precoQuarto { get; set; }
        //descrição do quarto
        public string descrQuarto { get; set; }
        //hoteis com quartos
        public ICollection<Hoteis> ListaDeHoteis { get; set; }
    }
}
