using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatteoSclafani_B8IT117
{
    public sealed class Student: Person 
    {
        private string studentNumber;
        private Student_Type type;


        //autoimplemented properties
        public string StudentNumber
        {
            get
            {
                return studentNumber;
            }

            set
            {
                if (value.Length==4 && value.EndsWith("S"))

                {
                   studentNumber = value;

                }

                else throw new ArgumentOutOfRangeException("Invalid Student Number");
            }

        }

        public Student_Type Type
        {
            get
            {
                return type;
            }
            set
            {

                if (value == Student_Type.PostGraduate || value == Student_Type.PostGraduate )
                {
                    type = value;
                }
                else throw new ArgumentException("Error: Invalid Student type");
            }
        }

        //Constructors
        public Student() { }

        public Student(string name, string ppsn, string address, string phone, string email, string studentNumber)
            : base(name, ppsn, address, phone, email)
        {

            this.StudentNumber = studentNumber;
            this.Pps = ppsn;
            this.Name = name;
            this.Address = Address;
            this.Phone = phone;
            this.Email = email;
        }

        //overloaded constructor
        public Student(string name, string ppsn, string address, string phone, string email, string studentNumber,Student_Type type)
            : base(name, ppsn, address, phone, email)
        {

            this.StudentNumber = studentNumber;
            this.Pps = ppsn;
            this.Name = name;
            this.Address = Address;
            this.Phone = phone;
            this.Email = email;
            this.Type = type;

        }

        public override string ToString()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
                return  base.ToString() + string.Format("\nStudent Number: {0}", StudentNumber) ;

        } 

    }
}
