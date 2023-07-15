using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeakUp.Domain.Entities
{
    public class Cpf : Entity
    {
        public Cpf(long numeroCpf)
        {
            NumeroCpf = numeroCpf;
        }
        private long NumeroCpf { get; set; }
    }
}
