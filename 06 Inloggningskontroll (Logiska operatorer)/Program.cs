Console.Write("Användarnamn: ");
string user = Console.ReadLine();
Console.Write("Lösenord: ");
string pass = Console.ReadLine();

if (user == "admin" && pass == "hemligt123")
{
    Console.WriteLine("Inloggning lyckades!");
}
else
{
    Console.WriteLine("Felaktiga uppgifter.");
}






#region Specialkod på slutet
Console.Write("\n\nTryck på en tangent för att stänga fönstret...");
Console.ReadKey();
#endregion