Console.Write("Ange temperatur: ");
double temp = double.Parse(Console.ReadLine());

if (temp < 0.0)  // Om vi skriver 0.0 istället för bara 0 så blir koden tydligare
{
    Console.WriteLine("Det är minusgrader ute.");
}
else  // temp >= 0.0
{
    Console.WriteLine("Det är plusgrader eller nollgradigt ute.");
}






Console.Write("\n\nTryck på en tangent för att stänga fönstret...");
Console.ReadKey();