using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MatteoSclafani_B8IT117;

namespace UnitTestMatteoSclafani_B8IT117
{
    [TestClass]
    public class UnitTestStudent
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CheckWitWrongUnderGraduate()
        {

            //Arrange
            Student student = new Student();
            string value = "UnderGraduat";

            //Act
            student.Type = (Student_Type)Enum.Parse(typeof(Student_Type), value);

        }


        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CheckWithWrongPostGraduate()
        {

            //Arrange
            Student student = new Student();
            string value = "PostGraduat";

            //Act
            student.Type = (Student_Type)Enum.Parse(typeof(Student_Type), value);

        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void CheckWithWrongPpsNumber()
        {
            //Arrange
            Student student = new Student();
            string value = "123456";

            //Act
            student.Pps = value;

        }
    }
}
