using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeakUp.Domain.Entities
{
    public class NumeroEndereco : Entity
    {
        public NumeroEndereco(int numeroEndereco)
        {
            Numero = numeroEndereco;
        }
        private int Numero { get; set; }
    }
}
