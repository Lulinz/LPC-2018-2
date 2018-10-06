using Microsoft.EntityFrameworkCore;

namespace Aula10_Avaliacao_G1.Models
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) 
            : base(options)
        {}        


        public DbSet<Plano> planos { get; set; }
        public DbSet<Paciente> pacientes { get; set; }
        public DbSet<Consulta> consultas { get; set; }


    }
}