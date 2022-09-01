using System.ComponentModel.DataAnnotations;
using OCPI.Tariffs;

namespace OCPI.CDRs
{
    public class CDR
    {
        [Required]
        [StringLength(2)]
        public string CountryCode { get; set; }
        [Required]
        [StringLength(3)]
        public string PartyId { get; set; }
        [Required]
        [StringLength(39)]
        public string Id { get; set; }
        [Required]
        public DateTime StartDateTime { get; set; }
        [Required]
        public DateTime EndDateTime { get; set; }
        [StringLength(36)]
        public string? SessionId { get; set; }
        [Required]
        public CDRToken CDRToken { get; set; }
        [Required]
        public AuthMethod AuthMethod { get; set; }
        [StringLength(36)]
        public string AuthorizationReference { get; set; }
        [Required]
        public CDRLocation CDRLocation { get; set; }
        [StringLength(255)]
        public string? MeterId { get; set; }
        [Required]
        [StringLength(3)]
        public string Currency { get; set; }
        [Required]
        public IEnumerable<Tariff> Tariffs { get; set; }
        [Required]
        public IEnumerable<ChargingPeriod> ChargingPeriods { get; set; }
        public SignedData SignedData { get; set; }
        [Required]
        public Price TotalCost { get; set; }
        public Price? TotalFixedCost { get; set; }
        [Required]
        public decimal TotalEngery { get; set; }
        public Price? TotalEnergyCost { get; set; }
        [Required]
        public decimal TotalTime { get; set; }
        public Price? TotalTimeCost { get; set; }
        [Required]
        public decimal TotalParkingTime { get; set; }
        public Price? TotalParkingCost { get; set; }
        public Price? TotalReservationCost { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
        [StringLength(39)]
        public string? InvoiceReferenceId { get; set; }
        public bool? Credit { get; set; }
        [StringLength(39)]
        public string? CreditReferenceId { get; set; }
        public bool? HomeChargingCompensation { get; set; }
        public DateTime LastUpdated { get; set; }

        public CDR() { }
    }
}