namespace ELearn.Models
{
    public class Author : BaseEntity
    {
        public string FullName { get; set; }
        public ICollection<Course> Courses { get; set; }

    }
}
