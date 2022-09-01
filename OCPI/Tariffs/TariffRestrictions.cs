using System.ComponentModel.DataAnnotations;

namespace OCPI.Tariffs
{
    public class TariffRestrictions
    {
        [StringLength(5)]
        public string? StartTime { get; set; }
        [StringLength(5)]
        public string? EndTime { get; set; }
        [StringLength(10)]
        public string? StartDate { get; set; }
        [StringLength(10)]
        public string? EndDate { get; set; }
        public decimal? MinKWH { get; set; }
        public decimal? MaxKWH { get; set; }
        public decimal? MinCurrent { get; set; }
        public decimal? MaxCurrent { get; set; }
        public decimal? MinPower { get; set; }
        public decimal? MaxPower { get; set; }
        public int? MinDuration { get; set; }
        public int? MaxDuration { get; set; }
        public IEnumerable<DayOfWeek> DayOfWeek { get; set; }
        public ReservationRestrictionType? Reservation { get; set;}

        public TariffRestrictions() { }
    }
}