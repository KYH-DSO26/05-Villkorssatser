// Klassdefinition:
class User { public string Name { get; set; } public bool IsAdmin { get; set; } }

class Program
{
    static void Main()
    {
        User u = new User { Name = "Mikael", IsAdmin = true };
        string meddelande = u switch
        {
            { IsAdmin: true } => $"Välkommen chef, {u.Name}!",
            { IsAdmin: false } => $"Välkommen användare, {u.Name}.",
            _ => "Okänd entitet"
        };
        Console.WriteLine(meddelande);

        #region Specialkod på slutet
        Console.Write("\n\nTryck på en tangent för att stänga fönstret...");
        Console.ReadKey();
        #endregion
    }
}