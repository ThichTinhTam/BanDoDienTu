using System.ComponentModel.DataAnnotations;

namespace DuAn1BanHang.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
    }
}
