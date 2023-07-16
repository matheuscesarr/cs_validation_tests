int monster = 10;
int hero = 10;
Random damage = new Random();
do {
    int hit = damage.Next(1,11);
    Console.WriteLine($"Monster was damaged and lost {hit} health and now has {monster-hit} health.");
    if (hit>=monster) {Console.WriteLine("Hero Wins!"); break;} else {monster-=hit;}
    hit = damage.Next(1,11);
    Console.WriteLine($"Hero was damaged and lost {hit} health and now has {hero-hit} health.");
    if (hit>=hero) {Console.WriteLine("Monster Wins!"); break;} else {hero-=hit;}
} while (monster > 0 && hero > 0);