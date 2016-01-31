using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MatteoSclafani_B8IT117;

namespace UnitTestMatteoSclafani_B8IT117
{
    [TestClass]
    public class UnitTestLecturer
    {
        [TestMethod]
        public void CheckWithSecondLevelLecturerString()
        {

            //Arrange
            string expected = "Second Level Lecturer";
            decimal salary = 5555m;
            
            //Act
            Lecturer lecturer = new Lecturer();
            lecturer.Salary = salary;

            //Assert
            Assert.AreEqual( expected, lecturer.CheckLevel(),false);


        }
        [TestMethod]
        public void CheckWithFirtsLevelLecturerString()
        {

            //Arrange
            string expected = "First Level Lecturer";
            decimal salary = 1500m;

            //Act
            Lecturer lecturer = new Lecturer();
            lecturer.Salary = salary;

            //Assert
            Assert.AreEqual(expected, lecturer.CheckLevel(), false);


        }

        [TestMethod]
        public void CheckWithThirdLevelLecturerString()
        {

            //Arrange
            string expected = "Third Level Lecturer";
            decimal salary = 6500m;

            //Act
            Lecturer lecturer = new Lecturer();
            lecturer.Salary = salary;

            //Assert
            Assert.AreEqual(expected, lecturer.CheckLevel(), false);


        }


    }
}
