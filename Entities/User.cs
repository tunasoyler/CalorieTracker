using Entities.Enums;

namespace Entities
{
    public class User
    {
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public UsersOfApplication UserOfApplication { get; set; }
        public Genders Gender { get; set; }
        public Purposes Purpose { get; set; }
        public double Height { get; set; }
        public double Weight { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime RegisterDate { get; set; }
        public virtual ICollection<Meal> Meals { get; set; }
        public User()
        {
            Meals = new List<Meal>();
        }
    }
}