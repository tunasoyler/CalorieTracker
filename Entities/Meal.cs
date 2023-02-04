namespace Entities
{
    public class Meal : BaseEntity
    {
        public string MealName { get; set; }
        public virtual ICollection<MealDetails> MealDetails { get; set; }
        public int UserID { get; set; }
        public virtual User User { get; set; }
        public int MealTypeID { get; set; }
        public virtual MealType MealType { get; set; }
        public Meal()
        {
            MealDetails= new HashSet<MealDetails>();
        }
    }
}