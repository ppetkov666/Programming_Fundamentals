namespace _08.Mentor_Group
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Globalization;
    class Student
    {
        public string Name { get; set; }
        public List<DateTime> Dates { get; set; }
        public List<string> Comments { get; set; }
    }
    class StartUp
    {
        static void Main()
        {
            List<Student> allStudentStorageList = new List<Student>();
            var command = Console.ReadLine();
            
            while (command != "end of dates")
            {
                var splittedCommand = command.Split(' ', ',').ToArray();
                var name = splittedCommand[0];
                var listofDates = splittedCommand.Skip(1).ToList();
                var DatesforAddingtoList = new List<DateTime>();
                foreach (string date in listofDates)
                {         
                    DateTime currentdate = new DateTime();
                    currentdate = DateTime
                        .ParseExact(date, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                    DatesforAddingtoList.Add(currentdate);
                }
                if (allStudentStorageList.Any(x=>x.Name == name))
                {
                    var studentnamewithDate = allStudentStorageList
                        .Single(x=>x.Name==name);
                    studentnamewithDate.Dates.AddRange(DatesforAddingtoList);
                }
                else
                {
                    Student student = new Student();
                    student.Name = name;       
                    student.Comments = new List<string>();
                    student.Dates = DatesforAddingtoList;
                    allStudentStorageList.Add(student);
                }
                command = Console.ReadLine();
            }
            var nextinput = Console.ReadLine();
            while (nextinput != "end of comments")
            {
                var splitted = nextinput.Split('-').ToArray();
                var name = splitted[0];
                var commentsforAdd = splitted[1];
                   
                if (allStudentStorageList.Any(x=>x.Name == name))
                {                   
                    var studentwithComment = allStudentStorageList
                        .First(x => x.Name == name);               
                    studentwithComment.Comments.Add(commentsforAdd);
                }                
                nextinput = Console.ReadLine();
            }            
            foreach (var item in allStudentStorageList.OrderBy(x=>x.Name))
            {
                Console.WriteLine(item.Name);
                Console.WriteLine("Comments:");
                foreach (var comments in item.Comments)
                {                   
                    Console.WriteLine($"- {comments}");
                }
                Console.WriteLine("Dates attended:");
                foreach (var dates in item.Dates.OrderBy(x=>x.Date))
                {                    
                    Console.WriteLine($"-- {dates.ToString("dd/MM/yyyy")}");
                }
            }
        }
    }  
}
