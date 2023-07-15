using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SpeakUp.Domain.Entities;

namespace SpeakUp.Domain.Entities
{
    public class BairroCidade : Entity
    {
        public BairroCidade(Guid bairro, Guid cidade)
        {
            Bairro = bairro;
            Cidade = cidade;
        }
        private Guid Bairro { get; set; }
        private Guid Cidade { get; set; }
    }
}
