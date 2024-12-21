int heroHealth = 10, monsterHealth = 10;
Random attack = new Random();

while ((heroHealth > 0) && (monsterHealth > 0)) {
    int heroAttack = attack.Next(1, 11);
    monsterHealth -= heroAttack;
    Console.WriteLine ($"Monster was damaged and lost {heroAttack} health and now has {monsterHealth} health.");
    if (monsterHealth > 0)
    {
        int monsterAttack = attack.Next(1,11);
        heroHealth -= monsterAttack;
        Console.WriteLine ($"Hero was damaged and lost {monsterAttack} health and now has {heroHealth} health.");
    }

    if (monsterHealth <= 0)
        Console.WriteLine ("Hero wins!");

    if (heroHealth <= 0)
        Console.WriteLine ("Monster wins!");
}
