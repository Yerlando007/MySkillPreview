using Microsoft.EntityFrameworkCore;
using DataManager.Models.EF;

namespace DataManager.Models.Base
{
    public class TodoContext : DbContext
    {
        public TodoContext(DbContextOptions<TodoContext> options) : base(options)
        {
        }
        
        public TodoContext() { }

        public DbSet<TodoItem> TodoItems { get; set; }
        public DbSet<Table1> Table1 { get; set; }
        public DbSet<Table2> Table2 { get; set; }
        public DbSet<Table3> Table3 { get; set; }

    }
}