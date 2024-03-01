using System.ComponentModel.DataAnnotations;

namespace App.Models.Users
{
    public class User
    {

        [Key]
        public int UserId { get; set; }

        public string? FullName { get; set; }

        public string? Position { get; set; }
        [Required(ErrorMessage = "Email is required")]
        public string Email { get; set; }

        public string? Phone { get; set; }

        [Required(ErrorMessage = "Email is required")]
        public string PassWord { get; set; }


    }
}