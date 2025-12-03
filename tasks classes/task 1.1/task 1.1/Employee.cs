using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_1._1
{
    internal abstract class Employee
    {
        public int Id_;
        public string FullName_;
        public string email_;

        public void SetId(int Id)
        {
            Id_ = Id;
        }
        public int GetId()
        {
            return Id_;
        }
        public void SetFullName(string FullName)
        {
            FullName_ = FullName;
        }
        public string GetFullName()
        {
            return FullName_;
        }
        public void SetEmail(string email)
        {
            email_ = email;
        }

        public string GetEmail()
        {
            return email_;
        }
        public abstract decimal CalculateSalary();
    }
}

