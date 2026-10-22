using FilmesAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.CompilerServices;

namespace FilmesAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class FilmeController : ControllerBase
{
    private static List<Filme> filmes = new List<Filme>();

    [HttpPost]
    public void AdiconarFilme([FromBody] Filme filme)
    {

        // Lógica para adicionar um filme
       
        
         filmes.Add(filme);
         Console.WriteLine(filme.Titulo);
         Console.WriteLine(filme.Duracao);
        
       
    }


}
