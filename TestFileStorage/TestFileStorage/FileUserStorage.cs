using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestFileStorage
{
    class FileUserStorage : IUsersInterface
    {
        public List<User> Load()
        {
            List<User> AllUser = new List<User>();
            string path = @"info.txt";
            StreamReader info = new StreamReader(path);

            string line;
            while ((line = info.ReadLine()) != null)
            {
                string[] lines = line.Split('-');
                AllUser.Add(new User (lines[0], lines[1]));

            }
            
            info.Close();
            return AllUser;
            
        }

       public bool UserVerification(string login)
       {
            List<User> Users = Load();
            foreach(User us in Users)
            {
                if (us.Login == login)
                {
                    return true;
                }
                
            }
            return false;
       }

        public bool UserRegistration(User us)
        {
            string path = @"info.txt";
            StreamWriter sw = new StreamWriter(path, true);
            sw.WriteLine(us.Login + "-" + us.Password);
            sw.Close();
            return true;
        }
    }
}
