using System.ComponentModel.DataAnnotations;
namespace Project2_IoT_Management.Models
{
    public class Categories
    {
        [Key]
        public long CategoryId { get; set; }
        public string? CategoryName { get; set; }
        public string? CategoryDescription { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
