using System;
using System.Web;

namespace Projeto_Final_TI2.Models
{
    public class Hoteis
    {
        //id dos hoteis
        public int Id { get; set; }
        //nome dos hoteis
        public string NomeHotel { get; set; }
        //local do hotel
        public string LocalHotel { get; set; }
        //preço do quarto do hotel
        public decimal PrecoHotel { get; set; }
        //vagas do hotel
        public int VagasHotel { get; set; }
        //foreign key quartos
        public int QuartoFK { get; set; }
        public Quartos Quarto { get; set; }
        //foreign key reservas
        public int ReservasFK { get; set; }
        public Reservas Reserva { get; set; }
        //foreign key clientes
        public int ClientesFK { get; set; }
        public Clientes Cliente { get; set; }
    }
}
