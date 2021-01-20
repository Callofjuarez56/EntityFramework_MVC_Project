using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication6.Storage.Entity
{
    [Table("SecondMod")]
    public class SecondM : IUniqueidenifiableEntity
    {
        [Key]
        [Required]
        [Column("gId")]
        public Guid id { get; set; }


        [Required]
        [Column("szNumber")]
        public string SecondMd { get; set; }
    }

}
