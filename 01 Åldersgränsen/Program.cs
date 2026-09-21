Console.Write("Ange din ålder: ");
int ålder = int.Parse(Console.ReadLine());

if (ålder < 18)
{
    Console.WriteLine("Du är minderårig");
}




Console.Write("\n\nTryck på en tangent för att stänga fönstret...");
Console.ReadKey();