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
        List<User> allUsers_ = new List<User>();
        public MemoryUsersModel() 
        {
          allUsers_.Add(new User { Login = "abc", Password = "123", Name = "Vasiliy"});
            allUsers_.Add(new User { Login = "def", Password = "456", Name = "Sergo"});
            allUsers_.Add(new User { Login = "ghi", Password = "789", Name = "Temchik"});
        }
        public List<User> Load()
        {
            return allUsers_;
        }
        public bool Register(User user)
        {
            int countListUser = allUsers_.Count;
            allUsers_.Add(user);
            if (allUsers_.Count > countListUser)
            {
                return true;
            }
            return false;
        }

        public void Remove(List<User> selectedUsers)
        {
            foreach (User u in selectedUsers)
            {
                selectedUsers.Remove(u);
            }
        }

        public void RemoveUsers(List<User> users)
        {
            foreach (User u in users)
            {
                int TargetIndex = allUsers_.FindIndex(local => local.Login == u.Login );
                if (TargetIndex >= 0)
                {
                    allUsers_.RemoveAt(TargetIndex);
                }
            }
        }

        public List<User> UpUserData()
        {
            return allUsers_;
        }
    }
}
