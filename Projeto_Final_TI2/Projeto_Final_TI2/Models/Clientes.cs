using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web;

namespace Projeto_Final_TI2.Models
{
    public class Clientes
    {
        //id do cliente
        public int IdCliente { get; set; }
        //localidade do cliente
        public string Localidade { get; set; }
        //data de nascimento do cliente
        public DateTime DataNasc { get; set; }
        //morada do cliente
        public string Morada { get; set; }
        //nome do cliente
        public string NomeCliente { get; set; }

        //foreign key reservas
        [ForeignKey("Reservas")]
        public int ReservasFK { get; set; }
        public Reservas Reserva { get; set; }

        public ICollection<Hoteis>ListadeHoteis { get; set; }
    }
}
