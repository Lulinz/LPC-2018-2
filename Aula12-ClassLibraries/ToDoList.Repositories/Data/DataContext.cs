using Microsoft.EntityFrameworkCore;
using ToDoList.Domain;

namespace ToDoList.Repositories.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) 
            : base(options)
        {}

        public DbSet<ToDo> todos { get; set; }
    }
}