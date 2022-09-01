using System.ComponentModel.DataAnnotations;

namespace OCPI.Commands
{
    public class UnlockConnector
    {
        [Required]
        [StringLength(255)]
        public string ResponseUrl { get; set; }
        [Required]
        [StringLength(36)]
        public string LocationId { get; set; }
        [Required]
        [StringLength(36)]
        public string EVSEUId { get; set; }
        [Required]
        [StringLength(36)]
        public string ConnectorId { get; set; }

        public UnlockConnector() { }
    }
}
