using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeakUp.Domain.Entities
{
    public class Aluno : Entity
    {
        public Aluno(
            ENivelConversacao nivelConversacao,
            string tempoEstudaIngles,
            EDisponibilidadeConversacao disponibilidadeConversacao,
            DateTime dataIngresso,
            EPersonalidade ePersonalidade,
            bool isDisponivel
            )
        {
            NivelConversacao = nivelConversacao;
            TempoEstudaIngles = tempoEstudaIngles;
            DisponibilidadeConversacao = disponibilidadeConversacao;
            DataIngresso = dataIngresso;
            EPersonalidade = ePersonalidade;
            IsDisponivel = isDisponivel;

        }
        private ENivelConversacao NivelConversacao { get; set; }
       private string TempoEstudaIngles { get; set; }
       private EDisponibilidadeConversacao DisponibilidadeConversacao { get; set; }
       private DateTime DataIngresso { get; set; } = DateTime.MinValue;
       private EPersonalidade EPersonalidade { get; set; }
       private bool IsDisponivel { get; set; }

    }

}
