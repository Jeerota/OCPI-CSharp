using System.ComponentModel.DataAnnotations;

namespace OCPI.Commands
{
    public class CancelReservation
    {
        [Required]
        [StringLength(255)]
        public string Language { get; set; }
        [Required]
        [StringLength(36)]
        public string ReservationId { get; set; }

        public CancelReservation() { }
    }
}