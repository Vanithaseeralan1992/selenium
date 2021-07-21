using System;
using System.Collections.Generic;
using System.Linq;

namespace Practicecodes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Object oriented programming in C# \n");
            Console.Write("--------------------------------- \n");
            //StudentMarklist is Model here and Marks is list
            List<StudentMarklist> Marks = new List<StudentMarklist>();
           
            Marks.Add(new StudentMarklist { Roll_Number = 101, Name = "Vanitha", Marks = 40, subject = "Maths" });
            Marks.Add(new StudentMarklist { Roll_Number = 102, Name = "Thejasri", Marks = 10, subject = "Science" });
            Marks.Add(new StudentMarklist { Roll_Number = 103, Name = "Pavin", Marks = 70, subject = "Maths" });
            Marks.Add(new StudentMarklist { Roll_Number = 104, Name = "Seeralan", Marks = 80, subject = "Maths" });
            //Marks is list here
            foreach(StudentMarklist student in Marks)
            {
                Console.Write(student.Roll_Number + " | " + student.Name + "    | " + student.Marks + " | " + student.subject + " | \n");
                                  
            }
            List<StudentMarklist> failedstudent = new List<StudentMarklist>();
            failedstudent = Marks.Where(n => n.Marks < 30).ToList();
            /*foreach(StudentMarklist student1 in failedstudent)
            {
                Console.Write(student1.Roll_Number + " | " + student1.Name + " | " + student1.Marks + " | " + student1.subject + " | ");
            }*/
            Console.WriteLine("\n\n");
            Console.WriteLine("failed student\n\n\n");
            failedstudent.ForEach(s => Console.Write(s.Roll_Number + "     | " + s.Name + " | " + s.Marks + " | " + s.subject + " | \n"));

            Console.ReadKey();
        }
    }
}
