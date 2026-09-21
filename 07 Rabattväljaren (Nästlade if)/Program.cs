Console.Write("Är du student? (ja/nej): ");
string student = Console.ReadLine().ToLower().Trim();

if (student == "ja" || student == "j")
{
    Console.Write("Har du Mecenat-kort? (ja/nej): ");
    string kort = Console.ReadLine().ToLower();
    if (kort == "ja" || kort == "j")
    {
        Console.WriteLine("Du får 20% rabatt!");
    }
    else
    {
        Console.WriteLine("Du får 10% rabatt!");
    }
}
else
{
    Console.WriteLine("Standarpris gäller.");
}





#region Specialkod på slutet
Console.Write("\n\nTryck på en tangent för att stänga fönstret...");
Console.ReadKey();
#endregion