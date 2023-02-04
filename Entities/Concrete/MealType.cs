namespace Entities.Concrete
{
    public class MealType : BaseEntity
    {
        public virtual ICollection<Meal> Meals { get; set; }
        public MealType()
        {
            Meals = new HashSet<Meal>();
        }
    }
}