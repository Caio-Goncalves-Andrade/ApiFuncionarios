using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CadastroFuncionários
{
    public class Funcionario
    {
        public int? Id { get; set; }

        public string Nome { get; set; }

        public string Endereco { get; set; }

        public DateTime Nascimento { get; set; }

        public int Salario { get; set; }

        public string Genero { get; set; }
    }
}
