namespace _04.Average_Grades
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class Student
    {
        public string Name { get; set; }
        public List<double> Grades { get; set; }
        public double Average => Grades.Average();
    }
    class StartUp
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            double n = double.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Student student = new Student();
                var input = Console.ReadLine().Split(' ').ToArray();
                student.Name = input[0];
                student.Grades = input.Skip(1).Select(double.Parse).ToList();
                students.Add(student);
            }
            var output = students
                .Where(p => p.Average >= 5.00)
                .OrderBy(x => x.Name)
                .ThenByDescending(y => y.Average)
                .ToList();
            foreach (var item in output)
            {
                Console.WriteLine($"{item.Name} -> {item.Average:f2}");
            }
        }
    }
}
