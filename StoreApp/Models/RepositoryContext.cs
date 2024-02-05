using Microsoft.EntityFrameworkCore;

namespace StoreApp.Models
{
    public class RepositoryContext :DbContext  //bu sayede veri tabanı gibi düşeneceğiz burayı
    {
        public DbSet<Product> Products { get; set; }
        public RepositoryContext(DbContextOptions<RepositoryContext> options)
        : base(options) 
        {
        
        
        }
        
            
        

    }
}
