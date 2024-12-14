// See https://aka.ms/new-console-template for more information
Console.WriteLine("Input a sentence:");
string sentence = Console.ReadLine();
string new_sentence = sentence.Replace(" ", "");
Console.WriteLine($"New sentence (without spaces) \n{new_sentence}");
