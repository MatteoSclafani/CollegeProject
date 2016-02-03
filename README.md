﻿# CollegeProject

Program provide a Console-based UI that allow for services such as 
	Add student
	Add lecturer
	Search lecturer or student
	Show the details of all enrolled students
	Show the names of all lecturers							 

Create an inheritance hierarchy for this application, below are the required classes to use in your application. Use appropriate data types while developing the classes.

1.	College Class (this is the entry point to the programme)

2.	Person Class
	A class Person with attributes PPSN, Name, Address, Phone and Email.		

3.	Student Class (should inherit the functionality of base class Person)
	A class Student which inherits from Person with attributes Status and StudentId. A student’s status can either be a Postgrad or an Undergrad.
	Create a constructor for Student such that all attributes belonging to a Student can be assigned via the constructor.

4.	Staff Class (should inherit the functionality of base class Person)
	Create a class Staff which inherits from Person with an attribute of Id and Salary

5.	Lecturer Class (should inherit the functionality of base class Staff)
	Create a class Lecturer which inherits from Staff with an attribute of Subject(s) Taught
	Create a constructor for Lecturer such that all attributes belonging to a Lecturer can be assigned via the constructor.


Other features include:									

INNOVATION APPLIED TO MY PROGRAM

STUDENTS/LECTURERS CLASSES

 Remove Student/Lecturer by StudentNumber/StaffId;
 Verify a StudentNumber/StaffId, if already exists in the Lists the object won’t be
Added.

PERSON PROPERTIES

 Name allows only Letters;
 Phone allows only Digit;
 Email: IsValidEmail method calls the Regex.Replace(String, String,
MatchEvaluator) method with the (@)(.+)$ regular expression pattern to separate the
domain name from the email address. (Microsoft Developer NetWork).
LECTURER METHOD
 Method CheckLevel controls Salary and It gives a Level to each Lecturer.

FUNCTIONS TESTED

UNITTESTSTUDENTS TEST CLASS

In this class I tested overloaded remove method public bool Remove(string studentnumber)
from Students Class.
 public void RemoveStudentfromListUsingRightStudentNumber(): I created a student
object, assigned it a studentNumber and tried to remove object using
Remove(studentnumber) that returning a true value it removes the object and
confirm the Assert.
 public void RemoveStudentfromListUsingWrongStudentNumber(): I created a student
object,assigned it a studentNumber and tried to remove object using
OBJECT ORIENTED PROGRAMMING ASSIGNMENT
MATTEO SCLAFANI 10330669 2
Remove(AnotherStudentNumber) that returning a false value it removes the object and confirm the Assert.

UNITTESTSTUDENT TEST CLASS

I tested in the first two methos Student Type Property from Student class and in the last one PPs property.
 public void CheckWitWrongUnderGraduate(): I created a string “Undergraduat” without final “e”, an object student and I put that value in Type field. It is expected an ArgumentException.
 public void CheckWithWrongPostGraduate():I created a string “PostGraduat” without final “e”, an object student and I put that value in Type field. It was expected an ArgumentException.
 public void CheckWithWrongPpsNumber(): I created a string with a wrong pps number and it was expected an ArgumentException.

UNITTESTLECTURER TEST CLASS

I tested the method public override string CheckLevel() created in Lecturer class.
 public void CheckWithSecondLevelLecturerString(): I created a decimal salary value to have a Second Level Lecturer string from CheckLevel method;
 public void CheckWithFirtsLevelLecturerString(): I created a decimal salary value to have a First Level Lecturer string from CheckLevel method;
 public void CheckWithThirdLevelLecturerString(): I created a decimal salary value to have a Third Level Lecturer string from CheckLevel method.


