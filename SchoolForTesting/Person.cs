using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolForTesting
{
    public class Person
    {
        private string _name;
        private string _address;
        //private Gender _genderValue;

        public Person(string name, string address, Gender _genderValue)
        {
            Name = name;
            Address = address;
            GenderValue = _genderValue;
        }
        /// <summary>
        /// navnet må ikke være mindre end 2 tegn
        /// </summary>
        public string Name
        {
            get => _name;
            set
            {
                if (value.Length < 2) throw new ArgumentOutOfRangeException();
                _name = value;

            }
        }
        /// <summary>
        /// addressen må ikke være null
        /// </summary>
        public string Address
        {
            get => _address;
            set
            {
                if (value == null) throw new ArgumentOutOfRangeException();
                _address = value;

            }
        }

        public Gender GenderValue { get; set; }
        //public Gender GenderValue
        //{
        //    get => _genderValue;
        //    set => _genderValue = value;
        //}

        public enum Gender
        {
            Male, Female
        }
    }
}
