using OCPI.Sessions;
using System.ComponentModel.DataAnnotations;

namespace OCPI.Tokens
{
    public class Token
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
        [Required]
        public TokenType Type { get; set; }
        [Required]
        [StringLength(36)]
        public string ContractId { get; set; }
        [StringLength(64)]
        public string? VisualNumber { get; set; }
        [Required]
        [StringLength(64)]
        public string Issuer { get; set; }
        [StringLength(36)]
        public string? GroupId { get; set; }
        [Required]
        public bool Valid { get; set; }
        [Required]
        public WhitelistType Whitelist { get; set; }
        [StringLength(2)]
        public string? Language { get; set; }
        public ProfileType? DefaultProfileType { get; set; }
        public EnergyContract? EnergyContract { get; set; }
        public DateTime LastUpdate { get; set; }

        public Token() { }
    }
}