using System.ComponentModel.DataAnnotations;

namespace OCPI.Tariffs
{
    public class TariffElement
    {
        [Required]
        public IEnumerable<PriceComponet> PriceComponets { get; set; }
        public IEnumerable<TariffRestrictions> TariffRestrictions { get; set; }

        public TariffElement() { }
    }
}