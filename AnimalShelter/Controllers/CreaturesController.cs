using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AnimalShelter.Models;

namespace AnimalShelter.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class CreaturesController : ControllerBase
  {
    private readonly AnimalShelterContext _db;

    public CreaturesController(AnimalShelterContext db)
    {
      _db = db;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Creature>>> Get(string name, string spieces, string mythical)
    {
      var query = _db.Creatures.AsQueryable();

      if (name != null)
      {
        query = query.Where(entry => entry.Name == name);
      }

      if (spieces != null)
      {
        query = query.Where(entry => entry.Spieces == spieces);
      }

      if (mythical != null)
      {
        query = query.Where(entry => entry.Mythical == mythical);
      }

      return await query.ToListAsync();
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Creature>> GetCreature(int id)
    {
      var creature = await _db.Creatures.FindAsync(id);

      if (creature == null)
      {
        return NotFound();
      }

      return creature;
    }


    [HttpPost]
    public async Task<ActionResult<Creature>> Post(Creature creature)
    {
      _db.Creatures.Add(creature);
      await _db.SaveChangesAsync();

      return CreatedAtAction(nameof(GetCreature), new { id = creature.CreatureId }, creature);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Put(int id, Creature creature)
    {
      if (id != creature.CreatureId)
      {
        return BadRequest();
      }

      _db.Entry(creature).State = EntityState.Modified;

      try
      {
        await _db.SaveChangesAsync();
      }
      catch (DbUpdateConcurrencyException)
      {
        if (!CreatureExists(id))
        {
          return NotFound();
        }
        else
        {
          throw;
        }
      }

      return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteCreature(int id)
    {
      var creature = await _db.Creatures.FindAsync(id);
      if (creature == null)
      {
        return NotFound();
      }

      _db.Creatures.Remove(creature);
      await _db.SaveChangesAsync();

      return NoContent();
    }

    private bool CreatureExists(int id)
    {
      return _db.Creatures.Any(e => e.CreatureId == id);
    }
  }
}