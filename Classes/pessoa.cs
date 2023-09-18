using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace back_end.Classes
{
    public abstract class Pessoa
    {
        public string? nome { get; set; }
        public Endereco endereco { get; set; }

        public float rendimento {get; set;}
        public abstract double PagarImposto(float rendimento);
    }
}