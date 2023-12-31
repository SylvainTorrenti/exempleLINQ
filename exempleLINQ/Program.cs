﻿using exempleLINQ;
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
//IList<Student> studentList = new List<Student>() {
//    new Student() { StudentID = 1, StudentName = "John", StandardID =1 },
//    new Student() { StudentID = 2, StudentName = "Moin", StandardID =1 },
//    new Student() { StudentID = 3, StudentName = "Bill", StandardID =2 },
//    new Student() { StudentID = 4, StudentName = "Ram" , StandardID =2 },
//    new Student() { StudentID = 5, StudentName = "Ron"  }
//};

//IList<Standard> standardList = new List<Standard>() {
//    new Standard(){ StandardID = 1, StandardName="Standard 1"},
//    new Standard(){ StandardID = 2, StandardName="Standard 2"},
//    new Standard(){ StandardID = 3, StandardName="Standard 3"}
//};

//var innerJoin = studentList.Join(// outer sequence 
//                      standardList,  // inner sequence 
//                      student => student.StandardID,    // outerKeySelector
//                      standard => standard.StandardID,  // innerKeySelector
//                      (student, standard) => new  // result selector
//                      {
//                          StudentName = student.StudentName,
//                          StandardName = standard.StandardName
//                      });
//foreach (var std in innerJoin)
//{
//    Console.WriteLine(std.StudentName + " - " + std.StandardName);
//}
#endregion
#endregion
#region GroupJoin
//IList<Student> studentList = new List<Student>() {
//    new Student() { StudentID = 1, StudentName = "John", StandardID =1 },
//    new Student() { StudentID = 2, StudentName = "Moin", StandardID =1 },
//    new Student() { StudentID = 3, StudentName = "Bill", StandardID =2 },
//    new Student() { StudentID = 4, StudentName = "Ram",  StandardID =2 },
//    new Student() { StudentID = 5, StudentName = "Ron" }
//};

//IList<Standard> standardList = new List<Standard>() {
//    new Standard(){ StandardID = 1, StandardName="Standard 1"},
//    new Standard(){ StandardID = 2, StandardName="Standard 2"},
//    new Standard(){ StandardID = 3, StandardName="Standard 3"}
//};

//var groupJoin = standardList.GroupJoin(studentList,  //inner sequence
//                                std => std.StandardID, //outerKeySelector 
//                                s => s.StandardID,     //innerKeySelector
//                                (std, studentsGroup) => new // resultSelector 
//                                {
//                                    Students = studentsGroup,
//                                    StandarFulldName = std.StandardName
//                                });

//foreach (var item in groupJoin)
//{
//    Console.WriteLine(item.StandarFulldName);

//    foreach (var stud in item.Students)
//        Console.WriteLine(stud.StudentName);
//} 
#endregion
#region Select
#region Select simple
//IList<Student> studentList = new List<Student>() {
//    new Student() { StudentID = 1, StudentName = "John" },
//    new Student() { StudentID = 2, StudentName = "Moin" },
//    new Student() { StudentID = 3, StudentName = "Bill" },
//    new Student() { StudentID = 4, StudentName = "Ram" },
//    new Student() { StudentID = 5, StudentName = "Ron" }
//};

//var selectResult = from s in studentList
//                   select s.StudentName;
//foreach (var std in selectResult)
//{
//    Console.WriteLine(std);
//} 
#endregion
#region Select plusieurs champs
//IList<Student> studentList = new List<Student>() {
//    new Student() { StudentID = 1, StudentName = "John", Age = 13 } ,
//    new Student() { StudentID = 2, StudentName = "Moin",  Age = 21 } ,
//    new Student() { StudentID = 3, StudentName = "Bill",  Age = 18 } ,
//    new Student() { StudentID = 4, StudentName = "Ram" , Age = 20 } ,
//    new Student() { StudentID = 5, StudentName = "Ron" , Age = 15 }
//};

//// returns collection of anonymous objects with Name and Age property
//var selectResult = from s in studentList
//                    select new { Name = "Mr. " + s.StudentName, Age = s.Age };
//var selectResult = studentList.Select(s => new
//{
//    Name = s.StudentName,
//    Age = s.Age
//});

