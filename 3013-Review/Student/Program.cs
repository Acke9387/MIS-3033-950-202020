using System;
using System.Collections.Generic;
using System.IO;

namespace Student
{
    class Program
    {
        private static List<Student> students = new List<Student>();

        static void Main(string[] args)
        {
            string[] lines = (File.ReadAllLines("studentDataRandom100Rows.csv"));


            //Student stud = new Student();
            //stud.FirstName = "adam";
            //stud.LastName = "ackerman";
            //stud.FavoriteColor = "blue";
            //stud.ID = 1;
            //Console.WriteLine(stud.CreateFullName());

            // 0         1          2            3
            //id	first_name	last_name	favorite_color
            for (int i = 1; i < lines.Length; i++)
            {
                string line = lines[i];

                string[] pieces = line.Split(',');

                //int id = Convert.ToInt32(pieces[0]);

                bool isgreater = 8203029752 > Int64.MaxValue;

                Student currentStudent = new Student(Convert.ToInt64(pieces[0]), pieces[1], pieces[2], pieces[3]);

                students.Add(currentStudent);
            }

            // output all the students whose favorite color is Puce

            OutputStudentsWithFavoriteColor("blue");

            OutputStudentsWithFavoriteColor("pink");

            OutputStudentsWithFavoriteColor("puce");

            //foreach (var line in lines)
            //{
            //    Console.WriteLine(line);
            //}

            Console.ReadKey();
        }

        private static void OutputStudentsWithFavoriteColor(string color)
        {
            Console.WriteLine(color);
            foreach (var student in students)
            {
                if (student.FavoriteColor.ToLower() == color.ToLower())
                {
                    //Console.WriteLine(student.CreateFullName());
                    Console.WriteLine(student);
                }
            }
            Console.WriteLine();
        }
    }
}
