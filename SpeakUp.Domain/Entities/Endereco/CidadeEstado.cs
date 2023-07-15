using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeakUp.Domain.Entities
{
    public class CidadeEstado : Entity
    {
        public CidadeEstado(Guid cidade, Guid estado)
        {
            Cidade = cidade;
            Estado = estado;
        }
        private Guid Cidade { get; set; }
        private Guid Estado { get; set; }
    }
}
