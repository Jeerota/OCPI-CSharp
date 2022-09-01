using System.ComponentModel.DataAnnotations;

namespace OCPI
{
    public class DisplayText
    {
        [Required]
        [StringLength(2)]
        public string Language { get; set; }
        [Required]
        [StringLength(512)]
        public string Text { get; set; }

        public DisplayText() { }
    }
}
