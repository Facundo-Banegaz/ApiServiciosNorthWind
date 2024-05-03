using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ServiciosNorthWind.Data;
using ServiciosNorthWind.Models;

namespace ServiciosNorthWind.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly NorthwindContext _Context;

        public CategoryController(NorthwindContext context)
        {
            _Context = context; 
        }


        [HttpGet]
        public async Task<ActionResult<List<Category>>> GetAll()
        {
            var listaCategory = (from Category in _Context.Categories select Category).ToListAsync();

            return await listaCategory;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Category>> GetByID(int id)
        {
            var category = await _Context.Categories.FindAsync(id);

            if (category == null)
            {
                return NotFound();//codigo 404
            }
            else
            {
                return Ok(category); // codigo 200
            }
        }

        [HttpPost]
        public async Task<ActionResult<Category>> Add(Category category)
        {
            _Context.Add(category);
            await _Context.SaveChangesAsync();
            return Ok(category);
        }

    }
}
