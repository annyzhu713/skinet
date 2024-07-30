using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    //Db Context = session with database that can be used to query and save instances of entities. 
    //Combination of UoW and Repository patterns 
    public class StoreContext : DbContext
    {
        public StoreContext(DbContextOptions options): base(options) {

        }
        
        public DbSet<Product> Products {get; set;}
    }
}