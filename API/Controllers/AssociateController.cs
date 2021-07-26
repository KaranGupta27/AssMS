using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AssociateController : ControllerBase
    {
        private readonly DataContext _dataContext;
        public AssociateController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

    //  [HttpGet]   
    //  public ActionResult<IEnumerable<Associate>> GetAssociates()
    //  {
    //      return _dataContext.Associates.ToList();
    //  }
    //  [HttpGet("{id}")]   
    //  public ActionResult<Associate> GetAssociate(int id)
    //  {
    //      return _dataContext.Associates.Find(id);
    //  }

    [HttpGet]   
     public async Task<ActionResult<IEnumerable<Associate>>> GetAssociates()
     {
         return await _dataContext.Associates.ToListAsync();
     }
     [HttpGet("{id}")]   
     public async Task<ActionResult<Associate>> GetAssociate(int id)
     {
         return await _dataContext.Associates.FindAsync(id);
     }
    }
}