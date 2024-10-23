using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using back_end.Infrastructure.Data;
using back_end.Domain.Entities;

namespace back_end.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConsorciosController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ConsorciosController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IEnumerable<Consorcios>> GetConsorcios()
        {
            return await _context.Consorcios.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Consorcios>> GetConsorcio(int id)
        {
            var consorcio = await _context.Consorcios.FindAsync(id);

            if (consorcio == null)
            {
                return NotFound();
            }

            return consorcio;
        }
    }
}
