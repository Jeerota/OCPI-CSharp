using System.ComponentModel.DataAnnotations;

namespace OCPI.CDRs
{
    public class SignedData
    {
        [Required]
        [StringLength(36)]
        public string EncodingMethod { get; set; }
        public int? EncodingMethodVersion { get; set; }
        [StringLength(512)]
        public string? PublicKey { get; set; }
        [Required]
        public IEnumerable<SignedValue> SignedValues { get; set; }
        [StringLength(512)]
        public string? URL { get; set; }

        public SignedData() { }
    }
}
