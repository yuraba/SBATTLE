namespace ConsoleApp1;

public class AddArmor : Interface_addsuperpower
{
    public void AddSuperpower(Heros hero, int power)
    {
        hero.Armor += power;
    }
}