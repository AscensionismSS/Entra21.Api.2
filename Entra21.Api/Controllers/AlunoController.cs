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

        [HttpPost("InserirAluno")]
        public IActionResult InserirAluno([FromBody] Aluno aluno)
        {
            try
            {
                if (aluno == null)
                {
                    return BadRequest("Dados do aluno não podem ser nulos.");
                }
                _alunoApplication.InserirAluno(aluno);
                return Ok("Aluno inserido com sucesso.");
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro ao inserir aluno: {ex.Message}");
            }
        }

        [HttpDelete("ExcluirAluno")]

        public IActionResult ExcluirAluno(int id)
        {
            try
            {
                _alunoApplication.ExcluirAluno(id);
                return Ok("Aluno excluído com sucesso");

            }
            catch (Exception)
            {

                return BadRequest();
            }
        }

        [HttpPut("Atualizar Aluno")]

        public IActionResult AtualizarAluno(Aluno aluno)
        {
            try
            {
                _alunoApplication.AtualizarAluno(aluno);
                return Ok("Aluno Atualizado com sucesso");

            }
            catch (Exception)
            {

                return BadRequest();
            }
        }

        [HttpPatch("AtualizarAlunoParcial")]

        public IActionResult AtualizarAlunoParcial(Aluno aluno)
        {
            try
            {
                _alunoApplication.AtualizarAlunoParcial(aluno);
                return Ok("Aluno Atualizado com sucesso");
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro ao atualizar aluno: {ex.Message}");
            }
        }
    }
}
