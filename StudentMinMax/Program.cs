using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace StudentMinMax
{
    public static class Program
    {
        public static void Main()
        {

            string[] studentData = GetStudentDataFromFile();

            Student[] students = new Student[studentData.Count() - 1];

            for (int i = 0; i < students.Length; i++)
            {
                Student student = CreateStudentObject(studentData[i]);
                students.SetValue(student, i);
            }


            foreach (var student in students)
            {
                Console.WriteLine($"{student.Name} Min: {student.GetMinimumScore()} Max: {student.GetMaximumScore()}");
            }

            Console.ReadLine();


        }

        public static string[] GetStudentDataFromFile()
        {
            string[] studentLine = new string[5];
            string[] eachLineInTxtFile = File.ReadAllLines(@"C:\Users\formo\Desktop\CoderGirl\Visual Studio Practice\StudentMinMax\studentdata.txt");




            int lineCounter = File.ReadLines(@"C:\Users\formo\Desktop\CoderGirl\Visual Studio Practice\StudentMinMax\studentdata.txt").Count();



            for (int i = 0; i < lineCounter; i++)
            {
                studentLine.SetValue(eachLineInTxtFile[i], i);
            }

           
            return studentLine;
        } 

        

        public static Student CreateStudentObject(string studentLine)
        {
            Student student = new Student();
            string[] data = studentLine.Split(", ");
            student.Name = data[0];
            student.Scores = GetTestScores(studentLine);
            

            return student;
        }

        public static int[] GetTestScores(string studentLine)

        {
            string[] data = studentLine.Split(" ");

            int[] scores = new int[data.Length - 1];
            for (int i = 1; i < data.Length; i++)
            {

                int score = int.Parse(data[i]);
                scores.SetValue(score, i - 1);

            }

            return scores;
        }


    }
}