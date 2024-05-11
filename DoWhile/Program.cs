Random random = new Random();
int monster = 10;
int hero = 10;

do
{
    int attack = random.Next(1, 11);
    monster -= attack;
    Console.WriteLine($"Monster was damaged and lost {attack} health and now has {monster} health.");

    if (monster <= 0) continue;

    attack = random.Next(1, 11);
    hero -= attack;
    Console.WriteLine($"Hero was damaged and lost {attack} health and now has {hero} health.");
} while  (hero > 0 && monster > 0);

Console.WriteLine(hero > monster ? "Hero wins!" : "Monster wins!");