using System.Reflection;
using Microsoft.AspNetCore.Mvc;
using Modelo.Application.Interface;
using Modelo.Domain;


namespace Entra21.Api.Controllers
{

    [Route("api/[controller]")]
    [ApiController]

    public class AlunoController : Controller
    {

        private readonly IAlunoApplication _alunoApplication;

        public AlunoController(IAlunoApplication alunoApplication)
        {
            _alunoApplication = alunoApplication;
        }


        [HttpGet("BuscarDadosAluno/{id}")]
        public IActionResult BuscarDadosAluno(int id)
        {
            try
            {
                var aluno = _alunoApplication.BuscarAluno(id);

                return Ok(aluno);

            }
            catch (Exception ex)
            {

                return BadRequest();
            }
        }
    }
}
