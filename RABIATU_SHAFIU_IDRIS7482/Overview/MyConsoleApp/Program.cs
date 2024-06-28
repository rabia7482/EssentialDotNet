// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int a = 1;
char c = 'A';
float f = 123.45f;
decimal d = 400.85m;
int b = default;
bool tf = default;

Console.WriteLine($"{a}, {b}, {tf}, {c}, {f}, {d}");

string response;
Console.WriteLine("What's your name?");
response = Console.ReadLine();
Console.WriteLine($"Enjoy the course,{response}");

OperatingSystem thisOS = Environment.OSVersion;
Console.WriteLine(thisOS.Platform);
Console.WriteLine(thisOS.VersionString);