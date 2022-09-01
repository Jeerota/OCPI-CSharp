using System.ComponentModel.DataAnnotations;

namespace OCPI.Locations
{
    public class Connector
    {
        [Required]
        [StringLength(36)]
        public string Id { get; set; }
        [Required]
        public ConnectorType Standard { get; set; }
        [Required]
        public ConnectorFormat Format { get; set; }
        [Required]
        public PowerType PowerType { get; set; }
        [Required]
        public int MaxVoltage { get; set; }
        [Required]
        public int MaxAmperage { get; set; }
        public int? MaxEletricPower { get; set; }
        [Required]
        public IEnumerable<string> TariffIds { get; set; }
        [StringLength(255)]
        public string? URL { get; set; }
        [Required]
        public DateTime LastUpdated { get; set; }

        public Connector() { }
    }
}