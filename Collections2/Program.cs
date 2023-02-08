using Collections2;
using System.ComponentModel.DataAnnotations;

namespace Collection2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<Student> listStudent= new List<Student>();
            var student = new Student();
            student.Name = "Fatima";
            student.Surname = "Karimova";
            student.Pin = "F28";
            var student2 = new Student();
            student2.Name = "Azer";
            student2.Surname = "Karimov";
            student2.Pin = "A20";
            var student3 = new Student();
            student3.Name = "Mawa";
            student3.Surname = "Karimova";
            student3.Pin = "A20";
            AddStudent(listStudent, student);
            AddStudent(listStudent, student2);
           AddStudent(listStudent, student3);

            foreach( var std in listStudent)
            {
                Console.WriteLine(std.GetDetails());
            }
            Console.WriteLine(GetCountA(listStudent));
            
        }


        static void AddStudent(List<Student> listStudent, Student student)
        {
            var pinDublicat = listStudent.Any(p => p.Pin == student.Pin);
            if(!pinDublicat)
            {
                listStudent.Add(student);
            }
        }
       

        static int GetCountA(List<Student> listStudent)
        {
            int count = listStudent.Count(s => s.Name.ToLower().Contains('a'));
            return count;
        }
       
    }
}