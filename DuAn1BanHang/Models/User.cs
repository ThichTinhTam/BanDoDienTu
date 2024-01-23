using System.ComponentModel.DataAnnotations;

namespace DuAn1BanHang.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }   
        public string? Email { get; set; }
        public string? Password { get; set; }
        public string? Role { get; set; } //quyen
    }
}
