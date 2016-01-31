using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatteoSclafani_B8IT117
{
    public abstract class Staff:Person 

    {
        //variables
        private string staffId;
        private decimal salary;



        //autoimplemented properties
        public string StaffID
        {
            get
            {
                return staffId;
            }
            set
            {
                if (value.Length == 4 && value.EndsWith("F"))
                {
                    staffId = value;
                }
                else throw new ArgumentOutOfRangeException("Invalid Staff Number");
            }
        }

        public decimal Salary
        {
            get
            {
                return salary;
            }
            set
            {
                if (value >= 1500m && value <= 8000m)
                {
                    salary = value;
                }
                else throw new ArgumentOutOfRangeException("Invalid Salary");

            }
        }

        //constructors
        public Staff() { }

        public Staff(string name, string pps, string address, string phone, string email,string staffId, decimal salary)
            :base(name,pps,address,phone,email)
        {
            this.StaffID = staffId;
            this.Salary = salary;
        }

        //Methods
        public abstract string CheckLevel();



        public override string ToString()
        {

            return base.ToString() + string.Format("\nStaffId: {0} \nSalary: {1}", this.StaffID,this.Salary);

        }

        
    }
}
