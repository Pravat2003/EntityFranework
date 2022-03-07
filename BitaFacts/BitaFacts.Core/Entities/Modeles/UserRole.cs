using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitaFacts.Core.Entities.Modeles
{
    [Table("UserRole")]
    public class UserRole
    {
        [Key]
        [Column("RoleId")]
        public int Id { get; set; }
        [Required]
        public string RoleName { get; set; }
        public bool IsActive { get; set; }
        [NotMapped]
        public DateTime ModifyDate { get; set; }
        [NotMapped]
        public DateTime CreatedDate { get; set; }

    }
}
