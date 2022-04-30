using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

using Microsoft.EntityFrameworkCore;
using appPolnice.Models;


namespace appPolnice.Data;



public class ApplicationDbContext : IdentityDbContext

{

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)

        : base(options)

    {

    }



    public DbSet<appPolnice.Models.Contacto> DataContactos { get; set; }



    public DbSet<appPolnice.Models.Producto> DataProductos { get; set; }



   

   

}