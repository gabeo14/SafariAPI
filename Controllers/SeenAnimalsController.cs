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
  }
}