namespace Entities.Concrete
{
    public class Genders : CommonEntity
    {
        public virtual ICollection<User> Users { get; set; }
        public Genders()
        {
            Users = new HashSet<User>();
        }
        //public override string ToString()
        //{
        //    return Name;
        //}
    }
}