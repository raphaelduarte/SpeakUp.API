namespace SpeakUp.Domain.Entities;

public class Usuario : Entity
{
    public Usuario(
        Guid nomeCompletoId,
        Guid cpfId,
        Guid enderecoCompletoId,
        Guid telefoneId,
        Guid emailId,
        ETipoUsuario eTipodUsuario,
        Guid dataNascimentoId
    )
    {
        NomeCompletoId = nomeCompletoId;
        CpfId = cpfId;
        EnderecoCompletoId = enderecoCompletoId;
        TelefoneId = telefoneId;
        EmailId = emailId;
        ETipoUsuario = eTipodUsuario;
        DataNascimentoId = dataNascimentoId;

    }
    private Guid NomeCompletoId { get; set; }
    private Guid CpfId { get; set; }
    private Guid EnderecoCompletoId { get; set; }
    private Guid TelefoneId { get; set; }
    private Guid EmailId { get; set; }
    private Guid DataNascimentoId { get; set; }
    private ETipoUsuario ETipoUsuario { get; set; }
}