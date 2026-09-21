Console.Write("Skriv en text: ");
string text = Console.ReadLine();
bool specialTextFinns = false;

if (string.IsNullOrEmpty(text))
{
    Console.WriteLine("Texten är tom.");
}
if (text.StartsWith("Hejsan"))
{
    Console.WriteLine("Texten börjar med en hälsning.");
    specialTextFinns = true;
}
if (text.EndsWith("!"))
{
    Console.WriteLine("Texten avslutas med utropstecken!");
    specialTextFinns = true;
}
if (specialTextFinns == false)
{
    Console.WriteLine("Texten uppfyller inga specialvillkor");
}






#region Specialkod på slutet
Console.Write("\n\nTryck på en tangent för att stänga fönstret...");
Console.ReadKey();
#endregion