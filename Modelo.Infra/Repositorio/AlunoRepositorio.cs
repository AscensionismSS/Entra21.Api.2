using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Modelo.Domain;
using Modelo.Infra.Repositorio.Interface;

namespace Modelo.Infra.Repositorio
{
    public class AlunoRepositorio : IAlunoRepositorio
    {
        private readonly BancoContexto _contexto;

        public AlunoRepositorio(BancoContexto contexto)
        {
            _contexto = contexto;
        }

        public Aluno BuscarId(int id)
        {
            return _contexto.Aluno.FirstOrDefault(x => x.Id == id);
        }


        public void InserirAluno(Aluno aluno)
        {
            _contexto.Aluno.Add(aluno);
            _contexto.SaveChanges();
        }

        public void AtualizarAluno(Aluno aluno)
        {
            
            _contexto.Aluno.Update(aluno);
            _contexto.SaveChanges();
            
        }

        public void AtualizarAlunoParcial(Aluno aluno)
        {

            _contexto.Aluno.Update(aluno);
            _contexto.SaveChanges();

        }

        public void ExcluirAluno(int id)
        {
            var aluno = BuscarId(id);
            _contexto.Aluno.Remove(aluno);
            _contexto.SaveChanges();
        }
    }
}
