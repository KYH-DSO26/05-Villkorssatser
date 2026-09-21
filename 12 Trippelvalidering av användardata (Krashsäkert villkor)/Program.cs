Console.Write("Mata in ett heltal: ");
string input = Console.ReadLine();
if (int.TryParse(input, out int tal))
{
    string tecken = tal >= 0 ? "positivt" : "negativt";
    string paritet = tal % 2 == 0 ? "jämnt" : "udda";
    Console.WriteLine($"Talet är ett {tecken} och {paritet} tal.");
}
else
{
    Console.WriteLine("Det där var inget giltigt heltal!");
}





#region Specialkod på slutet
Console.Write("\n\nTryck på en tangent för att stänga fönstret...");
Console.ReadKey();
#endregion