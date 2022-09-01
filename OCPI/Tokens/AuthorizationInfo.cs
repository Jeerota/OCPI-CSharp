using System.ComponentModel.DataAnnotations;

namespace OCPI.Tokens
{
    public class AuthorizationInfo
    {
        [Required]
        public AllowedType Allowed { get; set; }
        [Required]
        public Token Token { get; set; }
        public LocationReferences? Location { get; set; }
        [StringLength(36)]
        public string? AuthorizationReference { get; set; }
        public DisplayText? Info { get; set; }

        public AuthorizationInfo() { }
    }
}