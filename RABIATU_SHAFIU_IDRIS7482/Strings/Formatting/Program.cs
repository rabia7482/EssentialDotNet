﻿// Application Programming .NET Programming with C# by Abdullahi Tijjani
// Example file for formatting string content

float f1 = 123.4f;
int i1 = 2000;

// TODO: Spacing and Alignment: Indexes
Console.WriteLine("{0,-15}{1,10}","Float val","Int Val");
Console.WriteLine("{0,-15}{1,10}",f1,i1);

// TODO: Spacing and Alignment: Interpolation
Console.WriteLine($"{f1,-15}{i1,10}");
