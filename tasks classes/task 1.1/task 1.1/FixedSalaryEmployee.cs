using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_1._1
{
    internal class FixedSalaryEmployee : Employee
    {
        private decimal monthlySalary_;

        public void SetMonthlySalary(decimal salary)
        {
            monthlySalary_ = salary;
        }

        public decimal GetMonthlySalary()
        {
            return monthlySalary_;
        }

        public override decimal CalculateSalary()
        {
            return monthlySalary_;
        }
    }
}

