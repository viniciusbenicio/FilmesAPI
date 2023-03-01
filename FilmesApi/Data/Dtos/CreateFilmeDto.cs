using System.ComponentModel.DataAnnotations;

namespace FilmesApi.Data.Dtos;

public class CreateFilmeDto
{
    [Required(ErrorMessage = "O Título do filme é obrigatório")]
    public string Titulo { get; set; }
    [Required(ErrorMessage = "O Genero do titulo é obrigatório")]
    [StringLength(50, ErrorMessage = "O Tamanho do Genero não pode execder 50 caracteres")]
    public string Genero { get; set; }
    [Required()]
    [Range(70, 600, ErrorMessage = "A Duração deve ter entre 70 e 600 minutos")]
    public int Duracao { get; set; }
}
