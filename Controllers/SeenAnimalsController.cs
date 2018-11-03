using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SafariApi.Models;

namespace SafariAPI.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class SeenAnimalsController : ControllerBase
  {

    [HttpGet]
    // https://localhost:5001/api/SeenAnimals
    public IEnumerable<SeenAnimals> Get()
    {
      var db = new SafariAPIContext();
      return db.SeenAnimals;
    }

    [HttpPost]
    public ActionResult<SeenAnimals> Post([FromBody] SeenAnimals seenAnimals)
    {
      var db = new SafariAPIContext();
      db.SeenAnimals.Add(seenAnimals);
      db.SaveChanges();
      return seenAnimals;
    }

    [HttpDelete("{id}")]
    public ActionResult Delete(int id)
    {
      var db = new SafariAPIContext();
      var animal = db.SeenAnimals.FirstOrDefault(a => a.Id == id);
      if (animal == null)
      {
        return NotFound();
      }
      db.SeenAnimals.Remove(animal);
      db.SaveChanges();
      return Ok();
    }

    [HttpPut("{id}")]
    public ActionResult<SeenAnimals> Put([FromRoute] int id, [FromBody] SeenAnimals updated)
    {
      var db = new SafariAPIContext();
      var seenAnimals = db.SeenAnimals.FirstOrDefault(a => a.Id == id);

      seenAnimals.Species = updated.Species;
      seenAnimals.CountOfTimesSeen = updated.CountOfTimesSeen;
      seenAnimals.LocationOfLastSeen = updated.LocationOfLastSeen;

      db.SaveChanges();
      return updated;
    }
  }
}