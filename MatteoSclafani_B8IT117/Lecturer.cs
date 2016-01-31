using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatteoSclafani_B8IT117
{
    public sealed class Lecturer:Staff

    {
        private string subjectTaught;
       

        public string SubjectTaught
        {
            get { return subjectTaught;  }

            set
            {
                if( value.Length >0 && value.Length<20 )
                {

                    subjectTaught = value;
                }
                else throw new ArgumentOutOfRangeException("Invalid Subject Taught");
            }
        }

        public string Level { set; get; }


        public Lecturer() { }

        public Lecturer(string name,string pps, string address, string phone, string email,string staffId, decimal salary, string subjectT)
            :base(name,pps,address,phone,email,staffId,salary)

        {
            this.SubjectTaught = subjectTaught;

        }

        public override string CheckLevel()

        {
            

            if (Salary >= 1500m && Salary <= 5000m)
            {

                this.Level = "First Level Lecturer";
            }
            else if (Salary >= 5000m && Salary<=6000m)
            {

                this.Level = "Second Level Lecturer";
            }
            else

                this.Level = "Third Level Lecturer";


            return Level;
        }

        public override string ToString()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            return base.ToString() + string.Format("\nSubjectTaught: {0} \nLevel: {1}", this.SubjectTaught, CheckLevel());

        }
    }
}
