using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ServiciosNorthWind.Data;
using ServiciosNorthWind.Models;

namespace ServiciosNorthWind.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegionController : ControllerBase
    {
        private readonly NorthwindContext _Context;
        public RegionController(NorthwindContext context)
        {
            _Context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Region>>> GetAll()
        {
            var listaRegion = (from Region in _Context.Region select Region).ToListAsync();

            return await listaRegion;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Region>> GetByID(int id)
        {
            var Region = await _Context.Region.FindAsync(id);

            if (Region == null)
            {
                return NotFound();//codigo 404
            }
            else
            {
                return Ok(Region); // codigo 200
            }
        }

        [HttpPost]
        public async Task<ActionResult<Region>> Add(Region region)
        {
            _Context.Add(region);
            await _Context.SaveChangesAsync();
            return Ok(region);
        }
    }
}
