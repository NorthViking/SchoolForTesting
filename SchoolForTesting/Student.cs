using System;

namespace SchoolForTesting
{
    public class Student:Person
    {
        private int _semester;
      

        /// <summary>
        /// 
        /// </summary>
        /// <param name="semester"></param>
 
        public Student(string name, string address, Gender _genderValue, int semester):base(name,address,_genderValue)
        {
            
            Semester = semester;
        }

        /// <summary>
        /// antal semmestere må ikke være mindre end 1 eller størrer end 8
        /// </summary>
        public int Semester
        {
            get => _semester;
            set
            {
                if(value<=1 || value>=8) throw  new ArgumentOutOfRangeException();
                _semester = value;
            }
        }

        

    }
}
