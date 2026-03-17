using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBWinform
{
    public class Users
    {
        [DisplayName("Логин")]
        public string Login {  get; set; }
        [DisplayName("Пароль")]
        public string Password { get; set; }
        [DisplayName("Возраст")] 
        public int Age { get; set; }
        [DisplayName("Имя")] 
        public string FirstName { get; set; }
        [DisplayName("Фамилия")] 
        public string LastName { get; set; }
    }
}
