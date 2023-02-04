namespace Entities
{
    public class Meal
    {
        public int Id { get; set; }
        public virtual ICollection<Food> Foods { get; set; }
        public virtual User User { get; set; }
        public int MealTypeID { get; set; }
        public virtual MealType MealType { get; set; }
        public Meal()
        {
            Foods = new List<Food>();
        }
    }
}