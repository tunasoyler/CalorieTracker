namespace Entities.ViewModels
{
    public class MealDetailsViewModel
    {
        public int Id { get; set; }
        public string MealType { get; set; }
        public string Food { get; set; }
        public double Gram { get; set; }
        public byte[] Image { get; set; }
        public double Calorie { get; set; }       
        public DateTime CreatedDate { get; set; }
    }
}