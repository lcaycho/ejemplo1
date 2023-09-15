using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;



namespace petclinic.Models
{
     [Table("t_contacto")]

    public class Contacto
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id{get; set;}
        public string? Name {get; set;}
        public string? Email {get; set;}
        public string? Phone {get; set;}
        public string? Question {get; set;}
    }
}