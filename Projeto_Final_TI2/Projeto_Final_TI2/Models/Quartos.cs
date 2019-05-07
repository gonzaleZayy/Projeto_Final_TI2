using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
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

        //foreign key reservas
        [ForeignKey("Reservas")]
        public int ReservasFK { get; set; }
        public Reservas Reserva { get; set; }

        //foreign key reservas
        [ForeignKey("Hoteis")]
        public int HotelFK { get; set; }
        public Hoteis Hotel { get; set; }

        //hoteis com quartos
        public ICollection<Hoteis> ListaDeHoteis { get; set; }
    }
}
