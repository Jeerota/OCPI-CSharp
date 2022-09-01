using System.ComponentModel.DataAnnotations;

namespace OCPI.Locations
{
    public class ExceptionalPeriod
    {
        [Required]
        public DateTime PeriodBegin { get; set; }
        [Required]
        public DateTime PeriodEnd { get; set; }

        public ExceptionalPeriod() { }
    }
}