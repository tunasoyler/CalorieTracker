namespace Entities.Concrete
{
    public class User : BaseEntity
    {
       
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public UserType UserType { get; set; }
        public Genders Gender { get; set; }
        public ActivityType ActivityType { get; set; }
        public double GoalWeight { get; set; }
        public double Height { get; set; }
        public double Weight { get; set; }
        public double BMR { get; set; }
        public DateTime BirthDate { get; set; }
        public virtual ICollection<Meal> Meals { get; set; }
        public User()
        {
            Meals = new HashSet<Meal>();
        }
    }
}