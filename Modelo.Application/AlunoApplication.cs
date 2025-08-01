using Modelo.Application.Interface;
using Modelo.Domain;
using Modelo.Infra.Repositorio.Interface;

namespace Modelo.Application
{
    public class AlunoApplication : IAlunoApplication
    {
        private readonly IAlunoRepositorio _alunoRepositorio;

        public AlunoApplication(IAlunoRepositorio alunoRepositorio)
        {
            _alunoRepositorio = alunoRepositorio;
        }

        public Aluno BuscarAluno(int id)
        {
            return _alunoRepositorio.BuscarId(id);

        }

        public void InserirAluno(Aluno aluno)
        {
            _alunoRepositorio.InserirAluno(aluno);
        }

        public void ExcluirAluno(int id)
        {
            _alunoRepositorio.ExcluirAluno(id);
        }

        public void AtualizarAluno(Aluno aluno)
        {
            _alunoRepositorio.AtualizarAluno(aluno);
        }

       public void AtualizarAlunoParcial(Aluno aluno)
        {
            _alunoRepositorio.AtualizarAlunoParcial(aluno);
        }
    }
}