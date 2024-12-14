// See https://aka.ms/new-console-template for more information
Console.WriteLine("Input your furname and your name:");
string? furname_and_name = Console.ReadLine();
string[] parts = furname_and_name.Split(' ',StringSplitOptions.RemoveEmptyEntries);
if (parts.Length != 2)
{
    Console.WriteLine("Error: there was an error while driving");
    return;
}
string furname = parts[0];
string name = parts[1];
if (char.ToLower(furname[0]) == char.ToLower(name[0]))
{
    Console.WriteLine("The surname begins with the same letter as the first name");
}
else
{
    Console.WriteLine("The last name does not start with the same letter as the first name");
}