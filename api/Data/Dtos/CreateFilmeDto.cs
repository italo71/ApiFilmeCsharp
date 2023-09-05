using System.ComponentModel.DataAnnotations;

namespace api.Data.Dtos;

public class CreateFilmeDto
{
    [Required(ErrorMessage = "O título do Filme é obrigatório")]
    [StringLength(30)]
    public string Titulo { get; set; }
    [Required(ErrorMessage = "O Genero do FIlme é obrigatório")]
    [StringLength(50, ErrorMessage = "Genero maior que 50 caracteres")]
    public string Genero { get; set; }
    [Required]
    [Range(70, 600, ErrorMessage = "Tempo do filme deve ser entre 70 e 600 minutos")]
    public int Duracao { get; set; }
}
