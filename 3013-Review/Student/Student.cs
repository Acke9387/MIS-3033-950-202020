using System;
using System.Collections.Generic;
using System.Text;

namespace Student
{
    public class Student
    {

        public Int64 ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FavoriteColor { get; set; }

        /// <summary>
        /// Default/Empty Constructor for the Student class
        /// that sets every property to it's starting value
        /// </summary>
        public Student()
        {
            ID = -900; // I wanted to start off with -900 that way if know if they are a real student or not
            FirstName = "";
            LastName = string.Empty;
            FavoriteColor = string.Empty;
        }

        /// <summary>
        /// Overloaded constructor taking ALL of the properties values
        /// </summary>
        /// <param name="id"></param>
        /// <param name="first"></param>
        /// <param name="last"></param>
        /// <param name="color"></param>
        public Student(Int64 id, string first, string last, string color)
        {
            ID = id;
            FirstName = first;
            LastName = last;
            FavoriteColor = color;
        }

        /// <summary>
        /// Overloaded constructor taking just the id
        /// </summary>
        /// <param name="id"></param>
        public Student(Int64 id) : this()
        {
            ID = id;
            //FirstName = "";
            //LastName = string.Empty;
            //FavoriteColor = string.Empty;
        }

        public string CreateFullName()
        {
            // return LastName + ", " + FirstName;
            return $"{LastName}, {FirstName}";
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName} ({ID})";
        }

    }
}
