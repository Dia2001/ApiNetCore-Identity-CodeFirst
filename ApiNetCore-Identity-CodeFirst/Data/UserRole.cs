using ApiNetCore_Identity_CodeFirst.Repositories;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiNetCore_Identity_CodeFirst.Data
{
    [Table("UserRoles")]
    public class UserRole : IdentityUserRole<Guid>, IEntity<Guid>
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public virtual Role Role { get; set; }
        public virtual User User { get; set; }
    }
}
