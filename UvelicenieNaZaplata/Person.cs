using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UvelicenieNaZaplata
{
    internal class Person
    {
        private string firstname;
        private string lastname;
        private int age;
        private double salary;
        public string FirstName 
        { 
            get
            {
                return firstname;
            }
            set
            {
                firstname = value;
            }
        }
        public string LastName 
        { 
            get
            {
                return lastname;
            }
            set
            {
                lastname = value;
            }
        }
        public int Age 
        { 
            get
            {
              return age;
            }
            set
            {
                age = value;
            }
        }
        public double Salary 
        { 
            get
            {
                return salary;
            }
            set
            {
                salary = value;
            }
        }

        public Person(string firstName, string lastName, int age, double salary)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.Salary = salary;
        }

        public void IncreaseSalary(double percent)
        {
            if (this.age > 30)
            {
                this.salary += this.salary * percent / 100; 
            }
            else
            {
                this.salary += this.salary * percent / 200;
            }
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName} get {Salary:f2} leva";
        }
    }
}
