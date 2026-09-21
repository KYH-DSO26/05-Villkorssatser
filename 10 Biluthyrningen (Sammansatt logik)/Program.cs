Console.Write("Ange din ålder: ");
int ålder = int.Parse(Console.ReadLine());
Console.Write("Hur många år har du haft körkort? ");
int årKörkort = int.Parse(Console.ReadLine());
Console.Write("Är du man eller kvinna? (m/k): ");
string kön = Console.ReadLine().ToLower();

if (kön == "m")
{
    if (ålder >= 25 && årKörkort >= 3)
    {
        Console.WriteLine("Du får hyra sportbilen!");
    }
    else
    {
        Console.WriteLine("Tyvärr, du uppfyller inte kraven.");
    }
}
else
{
    if (ålder >= 23)
        Console.WriteLine("Välkommen att hyra bilen!");

    else
    {
        Console.WriteLine("Du är för ung, dessvärre!");
    }
}




#region Specialkod på slutet
Console.Write("\n\nTryck på en tangent för att stänga fönstret...");
Console.ReadKey();
#endregion