using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ServiciosNorthWind.Data;
using ServiciosNorthWind.Models;
namespace ServiciosNorthWind.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShipperController : ControllerBase
    {
        private readonly NorthwindContext _Context;
        public ShipperController(NorthwindContext context)
        {
            _Context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Shipper>>> GetAll() 
        {
            var listaShipper =(from sh in _Context.Shippers select sh).ToListAsync();

            return await listaShipper;
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Shipper>> GetByID(int id)
        {
            var Shipper = await _Context.Shippers.FindAsync(id);

            if(Shipper == null)
            {
                return NotFound();//codigo 404
            }
            else
            {
                return Ok(Shipper); // codigo 200
            }
        }

        [HttpPost]
        public async Task<ActionResult<Shipper>> Add(Shipper shipper)
        {
            _Context.Add(shipper);
            await _Context.SaveChangesAsync();
            return Ok(shipper);
        }
    }
}
