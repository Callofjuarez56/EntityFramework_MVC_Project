using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication6.Storage.Entity
{   
     [Table("Students")]
    public class cal_c : IUniqueidenifiableEntity
    {
        [Key]
        [Required]
        [Column("gId")]
        public Guid id { get; set; } // Guid - уникальный идентификатор.
        
        [Required] // данное поле не может быть пустым
        [Column("szName")]
        [MaxLength(50)]
        public string FirstNumber { get; set; }

        [Required]
        [Column("szLastName")]
        [MaxLength(50)]
        public string SecondNumber { get; set; }

        [Required]
        [Column("gGroupID")]
        public Guid GroupID { get; set; }
        [ForeignKey(nameof(GroupID))] //внешний ключ для связки

        [Required]
        [Column("gSubjID")]
        public Guid SubjID { get; set; }
        [ForeignKey(nameof(SubjID))]

        [Required]
        [Column("gFirstModID")]
        public Guid FirstModID { get; set; }
        [ForeignKey(nameof(FirstModID))]

        [Required]
        [Column("gSecondModID")]
        public Guid SecondModID { get; set; }
        [ForeignKey(nameof(SecondModID))]

        [Required]
        [Column("szGroupLeader")]
        [MaxLength(50)]
        public string GroupLeader { get; set; }

        public Group Group { get; set; }





        //public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

     


    }
}
