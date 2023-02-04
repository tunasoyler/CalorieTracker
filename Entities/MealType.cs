namespace Entities
{
    public class MealType : BaseEntity
    {
        public string MealTypeName { get; set; }
        public virtual ICollection<Meal> Meals { get; set; }
        public MealType()
        {
            Meals = new HashSet<Meal>();
        }
    }
}