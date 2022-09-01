using OCPI.Tokens;
using System.ComponentModel.DataAnnotations;

namespace OCPI.Locations
{
    public class PublishTokenType
    {
        [StringLength(36)]
        public string UID { get; set; }
        public TokenType Type { get; set; }
        [StringLength(64)]
        public string VisualNumber { get; set; }
        [StringLength(64)]
        public string Issuer { get; set; }
        [StringLength(36)]
        public string GroupId { get; set; }

        public PublishTokenType() { }
    }
}