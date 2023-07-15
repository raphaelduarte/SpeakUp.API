using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeakUp.Domain.Entities
{
    public class Email : Entity
    {
        public Email(string enderecoEmail)
        {
            EnderecoEmail = enderecoEmail;
        }
        private string EnderecoEmail { get; set; }
    }
}
