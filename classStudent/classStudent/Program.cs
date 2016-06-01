using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classStudent
{
    class Student
    {
        string name;
        string surname;
        int age;
        string id;

        public Student(string name, string surname, int age, string id)
        {
            this.name = name;
            this.surname = surname;
            this.age = age;
            this.id = id;
        
        }
        public Student()
        {

        }
        public override string ToString()
        {
            return "name: " + this.name + "; surname: " + this.surname + "; age: " + this.age + "; id: " + id;
        }
    }
            
    class Program
    {
        static void Main(string[] args)
        {
            Student firstStudent = new Student("Ayan", "Kurmanbay", "15BD02093");
            Student s = new Student();
            Console.WriteLine(firstStudent);
            Console.ReadKey();
        }
    }
}
