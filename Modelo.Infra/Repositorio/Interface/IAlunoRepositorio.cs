using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo.Domain;

namespace Modelo.Infra.Repositorio.Interface
{
    public interface IAlunoRepositorio
    {
        Aluno BuscarId (int id);
    }
}
