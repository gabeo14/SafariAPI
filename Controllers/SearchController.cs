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
  public class SearchController : ControllerBase
  {
    [HttpGet]
    public IQueryable<SeenAnimals> Search(string searchTerm)
    {
      var db = new SafariAPIContext();
      var searchResults = db.SeenAnimals.Where(w => w.Species.ToLower().Contains(searchTerm.ToLower()));

      return searchResults;
    }
  }
}