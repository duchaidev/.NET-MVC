using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace App.Models.Contacts
{
    public class Contact
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        [Column(TypeName = "nvarchar(100)")]
        public string Name { get; set; }
        public string Email { get; set; }

        [Required]
        [StringLength(12)]
        public string Phone { get; set; }
        public string Message { get; set; }
    }
}