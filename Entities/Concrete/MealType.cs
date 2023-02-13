namespace Entities.Concrete
{
    public class MealType : CommonEntity
    {
        public virtual ICollection<Meal> Meals { get; set; }
        public MealType()
        {
            Meals = new HashSet<Meal>();
        }
    }
}