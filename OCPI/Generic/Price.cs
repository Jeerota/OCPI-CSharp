using System.ComponentModel.DataAnnotations;

namespace OCPI
{
    public class Price
    {
        [Required]
        public decimal ExclVat { get; set; }
        [Required]
        public decimal InclVat { get; set; }

        public Price() { }
    }
}
