
using a;
using b;
using System.Text.Json;

Console.WriteLine("Sep 13, student db");
// db manipulation => LINQ (Collection extension functions)=> need to know LAMDA expression=> Delegate
// lamda expression, arrow function=> function, short wau to write a function

// assignment(accumulator assignment)
// how to define functions
// simple vs complex

StudentDB db;// 
db = new StudentDB();

string filePath = "data.txt";

var opt = new JsonSerializerOptions();
opt.WriteIndented = true;

string jsonStr;

// collection extension functions
var r1 = db.StudentsTB1.Take(3).FirstOrDefault();// Student

//var r3 = db.StudentsTB1.Min(x => x.Age);// ctrl d to copy a line
var r3 = db.StudentsTB1.ToList().MinBy(x => x.Age);// ctrl d to copy a line

jsonStr = JsonSerializer.Serialize(r3, opt);
File.WriteAllText(filePath, jsonStr);

bool r2;
r2 = CheckAge(r1);
Console.WriteLine(r2);

r2 = CheckID(r1);
Console.WriteLine(r2);

FunType1 funCard1;//complex
funCard1 = CheckAge;

r2 = funCard1(r1);
Console.WriteLine(r2);

funCard1 = CheckID;
r2 = funCard1(r1);
Console.WriteLine(r2);

FunType1 funCard2;// complex, null
funCard2 = (Student x) => { return x.Name.ToLower()=="david"; };// arrow function, anonymous function

funCard2 = (x) => { return x.Name.ToLower() == "david"; };// arrow function, anonymous function


funCard2 = x => { return x.Name.ToLower() == "david"; };// arrow function, anonymous function


funCard2 = (x) => x.Name.ToLower() == "david";// arrow function, anonymous function

funCard2 = (x) => x.Age == 19;// arrow function, anonymous function

r2 = funCard2(r1);
Console.WriteLine(r2);




// the above code is for database manipulation
//the below code is function definition

bool CheckAge(Student s)
{
    return s.Age == 20;
}

bool CheckID(Student s)
{
    return s.Id.ToLower() == "s123";
}

// delegate to define a function type
delegate bool FunType1(Student x);// FunType1 Car, Complex