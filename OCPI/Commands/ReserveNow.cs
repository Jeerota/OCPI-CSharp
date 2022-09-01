using OCPI.Tokens;
using System.ComponentModel.DataAnnotations;

namespace OCPI.Commands
{
    public class ReserveNow
    {
        [Required]
        [StringLength(255)]
        public string ResponseUrl { get; set; }
        [Required]
        public Token Token { get; set; }
        [Required]
        public DateTime ExpiryDate { get; set; }
        [Required]
        [StringLength(36)]
        public string ReservationId {get; set; }
        [Required]
        [StringLength(36)]
        public string LocationId { get; set; }
        [StringLength(36)]
        public string? EVSEUId { get; set; }
        [StringLength(36)]
        public string? AuthorizationReference { get; set; }

        public ReserveNow() { }
    }
}