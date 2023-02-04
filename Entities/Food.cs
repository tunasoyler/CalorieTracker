namespace Entities
{
    public class Food
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public double Calorie { get; set; }
        public virtual ICollection<Meal> Meals { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public Food()
        {
            Meals= new List<Meal>();
        }
    }
    
}