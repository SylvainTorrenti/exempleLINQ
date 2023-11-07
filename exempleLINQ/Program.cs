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
#region OrderBy
#region OrderBy 1
//IList<Student> studentList = new List<Student>() {
//    new Student() { StudentID = 1, StudentName = "John", Age = 18 } ,
//    new Student() { StudentID = 2, StudentName = "Steve",  Age = 15 } ,
//    new Student() { StudentID = 3, StudentName = "Bill",  Age = 25 } ,
//    new Student() { StudentID = 4, StudentName = "Ram" , Age = 20 } ,
//    new Student() { StudentID = 5, StudentName = "Ron" , Age = 19 }
//};
////////////////// Synthaxe 1 \\\\\\\\\\\\\\\\
//var orderByResult = from s in studentList
//                    orderby s.StudentName
//                    select s;
////////////////// Synthaxe 2 \\\\\\\\\\\\\\\\
//var orderByResult = studentList.OrderBy(s => s.StudentName);
//foreach (Student std in orderByResult)
//{
//    Console.WriteLine(std.StudentName);
//}
//Console.WriteLine("--------------------");
////////////////// Synthaxe 1 \\\\\\\\\\\\\\\\
//var orderByDescendingResult = from s in studentList
//                              orderby s.StudentName descending
//                              select s;
////////////////// Synthaxe 2 \\\\\\\\\\\\\\\\
//var orderByDescendingResult = studentList.OrderByDescending(s => s.StudentName);
//foreach (Student std in orderByDescendingResult)
//{
//    Console.WriteLine(std.StudentName);
//} 
#endregion
#region OrderBy 2
//IList<Student> studentList = new List<Student>() {
//    new Student() { StudentID = 1, StudentName = "John", Age = 18 } ,
//    new Student() { StudentID = 2, StudentName = "Steve",  Age = 15 } ,
//    new Student() { StudentID = 3, StudentName = "Bill",  Age = 25 } ,
//    new Student() { StudentID = 4, StudentName = "Ram" , Age = 20 } ,
//    new Student() { StudentID = 5, StudentName = "Ron" , Age = 19 },
//    new Student() { StudentID = 6, StudentName = "Ram" , Age = 18 }
//};

//var orderByResult = from s in studentList
//                    orderby s.StudentName, s.Age
//                    select new { s.StudentName, s.Age };
//foreach (var std in orderByResult)
//{
//    Console.WriteLine(std.StudentName + "," + std.Age);
//} 
#endregion
#endregion
#region ThenBy
//IList<Student> studentList = new List<Student>() {
//    new Student() { StudentID = 1, StudentName = "John", Age = 18 } ,
//    new Student() { StudentID = 2, StudentName = "Steve",  Age = 15 } ,
//    new Student() { StudentID = 3, StudentName = "Bill",  Age = 25 } ,
//    new Student() { StudentID = 4, StudentName = "Ram" , Age = 20 } ,
//    new Student() { StudentID = 5, StudentName = "Ron" , Age = 19 },
//    new Student() { StudentID = 6, StudentName = "Ram" , Age = 18 }
//};
//var thenByResult = studentList.OrderBy(s => s.StudentName).ThenBy(s => s.Age);
//foreach (var std in thenByResult)
//{
//    Console.WriteLine("Nom : " + std.StudentName + ", Age : " + std.Age);
//}
//Console.WriteLine("----------------------");
//var thenByDescResult = studentList.OrderBy(s => s.StudentName).ThenByDescending(s => s.Age);
//foreach (var std in thenByDescResult)
//{
//    Console.WriteLine("Nom : " + std.StudentName + ", Age : " + std.Age);
//} 
#endregion
#region GroupBy & ToLookup
#region GroupBy
//IList<Student> studentList = new List<Student>() {
//        new Student() { StudentID = 1, StudentName = "John", Age = 18 } ,
//        new Student() { StudentID = 2, StudentName = "Steve",  Age = 21 } ,
//        new Student() { StudentID = 3, StudentName = "Bill",  Age = 18 } ,
//        new Student() { StudentID = 4, StudentName = "Ram" , Age = 20 } ,
//        new Student() { StudentID = 5, StudentName = "Abram" , Age = 21 }
//    };
////////////////// Synthaxe 1 \\\\\\\\\\\\\\\\
//var groupedResult = from s in studentList
//                    group s by s.Age;
////////////////// Synthaxe 2 \\\\\\\\\\\\\\\\
//var groupedResult = studentList.GroupBy(s => s.Age);
////iterate each group        
//foreach (var ageGroup in groupedResult)
//{
//    Console.WriteLine("Age Group: {0}", ageGroup.Key); //Each group has a key 

//    foreach (Student s in ageGroup) // Each group has inner collection
//        Console.WriteLine("Student Name: {0}", s.StudentName);
//}
#endregion
#region ToLookup
//IList<Student> studentList = new List<Student>() {
//        new Student() { StudentID = 1, StudentName = "John", Age = 18 } ,
//        new Student() { StudentID = 2, StudentName = "Steve",  Age = 21 } ,
//        new Student() { StudentID = 3, StudentName = "Bill",  Age = 18 } ,
//        new Student() { StudentID = 4, StudentName = "Ram" , Age = 20 } ,
//        new Student() { StudentID = 5, StudentName = "Abram" , Age = 21 }
//    };

//var lookupResult = studentList.ToLookup(s => s.Age);

//foreach (var group in lookupResult)
//{
//    Console.WriteLine("Age Group: {0}", group.Key);  //Each group has a key 

//    foreach (Student s in group)  //Each group has a inner collection  
//        Console.WriteLine("Student Name: {0}", s.StudentName);
//} 
#endregion
#endregion
#region Join
#region Join string
//IList<string> strList1 = new List<string>() {
//    "One",
//    "Two",
//    "Three",
//    "Four"
//};

//IList<string> strList2 = new List<string>() {
//    "One",
//    "Two",
//    "Five",
//    "Six"
//};

//var innerJoin = strList1.Join(strList2,
//                      str1 => str1,
//                      str2 => str2,
//                      (str1, str2) => str1);

//foreach (var str in innerJoin)
//{
//    Console.WriteLine(str);
//}
#endregion
#region Join class
IList<Student> studentList = new List<Student>() {
    new Student() { StudentID = 1, StudentName = "John", StandardID =1 },
    new Student() { StudentID = 2, StudentName = "Moin", StandardID =1 },
    new Student() { StudentID = 3, StudentName = "Bill", StandardID =2 },
    new Student() { StudentID = 4, StudentName = "Ram" , StandardID =2 },
    new Student() { StudentID = 5, StudentName = "Ron"  }
};

IList<Standard> standardList = new List<Standard>() {
    new Standard(){ StandardID = 1, StandardName="Standard 1"},
    new Standard(){ StandardID = 2, StandardName="Standard 2"},
    new Standard(){ StandardID = 3, StandardName="Standard 3"}
};

var innerJoin = studentList.Join(// outer sequence 
                      standardList,  // inner sequence 
                      student => student.StandardID,    // outerKeySelector
                      standard => standard.StandardID,  // innerKeySelector
                      (student, standard) => new  // result selector
                      {
                          StudentName = student.StudentName,
                          StandardName = standard.StandardName
                      });
foreach (var std in innerJoin)
{
    Console.WriteLine(std.StudentName + " - " + std.StandardName);
}
#endregion 
#endregion

