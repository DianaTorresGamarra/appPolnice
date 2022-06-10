using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace appPolnice.Models
{
    [Table("t_detalle_pedido")]
    public class DetallePedido
    {    
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id {get; set;}

        [Column("Producto")] 
        public Producto Producto {get; set;}
        
        [Column("Cantidad")]
        public int Cantidad {get; set;}
        
        [Column("Precio")]
        public Decimal Precio { get; set; }
        
        [Column("Pedido")]
        public Pedido Pedido {get; set;}

        
    }
}