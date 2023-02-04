namespace Entities
{
    public class Food : BaseEntity
    {
        public string FoodName { get; set; }
        public double Calorie { get; set; }
        public virtual ICollection<MealDetails> MealDetails { get; set; }
        
        public Food()
        {
            MealDetails = new HashSet<MealDetails>();
        }
    }
    
}