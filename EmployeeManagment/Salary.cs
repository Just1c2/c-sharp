using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagment
{
    class Salary
    {
        public float basicSalary;
        public float hoursRent;
        public float medicalAllowance;
        public float conveyanve;

        double bsPercent;
        double hrPercent;
        double maPercent;
        double caPercent;

        public float overtime;
        public double overtimeRet;
        public double totalOvertimeRet;

        public double CalculateSalary(float basicSalary)
        {
            this.bsPercent = 0.50;
            this.hrPercent = 0.20;
            this.maPercent = 0.25;
            this.caPercent = 0.05;

            this.basicSalary = basicSalary;
            this.hoursRent = Convert.ToInt32(basicSalary * hrPercent);
            this.medicalAllowance = Convert.ToInt32(basicSalary * maPercent);
            this.conveyanve = Convert.ToInt32(basicSalary * caPercent);
            var totalSalary = this.basicSalary + this.hoursRent + this.medicalAllowance + this.conveyanve;
            this.currency = Currency.BDT;
            return totalSalary;
        }

        public double CalculateByOverTime(double overtime)
        {
            this.overtime = basicSalary;
            var ot = (((overtime / 30) / 8) * 2 * 8);
            return ot;
        }

        public Currency currency;
    }
    public enum Currency
    {
        BDT, RS, USD, ERO, CNY, YEN
    }
}
