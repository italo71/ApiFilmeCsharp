using System.ComponentModel.DataAnnotations;

namespace api.Models;

public class Filme
{
    [Key]
    [Required]
    public int id { get; set; }

    [Required(ErrorMessage = "O título do Filme é obrigatório")]
    [StringLength(30)]
    public string Titulo { get; set; }
    [Required (ErrorMessage = "O Genero do FIlme é obrigatório")]
    [MaxLength(50, ErrorMessage = "Genero maior que 50 caracteres")]
    public string Genero { get; set; }
    [Required]
    [Range(70,600, ErrorMessage ="Tempo do filme deve ser entre 70 e 600 minutos")]
    public int Duracao { get; set; }
}
