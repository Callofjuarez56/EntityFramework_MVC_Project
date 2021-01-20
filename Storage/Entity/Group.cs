using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication6.Storage.Entity
{
    [Table("tblGroup")]
    public class Group : IUniqueidenifiableEntity
    {
        [Key] // позволяет сказать, что наш id будет первичным(уникальным) ключом для данной строки 
        [Required]   //требуется
        [Column("gId")] // пользователь не должен знать об ID-шнике группы поэтому чтобы не вводить ID создадим класс Create...
        public Guid id { get; set; }

        [Required]
        [Column("szName")]
        public string Name { get; set; }

        [Required]
        [Column("szDepartmentnumber")]
        public string DepartmentNumber { get; set; } 
    }
}

// ER Diagram - Entity Relationship Diagram 