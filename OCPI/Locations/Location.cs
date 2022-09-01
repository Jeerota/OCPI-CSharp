using System.ComponentModel.DataAnnotations;

namespace OCPI.Locations
{
    public class Location
    {
        [Required]
        [StringLength(2)]
        public string CountryCode { get; set; }
        [Required]
        [StringLength(3)]
        public string PartyId { get; set; }
        [Required]
        [StringLength(36)]
        public string Id { get; set; }
        public bool Publish { get; set; }
        public PublishTokenType? PublishAllowTo { get; set; }
        [StringLength(255)]
        public string? Name { get; set; }
        [Required]
        [StringLength(45)]
        public string Address { get; set; }
        [StringLength(45)]
        [Required]
        public string City { get; set; }
        [StringLength(10)]
        public string? PostalCode { get; set; }
        [StringLength(20)]
        public string? State { get; set; }
        [Required]
        [StringLength(3)]
        public string Country { get; set; }
        [Required]
        public GeoLocation Coorindates { get; set; }
        public IEnumerable<AdditionalGeoLocation> RelatedLocations { get; set; }
        public ParkingType? ParkingType { get; set; }
        public IEnumerable<EVSE> EVSES { get; set; }
        public DisplayText Directions { get; set; }
        public BusinessDetails? Operator { get; set; }
        public BusinessDetails? Suboperator { get; set; }
        public BusinessDetails? Owner { get; set; }
        public IEnumerable<Facility> Facilities { get; set; }
        [StringLength(255)]
        public string TimeZone { get; set; }
        public Hours? OpeningTimes { get; set; }
        public bool? ChargingWhenClosed { get; set; }
        public IEnumerable<Image> Images { get; set; }
        public EnergyMix EnergyMix { get; set; }
        public DateTime LastUpdated { get; set; }

        public Location() { }
    }
}