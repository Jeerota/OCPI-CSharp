using System.ComponentModel.DataAnnotations;

namespace OCPI.Sessions
{
    public class ChargingPreferences
    {
        [Required]
        public ProfileType ProfileType { get; set; }
        public DateTime? DepartureTime { get; set; }
        public decimal? EnergyNeed { get; set; }
        public bool? DischargeAllowed { get; set; }

        public ChargingPreferences()
        {
            DischargeAllowed = false;
        }
    }
}
