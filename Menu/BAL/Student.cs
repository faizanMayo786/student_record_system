using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu.BAL
{
    class Student
    {
        //Registration  No.,  Name,  Quizzes  Marks  (5  quizzes  per  semester),  Mid-Term Marks, End-Term Marks and Total Marks. 
        private string regNo;
        private string name;
        private double quizzes;
        private double midTermMark;
        private double finalMarks;
        private double totalMarks;
        public string RegNo { get { return regNo; } set { regNo = value; } }
        public string Name { get { return name; } set { name = value; } }
        public double Quizzes { get { return quizzes; } set { quizzes = value; } }
        public double MidsMarks { get { return midTermMark; } set { midTermMark = value; } }
        public double FinalsMarks { get { return finalMarks; } set { finalMarks = value; } }
        public Student(string name, string regNo, double quizzes, double midTermMark, double finalMarks)
        {
            Name = name;
            RegNo = regNo;
            Quizzes = quizzes;
            MidsMarks = midTermMark;
            FinalsMarks = finalMarks;
        }
        public double TotalMarks()
        {
            totalMarks = Quizzes + FinalsMarks + MidsMarks;
            return totalMarks;
        }

    }
}
