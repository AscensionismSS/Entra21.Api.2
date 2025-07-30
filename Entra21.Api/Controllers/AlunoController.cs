using System.Reflection;
using Microsoft.AspNetCore.Mvc;
using Modelo.Domain;


namespace Entra21.Api.Controllers
{

    [Route("api/[controller]")]
    [ApiController]

    public class AlunoController : Controller
    {
        [HttpGet("BuscarDadosAluno/{id}")]
        public IActionResult BuscarDadosAluno(int id)
        {
            try
            {
                Aluno aluno = new Aluno();

                aluno.Id = 1;
                aluno.Nome = "João da Silva";
                aluno.Idade = 20;
                aluno.Cep = "12345-678";

                return Ok(aluno);

            }
            catch (Exception ex)
            {

                return BadRequest();
            }
        }
    }
}
