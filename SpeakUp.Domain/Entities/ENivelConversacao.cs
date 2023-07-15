using System.ComponentModel;

namespace SpeakUp.Domain.Entities;

public enum ENivelConversacao
{
    [Description("Zero (to começando agora, não falo nada além de palavras básicas como 'Hello' e 'please')")]
    Zero = 0,

    [Description("Iniciante (sei algumas coisas, formo algumas frases mas tenho pouco conhecimento e bastante dificuldade)")]
    Iniciante = 1,

    [Description("Intermediário (consigo entender muita coisa quando leio, até entendo quando escuto algumas coisas, sei me comunicar o básico mas nada de ter uma conversa ou de escrever textos longos)")]
    Intermadiario = 2,

    [Description("Avançado (consigo ler bem, entender bem e consigo manter uma conversa em inglês, quero aprimorar apenas mas já sei me desenrolar bem)")]
    Avancado = 3
}