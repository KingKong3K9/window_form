using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice_window6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> mylist = new List<string>();
            // Inserting elements into List
            mylist.Add("C#");
            mylist.Add("Java");
            mylist.Add("C");
            mylist.Add("C++");
            // To get an Enumerator
            // for the List.
            List<string>.Enumerator em = mylist.GetEnumerator();
            //display(em);
            while (em.MoveNext())
            {
                string val = em.Current;
                Console.WriteLine(val);
            }
        }
    }
}
