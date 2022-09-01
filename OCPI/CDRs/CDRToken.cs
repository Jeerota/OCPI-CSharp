using OCPI.Tokens;
using System.ComponentModel.DataAnnotations;

namespace OCPI.CDRs
{
    public class CDRToken
    {
        [Required]
        [StringLength(2)]
        public string CountryCode { get; set; }
        [Required]
        [StringLength(3)]
        public string PartyId { get; set; }
        [Required]
        [StringLength(36)]
        public string UId { get; set; }
        public TokenType Type { get; set; }
        [Required]
        [StringLength(36)]
        public string ContractId { get; set; }

        public CDRToken() { }
    }
}
