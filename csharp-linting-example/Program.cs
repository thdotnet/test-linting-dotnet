using System;
using System.Collections.Generic;
namespace SampleApp
{
class Program {
static void Main(string[] args)
{
List<string> names = new List<string>(){"John","Jane","Doe"};
foreach(var name in names) {Console.WriteLine(name);}
Console.ReadKey();
}
}
}
