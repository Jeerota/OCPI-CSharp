using System.ComponentModel.DataAnnotations;

namespace OCPI.CDRs
{
    public class CDRDimension
    {
        [Required]
        public CDRDimensionType Type { get; set; }
        [Required]
        public decimal Volume { get; set; }

        public CDRDimension() { }
    }
}
