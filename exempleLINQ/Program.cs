using exempleLINQ;
using System.Collections;

#region WHERE
#region Creation student
//IList<Student> studentList = new List<Student>(){
//        new Student() { StudentID = 1, StudentName = "John", Age = 13} ,
//        new Student() { StudentID = 2, StudentName = "Moin",  Age = 21 } ,
//        new Student() { StudentID = 3, StudentName = "Bill",  Age = 18 } ,
//        new Student() { StudentID = 4, StudentName = "Ram" , Age = 20} ,
//        new Student() { StudentID = 5, StudentName = "Ron" , Age = 15 }
//    };
#endregion
#region where sur prop
//var filteredResult = from s in studentList 
//                     where s.StudentName.Contains("R") && s.StudentName.Contains("a")
//                     select s;

//foreach (Student std in filteredResult)
//{
//    Console.WriteLine(std.StudentName);
//}
////////////////Autre méthode même résultat\\\\\\\\\\\\\\\\\\\\\\
//var filteredResult = studentList.Where(s => s.Age > 12 && s.Age < 20);
//foreach (Student std in filteredResult)
//{
//    Console.WriteLine(std.StudentName);
//}

#endregion
#region where avec fonction
//static bool IsTeenager(Student std)
//{
//    return std.Age > 12 && std.Age < 20;
//}

//var teenager = from s in studentList
//               where IsTeenager(s)
//               select s;

//foreach (Student std in teenager)
//{
//    Console.WriteLine(std.StudentName);
//} 
#endregion
#endregion
#region OfType
//IList mixedList = new ArrayList
//{
//    0,
//    "One",
//    "Two",
//    3,
//    new Student() { StudentID = 1, StudentName = "Bill" }
//};
////////////////// Synthaxe 1 \\\\\\\\\\\\\\\\
//var stringResult = from s in mixedList.OfType<string>()
//                   select s;
////////////////// Synthaxe 2 \\\\\\\\\\\\\\\\
//var stringResult = mixedList.OfType<string>();
//foreach (String str in stringResult)
//{
//    Console.WriteLine(str);
//}
//Console.WriteLine("-------------------------");
////////////////// Synthaxe 1 \\\\\\\\\\\\\\\\
//var intResult = from s in mixedList.OfType<int>()
//                select s;
////////////////// Synthaxe 2 \\\\\\\\\\\\\\\\
//var intResult = mixedList.OfType<int>();
//foreach (int nb in intResult)
//{
//    Console.WriteLine(nb);
//}
//Console.WriteLine("-------------------------");
////////////////// Synthaxe 1 \\\\\\\\\\\\\\\\
//var studentResult = from s in mixedList.OfType<Student>()
//                    select s;
////////////////// Synthaxe 2 \\\\\\\\\\\\\\\\
//var studentResult = mixedList.OfType<Student>();
//foreach (Student std in studentResult)
//{
//    Console.WriteLine(std.StudentName);
//} 
#endregion
