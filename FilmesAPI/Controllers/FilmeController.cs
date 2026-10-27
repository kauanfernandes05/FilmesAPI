using AutoMapper;
using FilmesAPI.Data;
using FilmesAPI.Data.Dtos;
using FilmesAPI.Models;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.CompilerServices;

namespace FilmesAPI.Controllers;

/// <summary>
/// Controller responsável pelo gerenciamento dos filmes.
/// </summary>
[ApiController]
[Route("[controller]")]
public class FilmeController : ControllerBase
{

    private FilmeContext _context;
    private IMapper _mapper;

    public FilmeController(FilmeContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }


    /// <summary>
    /// Adiona um filme ao banco de dados
    /// </summary>
    /// <param name="filmeDto">Objeto com os campos necessários para criação de um filme</param>
    /// <returns>IActionResult</returns>
    /// <response code="201"> Caso inserção seja feita com sucesso</response>
    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]

    public IActionResult AdiconarFilme(
        [FromBody] CreateFilmeDto filmeDto)
    {
        // Lógica para adicionar um filme
        Filme filme = _mapper.Map<Filme>(filmeDto);
        _context.filmes.Add(filme);
        _context.SaveChanges();
        return CreatedAtAction(nameof(RecuperarFilmePorId), new { id = filme.Id }, filme);   
    }

    /// <summary>
    /// Recupera todos os filmes cadastrados no banco de dados
    /// </summary>
    /// <param name="skip">Quantidade de registros que serão ignorados</param>
    /// <param name="take">Quantidade máxima de filmes que serão retornados</param>
    /// <returns>Uma lista de filmes cadastrados</returns>
    /// <response code="200">Filmes recuperados com sucesso</response>
    [HttpGet]
    public IEnumerable<ReadFilmeDto> RecuperaFilmes([FromQuery] int skip = 0, [FromQuery] int take = 50)
    {
        return _mapper.Map<List<ReadFilmeDto>>(_context.filmes.Skip(skip).Take(take));
    }

    /// <summary>
    /// Recupera um filme específico no banco de dados pelo seu ID
    /// </summary>
    /// <param name="id">Identificador do filme que será consultado</param>
    /// <returns>O filme correspondente ao ID informado</returns>
    /// <response code="200">Filme encontrado com sucesso</response>
    /// <response code="404">Filme não encontrado no banco de dados</response>
    [HttpGet("{id}")]
    public IActionResult RecuperarFilmePorId(int id)
    {
        // Lógica para recuperar um filme por IDs
        var filme =  _context.filmes.FirstOrDefault(filme => filme.Id == id);
        if (filme == null) return NotFound();
        var filmeDto = _mapper.Map<ReadFilmeDto>(filme);    
        return Ok(filmeDto);
    }


    /// <summary>
    /// Atualiza completamente os dados de um filme cadastrado no banco de dados
    /// </summary>
    /// <param name="id">Identificador do filme que será atualizado</param>
    /// <param name="filmeDto">Objeto contendo os novos dados do filme</param>
    /// <returns>Resultado da operação de atualização</returns>
    /// <response code="204">Filme atualizado com sucesso</response>
    /// <response code="400">Dados informados são inválidos</response>
    /// <response code="404">Filme não encontrado no banco de dados</response>
    [HttpPut("{id}")]
    public IActionResult AtualizaFilme(int id, 
        [FromBody] UpdateFilmeDto filmeDto)
        
    {
        // Lógica para atualizar um filme
        var filme = _context.filmes.FirstOrDefault(filme => filme.Id == id);
        if (filme == null) return NotFound();
        _mapper.Map(filmeDto, filme);
        _context.SaveChanges();
        return NoContent();
    }

    /// <summary>
    /// Atualiza parcialmente os dados de um filme cadastrado no banco de dados
    /// </summary>
    /// <param name="id">Identificador do filme que será atualizado</param>
    /// <param name="patch">Objeto contendo as alterações que serão aplicadas ao filme</param>
    /// <returns>Resultado da atualização parcial</returns>
    /// <response code="204">Filme atualizado parcialmente com sucesso</response>
    /// <response code="400">Dados de atualização inválidos</response>
    /// <response code="404">Filme não encontrado no banco de dados</response>
    [HttpPatch("{id}")]
    public IActionResult AtualizaFilmeParcial(int id, JsonPatchDocument<UpdateFilmeDto> patch)
    {
        // Lógica para atualizar parcialmente um filme

        var filme = _context.filmes.FirstOrDefault(filme => filme.Id == id);
        if (filme == null) return NotFound();
        var filmeParaAtualizar = _mapper.Map<UpdateFilmeDto>(filme);
        patch.ApplyTo(filmeParaAtualizar, ModelState);
        if(!TryValidateModel(filmeParaAtualizar))
        {
            return ValidationProblem(ModelState);
        }

        _mapper.Map(filmeParaAtualizar, filme);
        _context.SaveChanges();
        return NoContent();
    }

    /// <summary>
    /// Remove um filme cadastrado no banco de dados 
    /// </summary>
    /// <param name="id">Identificador do filme que será removido</param>
    /// <returns>Resultado da operação de exclusão</returns>
    /// <response code="204">Filme removido com sucesso</response>
    /// <response code="404">Filme não encontrado no banco de dados</response>
    [HttpDelete("{id}")]
    public IActionResult DeletaFilme(int id)
    {
        // Lógica para deletar um filme
        var filme = _context.filmes.FirstOrDefault(filme => filme.Id == id);
        if (filme == null) return NotFound();
        _context.Remove(filme);
        _context.SaveChanges();
        return NoContent();
    }

}
