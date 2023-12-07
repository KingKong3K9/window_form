using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace practice_7
{
    public class User
    {
        public int id {  get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }

        public string address { get; set; }
        public DateTime dob { get; set; }
        public int salary { get; set; }


        public User(int id, string firstname, string lastname, string address, string dob, int salary) 
        {
            this.id = id;  
            this.address = address;
            this.dob = Convert.ToDateTime(dob);
            this.salary = salary;
            this.lastname = lastname;
            this.firstname = firstname;
        }
    }
    public class car
    {
        public int price { get; set; }
        public string brand { get; set; }

        public car(int price, string brand)
        {
            this.price = price;
            this.brand = brand;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            User[] users = new User[]
            {
                new User (1,"John","","London","2001-04-01",0),
                new User (2,"Lenny","","New York","1997-12-11",0),
                new User (3, "Andrew","", "Boston", "1987-02-22", 0),
                new User (4, "Peter","", "Prague", "1936-03-24", 0),
                new User (5, "Anna","", "Bratislava", "1973-11-18", 0),
                new User (6, "Albert","", "Bratislava", "1940-12-11", 0),
                new User (7, "Adam","", "Trnava", "1983-12-01", 0),
                new User (8, "Robert","", "Bratislava", "1935-05-15", 0),
                new User (9, "Robert","", "Prague", "1998-03-14", 0),
            };
            IEnumerable<User> result = (from t in users
                                        where t.address == "Bratislava"
                                        select t);
            foreach (User t in result)
            {
                Console.WriteLine ($" {t.id} {t.firstname} {t.address} {t.dob}");
            }

            var cars = new List<car> {
                new car ( 52642,"Audi"),
                new car ( 57127,"Mercedes"),
                new car ( 9000,"Skoda"),
                new car ( 29000,"Volvo"),
                new car ( 350000,"Bentley"),
                new car ( 21000,"Citroen"),
                new car ( 41400,"Hummer"),
                new car ( 21600,"Volkswagen"),
            };
            IEnumerable<car> resultcar = (from c in cars
                                        where c.price >30000 && c.price <100000
                                        select c);
            Console.WriteLine("The cars whose between 30000 and 100000 is: ");
            foreach (car t in resultcar)
            {
                Console.WriteLine(" {c.price} {c.brand}");
            }
            var users2 = new List<User> {
                new User(0,"John", "Doe", "","", 1230),
                new User (0,"Lucy", "Novak","","", 670),
                new User (0,"Ben", "Walter","","", 2050),
                new User (0,"Robin", "Brown","","", 2300),
                new User (0,"Amy", "Doe","","", 1250),
                new User (0,"Joe", "Draker","","", 1190),
                new User (0,"Janet", "Doe","","", 980),
                new User (0,"Albert", "Novak","","", 1930),
            };
            var orderbyResult = from s in users2
                                orderby s.lastname, s.salary
                                select s;
            Console.WriteLine("Sort ascending by last name and salary\n");
            foreach (User b in orderbyResult)
            {
                Console.WriteLine($" {b.firstname} {b.lastname} {b.salary}");
            }

            IEnumerable<User> result2 = (from emp in users2
                                         where emp.salary > 1500
                                         select emp).ToList();
            Console.WriteLine("Users who have salary higher than 1500\n");
            foreach (User b in result2)
            {
                Console.WriteLine($" {b.firstname} {b.lastname} {b.salary}");
            }
        }
    }
}
