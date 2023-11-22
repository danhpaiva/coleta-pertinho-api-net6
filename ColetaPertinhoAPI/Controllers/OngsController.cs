using ColetaPertinhoAPI.Context;
using ColetaPertinhoAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ColetaPertinhoAPI.Controllers
{
    [Route("v1/api/ongs")]
    [ApiController]
    public class OngsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public OngsController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Ong>> BuscarTodasOngs()
        {
            var ongs = _context.Ongs.ToList();
            if (ongs is null)
                return NotFound("Nenhuma Ong encontrada!");
            return ongs;
        }

        [HttpGet("{id:int}", Name = "obter-produto")]
        public ActionResult<Ong> BuscarOng(int id)
        {
            var ong = _context.Ongs.FirstOrDefault(o => o.OngId == id);
            if (ong is null)
                return NotFound($"Ong com o Id: {id} não encontrada!");
            return ong;
        }

        [HttpGet("{nomeResponsavel}", Name = "obter-produto-responsavel")]
        public ActionResult<Ong> BuscarOngPorResponsavel(string nomeResponsavel)
        {
            var ong = _context.Ongs.FirstOrDefault(o => o.NomeResponsavel == nomeResponsavel);
            if (ong is null)
                return NotFound($"Nenhuma ong encontrada para o responsável: {nomeResponsavel}!");
            return ong;
        }

        [HttpPost]
        public ActionResult CadastrarOng(Ong ong)
        {
            try
            {
                if (ong is null)
                    return BadRequest();

                _context.Ongs.Add(ong);
                _context.SaveChanges();

                return new CreatedAtRouteResult("obter-produto", new { id = ong.OngId }, ong);
            }
            catch (Exception)
            {
                return BadRequest("Houve um erro!");
            }
        }

        [HttpPut("{id:int}")]
        public ActionResult AtualizarOng(int id, Ong ong)
        {
            if (id != ong.OngId)
                return BadRequest();

            _context.Entry(ong).State = EntityState.Modified;
            _context.SaveChanges();

            return Ok(ong);
        }

        [HttpDelete("{id:int}")]
        public ActionResult DeletarOng(int id)
        {
            var ong = _context.Ongs.FirstOrDefault(o => o.OngId == id);

            if (ong is null)
                return NotFound($"Ong {id} não encontrada!");

            _context.Ongs.Remove(ong);
            _context.SaveChanges();

            return Ok(ong);
        }
    }
}
