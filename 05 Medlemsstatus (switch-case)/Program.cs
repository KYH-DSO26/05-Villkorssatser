/*
 * Mer läsning om hur switch-case fungerar:
 * https://code-maze.com/csharp-switch-multiple-cases-return-same-result/
 * Googla annars på "c# case with multiple alternatives"
 */


Console.Write("Ange din medlemsnivå (Basic/Standard/Premium): ");
string nivå = Console.ReadLine();

switch (nivå.ToLower().Trim())
{
	case "b":
	case "basic": Console.WriteLine("Månadspris: 99 kr"); break;

	case "s":
	case "standard": Console.WriteLine("Månadspris: 149 kr"); break;

	case "p":
	case "premium": Console.WriteLine("Månadspris: 199 kr"); break;

	default: Console.WriteLine("Okänd medlemsnivå."); break;
}





#region Specialkod på slutet
Console.Write("\n\nTryck på en tangent för att stänga fönstret...");
Console.ReadKey();
#endregion