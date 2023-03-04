using System.ComponentModel.DataAnnotations;

namespace FilmesApi.Data.Dtos;

public class UpdateCinemaDto
{
    [Required(ErrorMessage = "O Campo de Nome é obrigatório.")]
    public string Nome { get; set; }
}
