using System.ComponentModel.DataAnnotations;

namespace OCPI.Locations
{
    public class StatusSchedule
    {
        [Required]
        public DateTime PeriodBegin { get; set; }
        public DateTime? PeriodEnd { get; set; }
        [Required]
        public Status Status { get; set; }

        public StatusSchedule() { }
    }
}