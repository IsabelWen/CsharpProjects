﻿Random random = new Random();
int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;

// Your code goes here

if (daysUntilExpiration == 0) {
    Console.WriteLine("Your subscription has expired.");
} else if (daysUntilExpiration == 1) {
    discountPercentage = 20;
    Console.WriteLine("Your subscription expires within a day!");
} else if (daysUntilExpiration <= 5) {
    discountPercentage = 10;
    Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.");
} else if (daysUntilExpiration <= 10) {
    Console.WriteLine("Your subscription will expire soon. Renew now!");
}

if (discountPercentage > 0) {
    Console.WriteLine($"Renew now and save {discountPercentage}%!");
}