using System.ComponentModel.DataAnnotations;

namespace OCPI.Commands
{
    public class CommpandResponse
    {
        [Required]
        public CommandResponseType Result { get; set; }
        [Required]
        public int Timeout { get; set; }
        public DisplayText? Message { get; set; }

        public CommpandResponse() { }
    }
}