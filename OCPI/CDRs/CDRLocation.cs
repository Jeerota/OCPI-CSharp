using System.ComponentModel.DataAnnotations;
using OCPI.Locations;

namespace OCPI.CDRs
{
    public class CDRLocation
    {
        [Required]
        [StringLength(36)]
        public string Id { get; set; }
        [StringLength(255)]
        public string? Name { get; set; }
        [Required]
        [StringLength(45)]
        public string Address { get; set; }
        [Required]
        [StringLength(45)]
        public string City { get; set; }
        [StringLength(10)]
        public string? PostalCode { get; set; }
        [StringLength(20)]
        public string? State { get; set; }
        [Required]
        [StringLength(3)]
        public string Country { get; set; }
        [Required]
        public GeoLocation Coordinates { get; set; }
        [Required]
        [StringLength(48)]
        public string EVSEId { get; set; }
        [Required]
        [StringLength(36)]
        public string ConnectorId { get; set; }
        [Required]
        public ConnectorType ConnectorStandard { get; set; }
        [Required]
        public ConnectorFormat ConnectorFormat { get; set; }
        [Required]
        public PowerType ConnectorPowerType { get; set; }

        public CDRLocation() { }
    }
}
