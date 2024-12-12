// See https://aka.ms/new-console-template for more information

// scivo una parola a caso nel terminale
Console.Write("Scrivi qualcosa: ");

//ReadLine Legge ciò che l'utente digita e ne prende il valore
string test = Console.ReadLine();

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
