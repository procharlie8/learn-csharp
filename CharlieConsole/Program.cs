// Variable - a place to store a value

// Method - a place where code exists and is stored
// void - a method that does not return anything - just runs some code

// Class - an object to store Variables and Methods (also other Classes)

// types of variables
// string - think of as some text
// integer - think of as a number
// int charlieAge = 9;

// string welcomeText = "Welcome to Charlie's console app";
// This is a method called "WriteLine" that is part of the the class "Console"
// Console.WriteLine(welcomeText);

// string askName = "Please enter your name";
// Console.WriteLine(askName);

// string username = Console.ReadLine();
// Console.WriteLine("Hello " + username);

// string askAge = "How old are you?";
// Console.WriteLine(askAge);

// string age = Console.ReadLine();
// Console.WriteLine("You entered your age as " + age);


// method to convert a string to an integer
int number;
int.TryParse("9876", out number);
Console.WriteLine(number);