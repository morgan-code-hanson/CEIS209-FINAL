using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hanson_CourseProject_part2
{
    public class Employee
    {
        //attributes
        private string firstName;
        private string lastName;
        private string ssn;
        private DateTime hireDate;
        private Benefits benefits;

        //default constructor
        public Employee()
        {
            firstName = "N/A";
            lastName = "N/A";
            ssn = "N/A";
            hireDate = new DateTime();
            benefits = new Benefits();
        }

        //main constructor
        public Employee(string firstName, string lastName, string ssn, DateTime hireDate, Benefits benefits)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.ssn = ssn;
            this.hireDate = hireDate;
            this.benefits = benefits;

        }

        //public methods
        public override string ToString()
        {
            return "firstName= " + firstName
                + ", lastName= " + lastName
                + ", ssn= " + ssn
                + ", hireDate= " + hireDate.ToShortDateString()
                + ", healthInsurance = " + benefits.HealthInsurance
                + ", lifeInsurance = " + benefits.LifeInsurance
                + ", vacation = " + benefits.Vacation;
        }
        public double CalculatePay()
        {
            return 0;
        }
        public String FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public string SSN
        {
            get { return ssn; }
            set { ssn = value; }
        }
        public DateTime HireDate
        {
            get { return hireDate; }
            set { hireDate = value; }
        }
        public Benefits BenefitsEmp
        {
            get { return benefits; }
            set { benefits = value; }

        }
    }
}
