using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeakUp.Domain.Entities
{
    public class Logradouro : Entity
    {
        public Logradouro(string logradouroName)
        {
            LogradouroName = logradouroName;
        }
        private string LogradouroName;
    }
}
