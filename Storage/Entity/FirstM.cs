using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication6.Storage.Entity
{
    [Table("Firs_tMod")]
    public class FirstM : IUniqueidenifiableEntity
    {
        [Key]
        [Required]
        [Column("gId")]
        public Guid id { get; set; }

        [Required]
        [Column("szNumber")]
        public string FirstMd { get; set; }
    }
}
