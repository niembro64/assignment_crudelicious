using Microsoft.EntityFrameworkCore;
namespace assignment_crudelicious.Models
{ 
    public class MyContext : DbContext 
    { 
        public MyContext(DbContextOptions options) : base(options) { }
        public DbSet<Pet> Pets { get; set; }
    }
}