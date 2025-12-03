using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_1._1
{
    internal class FreelancerEmployee : FreelancerEmployee
    {
        private decimal projectPayment_;
        private decimal taxRate_;

        public void SetProjectPayment(decimal payment)
        {
            projectPayment_ = payment;
        }

        public decimal GetProjectPayment()
        {
            return projectPayment_;
        }
        public void SetTaxRate(decimal rate)
        {
            taxRate_ = rate;
        }
        public decimal GetTaxRate()
        {
            return taxRate_;
        }
        public override decimal CalculateSalary()
        {
            decimal taxAmount = projectPayment_ * taxRate_;
        }
    }
}
