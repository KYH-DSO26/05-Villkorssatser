/*
 * För mer läsning, se https://www.geeksforgeeks.org/c-sharp/switch-expression-in-c-sharp-8-0/
 */


Console.Write("Ange felkod: ");
int felkod = int.Parse(Console.ReadLine());

string kategori = felkod switch
{
    >= 100 and <= 199 => "Hådvarufel",
    >= 200 and <= 299 => "Mjukvarufel",
    _ => "Okänt fel"
};
Console.WriteLine($"Kategori: {kategori}");






#region Specialkod på slutet
Console.Write("\n\nTryck på en tangent för att stänga fönstret...");
Console.ReadKey();
#endregion