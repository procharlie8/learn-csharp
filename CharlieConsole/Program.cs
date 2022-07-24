// Variable - a place to store a value

// Method - a place where code exists and is stored
// void - a method that does not return anything - just runs some code

// Class - an object to store Variables and Methods (also other Classes)

// types of variables
// string - think of as some text
// integer - think of as a number

string welcomeText = "Welcome to Charlie's console app";
// This is a method called "WriteLine" that is part of the the class "Console"
Console.WriteLine(welcomeText);

string nameAsk = "Please enter your name";
Console.WriteLine(nameAsk);

string username = Console.ReadLine();

Console.WriteLine("Hello " + username);