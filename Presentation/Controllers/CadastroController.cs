using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using back_end.Infrastructure.Data;
using back_end.Domain.Entities;
using Microsoft.AspNetCore.Authorization;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;

namespace back_end.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CadastroController : ControllerBase
    {
        private readonly AppDbContext _context;

        public CadastroController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        [Authorize]
        public async Task<ActionResult<IEnumerable<Cadastro>>> GetCadastros()
        {
            return await _context.Cadastros.ToListAsync();
        }

        [HttpGet("{id}")]
        [Authorize]
        public async Task<ActionResult<Cadastro>> GetCadastro(int id)
        {
            var cadastro = await _context.Cadastros.FindAsync(id);

            if (cadastro == null)
            {
                return NotFound();
            }

            return cadastro;
        }

        [HttpPost]
        public async Task<ActionResult<Cadastro>> CreateCadastro(Cadastro cadastro)
        {
            var cota = await _context.Cotas.FindAsync(cadastro.CotaId);
            if (cota == null)
            {
                return BadRequest("Cota não encontrada.");
            }

            cota.Status = "Ocupada";
            _context.Entry(cota).State = EntityState.Modified;

            cadastro.DataCadastro = DateTime.Now.Date;
            cadastro.NumeroCota = cota.NumeroCota;
            cadastro.Tipo = cota.Tipo;
            cadastro.Valor = cota.Valor;

            _context.Cadastros.Add(cadastro);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetCadastro), new { id = cadastro.Id }, cadastro);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateCadastro(int id, [FromBody] Cadastro cadastro)
        {
            // Busca o cadastro existente no banco de dados
            var existingCadastro = await _context.Cadastros.FindAsync(id);
            if (existingCadastro == null)
            {
                return NotFound(); // Retorna 404 caso não encontre o cadastro
            }

            // Atualiza apenas os campos permitidos
            if (!string.IsNullOrEmpty(cadastro.NomeUsuario))
            {
                existingCadastro.NomeUsuario = cadastro.NomeUsuario;
            }

            if (!string.IsNullOrEmpty(cadastro.Contato))
            {
                existingCadastro.Contato = cadastro.Contato;
            }

            if (!string.IsNullOrEmpty(cadastro.Parcelamento))
            {
                existingCadastro.Parcelamento = cadastro.Parcelamento;
            }

            // Salva as alterações no banco de dados
            await _context.SaveChangesAsync();

            // Retorna o objeto atualizado
            return Ok(existingCadastro); // Retorna 200 com o objeto atualizado
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCadastro(int id)
        {
            var cadastro = await _context.Cadastros.FindAsync(id);
            if (cadastro == null)
            {
                return NotFound();
            }

            var cota = await _context.Cotas.FindAsync(cadastro.CotaId);
            if (cota != null)
            {
                cota.Status = "Disponível";
                _context.Entry(cota).State = EntityState.Modified;
            }

            _context.Cadastros.Remove(cadastro);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CadastroExists(int id)
        {
            return _context.Cadastros.Any(e => e.Id == id);
        }
    }
}