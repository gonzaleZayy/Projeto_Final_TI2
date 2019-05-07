using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web;

namespace Projeto_Final_TI2.Models
{
    public class Reservas
    {
        //id da reserva
        public int IdReserva { get; set; }
        //data da reserva
        public decimal dataReserva { get; set; }
        //check in
        public Boolean checkIn { get; set; }
        //data de entrada
        public int DataEntrada { get; set; }
        //dia de saida
        public int DataSaida { get; set; }
        //verificar se esta pago ou nao
        public Boolean Pago { get; set; }
        //estado do pagamento  
        public string estadoPagamento { get; set; }
        //reservas

        //foreign keys
        //foreign key clientes
        [ForeignKey("Clientes")]
        public int ClientesFK { get; set; }
        public Clientes Cliente { get; set; }

        //foreign key hotel
        [ForeignKey("Hoteis")]
        public int HoteisFK { get; set; }
        public Hoteis Hotel { get; set; }

        //foreign key Quartos
        [ForeignKey("Quartos")]
        public int QuartosFK { get; set; }
        public Quartos Quarto { get; set; }

        public ICollection<Hoteis> ListaDeHoteis { get; set; }
    }
}
