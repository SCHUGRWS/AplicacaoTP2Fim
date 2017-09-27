//Richard Wilhian Schug
//richard.schug@catolicasc.org.br

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AvaliacaoTP2.Models
{
    public class AssociationType
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Periodo { get; set; }
        public int Mensalidade { get; set; }

    }
}