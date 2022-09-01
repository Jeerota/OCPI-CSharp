using System.ComponentModel.DataAnnotations;

namespace OCPI.Locations
{
    public class EnvironmentalImpact 
    {
        [Required]
        public EnvironmentalImpactCategory Category { get; set; }
        [Required]
        public decimal Amount { get; set; }

        public EnvironmentalImpact() { }
    }
}