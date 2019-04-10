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
    }
}
