namespace ConsoleApp1;

public static class Battle
{
    public static void Fight(Heros hero1, Heros hero2)
    {
        int round = 1;
            do
            {
                Console.WriteLine($"Round {round++}");
                hero2.Defense(hero1.Attack());
                hero1.Defense(hero2.Attack());
            } while (hero1.IsAlive && hero2.IsAlive);

            var win = hero1.IsAlive
                ? hero1
                : hero2.IsAlive
                    ? hero2
                    : null;
            
            var los = win != hero1
                ? hero1
                : hero2;

            if (win == null)
            {
                Console.WriteLine("Нічия");
            }
            else
            {
                Console.WriteLine($"{win} win in {round} round.\nHP left {win.Health}.\nLooser is {los}.");
                
            }
    }
}