//// iterate selectResult
//foreach (var item in selectResult)
//    Console.WriteLine("Student Name: {0}, Age: {1}", item.Name, item.Age); 
#endregion
#endregion
#region ALL & ANY
//IList<Student> studentList = new List<Student>() {
//        new Student() { StudentID = 1, StudentName = "John", Age = 18 } ,
//        new Student() { StudentID = 2, StudentName = "Steve",  Age = 15 } ,
//        new Student() { StudentID = 3, StudentName = "Bill",  Age = 25 } ,
//        new Student() { StudentID = 4, StudentName = "Ram" , Age = 20 } ,
//        new Student() { StudentID = 5, StudentName = "Ron" , Age = 19 }
//    };

//// checks whether all the students are teenagers    
//bool areAllStudentsTeenAger = studentList.All(s => s.Age > 12 && s.Age < 20);

//Console.WriteLine(areAllStudentsTeenAger);

//bool isAnyStudentTeenAger = studentList.Any(s => s.Age > 12 && s.Age < 20);

//Console.WriteLine(isAnyStudentTeenAger); 
#endregion
#region Contain
#region Contains primitive data types
//IList<int> intList = new List<int>() { 1, 2, 3, 4, 5 };
//bool result = intList.Contains(10);  // returns false
//Console.WriteLine(result); 
#endregion
#region Contain class
////Il faut créé une class qui implémente IEqualityComparer<T> pour comparer les valeurs et non les references 
//IList<Student> studentList = new List<Student>() {
//        new Student() { StudentID = 1, StudentName = "John", Age = 18 } ,
//        new Student() { StudentID = 2, StudentName = "Steve",  Age = 15 } ,
//        new Student() { StudentID = 3, StudentName = "Bill",  Age = 25 } ,
//        new Student() { StudentID = 4, StudentName = "Ram" , Age = 20 } ,
//        new Student() { StudentID = 5, StudentName = "Ron" , Age = 19 }
//    };

//Student std = new Student() { StudentID = 3, StudentName = "Bill" };
//bool result = studentList.Contains(std, new StudentComparer()); //returns true
//Console.WriteLine(result); 
#endregion
#endregion
#region Aggregate
#region Aggregate simple
//IList<String> strList = new List<String>() { "One", "Two", "Three", "Four", "Five" };

//var commaSeperatedString = strList.Aggregate((s1, s2) => s1 + ", " + s2);

//Console.WriteLine(commaSeperatedString); 
#endregion
#region Aggregate avec seed
//IList<Student> studentList = new List<Student>() {
//        new Student() { StudentID = 1, StudentName = "John", Age = 13 } ,
//        new Student() { StudentID = 2, StudentName = "Moin", Age = 21 } ,
//        new Student() { StudentID = 3, StudentName = "Bill", Age = 18 } ,
//        new Student() { StudentID = 4, StudentName = "Ram", Age = 20 } ,
//        new Student() { StudentID = 5, StudentName = "Ron", Age = 15 }
//    };

//string commaSeparatedStudentNames = studentList.Aggregate<Student, string>(
//                                        "Student Names: ",  // seed value
//                                        (str, s) => str += s.StudentName + ",");

//Console.WriteLine(commaSeparatedStudentNames); 
#endregion
#region Aggregate avec Result Selector
//IList<Student> studentList = new List<Student>() {
//        new Student() { StudentID = 1, StudentName = "John", Age = 13 } ,
//        new Student() { StudentID = 2, StudentName = "Moin", Age = 21 } ,
//        new Student() { StudentID = 3, StudentName = "Bill", Age = 18 } ,
//        new Student() { StudentID = 4, StudentName = "Ram", Age = 20 } ,
//        new Student() { StudentID = 5, StudentName = "Ron", Age = 15 }
//    };

//string commaSeparatedStudentNames = studentList.Aggregate<Student, string, string>(
//                                            String.Empty, // seed value
//                                            (str, s) => str += s.StudentName + ",", // returns result using seed value, String.Empty goes to lambda expression as str
//                                            str => str.Substring(0, str.Length - 1)); // result selector that removes last comma

//Console.WriteLine(commaSeparatedStudentNames); 
#endregion
#endregion
#region Average
//IList<int> intList = new List<int>() { 10, 20, 30 };

