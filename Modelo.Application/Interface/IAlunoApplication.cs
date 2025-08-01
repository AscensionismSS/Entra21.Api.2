using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo.Domain;

namespace Modelo.Application.Interface
{
    public interface IAlunoApplication
    {
        Aluno BuscarAluno(int id);
        void InserirAluno(Aluno aluno);

        void ExcluirAluno(int id);

        void AtualizarAluno(Aluno aluno);

        void AtualizarAlunoParcial(Aluno aluno);
    }
}
