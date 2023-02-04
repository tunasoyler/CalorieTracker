namespace Entities
{
    public class MealType
    {
        public int Id { get; set; }
        public string MealTypeName { get; set; }
        public virtual ICollection<Meal> Meals { get; set; }
        public MealType()
        {
            Meals = new List<Meal>();
        }
    }
}