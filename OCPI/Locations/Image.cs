using System.ComponentModel.DataAnnotations;

namespace OCPI.Locations
{
    public class Image
    {
        [Required]
        [StringLength(255)]
        public string URL { get; set; }
        [StringLength(255)]
        public string? Thumbnail { get; set; }
        [Required]
        public ImageCategory Category { get; set; }
        [Required]
        [StringLength(4)]
        public string Type { get; set; }
        public int? Width { get; set; }
        public int? Height { get; set; }

        public Image() 
        {
            if (Width.HasValue && (Width < 0 || Width > 99999))
                throw new ArgumentOutOfRangeException(nameof(Width)); 
            if (Height.HasValue && (Height < 0 || Height > 99999))
                throw new ArgumentOutOfRangeException(nameof(Height));
        }
    }
}