//var avg = intList.Average();

//Console.WriteLine("Average: {0}", avg);
//IList<Student> studentList = new List<Student>() {
//        new Student() { StudentID = 1, StudentName = "John", Age = 13 } ,
//        new Student() { StudentID = 2, StudentName = "Moin", Age = 21 } ,
//        new Student() { StudentID = 3, StudentName = "Bill", Age = 18 } ,
//        new Student() { StudentID = 4, StudentName = "Ram", Age = 20 } ,
//        new Student() { StudentID = 5, StudentName = "Ron", Age = 15 }
//    };

//var avgAge = studentList.Average(s => s.Age);

//Console.WriteLine("Average Age of Student: {0}", avgAge); 
#endregion
#region Count
#region Count simple
//IList<int> intList = new List<int>() { 10, 21, 30, 45, 50 };

//var totalElements = intList.Count();

//Console.WriteLine("Total Elements: {0}", totalElements);

//var evenElements = intList.Count(i => i % 2 == 0);

//Console.WriteLine("Even Elements: {0}", evenElements); 
#endregion
#region Count complex type collection
//IList<Student> studentList = new List<Student>() {
//        new Student() { StudentID = 1, StudentName = "John", Age = 13 } ,
//        new Student() { StudentID = 2, StudentName = "Moin", Age = 21 } ,
//        new Student() { StudentID = 3, StudentName = "Bill", Age = 18 } ,
//        new Student() { StudentID = 4, StudentName = "Ram", Age = 20 } ,
//        new Student() { StudentID = 5, StudentName = "Mathew", Age = 15 }
//    };

//var totalStudents = studentList.Count();

//Console.WriteLine("Total Students: {0}", totalStudents);

//var adultStudents = studentList.Count(s => s.Age >= 18);

//Console.WriteLine("Number of Adult Students: {0}", adultStudents);
#endregion
#endregion
#region Max
#region Max simple
//IList<int> intList = new List<int>() { 10, 21, 30, 45, 50, 87 };

//var largest = intList.Max();

//Console.WriteLine("Largest Element: {0}", largest);

//var largestEvenElements = intList.Max(i => {
//    if (i % 2 == 0)
//        return i;

//    return 0;
//});

//Console.WriteLine("Largest Even Element: {0}", largestEvenElements); 
#endregion
#region Max complex type collection
//IList<Student> studentList = new List<Student>() {
//        new Student() { StudentID = 1, StudentName = "John", Age = 13 } ,
//        new Student() { StudentID = 2, StudentName = "Moin", Age = 21 } ,
//        new Student() { StudentID = 3, StudentName = "Bill", Age = 18 } ,
//        new Student() { StudentID = 4, StudentName = "Ram", Age = 20 } ,
//        new Student() { StudentID = 5, StudentName = "Ron", Age = 15 }
//    };

//var oldest = studentList.Max(s => s.Age);

//Console.WriteLine("Oldest Student Age: {0}", oldest); 
#endregion
#region Max student with more long name
//// Student collection
//IList<Student> studentList = new List<Student>() {
//                new Student() { StudentID = 1, StudentName = "John", Age = 13 } ,
//                new Student() { StudentID = 2, StudentName = "Moin", Age = 21 } ,
//                new Student() { StudentID = 3, StudentName = "Bill", Age = 18 } ,
//                new Student() { StudentID = 4, StudentName = "Ram", Age = 20 } ,
//                new Student() { StudentID = 5, StudentName = "Steve", Age = 15 }
//            };

//var studentWithLongName = studentList.Max();

//Console.WriteLine("Student ID: {0}, Student Name: {1}", studentWithLongName.StudentID, studentWithLongName.StudentName); 
#endregion
#endregion
#region Sum
#region Sum simple
//IList<int> intList = new List<int>() { 10, 21, 30, 45, 50, 87 };

//var total = intList.Sum();

//Console.WriteLine("Sum: {0}", total);

//var sumOfEvenElements = intList.Sum(i =>
//{
//    if (i % 2 == 0)
//        return i;

//    return 0;
//});

