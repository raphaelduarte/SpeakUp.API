using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeakUp.Domain.Entities
{
    public class Cidade : Entity
    {
        public Cidade(string cidade)
        {
            CidadeName = cidade;
        }
        private string CidadeName { get; set; }
    }
}
