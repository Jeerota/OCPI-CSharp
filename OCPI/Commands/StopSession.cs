using System.ComponentModel.DataAnnotations;

namespace OCPI.Commands
{
    public class StopSession
    {
        [Required]
        [StringLength(255)]
        public string ResponseUrl { get; set; }
        [Required]
        [StringLength(36)]
        public string SessionId { get; set; }

        public StopSession() { }
    }
}
