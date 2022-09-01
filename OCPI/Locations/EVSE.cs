using System.ComponentModel.DataAnnotations;

namespace OCPI.Locations
{
    public class EVSE
    {
        [Required]
        [StringLength(36)]
        public string UID { get; set; }
        [StringLength(48)]
        public string? EVSEId { get; set; }
        [Required]
        public Status Status { get; set; }
        public IEnumerable<StatusSchedule> StatusSchedule { get; set; }
        [Required]
        public IEnumerable<Capability> Capabilities { get; set; }
        [Required]
        public IEnumerable<Connector> Connectors { get; set; }
        [StringLength(4)]
        public string? FloorLevel { get; set; }
        public GeoLocation? Coordinates { get; set; }
        [StringLength(16)]
        public string? PhysicalReference { get; set; }
        public DisplayText Directions { get; set; }
        public IEnumerable<ParkingRestriction> ParkingRestrictions { get; set; }
        public IEnumerable<Image> Images { get; set; }
        [Required]
        public DateTime LastUpdated { get; set; }

        public EVSE() { }
    }
}