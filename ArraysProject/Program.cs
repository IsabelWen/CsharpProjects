string[] bestellIDs = { "B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179" };

foreach (string bestellID in bestellIDs)
{
    if (bestellID.StartsWith("B")) {
        Console.WriteLine($"Bestell-ID {bestellID} beginnt mit 'B'!");
    }
}