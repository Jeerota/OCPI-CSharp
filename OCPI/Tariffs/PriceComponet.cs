using System.ComponentModel.DataAnnotations;

namespace OCPI.Tariffs
{
    public class PriceComponet
    {
        [Required]
        public TariffDimensionType Type { get; set; }
        [Required]
        public decimal Price { get; set; }
        public decimal? VAT { get; set; }
        [Required]
        public int StepSize { get; set; }

        public PriceComponet() { }
    }
}