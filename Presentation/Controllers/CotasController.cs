using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using back_end.Infrastructure.Data;
using back_end.Domain.Entities;

namespace back_end.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CotasController : ControllerBase
    {
        private readonly AppDbContext _context;

        public CotasController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IEnumerable<Cotas>> GetCotas()
        {
            return await _context.Cotas.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Cotas>> GetCota(int id)
        {
            var cota = await _context.Cotas.FindAsync(id);

            if (cota == null)
            {
                return NotFound();
            }

            return Ok(cota);
        }
    }
}
