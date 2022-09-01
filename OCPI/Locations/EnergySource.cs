using System.ComponentModel.DataAnnotations;

namespace OCPI.Locations
{
    public class EnergySource
    {
        [Required]
        public EnergySourceCategory Source { get; set; }
        [Required]
        public decimal Percentage { get; set; }

        public EnergySource() 
        { 
            if(Percentage < 0 || Percentage > 100)
                throw new ArgumentOutOfRangeException(nameof(Percentage));
        }
    }
}