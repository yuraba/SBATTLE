using ConsoleApp1;

class MyClass
{
    public static void Main()
    {
        Console.WriteLine("exit - q; start any button");
        string ans = Console.ReadLine();
        while (ans != "q")
        {
            
            Heros hero1 = BattleHelper.ChooseHero("Choose your hero (1,2,3,4,5)");
            Heros hero2 = BattleHelper.ChooseHero("Choose your hero (1,2,3,4,5)");
            Heros hero3 = BattleHelper.ChooseHero("Choose your hero (1,2,3,4,5)");
            Heros hero4 = BattleHelper.ChooseHero("Choose your hero (1,2,3,4,5)");

            hero1.AddSuperpower(
                new AddArmor(), SuperPowerGenerator.GenerateSuperpower()
            );
            hero2.AddSuperpower(
                new AddBrunt(), SuperPowerGenerator.GenerateSuperpower()
            );
            hero3.AddSuperpower(
                new AddArmor(), SuperPowerGenerator.GenerateSuperpower()
            );
            hero4.AddSuperpower(
                new AddBrunt(), SuperPowerGenerator.GenerateSuperpower()
            );
            Battle.Fight(hero1, hero2);
            Battle.Fight(hero3, hero4);
            
            Console.WriteLine("\n \nContinue? (y/n)");
            string answ = Console.ReadLine();

            if (answ == "n")
            {
                break;
            }
        }
    }
}
