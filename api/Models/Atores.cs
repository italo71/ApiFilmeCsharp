using System.ComponentModel.DataAnnotations;

namespace api.Models;

public class Ator
{
    [Key]
    [Required]
    public int id { get; set; }
    [Required(ErrorMessage = "Nome do ator não pode ser vazio")] public string nome_ator { get; set; }
    [Required(ErrorMessage = "O campo Data é obrigatório.")]
    [DataType(DataType.Date)]
    [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
    public DateTime data_nascimento { get; set; }
    public string? natalidade { get; set; }
    public string? conjuge { get; set; }
}
