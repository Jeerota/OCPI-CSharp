using System.ComponentModel.DataAnnotations;

namespace OCPI.Locations
{
    public class BusinessDetails
    {
        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        [StringLength(255)]
        public string Website { get; set; }
        public Image Logo { get; set; }

        public BusinessDetails() { }
    }
}