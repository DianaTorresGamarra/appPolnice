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

    public DbSet<appPolnice.Models.Proforma> DataProforma { get; set; }
    public DbSet<appPolnice.Models.Pago> DataPago { get; set; }
    public DbSet<appPolnice.Models.Pedido> DataPedido { get; set; }

    public DbSet<appPolnice.Models.DetallePedido> DataDetallePedido { get; set; }




   

   

}