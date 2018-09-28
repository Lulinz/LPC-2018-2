using Microsoft.EntityFrameworkCore;

namespace Aula10_Avaliacao_G1.Models
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) 
            : base(options)
        {}        
    }
}