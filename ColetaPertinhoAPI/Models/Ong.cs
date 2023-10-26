using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ColetaPertinhoAPI.Models;

[Table("Ongs")]
public class Ong
{
    [Key]
    public int OngId { get; set; }
    [Required]
    [StringLength(100)]
    public string? Nome { get; set; }
    [Required]
    [StringLength(200)]
    public string? LocalColeta { get; set; }
    [StringLength(100)]
    public string? NomeResponsavel { get; set; }
    [StringLength(100)]
    public string? Email { get; set; }
    public DateTime DataCadastro { get; set; }
    public DateTime DataAtualizacao { get; set; }
    public bool Ativo { get; set; }
}
