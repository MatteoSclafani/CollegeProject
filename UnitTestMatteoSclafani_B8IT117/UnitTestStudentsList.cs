using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MatteoSclafani_B8IT117;

namespace UnitTestMatteoSclafani_B8IT117
{
    [TestClass]
    public class UnitTestStudentsList
    {


        public static Students students = new Students();

        [TestMethod]
        public void RemoveStudentfromListUsingRightStudentNumber()

        {
            //Arrange
            Student student = new Student();
            student.StudentNumber = "454S";
            students.Add(student);
            string EqualStudNumb = "454S";

            //Act
            bool expected= students.Remove(EqualStudNumb);

            // Assert - expected shoud be true
            Assert.AreEqual(expected,true);

        }

        [TestMethod]
        public void RemoveStudentfromListUsingWrongStudentNumber()

        {
            //Arrange
            Student student = new Student();
            student.StudentNumber = "456S";
            students.Add(student);
            string differentStudNumb = "123S";

            //Act
            bool expected = students.Remove(differentStudNumb);

            // Assert - expected shoud be false
            Assert.AreEqual(expected, false);

        }
    }
}
