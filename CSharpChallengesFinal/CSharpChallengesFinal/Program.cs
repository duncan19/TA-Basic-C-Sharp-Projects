using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace CSharpChallengesFinal
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new Roster())
            {
                Console.Write("Enter a name for a new Student: ");
                var name = Console.ReadLine();

                var student = new Student { Name = name };
                db.Students.Add(student);
                db.SaveChanges();
                var query = from b in db.Students
                            orderby b.Name
                            select b;

                Console.WriteLine("All students in the database:");
                foreach (var item in query)
                {
                    Console.WriteLine(item.Name);
                }

                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
            }
        }

    }

    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual List<Post> Posts { get; set; }
    }

    public class Post
    {

        public int Id { get; set; }
        public virtual Student Student { get; set; }
    }

    public class Roster : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Post> Posts { get; set; }
    }
}
