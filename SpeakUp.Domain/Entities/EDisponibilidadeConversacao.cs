using System.ComponentModel;

namespace SpeakUp.Domain.Entities;

public enum EDisponibilidadeConversacao
{
    [Description("Só tenho disponibilidade no turno da noite")]
    Noite = 0,

    [Description("Sou bem flexível e marcando com antecedência tenho disponibilidade qualquer dia")]
    Flexivel = 1,

    [Description("Só tenho disponibilidade nos turnos da manhã ou tarde")]
    ManhaOuTarde  = 2,

    [Description("Só tenho disponibilidade aos finais de semana")]
    FimDeSemana = 3,

    [Description("Minha rotina é bem louca mas sempre vou conseguir reservar 1 hora por semana")]
    SemRotina = 4
}