//Console.WriteLine("Sum of Even Elements: {0}", sumOfEvenElements);
#endregion
#region Sum complex type collection
//IList<Student> studentList = new List<Student>() {
//        new Student() { StudentID = 1, StudentName = "John", Age = 13 } ,
//        new Student() { StudentID = 2, StudentName = "Moin", Age = 21 } ,
//        new Student() { StudentID = 3, StudentName = "Bill", Age = 18 } ,
//        new Student() { StudentID = 4, StudentName = "Ram", Age = 20 } ,
//        new Student() { StudentID = 5, StudentName = "Ron", Age = 15 }
//    };

//var sumOfAge = studentList.Sum(s => s.Age);

//Console.WriteLine("Sum of all student's age: {0}", sumOfAge);

//var numOfAdults = studentList.Sum(s =>
//{

//    if (s.Age >= 18)
//        return 1;
//    else
//        return 0;
//});

//Console.WriteLine("Total Adult Students: {0}", numOfAdults);
#endregion
#endregion
#region ElementAt & ElementAtOrDefault
//IList<int> intList = new List<int>() { 10, 21, 30, 45, 50, 87 };
//IList<string> strList = new List<string>() { "One", "Two", null, "Four", "Five" };

//Console.WriteLine("1st Element in intList: {0}", intList.ElementAt(0));
//Console.WriteLine("1st Element in strList: {0}", strList.ElementAt(0));

//Console.WriteLine("2nd Element in intList: {0}", intList.ElementAt(1));
//Console.WriteLine("2nd Element in strList: {0}", strList.ElementAt(1));

//Console.WriteLine("3rd Element in intList: {0}", intList.ElementAtOrDefault(2));
//Console.WriteLine("3rd Element in strList: {0}", strList.ElementAtOrDefault(2));

//Console.WriteLine("10th Element in intList: {0} - default int value",
//                intList.ElementAtOrDefault(9));
//Console.WriteLine("10th Element in strList: {0} - default string value (null)",
//                 strList.ElementAtOrDefault(9));
#endregion
#region First & FirstOrDefault
#region First
//IList<int> intList = new List<int>() { 3, 4, 7, 10, 21, 30, 45, 50, 87 };
//IList<string> strList = new List<string>() { null, "Two", "Three", "Four", "Five" };

//Console.WriteLine("1st Element in intList: {0}", intList.First());
//Console.WriteLine("1st Even Element in intList: {0}", intList.First(i => i % 2 == 0));

//Console.WriteLine("1st Element in strList: {0}", strList.First()); 
#endregion
#region FirstOrDefault
//IList<int> intList = new List<int>() { 7, 10, 21, 30, 45, 50, 87 };
//IList<string> strList = new List<string>() { null, "Two", "Three", "Four", "Five" };
//IList<string> emptyList = new List<string>();

//Console.WriteLine("1st Element in intList: {0}", intList.FirstOrDefault());
//Console.WriteLine("1st Even Element in intList: {0}",
//                                 intList.FirstOrDefault(i => i % 2 == 0));

//Console.WriteLine("1st Element in strList: {0}", strList.FirstOrDefault());

//Console.WriteLine("1st Element in emptyList: {0}", emptyList.FirstOrDefault()); 
#endregion
#endregion
#region Last & LastOrDefault
#region Last
//IList<int> intList = new List<int>() { 7, 10, 21, 30, 45, 50, 87 };
//IList<string> strList = new List<string>() { null, "Two", "Three", "Four", "Five" };

//Console.WriteLine("Last Element in intList: {0}", intList.Last());

//Console.WriteLine("Last Even Element in intList: {0}", intList.Last(i => i % 2 == 0));

//Console.WriteLine("Last Element in strList: {0}", strList.Last()); 
#endregion
#region LastOrDefault
//List<int> intList = new List<int>() { 7, 10, 21, 30, 45, 50, 87 };
//IList<string> strList = new List<string>() { null, "Two", "Three", "Four", "Five" };
//IList<string> emptyList = new List<string>();

//Console.WriteLine("Last Element in intList: {0}", intList.LastOrDefault());

//Console.WriteLine("Last Even Element in intList: {0}",
//                                 intList.LastOrDefault(i => i % 2 == 0));

//Console.WriteLine("Last Element in strList: {0}", strList.LastOrDefault());

