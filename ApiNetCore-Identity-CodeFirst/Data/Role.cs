using ApiNetCore_Identity_CodeFirst.Repositories;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiNetCore_Identity_CodeFirst.Data
{
    public enum GROUP_ROLE
    {
        Admin = 1,
        User = 2,
    }
    [Table("Roles")]
    public class Role : IdentityRole<Guid>, IEntity<Guid>
    {
        public GROUP_ROLE Group { get; set; }
        public virtual ICollection<UserRole> UserRoles { get; set; }
    }
}
