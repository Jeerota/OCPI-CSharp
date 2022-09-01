using System.ComponentModel.DataAnnotations;

namespace OCPI.CDRs
{
    public class ChargingPeriod
    {
        [Required]
        public DateTime StartDateTime { get; set; }
        [Required]
        public IEnumerable<CDRDimension> Dimensions { get; set; }
        [StringLength(36)]
        public string? TariffId { get; set; }

        public ChargingPeriod() { }
    }
}
