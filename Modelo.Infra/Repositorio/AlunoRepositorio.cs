using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

    }
}
