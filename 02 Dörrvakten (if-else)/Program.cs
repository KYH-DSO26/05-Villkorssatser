Console.Write("Ange din ålder: ");
int ålder = int.Parse(Console.ReadLine());

// (a > b) samma sak som !(a <= b)
// (a < b) är samma sak som !(a >= b)

if (ålder >= 18)
{
    Console.WriteLine("Välkommen in!");
}
else
{
    Console.WriteLine("Du är minderårig");
}



Console.Write("\n\nTryck på en tangent för att stänga fönstret...");
Console.ReadKey();