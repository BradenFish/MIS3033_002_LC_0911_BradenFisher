// MIS 3033 002
// September 11, 2023
// Braden Fisher, 113492081
using a;
using b;
using System.Data;
using System.Text.Json;

Console.WriteLine("Entity Framework");

StudentDB studb;// complex
studb = new StudentDB();//  we connext to the database

Student stu;// 
stu = new Student() { Id = "s123", Name= "Braden Fisher", Age= 21};
//stu.Name = "Braden Fisher";

//studb.StudentsTB1.Add(stu);// studb.StudentsTB1 in the computer memory
//studb.SaveChanges();

// static
Student stu2;// complex
stu2 = new Student() { Id = "s1", Name = "Tom", Age = 200};
Console.WriteLine(Student.Instructor);

// anonymous class type
var r1 = new { Id = "s2", Name = "Tom" };// r1 is complex variable
Console.WriteLine(r1.Name);

//File JSON
string filePath = "data.txt";
File.WriteAllText(filePath, "200");

// {} []
//{}, one record, one student
//[], collection, has a warehouse, holds many records, can be null(can be empty)
string outMesStr;

var opt = new JsonSerializerOptions();
opt.WriteIndented = true;// memeber 

outMesStr = JsonSerializer.Serialize(stu2, opt);// ctrl . // static
// function overload
Console.WriteLine(outMesStr);
File.WriteAllText(filePath, outMesStr);

// []
var r2 = studb.StudentsTB1.Take(1);// r2 collection
outMesStr = JsonSerializer.Serialize(r2, opt);// ctrl . // static
// function overload
Console.WriteLine(outMesStr);
File.WriteAllText(filePath, outMesStr);

// delegate, lamda expression
// lamda expression: is s way to write a function, shortcut to write a function
// arrow function

int age1;// int datatype, age1: variable
int age2;//

Student stu3;
stu3 = new Student();
//Console.WriteLine(stu3.ToString()); 

bool CheckAge(Student s)
{
    return s.Age == 20;
}

bool CheckID(Student s)
{
    return s.Id == "s123";
}

Console.WriteLine(CheckAge(stu));
Console.WriteLine(CheckID(stu));


