using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatteoSclafani_B8IT117
{
    partial class College
    {
        //creation of Students and Lecturers Objects
        public static Students students = new Students();
        public static Lecturers lecturers = new Lecturers();
        

        static void Main(string[] args)
        {
            try
            {
                //declaration of variables
                int choice;
               
                bool bye = true;


                do
                {
                    //menu
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("-----------------------------------");
                    Console.WriteLine("Press");
                    Console.WriteLine("1. To add a Student");
                    Console.WriteLine("2. To remove a Student");
                    Console.WriteLine("3. To add a Lecturer");
                    Console.WriteLine("4. To remove a Lecturer");
                    Console.WriteLine("5. To show the details of all Students");
                    Console.WriteLine("6. To show the name of all Lecturers");
                    Console.WriteLine("7. To find a Student by student number");
                    Console.WriteLine("8. To find a Lecturer by staffId");
                    Console.WriteLine("9. To quit");
                    Console.WriteLine("-----------------------------------");

                    int.TryParse(Console.ReadLine(), out choice);

                    switch (choice)
                    {
                        case 1:
                            AddStudent();
                            break;
                        case 2:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Enter Student Number (Lenght 4 - ends with S)");
                            string studentid = Console.ReadLine();
                            if (students.Remove(studentid))
                                Console.WriteLine("Student removed");
                            else Console.WriteLine("Student not removed");
                            break;
                        case 3:
                            AddLecturer();
                            break;
                        case 4:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Enter Lecturer id (Lenght 4 - ends with F)");
                            string lecturerid = Console.ReadLine();
                            if (students.Remove(lecturerid))
                                Console.WriteLine("Lecturer removed");
                            else Console.WriteLine("Lecturer not removed");
                            break;
                        case 5:
                            ShowStudents();
                            break;
                        case 6:
                            ShowLecturers();
                            break;
                        case 7:

                           
                            Console.WriteLine("Enter Student Number");
                            string number = Console.ReadLine();
                            if (students.Contains(number))
                            {
                                Console.WriteLine("Student found, press Y to see student details or Any other key to exit");
                                // Nested if to show details
                                if (Console.ReadLine() == "Y")
                                {
                                    //call of overload method ShowStudents
                                    ShowStudents(number);
                                }
                                else
                                    break;
                            }
                            else Console.WriteLine("Student not found");
                            break;
                        case 8:

                            Console.BackgroundColor = ConsoleColor.Red;
                            Console.WriteLine("Enter Lecturer Number");
                            string lecturernumber = Console.ReadLine();
                            if (lecturers.Contains(lecturernumber))
                            {
                                Console.WriteLine("Lecturer found, press Y to see lecturer details or any Keys to exit");
                                // Nested if to show details
                                if (Console.ReadLine() == "Y")
                                {
                                    //call of overload method ShowLecturer
                                    //ShowLecturers(lecturernumber
                                    ShowLecturers(lecturernumber);
                                }
                                else
                                    break;
                            }
                            else Console.WriteLine("Lecturer not found");
                            break;

                        case 9:
                            bye = false;
                            break;
                        default:
                            Console.WriteLine("Invalid option selected");
                            break;

                    }
                } while (bye);

            }
            catch (Exception ex)

            {
                Console.WriteLine(ex.Message);
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Press Any key to exit....");
            Console.ReadKey();

        }
    }
}
