using System.ComponentModel.DataAnnotations;

namespace OCPI.Locations
{
    public class RegularHours
    {
        [Required]
        public int Weekday { get; set; }
        [Required]
        [StringLength(5)]
        public string PeriodBegin { get; set; }
        [Required]
        [StringLength(5)]
        public string PeriodEnd { get; set; }

        public RegularHours() { }
    }
}