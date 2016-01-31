using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatteoSclafani_B8IT117
{
    public class Lecturers : ICollection<Lecturer>
    {

        private List<Lecturer> list { get; set; }
        int i;

        public Lecturers()
        {

            list = new List<Lecturer>();

        }


        #region interface properties
        public int Count { get; }

        public bool IsReadOnly { get { return false; } }

        #endregion


        #region Methods

        // Add Method avoids lecturers with the same StaffId
        public void Add(Lecturer item)
        {

            bool flag = false;

            if (list.Count == 0 && flag == false)
            {
                list.Add(item);
                Console.WriteLine("Lecturer Added");
            }
            else
            {
                for (i = 0; i < list.Count && !flag; i++)
                {
                    if (list[i].StaffID.Equals(item.StaffID))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Lecturer cannot be inserted - StaffID unavailable");

                        flag = true;
                    }
                }
                if (flag == false)
                {
                    list.Add(item);
                    Console.WriteLine("Lecturer Added");
                }
            }
        }
        public bool Remove(Lecturer item)
        {
            bool remove = false;
            for (int i = 0; i < list.Count && !remove; i++)
            {
                if (list[i].StaffID == item.StaffID)
                {
                    list.Remove(list[i]);
                    remove = true;
                }
            }

            return remove;
        }

        //Overloading Remove Method
        public bool Remove(string lecturerid)
        {
            bool remove = false;
            for (int i = 0; i < list.Count && !remove; i++)
            {
                if (list[i].StaffID.ToString() == lecturerid.ToString());
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

        public bool Contains(Lecturer item)
        {
            return list.Contains(item);
        }

        public bool Contains(string id)
        {
            bool found = false;
            for (int i = 0; i < list.Count && !found; i++)
            {
                if (list[i].StaffID.Equals(id))
                    found = true;
            }

            return found;
        }


        public IEnumerator<Lecturer> GetEnumerator()
        {
            return list.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return list.GetEnumerator();
        }

        public void CopyTo(Lecturer[] array, int arrayIndex)
        {
            ((ICollection<Lecturer>)list).CopyTo(array, arrayIndex);
        }

        #endregion

    }
}
