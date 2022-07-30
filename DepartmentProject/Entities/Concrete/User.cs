using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DepartmentProject.Entities.Concrete
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        public string UserName { get; set; }
        [Column(TypeName = "Varchar(10)")]
        public string Password { get; set; }
    }
}
