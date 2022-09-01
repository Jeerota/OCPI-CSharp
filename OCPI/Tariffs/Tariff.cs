using OCPI.Locations;
using System.ComponentModel.DataAnnotations;

namespace OCPI.Tariffs
{
    public class Tariff
    {
        [Required]
        [StringLength(2)]
        public string CountryCode { get; set; }
        [Required]
        [StringLength(3)]
        public string PartyId { get; set; }
        [Required]
        [StringLength(36)]
        public string Id { get; set; }
        [Required]
        [StringLength(3)]
        public string Currency { get; set; }
        public TariffType? Type { get; set; }
        public IEnumerable<DisplayText> TariffAltText { get; set; }
        [StringLength(255)]
        public string? TariffAltURL { get; set; }
        public Price? MinPrice { get; set; }
        public Price? MaxPrice { get; set; }
        [Required]
        public IEnumerable<TariffElement> Elements { get; set; }
        public DateTime? StartDateTime { get; set; }
        public DateTime? EndDateTime { get; set; }
        public EnergyMix EnergyMix { get; set; }
        [Required]
        public DateTime LastUpdated { get; set; }

        public Tariff() { }
    }
}