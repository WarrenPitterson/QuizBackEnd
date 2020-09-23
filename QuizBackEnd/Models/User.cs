using System.ComponentModel.DataAnnotations;
using QuizBackEnd.Common;

namespace QuizBackEnd.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public PermissionLevels Permission { get; set; }
        public string Salt { get; set; }
    }
}
