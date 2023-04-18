using M1S09ExercicioSemana9.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace M1S09ExercicioSemana9.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class SemanaController : ControllerBase
    {
        private readonly SemanaContext _semanaContext;

        public SemanaController(SemanaContext semanaContext)
        {
            _semanaContext = semanaContext;
        }


        [HttpGet]
        public ActionResult Get()
        {
            return Ok();
        }

        [HttpGet]
        [Route("{id}")]
        public ActionResult Get([FromRoute] int Id)
        {
            return Ok();
        }

        [HttpPost]
        public ActionResult Post([FromBody] SemanaModel semanaModel)
        {
            if (semanaModel.Id > 0)
            {
                return Ok();
            }

            return BadRequest("Id deve ser maior que 0");
        }

        [HttpPut]
        [Route("{id}")]
        public ActionResult Put([FromBody] SemanaModel semanaModel,[FromRoute] int id)
        {
            if (semanaModel.Id == id)
            {
                return Ok();
            }

            return BadRequest("ID não encontrado!");
        }

        [HttpDelete]
        [Route("{id}")]
        public ActionResult Delete([FromRoute] int id)
        {
            var Id = _semanaContext.Semana.Find(id);

            if (Id == null)
            {
                return NotFound();
            }

            _semanaContext.Semana.Remove(Id);
            _semanaContext.SaveChanges();

            return NoContent();
        }

    }
}
