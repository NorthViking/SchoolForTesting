using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolForTesting
{
    public class Teacher:Person
    {
        private int _salary;

        public Teacher(string name, string address, Gender _genderValue, int salary) : base(name, address, _genderValue)
        {

            Salary = salary;
        }

        public int Salary
        {
            get => _salary;
            set
            {
                if (value<=0) throw new ArgumentOutOfRangeException();
                _salary = value;
            }
        }
    }
}
