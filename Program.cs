// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string test = "primo";

if (test == "primo")
    Console.WriteLine("hai scritto primo");
else if (test == "secondo")
    Console.WriteLine("hai scritto secondo");
else
    Console.WriteLine($"ha scritto {test}");


switch (test)
{
    case "primo":
        Console.WriteLine("hai scritto primo switch");
        break;
    case "secondo":
        Console.WriteLine("hai scritto secondo switch");
        break;
    default:
        Console.WriteLine($"ha scritto {test} switch");
        break;
}
