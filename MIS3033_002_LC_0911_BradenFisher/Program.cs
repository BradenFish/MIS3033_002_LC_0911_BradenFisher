// MIS 3033 002
// September 11, 2023
// Braden Fisher, 113492081
using a;
using b;

Console.WriteLine("Entity Framework");

StudentDB studb;// complex
studb = new StudentDB();//  we connext to the database

Student stu;
stu = new Student() { Id = "s123", Name= "Braden Fisher", Age= 21};
//stu.Name = "Braden Fisher";

studb.StudentsTB1.Add(stu);// studb.StudentsTB1 in the computer memory
studb.SaveChanges();
