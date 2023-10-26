namespace ColetaPertinhoAPI.Models;
public class Ong
{
    public int OngId { get; set; }
    public string? Nome { get; set; }
    public string? LocalColeta { get; set; }
    public string? NomeResponsavel { get; set; }

    public string? Email { get; set; }
    public DateTime DataCadastro { get; set; }
    public DateTime DataAtualizacao { get; set; }
    public bool Ativo { get; set; }
}
