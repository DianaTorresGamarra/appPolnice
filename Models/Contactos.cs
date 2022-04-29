using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using appPolnice.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace appPolnice.Models
{
    [Table("t_contacto")]
    public class Contactos
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id {get; set; }

        [Column("Nombre")]
        public string Nombre{ get;set;}

        [Column("Correo")]
        public string Correo { get;set;}

        [Column("Mensaje")]
        public string Mensaje { get;set;}

    }
}