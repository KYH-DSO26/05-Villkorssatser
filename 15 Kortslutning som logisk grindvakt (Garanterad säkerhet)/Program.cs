string? text = null;

// Tack vare short-circuiting (&&) utvärderas aldrig text.Length om text är null!
if (text != null && text.Length > 5)
{
    Console.WriteLine("Strängen är lång.");
}
else
{
    Console.WriteLine("Strängen är antingen null eller för kort.");
}







#region Specialkod på slutet
Console.Write("\n\nTryck på en tangent för att stänga fönstret...");
Console.ReadKey();
#endregion