using Cadastro_Cliente.Models;
using Microsoft.EntityFrameworkCore;

namespace Cadastro_Cliente.Data
{
    public class BancoContext : DbContext
    {
        public BancoContext(DbContextOptions<BancoContext> options) : base(options)
        { 
        
        }
        public DbSet <ClienteModel> Clientes { get; set; }            
        
    }
}
