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
    // ordered by times seen
    public IEnumerable<SeenAnimals> Get()
    {
      var db = new SafariAPIContext();
      return db.SeenAnimals.OrderBy(o => o.CountOfTimesSeen);
    }
  }
}