using ELearn.Models;

namespace ELearn.ViewModels
{
    public class HomeVM
    {
        public List<Slider> Slider { get; set; }
        public IEnumerable<Course> Courses { get; set; }
        public IEnumerable<MileStone> MileStones { get; set;}

    }
}
