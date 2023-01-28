//This is a comment to my code

//rakendus küsib kasutajal sisestada oma nime
//rakendus tervitab kasutajat nimepidi

Console.WriteLine("Enter your name:"); //Output
//String - sõne
String userName = Console.ReadLine(); //Input

Console.WriteLine("Hello" + ", " + userName + "!"); //Output

//String interpolation
Console.WriteLine($"Hello, {userName} !"); //Output