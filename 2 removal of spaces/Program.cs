// See https://aka.ms/new-console-template for more information
using System.Text;
StringBuilder events = new StringBuilder();
Console.WriteLine("Input number of events(number):");
int number_events = int.Parse(Console.ReadLine());
//events.AppendLine("Table of events");
int index_events = 1;
for (int i = 0; i < number_events; i++)
{
    Console.WriteLine($"Input {i+1} event");
    string some_event = Console.ReadLine();
    string time_when_event_happened = DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss");
    events.AppendLine($"Event {i+1}: {some_event}. Time: {time_when_event_happened}");
    index_events++;
}
Console.WriteLine("Table of events");
Console.WriteLine(events.ToString());