using System.ComponentModel.DataAnnotations;

namespace OCPI.CDRs
{
    public class SignedValue
    {
        [Required]
        [StringLength(32)]
        public string Nature { get; set; }
        [Required]
        [StringLength(512)]
        public string PlainData { get; set; }
        [Required]
        [StringLength(5000)]
        public string SignedData { get; set; }

        public SignedValue() { }
    }
}