//Console.WriteLine("Last Element in emptyList: {0}", emptyList.LastOrDefault()); 
#endregion
#endregion
#region Single & SingleOrDefault
//IList<int> oneElementList = new List<int>() { 7 };
//IList<int> intList = new List<int>() { 7, 10, 21, 30, 45, 50, 87 };
//IList<string> strList = new List<string>() { null, "Two", "Three", "Four", "Five" };
//IList<string> emptyList = new List<string>();

//Console.WriteLine("The only element in oneElementList: {0}", oneElementList.Single());
//Console.WriteLine("The only element in oneElementList: {0}",
//             oneElementList.SingleOrDefault());

//Console.WriteLine("Element in emptyList: {0}", emptyList.SingleOrDefault());

//Console.WriteLine("The only element which is less than 10 in intList: {0}",
//             intList.Single(i => i < 10)); 
#endregion
#region SequenceEqual
#region SequenceEqual primitive data type
//IList<string> strList1 = new List<string>() { "One", "Two", "Three", "Four", "Three" };

//IList<string> strList2 = new List<string>() { "One", "Two", "Three", "Four", "Three" };

//bool isEqual = strList1.SequenceEqual(strList2); // returns true
//Console.WriteLine(isEqual); 
//IList<string> strList1 = new List<string>() { "One", "Two", "Three", "Four", "Three" };

//IList<string> strList2 = new List<string>() { "Two", "One", "Three", "Four", "Three" };

//bool isEqual = strList1.SequenceEqual(strList2); // returns false
//Console.WriteLine(isEqual);
#endregion
#region SequenceEqual class without IComparable
//Student std = new Student() { StudentID = 1, StudentName = "Bill" };

//IList<Student> studentList1 = new List<Student>() { std };

//IList<Student> studentList2 = new List<Student>() { std };

//bool isEqual = studentList1.SequenceEqual(studentList2); // returns true
//Console.WriteLine(isEqual);

//Student std1 = new Student() { StudentID = 1, StudentName = "Bill" };
//Student std2 = new Student() { StudentID = 1, StudentName = "Bill" };

//IList<Student> studentList3 = new List<Student>() { std1 };

//IList<Student> studentList4 = new List<Student>() { std2 };

//isEqual = studentList3.SequenceEqual(studentList4);// returns false
//Console.WriteLine(isEqual); 
#endregion
#region SequenceEqual class with IComparable
//IList<Student> studentList1 = new List<Student>() {
//        new Student() { StudentID = 1, StudentName = "John", Age = 18 } ,
//        new Student() { StudentID = 2, StudentName = "Steve",  Age = 15 } ,
//        new Student() { StudentID = 3, StudentName = "Bill",  Age = 25 } ,
//        new Student() { StudentID = 4, StudentName = "Ram" , Age = 20 } ,
//        new Student() { StudentID = 5, StudentName = "Ron" , Age = 19 }
//    };

//IList<Student> studentList2 = new List<Student>() {
//        new Student() { StudentID = 1, StudentName = "John", Age = 18 } ,
//        new Student() { StudentID = 2, StudentName = "Steve",  Age = 15 } ,
//        new Student() { StudentID = 3, StudentName = "Bill",  Age = 25 } ,
//        new Student() { StudentID = 4, StudentName = "Ram" , Age = 20 } ,
//        new Student() { StudentID = 5, StudentName = "Ron" , Age = 19 }
//    };
//// following returns true
//bool isEqual = studentList1.SequenceEqual(studentList2, new StudentComparer());
//Console.WriteLine(isEqual); 
#endregion
#endregion
#region Concat
//IList<string> collection1 = new List<string>() { "One", "Two", "Three" };
//IList<string> collection2 = new List<string>() { "Five", "Six" };

//var collection3 = collection1.Concat(collection2);

//foreach (string str in collection3)
//    Console.WriteLine(str);
//IList<int> collection4 = new List<int>() { 1, 2, 3 };
//IList<int> collection5 = new List<int>() { 4, 5, 6 };

//var collection6 = collection4.Concat(collection5);

//foreach (int i in collection6)
//    Console.WriteLine(i); 
#endregion
#region DefaultIfEmpty
//IList<string> emptyList = new List<string>();

