using ConsoleApp1;

class MyClass
{
    public static void Main()
    {
        Heros hero1 = BattleHelper.ChooseHero("Choose your hero (1,2,3,4)");
        Heros hero2 = BattleHelper.ChooseHero("Choose your hero (1,2,3,4)");
        
        hero1.AddSuperpower(
            new AddArmor(), SuperPowerGenerator.GenerateSuperpower()
            );
        hero2.AddSuperpower(
            new AddBrunt(), SuperPowerGenerator.GenerateSuperpower()
            );
        
        Battle.Fight(hero1,hero2);

    }
}