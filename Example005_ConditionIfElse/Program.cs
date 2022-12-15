Console.Write("Enter user name: ");
string username = Console.ReadLine();

if (username.ToLower() == "bob")        // команда .ToLower() переводит все символы в нижний регистр
{
    Console.WriteLine("Oh my God, it's BOB!!!");
}
else
{
    Console.Write("Hello, "); Console.WriteLine(username);
}