using System.ComponentModel.DataAnnotations;
using OCPI.CDRs;

namespace OCPI.Sessions
{
    public class Session
    {
        [Required]
        [StringLength(2)]
        public string CountryCode { get; set; }
        [Required]
        [StringLength(3)]
        public string PartyId { get; set; }
        [Required]
        [StringLength(36)]
        public string Id { get; set; }
        [Required]
        public DateTime StartDateTime { get; set; }
        public DateTime? EndDateTime { get; set; }
        [Required]
        public decimal KWH { get; set; }
        [Required]
        public CDRToken CDRToken { get; set; }
        [Required]
        public AuthMethod AuthMethod { get; set; }
        [StringLength(36)]
        public string AuthorizationReference { get; set; }
        [Required]
        [StringLength(36)]
        public string LocationId { get; set; }
        [Required]
        [StringLength(36)]
        public string EVSEUId { get; set; }
        [Required]
        [StringLength(36)]
        public string ConnectorId { get; set; }
        [StringLength(255)]
        public string? MeterId { get; set; }
        [Required]
        [StringLength(3)]
        public string Currency { get; set; }
        public IEnumerable<ChargingPeriod> ChargingPeriods { get; set; }
        public Price TotalCost { get; set; }
        public SessionStatus Status { get; set; }
        public DateTime LastUpdated { get; set; }

        public Session() { }
    }
}