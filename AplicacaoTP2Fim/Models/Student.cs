//Richard Wilhian Schug
//richard.schug@catolicasc.org.br

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AvaliacaoTP2.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public virtual Band Faixa { get; set; }
        public virtual AssociationType TipoAssociacao { get; set; }

    }
}