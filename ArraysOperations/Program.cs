// Methoden: Sort() und Reverse()
/* string[] pallets = { "B14", "A11", "B12", "A13" };

Console.WriteLine("Sorted...");
Array.Sort(pallets);
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

Console.WriteLine("");
Console.WriteLine("Reversed...");
Array.Reverse(pallets);
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
} */

// Methoden: Clear() and Resize()
/* string[] pallets = { "B14", "A11", "B12", "A13" };
Console.WriteLine("");

Array.Clear(pallets, 0, 2);
Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

Console.WriteLine("");
Array.Resize(ref pallets, 6);
Console.WriteLine($"Resizing 6 ... count: {pallets.Length}");

pallets[4] = "C01";
pallets[5] = "C02";

foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

Console.WriteLine("");
Array.Resize(ref pallets, 3);
Console.WriteLine($"Resizing 3 ... count: {pallets.Length}");

foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
} */

// Methoden: ToCharArray(), Split() und Join()
/* string value = "abc123";
char[] valueArray = value.ToCharArray();
Array.Reverse(valueArray);
// string result = new string(valueArray);
string result = String.Join(",", valueArray);
Console.WriteLine(result);

string[] items = result.Split(',');
foreach (string item in items)
{
    Console.WriteLine(item);
} */

// Übung
/* string pangram = "The quick brown fox jumps over the lazy dog";
string[] pangramArray = pangram.Split(' ');
string[] newPangramArray =  new string[pangramArray.Length];

for (int i = 0; i < pangramArray.Length; i++)
{
    char[] wordArray = pangramArray[i].ToCharArray();
    Array.Reverse(wordArray);
    newPangramArray[i] = new string(wordArray);
}

string result = String.Join(' ', newPangramArray);
Console.WriteLine(result); */

// Übung 2
using System.Runtime.CompilerServices;

string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";
string[] orderArray = orderStream.Split(',');
Array.Sort(orderArray);

foreach (string order in orderArray)
{
    if (order.Length != 4) 
    {
        Console.WriteLine($"{order}\t- Error");
    } else
    {
        Console.WriteLine($"{order}");
    }
}
