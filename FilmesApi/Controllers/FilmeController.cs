using FilmesApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace FilmesApi.Controllers;

[ApiController]
[Route("[controller]")]
public class FilmeController : ControllerBase
{
    //Lista de Filmes...
    private static List<Filme> filmes = new List<Filme>();

    //Criando um Filme...
    [HttpPost]
    public void AdicionaFilme([FromBody] Filme filme)
    {
            filmes.Add(filme);
            Console.WriteLine
                         ($"  Titulo  : {filme.Titulo} " +
                          $"  Genero  : {filme.Genero} " +
                          $"  Duração : {filme.Duracao} ");
    }

    //Recuperando os Filmes...
    [HttpGet]
    public IEnumerable<Filme> RecuperaFilmes()
    {
        return filmes;
    }

}
