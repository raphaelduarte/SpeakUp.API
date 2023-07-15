using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeakUp.Domain.Entities
{
    public class DataNascimento : Entity
    {
        public DataNascimento(DateTime nascimento)
        {
            Nascimento = nascimento;
        }
        private DateTime Nascimento { get; set; }
    }
}
