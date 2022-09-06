namespace Project2_IoT_Management.Models
{
    public class Devices
    {
        public long DeviceId { get; set; }
        public long ZoneID { get; set; }
        public bool CategoryID { get; set; }
        public string? DeviceName { get; set; }
        public string? Status { get; set; }
        public DateTime DateCreated { get; set; }
        public bool isActive { get; set; }
    }
}
