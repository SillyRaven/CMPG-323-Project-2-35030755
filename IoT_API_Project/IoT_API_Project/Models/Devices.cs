using System.ComponentModel.DataAnnotations;

namespace Project2_IoT_Management.Models
{
    public class Devices
    {
        [Key]public long DeviceId { get; set; }
        public long ZoneID { get; set; }
        public long CategoryID { get; set; }
        public string? DeviceName { get; set; }
        public string? Status { get; set; }
        public DateTime DateCreated { get; set; }
        public bool isActive { get; set; }
    }
}
