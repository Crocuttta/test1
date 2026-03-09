// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, I am Olga");
//Console.WriteLine("Hello, I am Staa");
//Console.WriteLine("Hello, I am Olga");
//Console.WriteLine("Hello, I am Olga");




//var cond1 = true;
//var cond2 = false;
//var cond3 = cond1 && true; //true
//var cond4 = cond2 || cond3; //true
//var cond5 = !cond4; //false
//var cond6 = cond5 && cond4 || !cond2;
//false && true || true

//Console.WriteLine(cond5);
//Console.WriteLine(cond6);




Console.WriteLine("What is your name?");
var userName = Console.ReadLine();

Console.WriteLine("When you was born?");
string yearOfBirthdayStr = Console.ReadLine();
var yearOfBirthday = int.Parse(yearOfBirthdayStr);

var currentYear = DateTime.Now.Year; 
var age = currentYear - yearOfBirthday;

if (age < 3)
{
    Console.WriteLine("You are Lier");
}



Console.WriteLine($"Hi {userName}, cool you are {age} is old");





