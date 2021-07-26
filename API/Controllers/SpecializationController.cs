using System.Collections.Generic;
using System.Threading.Tasks;
using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SpecializationController : ControllerBase
    {
        private readonly DataContext _context;

        public SpecializationController(DataContext context )
        {
            _context = context;
        }
        [HttpGet]
        public async Task<IEnumerable<Specialization>>  GetSpecializations(){
            return await _context.Specializations.ToListAsync();
        }
        [HttpGet("{id}")]
        public async Task<Specialization> GetSpecialization(int id){
            return await _context.Specializations.FindAsync(id);
        }
    }
}