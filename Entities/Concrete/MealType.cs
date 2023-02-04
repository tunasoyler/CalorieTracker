namespace Entities.Concrete
{
    public class MealType : BaseEntity
    {
        public virtual ICollection<MealDetails> MealDetails { get; set; }
        public MealType()
        {
            MealDetails = new HashSet<MealDetails>();
        }
    }
}