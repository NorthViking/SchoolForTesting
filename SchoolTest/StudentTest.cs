using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SchoolForTesting;


namespace SchoolTest
{
    [TestClass]
    public class StudentTest
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void StudentAddressNull()
        {
            Student student = new Student("ha", null, Student.Gender.Male, 4);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void StudentNameToShort()
        {
            Student student = new Student("s", "hejvej", Student.Gender.Male,4);
        }

        [TestMethod]
        public void StudentNameTest()
        {
            Student student = new Student("so", "hejvej", Student.Gender.Female, 4);
            Assert.AreEqual("so", student.Name);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void StudentSemester0()
        {
            Student student = new Student("so", "hejvej", Student.Gender.Male,0);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void StudentSemester9()
        {
            Student student = new Student("so", "hejvej", Student.Gender.Male, 9);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TeacherSalary()
        {
            Teacher teacher = new Teacher("paul","snejlevej",Teacher.Gender.Male,0);
        }

        [TestMethod]
        public void TeacherRightName()
        {
            Teacher teacher = new Teacher("paul","snejlevej",Teacher.Gender.Male,1000);
            Assert.AreEqual("paul",teacher.Name);
        }

        [TestMethod]
        public void TeacherWrongName()
        {
            Teacher teacher = new Teacher("paul", "snejlevej", Teacher.Gender.Male,1000);
            Assert.AreNotEqual("maul", teacher.Name);
        }

        [TestMethod]
        public void TeacherGenderTypeMale()
        {
            Teacher teacher = new Teacher("paul", "snejlevej", Teacher.Gender.Male, 1000);
            Assert.AreEqual(Teacher.Gender.Male, teacher.GenderValue);
        }

        [TestMethod]
        public void TeacherGenderTypeFemale()
        {
            Teacher teacher = new Teacher("sally", "snejlevej", Teacher.Gender.Female, 1000);
            Assert.AreEqual(Teacher.Gender.Female, teacher.GenderValue);
        }

        [TestMethod]
        public void PersonGender()
        {
            Person person = new Person("lasse", "lillevej", Person.Gender.Female);
            Assert.AreNotEqual(Person.Gender.Male, person.GenderValue);
        }
    }
}
