using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace appPolnice.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<appPolnice.Models.Contactos> DataContactos { get; set; }

    public DbSet<appPolnice.Models.Producto> DataProductos { get; set; }
    
}