//var newList1 = emptyList.DefaultIfEmpty();
//var newList2 = emptyList.DefaultIfEmpty("None");

//Console.WriteLine("Count: {0}", newList1.Count());
//Console.WriteLine("Value: {0}", newList1.ElementAt(0));

//Console.WriteLine("Count: {0}", newList2.Count());
//Console.WriteLine("Value: {0}", newList2.ElementAt(0)); 
#endregion
#region Empty & Range & Repeat
#region Empty
//var emptyCollection1 = Enumerable.Empty<string>();
//var emptyCollection2 = Enumerable.Empty<Student>();

//Console.WriteLine("Count: {0} ", emptyCollection1.Count());
//Console.WriteLine("Type: {0} ", emptyCollection1.GetType().Name);

//Console.WriteLine("Count: {0} ", emptyCollection2.Count());
//Console.WriteLine("Type: {0} ", emptyCollection2.GetType().Name); 
#endregion
#region Range
//var intCollection = Enumerable.Range(10, 10);
//Console.WriteLine("Total Count: {0} ", intCollection.Count());

//for (int i = 0; i < intCollection.Count(); i++)
//    Console.WriteLine("Value at index {0} : {1}", i, intCollection.ElementAt(i)); 
#endregion
#region Repeat
//var intCollection = Enumerable.Repeat<int>(10, 10);
//Console.WriteLine("Total Count: {0} ", intCollection.Count());

//for (int i = 0; i < intCollection.Count(); i++)
//    Console.WriteLine("Value at index {0} : {1}", i, intCollection.ElementAt(i)); 
#endregion
#endregion
#region Distinct
//IList<string> strList = new List<string>() { "One", "Two", "Three", "Two", "Three" };

//IList<int> intList = new List<int>() { 1, 2, 3, 2, 4, 4, 3, 5 };

//var distinctList1 = strList.Distinct();

//foreach (var str in distinctList1)
//    Console.WriteLine(str);

//var distinctList2 = intList.Distinct();

//foreach (var i in distinctList2)
//    Console.WriteLine(i); 
#endregion
#region Except
//IList<string> strList1 = new List<string>() { "One", "Two", "Three", "Four", "Five" };
//IList<string> strList2 = new List<string>() { "Four", "Five", "Six", "Seven", "Eight" };

//var result = strList1.Except(strList2);

//foreach (string str in result)
//    Console.WriteLine(str); 
#endregion
#region Intersect
//IList<string> strList1 = new List<string>() { "One", "Two", "Three", "Four", "Five" };
//IList<string> strList2 = new List<string>() { "Four", "Five", "Six", "Seven", "Eight" };

//var result = strList1.Intersect(strList2);

//foreach (string str in result)
//    Console.WriteLine(str); 
#endregion
#region Union
//IList<string> strList1 = new List<string>() { "One", "Two", "three", "Four" };
//IList<string> strList2 = new List<string>() { "Two", "THREE", "Four", "Five" };

//var result = strList1.Union(strList2);

//foreach (string str in result)
//    Console.WriteLine(str); 
#endregion
#region Skip & SkipWhile
#region Skip
//IList<string> strList = new List<string>() { "One", "Two", "Three", "Four", "Five" };

//var newList = strList.Skip(2);

//foreach (var str in newList)
//    Console.WriteLine(str); 
#endregion
#region SkipWhile
//IList<string> strList = new List<string>() {
//                                            "One",
//                                            "Two",
//                                            "Three",
//                                            "Four",
//                                            "Five",
//                                            "Six"  };

//var resultList = strList.SkipWhile(s => s.Length < 4);

//foreach (string str in resultList)
//    Console.WriteLine(str); 
#endregion
#endregion
#region Take & TakeWhile
#region Take
//IList<string> strList = new List<string>() { "One", "Two", "Three", "Four", "Five" };

//var newList = strList.Take(2);

//foreach (var str in newList)
//    Console.WriteLine(str); 
#endregion
#region TakeWhile
//IList<string> strList = new List<string>() {
//                                            "Three",
//                                            "Four",
//                                            "Five",
//                                            "Hundred"  };

//var result = strList.TakeWhile(s => s.Length > 4);

//foreach (string str in result)
//    Console.WriteLine(str); 
#endregion 
#endregion