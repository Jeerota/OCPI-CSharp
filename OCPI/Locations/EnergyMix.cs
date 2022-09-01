using System.ComponentModel.DataAnnotations;

namespace OCPI.Locations
{
    public class EnergyMix
    {
        [Required]
        public bool IsGreenEnergy { get; set; }
        public IEnumerable<EnergySource> EnergySources { get; set; }
        public IEnumerable<EnvironmentalImpact> EnvironImpact { get; set; }
        [StringLength(64)]
        public string SupplierName { get; set; }
        [StringLength(64)]
        public string EnergyProductName { get; set; }

        public EnergyMix() { }
    }
}