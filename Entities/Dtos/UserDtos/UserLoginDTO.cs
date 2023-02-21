using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Dtos.UserDtos
{
    public class UserLoginDTO
    {
        public int Id { get; set; } 
        public string UserName { get; set; }
        public string Password { get; set; }
        public UserType UserType { get; set; }
    }
}
