using System.ComponentModel;

namespace SpeakUp.Domain.Entities;

public enum EPersonalidade
{
    [Description("Não sou extremamente tímido nem extrovertido mas não tenho vergonha de fazer amigos e puxar papo")]
    Normal = 0,

    [Description("Sou bem tímido e tenho um pouco de vergonha de conversar até mesmo em português")]
    Timido = 1,

    [Description("Sou bem extrovertido e adoro falar, bater papo e fazer novos amigos")]
    Extrovertido = 2
}