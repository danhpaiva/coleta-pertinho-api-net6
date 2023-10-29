using ColetaPertinhoAPI.Context;
using ColetaPertinhoAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace ColetaPertinhoAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OngsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public OngsController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Ong>> Get()
        {
            var ongs = _context.Ongs.ToList();
            if (ongs is null)
                return NotFound("Ong não encontrada!");
            return ongs;
        }
    }
}
