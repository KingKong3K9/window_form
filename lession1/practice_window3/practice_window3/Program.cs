using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice_window3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a name for the new directory:");
            string DirName = Console.ReadLine();
            // Checking if string is empty or not
            if (DirName != String.Empty)
            {
                // Creating the Directory
                Directory.CreateDirectory(DirName);
                // Checking Directory is created
                // Successfully or not
                if (Directory.Exists(DirName))
                {
                    Console.WriteLine("The directory was created!");
                    //Console.ReadKey();
                }
            }
            Console.WriteLine("Enter the directory name you want to delete:");
            DirName = Console.ReadLine();
            // Checking if Directory Exist or not
            if (Directory.Exists(DirName))
            {
                // This will delete the
                // Directory if it is empty
                Directory.Delete(DirName);
                // checking if directory if
                // deleted successfully or not
                if (Directory.Exists(DirName) == false)
                    Console.WriteLine("Directory deleted successfully...");
            }
            else
            Console.WriteLine("Directory {0} does not exist!", DirName);
            Console.ReadKey();
        }
    }
}
