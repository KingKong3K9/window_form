using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice_window5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("D:/visualstudio/code/practice_window5/practice_window5/bin/tmp.txt");
            Console.WriteLine("Content of the File:");
            // This is use to specify from where
            // to start reading input stream
            sr.BaseStream.Seek(0, SeekOrigin.Begin);
            // To read line from input stream
            string str = sr.ReadLine();
            // To read the whole file line by line
            while (str != null)
            {
                Console.WriteLine(str);
                str = sr.ReadLine();
            }
            Console.ReadLine();
            sr.Close();
        }
    }
}
