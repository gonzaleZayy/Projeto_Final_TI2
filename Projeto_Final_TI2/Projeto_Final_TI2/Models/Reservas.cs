using System;
using System.Collections.Generic;
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
        public ICollection<Hoteis> ListaDeHoteis { get; set; }
    }
}
