Console.Write("Ange ett heltal mellan 1 och 7: ");
int dag = int.Parse(Console.ReadLine());

switch (dag)
{
    case 1: Console.WriteLine("Måndag"); break;
    case 2:   // Normalt vill man ha detta långa formatet, eftersom mer än en kodrad ska köras.
		{
            Console.WriteLine("Tisdag");
			break;
		}
    case 3: Console.WriteLine("Onsdag"); break;
    case 4: Console.WriteLine("Torsdag"); break;
    case 5: Console.WriteLine("Fresdag"); break;
    case 6: Console.WriteLine("Lördag"); break;
    case 7: Console.WriteLine("Söndag"); break;
    default:
        Console.WriteLine("Felaktig inmatning! Ange ett tal mellan 1 och 7.");
		break;
}




#region Specialkod på slutet
Console.Write("\n\nTryck på en tangent för att stänga fönstret...");
Console.ReadKey();
#endregion