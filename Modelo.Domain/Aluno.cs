using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Modelo.Domain
{
    public class Aluno
    {
        
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Cep { get; set; }
    }
}
