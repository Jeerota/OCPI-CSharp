using System.ComponentModel.DataAnnotations;

namespace OCPI.Locations
{
    public class AdditionalGeoLocation
    {
        [Required]
        [StringLength(10)]
        public string Latitude { get; set; }
        [Required]
        [StringLength(11)]
        public string Longitude { get; set; }
        public DisplayText Name { get; set; }

        public AdditionalGeoLocation() { }
    }
}