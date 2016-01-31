using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MatteoSclafani_B8IT117
{
    partial class College
    {

        #region Add Methods

        public static void AddStudent()
        {
           

            Console.ForegroundColor = ConsoleColor.Blue;
            Student student = new Student();
            Console.WriteLine("Enter Student Number (Lenght 4 - ends with S)");
            student.StudentNumber = Console.ReadLine();
            Console.WriteLine("Enter Name");
            student.Name = Console.ReadLine();
            Console.WriteLine("Enter PPS Number (Lenght 7 - ends with N)");
            student.Pps = Console.ReadLine();
            Console.WriteLine("Enter Tpye (PostGraduate or Undergraduate)");
            student.Type = (Student_Type)Enum.Parse(typeof(Student_Type), Console.ReadLine());
            Console.WriteLine("Enter address:");
            student.Address = Console.ReadLine();
            Console.WriteLine("Enter Phone Number");
            student.Phone = Console.ReadLine();
            Console.WriteLine("Enter Email ( eg. John.lecturer@campus.com )");
            student.Email = Console.ReadLine();

         
                students.Add(student);

        }


        public static void AddLecturer()
        {

            Console.ForegroundColor = ConsoleColor.Blue;
            Lecturer lecturer = new Lecturer();
            Console.WriteLine("Enter Lecturer ID (Lenght 4 - ends with F)");
            lecturer.StaffID = Console.ReadLine();
            Console.WriteLine("Enter Name");
            lecturer.Name = Console.ReadLine();
            Console.WriteLine("Enter PPS Number (Lenght 7 - ends with N)");
            lecturer.Pps = Console.ReadLine();
            Console.WriteLine("Enter subject Taught (Less than 20 words)");
            lecturer.SubjectTaught = Console.ReadLine();
            Console.WriteLine("Enter Salary (more or equal than 1500 and less or equal than 8000)");
            lecturer.Salary = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Enter address:");
            lecturer.Address = Console.ReadLine();
            Console.WriteLine("Enter Phone Number");
            lecturer.Phone = Console.ReadLine();
            Console.WriteLine("Enter Email ( eg. John.student@campus.com )");
            lecturer.Email = Console.ReadLine();


            lecturers.Add(lecturer);

        }

        #endregion

        #region ShowAll Students/Lecturers methods with Overloading

        public static void ShowStudents()
        {
            foreach (Student i in students)
            {
                Console.WriteLine(i);
            }

        }

        //Method Overloaded
        public static void ShowStudents(string number)
        {
            foreach (Student i in students)
            {
                if (i.StudentNumber.ToString() == number)
                {
                    Console.WriteLine(i);
                }

            }
        }

        public static void ShowLecturers()
        {
            foreach (Lecturer i in lecturers)
            {
                Console.WriteLine(i.Name);
            }

        }

        //Method Overloaded
        public static void ShowLecturers(string number)
        {

            {
                foreach (Lecturer i in lecturers)
                {
                    if (i.StaffID.ToString() == number)
                    {
                        Console.WriteLine(i);
                    }


                }
            }

            #endregion
        }
    }
}
