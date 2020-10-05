using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CadastroFuncionários;

namespace CadastroFuncionários.Data
{
    public class CadastroFuncionáriosContext : DbContext
    {
        public CadastroFuncionáriosContext (DbContextOptions<CadastroFuncionáriosContext> options)
            : base(options)
        {
        }

        public DbSet<CadastroFuncionários.Funcionario> Funcionario { get; set; }
    }
}
