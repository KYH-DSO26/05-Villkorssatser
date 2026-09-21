/*
 * Detta visar hur vi kan använda if else för en massa intervall.
 * Prova att skriva samma sak med switch-case!
 */



Console.Write("Ange din ålder: ");
int ålder = int.Parse(Console.ReadLine());

if (ålder >= 0 && ålder <= 6)
{
    Console.WriteLine("Kategori: Barntillåten");
}
else if (ålder >= 7 && ålder <= 10) Console.WriteLine("Kategori: Från 7 år");
else if (ålder >= 11 && ålder <= 14) Console.WriteLine("Kategori: Från 11 år");
else if (ålder >= 15) Console.WriteLine("Kategori: Från 15 år");
else Console.WriteLine("Ogiltig ålder!");





#region Specialkod på slutet
Console.Write("\n\nTryck på en tangent för att stänga fönstret...");
Console.ReadKey();
#endregion