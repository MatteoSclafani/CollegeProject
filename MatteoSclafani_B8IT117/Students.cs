using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatteoSclafani_B8IT117
{
     public class Students : ICollection<Student>
    {

        private List<Student> list { get; set; }
        int i;

        public Students()
        {

            list = new List<Student>();

        }

        public int Count { get; }

        public bool IsReadOnly { get { return false; } }


        #region 



        // Add Method avoids students with the same StudentNumber
        public void Add(Student item)
        {

            bool flag = false;

            if (list.Count == 0 && flag==false)
            {
                list.Add(item);
                Console.WriteLine("Student Added");
            }
            else
            {
                for (i = 0; i < list.Count && !flag; i++)
                {
                    if (list[i].StudentNumber.Equals(item.StudentNumber))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Student cannot be inserted - Student Number unavailable");
                        
                        flag = true;
                    }
                }
                if(flag==false)
                {
                    list.Add(item);
                    Console.WriteLine("Student Added");
                }
            }
          }


        public bool Remove(Student item)
        {
            bool remove = false;
            for (int i = 0; i < list.Count && !remove; i++)
            {
                if (list[i].StudentNumber == item.StudentNumber)
                {
                    list.Remove(list[i]);
                    remove = true;
                }
            }

            return remove;
        }

        //Overloading Remove Method
        public bool Remove(string studentnumber)
        {
            bool remove = false;
            for (int i = 0; i < list.Count && !remove; i++)
            {
                if (list[i].StudentNumber.ToString() == studentnumber.ToString())
                {
                    list.Remove(list[i]);
                    remove = true;
                }
            }

            return remove;
        }

       

        public void Clear()
        {
            list.Clear();
        }

        public bool Contains(Student item)
        {
            return list.Contains(item);
        }

        public bool Contains(string id)
        {
            bool found = false;
            for (int i = 0; i < list.Count && !found; i++)
            {
                if (list[i].StudentNumber.Equals(id))
                    found = true;
            }

            return found;
        }


        public IEnumerator<Student> GetEnumerator()
        {
            return list.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return list.GetEnumerator();
        }

        

      

        public void CopyTo(Student[] array, int arrayIndex)
        {
            ((ICollection<Student>)list).CopyTo(array, arrayIndex);
        }



        #endregion

    }
}
