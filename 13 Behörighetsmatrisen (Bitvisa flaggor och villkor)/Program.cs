[Flags]
enum Rättigheter { None = 0, Read = 1, Write = 2, Execute = 4 }

// Kod i Main:
class Program
{
    static void Main()
    {
        Rättigheter användare = Rättigheter.Read | Rättigheter.Write;
        if ((användare & (Rättigheter.Read | Rättigheter.Write)) == (Rättigheter.Read | Rättigheter.Write))
        {
            Console.WriteLine("Användaren har både läs- och skrivrättigheter.");
        }

        #region Specialkod på slutet
        Console.Write("\n\nTryck på en tangent för att stänga fönstret...");
        Console.ReadKey();
        #endregion
    }
}