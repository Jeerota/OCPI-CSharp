using System.ComponentModel.DataAnnotations;

namespace OCPI.Tokens
{
    public class LocationReferences
    {
        [Required]
        [StringLength(36)]
        public string LocationId { get; set; }
        [Required]
        public IEnumerable<string> EVSEUIDs { get; set; }

        public LocationReferences() { }
    }
}