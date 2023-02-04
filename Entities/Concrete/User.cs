namespace Entities.Concrete
{
    public class User : BaseEntity
    {
        public string Password { get; set; }
        public UsersOfApplication UserOfApplication { get; set; }
        public Genders Gender { get; set; }
        public Purposes Purpose { get; set; }
        public double Height { get; set; }
        public double Weight { get; set; }
        public DateTime BirthDate { get; set; }
        public virtual ICollection<Meal> Meals { get; set; }
        public User()
        {
            Meals = new HashSet<Meal>();
        }
    }
}