namespace Entities.Concrete
{
    public class User : BaseEntity
    {
       
        public string Password { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public int? UserTypeId { get; set; }
        public virtual UserType UserType { get; set; }
        public int? GenderId { get; set; }
        public virtual Genders Gender { get; set; }
        public int? ActivityTypeId { get; set; }
        public virtual ActivityType ActivityType { get; set; }
        public double? GoalWeight { get; set; }
        public double? Height { get; set; }
        public double? Weight { get; set; }
        public string? Timeline { get; set; }
        public double? BMR { get; set; }
        public double? DailyCalorieLimit { get; set; }
        public DateTime? BirthDate { get; set; }
        public virtual ICollection<Meal> Meals { get; set; }
        public User()
        {
            Meals = new HashSet<Meal>();
        }
    }
}