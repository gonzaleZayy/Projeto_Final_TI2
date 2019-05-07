using System;
using System.Collections.Generic;
using System.Web;

namespace Projeto_Final_TI2.Models
{
    public class Fotos
    {
        //id da foto
        public int IdFoto { get; set; }
        //string com nome do ficheiro
        public string nomeFicheiro { get; set; }
        //legenda das fotos
        public string legenda { get; set; }

        public ICollection<Hoteis> ListaDeHoteis { get; set; }

    }
}
