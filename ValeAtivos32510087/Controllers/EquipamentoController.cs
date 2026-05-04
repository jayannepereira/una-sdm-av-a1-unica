using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ValeAtivos32510087.Data;
using ValeAtivos32510087.Models;

namespace ValeAtivos32510087.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EquipamentoController : ControllerBase
    {
        private readonly AppDbContext _context;
        public EquipamentoController(AppDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<IActionResult> AddEquipamentos([FromBody] Equipamento equipamento)
        {
            _context.Equipamentos.Add(equipamento);
            await _context.SaveChangesAsync();

            return Ok(equipamento);
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Equipamento>>> GetEquipamentos()
        {
            var equipamento = await _context.Equipamentos.ToListAsync();
            return Ok(equipamento);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Equipamento>> GetEquipamentos(int id)
        {
            var equipamento = await _context.Equipamentos.FindAsync(id);
            if(equipamento == null)
            {   
                return NotFound();
            }
            
            return Ok(equipamento);
        }
    }
}