using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_1._1
{
    internal class HourlySalaryEmployee : Employee
    {
        private decimal hourlyRate_;
        private int regularHours_;
        private int overtimeHours_;

        public void SetHourlyRate(decimal rate)
        {
            hourlyRate_ = rate;
        }

        public decimal GetHourlyRate()
        {
            return hourlyRate_;
        }
        public void SetRegularHours(int hours)
        {
            regularHours_ = hours;
        }

        public int GetRegularHours()
        {
            return regularHours_;
        }
        public void SetOvertimeHours(int hours)
        {
            overtimeHours_ = hours;
        }

        public int GetOvertimeHours()
        {
            return overtimeHours_;
        }
        public override decimal CalculateSalary()
        {
            decimal regularSalary = hourlyRate_ * regularHours_;
            decimal overtimeRate = hourlyRate_ * 1.5m;
            decimal overtimeSalary = overtimeRate * overtimeHours_;
        }
    }
}
