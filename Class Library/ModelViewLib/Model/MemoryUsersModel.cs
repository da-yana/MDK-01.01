using ModelViewLib.ModelViews;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelViewLib.Model
{
    public class MemoryUsersModel : IUsersModel
    {
        List<User> users = new List<User>();
        public MemoryUsersModel() 
        {
          users.Add(new User { Login = "abc", Password = "123", Name = "Vasiliy"});
            users.Add(new User { Login = "def", Password = "456", Name = "Sergo"});
            users.Add(new User { Login = "ghi", Password = "789", Name = "Temchik"});
        }
        public bool Register(User user)
        {
            int CountLenght = users.Count;
            users.Add(user);
            return CountLenght < users.Count();
        }
        public List<User> UpUserData()
        {
            return users;
        }
    }
}
