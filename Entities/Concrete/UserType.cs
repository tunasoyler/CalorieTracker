namespace Entities.Concrete
{
    public class UserType : CommonEntity
    {
        public virtual ICollection<User> Users { get; set; }
        public UserType()
        {
            Users=new HashSet<User>();
        }
    }
}