using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Reflection.Metadata.Ecma335;

namespace BibliothekAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MainController : ControllerBase
    {
        // GET
        [HttpGet("test")]
        public string Get()
        {
            return "Test";
        }

        //Get data
        [HttpGet("{libraryName}/{mediumId}")]
        public async Task<ActionResult<Medium>> GetDataFromLibrary(string libraryName, int mediumId)
        {
            var list = new List<Medium>();
            switch (libraryName)
            {
                case "Herforder Bibliothek":
                    var her = new HerfordData();
                    list.AddRange(new List<Medium>() { her.m1, her.m2, her.m3, her.m4 });
                    foreach(var obj in list)
                    {
                        if (obj.Id == mediumId)
                        {
                            return obj;
                        }
                    }
                    return StatusCode(404);
                case "Kölner Stadtbibliothek":
                    var col = new CologneData();
                    list.AddRange(new List<Medium>() { col.m1, col.m2, col.m3, col.m4 });
                    foreach(var obj in list)
                    {
                        if(obj.Id == mediumId)
                        {
                            return obj;
                        }
                    }
                    return StatusCode(404);
                default: return StatusCode(404);
            }
        }
    }
}
