using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht1
{
    class Program
    {
        static void Main(string[] args)
        {
            List < Student > Students = new List<Student>();

            Student s1 = new Student("Masa", "Niemi", "A1111", "TTV17S1");
            Student s2 = new Student("Allan", "Aalto", "B2222", "TTV17S2");
            Student s3 = new Student("Hanna", "Husso", "C3333", "TTV17S3");
            Student s4 = new Student("Teppo", "Testaaja", "D4444", "TTV17S1");
            Students.Add(s1);
            Students.Add(s2);
            Students.Add(s3);
            Students.Add(s4);

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Please, give data of a new Opiskelija: ");
                Console.Write("AsioID: ");
                string id = Console.ReadLine();
                Console.Write("First name: ");
                string fname = Console.ReadLine();
                Console.Write("Last name: ");
                string lname = Console.ReadLine();
                Console.Write("Group: ");
                string group = Console.ReadLine();

                if (id != s1.AsioID && id != s2.AsioID && id != s3.AsioID && id != s4.AsioID)
                {
                    Student s5 = new Student(fname, lname, id, group);
                    Students.Add(s5);
                    break;
                }
                else
                {
                    Console.WriteLine("AsioID is already taken!");
                }
            }

            Students.Sort((x, y) => x.LastName.CompareTo(y.LastName));
            Console.WriteLine("Students in MiniASIO: ");
            foreach (Student stu in Students)
            {
                Console.WriteLine(stu.FirstName + " " + stu.LastName + " " + stu.AsioID + " " + stu.Group);
            }
        }
    }
}
