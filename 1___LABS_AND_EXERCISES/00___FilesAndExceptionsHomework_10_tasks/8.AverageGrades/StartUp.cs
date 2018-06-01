namespace _8.AverageGrades
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.IO;
    class Student
    {
        public string Name { get; set; }
        public List<double> Grades { get; set; }
        public double AverageGrade
        {
            get
            { return (double)Grades.Sum() / Grades.Count; }
        }
    }
    public class StartUp
    {
        public static void Main()
        {
            Student[] studentGrades = GetStudentGrades();
            string[] topStudents = studentGrades
                                    .Where(x => x.AverageGrade >= 5)
                                    .Select(x => x.Name).Distinct()
                                    .OrderBy(x => x)
                                    .ToArray();
            foreach (string student in topStudents)
            {
                double[] studentAverGrades = studentGrades
                                                .Where(x => x.Name == student && x.AverageGrade >= 5)
                                                .Select(x => x.AverageGrade)
                                                .OrderByDescending(x => x)
                                                .ToArray();
                foreach (double studentAverageGrade in studentAverGrades)
                {

                    File.AppendAllText("../../output.txt",$"{student} -> {studentAverageGrade:f2}");
                    File.AppendAllText("../../output.txt", Environment.NewLine);
                }

            }
        }
        private static Student[] GetStudentGrades()
        {

            var n = File.ReadAllText("../../input-ListOfStudents.txt");
            int numberofStudents = int.Parse(n);
            string[] studentsinfoinitial = File.ReadAllLines("../../input.txt");
            File.Delete("../../output.txt");
            Student[] grades = new Student[numberofStudents];
            for (int i = 0; i < numberofStudents; i++)
            {
                List<double> studentGrades = new List<double>();
                var studentsinfo = studentsinfoinitial[i]
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                for (int y = 1; y < studentsinfo.Length; y++)
                    studentGrades.Add(double.Parse(studentsinfo[y]));
                grades[i] = new Student() { Name = studentsinfo[0], Grades = studentGrades };
            }
            return grades;
        }
    }
}
