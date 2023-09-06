using System.ComponentModel.DataAnnotations;

namespace api.Data.Dtos;

public class RetornoAtorDto
{
    public string nome_ator { get; set; }
    public DateTime data_nascimento { get; set; }
}

