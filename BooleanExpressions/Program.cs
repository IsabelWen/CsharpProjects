﻿/*
// Heads or Tails
Random coin = new Random();
int randomNum = coin.Next(0,2);

Console.WriteLine($"Discount: {((randomNum == 0)? "Heads" : "Tails")}");
*/

// Implementieren von Geschäftsregeln
string permission = "Admin|Manager";
int level = 55;

if (permission.Contains("Admin"))
{
    if (level > 55)
    {
        Console.WriteLine("Welcome, Super Admin user.");
    }
    else
    {
        {
            Console.WriteLine("Welcome, Admin user.");
        }
    }
    
}
else if (permission.Contains("Manager"))
{
    if (level >= 20) 
    {
        Console.WriteLine("Contact an Admin for access.");
    }
    else 
    {
        Console.WriteLine("You do not have sufficient privileges.");
    }
}
else if (!permission.Contains("Admin") && !permission.Contains("Manager"))
{
    Console.WriteLine("You do not have sufficient privileges.");
}