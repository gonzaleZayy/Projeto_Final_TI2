using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web;

namespace Projeto_Final_TI2.Models
{
    public class Hoteis
    {
        //id dos hoteis
        public int IdHotel { get; set; }
        //nome dos hoteis
        public string NomeHotel { get; set; }
        //local do hotel
        public string LocalHotel { get; set; }
        //preço do quarto do hotel
        public decimal PrecoHotel { get; set; }
        //vagas do hotel
        public int VagasHotel { get; set; }

        //FOREIGN KEYS
        //foreign key fotos
        [ForeignKey("Fotos")]
        public int FotoFK { get; set; }
        public Fotos Foto { get; set; }
        //foreign key quartos
        [ForeignKey("Quartos")]
        public int QuartoFK { get; set; }
        public Quartos Quarto { get; set; }
    }
}
