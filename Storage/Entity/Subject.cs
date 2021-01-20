using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication6.Storage.Entity
{
    [Table("Subject")]
    public class Subject : IUniqueidenifiableEntity
    {
        [Key]
        [Required]
        [Column("gId")]
        public Guid id { get; set; }

        [Required]
        [Column("szName")]
        public string Name_of_Sub { get; set; }



    }
}
