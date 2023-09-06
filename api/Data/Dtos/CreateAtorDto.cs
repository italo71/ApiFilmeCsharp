using System.ComponentModel.DataAnnotations;

namespace api.Data.Dtos;

public class CreateAtorDto
{
    [Required(ErrorMessage = "Nome do ator não pode ser vazio")] public string nome_ator { get; set; }
    [Required(ErrorMessage = "O campo Data é obrigatório.")]
    [DataType(DataType.Date)]
    [DisplayFormat(DataFormatString = "{yyyy-MM-dd}", ApplyFormatInEditMode = true)]
    public DateTime data_nascimento { get; set; }
}
