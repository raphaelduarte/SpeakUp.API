using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeakUp.Domain.Entities
{
    public class Telefone : Entity
    {
        public Telefone(int ddd, long telefoneNumero)
        {
            Ddd = ddd;
            TelefoneNumero = telefoneNumero;
        }

        private int Ddd { get; set; }
        private long TelefoneNumero { get; set; }
    }
}
