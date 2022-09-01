using System.ComponentModel.DataAnnotations;

namespace OCPI.Locations
{
    public class Hours
    {
        [Required]
        public bool TwentyFourSeven { get; set; }
        public IEnumerable<RegularHours> RegularHours { get; set; }
        public IEnumerable<ExceptionalPeriod> ExceptionalOpenings { get; set; }
        public IEnumerable<ExceptionalPeriod> ExceptionalClosings { get; set; }

        public Hours()
        {
            if (!TwentyFourSeven && RegularHours == null)
                throw new ArgumentNullException(nameof(RegularHours));
            if (TwentyFourSeven && RegularHours != null)
                throw new ArgumentException("RegularHours is not required if location is always open");
            if (TwentyFourSeven && ExceptionalOpenings != null)
                throw new ArgumentException("ExceptionalOpenings is not required if location is always open");
            if (TwentyFourSeven && ExceptionalClosings != null)
                throw new ArgumentException("ExceptionalClosings is not required if location is always open");
        }
    }
}