using Microsoft.EntityFrameworkCore;
using MinhaAPICORE.Model;

namespace MinhaAPICORE.Data
{
    public class ApiContext : DbContext 
    {

        public ApiContext(DbContextOptions<ApiContext> options) : base(options)
        {

        }

        public DbSet<Fornecedor> Fornecedores { get; set; }


    }
}
