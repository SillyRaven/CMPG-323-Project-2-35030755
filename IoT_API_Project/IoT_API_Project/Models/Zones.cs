using System.ComponentModel.DataAnnotations;
namespace Project2_IoT_Management.Models
{
    public class Zones
    {
        [Key]public long ZoneID { get; set; }
        public string? ZoneName { get; set; }
        public string? ZoneDescription { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
