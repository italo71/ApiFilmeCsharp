using api.Data;
using api.Data.Dtos;
using api.Models;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers;

[ApiController]
[Route("[Controller]")]
public class AtorController : ControllerBase
{
    private FilmeContext _context;
    private IMapper _mapper;

    public AtorController(FilmeContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    [HttpPost]
    public IActionResult adicionaAtor([FromBody]CreateAtorDto AtorDto)
    {
        Ator ator = _mapper.Map<Ator>(AtorDto);
        _context.Add(ator);
        _context.SaveChanges();
        return CreatedAtAction(nameof(RecuperAtorPorId), new { id = ator.id }, ator);
    }

    [HttpGet("{id}")]
    public IActionResult RecuperAtorPorId(int id)
    {
        var ator = _context.Atores.FirstOrDefault(ator => ator.id == id);
        if (ator == null) return NotFound();
        RetornoAtorDto atorConvertido = _mapper.Map<RetornoAtorDto>(ator);
        return Ok(atorConvertido);
    }

    [HttpGet]
    public IEnumerable<Ator> RecuperaAtores([FromQuery] int skip = 0, [FromQuery] int take = 10)
    {

        return _context.Atores.Skip(skip).Take(take);
    }
}
