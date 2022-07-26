// Variable - a place to store a value

// Method - a place where code exists and is stored
// void - a method that does not return anything - just runs some code

// Class - an object to store Variables and Methods (also other Classes)

// types of variables
// string - think of as some text
// string name = "Charlie";
// integer - think of as a number
// int charlieAge = 9;
// boolean - can only have the value true or false (a bit like an on/off switch)
// bool isDadStinky = false;

// if statement - is a way to check if something is true or false
// the code inside the curly brackets an if statement only runs if the value inside the brackets is true
// if (true)
// {
//     string stinkys = "You have entered a number";
//     Console.WriteLine(stinkys);
// }

string welcomeText = "Welcome to Charlie's console app";
// This is a method called "WriteLine" that is part of the the class "Console"
Console.WriteLine(welcomeText);

string askName = "Please enter your name";
Console.WriteLine(askName);

string username = Console.ReadLine();
Console.WriteLine("Hello " + username);

string askAge = "How old are you?";
Console.WriteLine(askAge);

string age = Console.ReadLine();
Console.WriteLine("You entered your age as " + age);

// method to convert a string to an integer
int number;
bool isNumber = int.TryParse(age, out number);

while (isNumber == false)
{
    Console.WriteLine("That is not a number, please try again");
    Console.WriteLine("How old are you?");
    string ageRetry = Console.ReadLine();
    Console.WriteLine("You entered your age as " + ageRetry);
    isNumber = int.TryParse(ageRetry, out number);
}