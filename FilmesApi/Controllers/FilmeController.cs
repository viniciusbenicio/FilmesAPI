using FilmesApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace FilmesApi.Controllers;

[ApiController]
[Route("[controller]")]
public class FilmeController : ControllerBase
{
    //Lista de Filmes...
    private static List<Filme> filmes = new List<Filme>();
    private static int Id = 0;

    //Criando um Filme...
    [HttpPost]
    public IActionResult AdicionaFilme([FromBody] Filme filme)
    {
            filme.Id = Id++;
            filmes.Add(filme);
            return CreatedAtAction(nameof(RecuperaFilmePorId), 
                new {id = filme.Id}, 
                          filme);
    }

    //Recuperando os Filmes...
    [HttpGet]
    public IEnumerable<Filme> RecuperaFilmes([FromQuery]int skip = 0, [FromQuery]int take = 50)
    {
        return filmes.Skip(skip).Take(take);
    }

    //Recuperando Filme por Id...
    [HttpGet("{id}")]
    public IActionResult RecuperaFilmePorId(int id)
    {
        var filme = filmes.FirstOrDefault(filme => filme.Id == id);

        if(filme == null) return NotFound();

        return Ok(filme);




    }
    

}
